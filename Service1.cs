using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace entrevistaGA
{
    public partial class Service1 : ServiceBase
    {
        #region Variables
        private System.Windows.Forms.Timer timer;
        #endregion

        #region MetodosPrivados

        private void InicioServicio(object sender, EventArgs e)
        {
            try
            {
                timer = new System.Windows.Forms.Timer();
                timer.Interval = Convert.ToInt32(ConfigurationManager.AppSettings["intervaloEjecucion"]);
                timer.Enabled = true;
                this.timer.Tick += new EventHandler(EventoTemporizador);

            }
            catch (Exception ex)
            {
                throw;
            }

        }
        private void EventoTemporizador(object sender, EventArgs e)
        {
            string readyToProcess = ConfigurationManager.AppSettings["readyToProcess"];
            string errors = ConfigurationManager.AppSettings["errors"];
            string filesProcessed = ConfigurationManager.AppSettings["filesProcessed"];

            try
            {


                string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionSQL"].ToString();
                SqlConnection sqlConnection = new SqlConnection(cadenaConexion);
                SqlCommand comando = new SqlCommand("InsertTicket", sqlConnection);
                comando.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                foreach (string file in Directory.GetFiles(readyToProcess, "*.fct"))
                {
                    string fileName = Path.GetFileName(file);
                    string content = File.ReadAllText(file);

                    // Separar el texto en campos
                    string[] fields = content.Split('|');
                    string fechaCompleta = fields[2] + fields[3];
                    DateTime fechaHora = DateTime.ParseExact(fechaCompleta, "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

                    Tickets ticket = new Tickets
                    {
                        Id_Tienda = fields[0],
                        Id_Registradora = fields[1],
                        FechaHora = fechaHora,
                        Ticket = int.Parse(fields[4]),
                        Impuesto = float.Parse(fields[5]),
                        Total = float.Parse(fields[6]),
                        FechaHora_Creacion = DateTime.Now
                    };

                    comando.Parameters.AddWithValue("Id_Tienda", ticket.Id_Tienda);
                    comando.Parameters.AddWithValue("Id_Registradora", ticket.Id_Registradora);
                    comando.Parameters.AddWithValue("FechaHora", ticket.FechaHora);
                    comando.Parameters.AddWithValue("Ticket", ticket.Ticket);
                    comando.Parameters.AddWithValue("Impuesto", ticket.Impuesto);
                    comando.Parameters.AddWithValue("Total", ticket.Total);

                    string filePath = Path.Combine(readyToProcess, fileName);

                    try
                    {
                        string destinationPath = Path.Combine(filesProcessed, fileName);
                        comando.ExecuteNonQuery();
                        File.Move(filePath, destinationPath);
                    }
                    catch
                    {
                        string destinationPath = Path.Combine(errors, fileName);
                        File.Move(filePath, destinationPath + "_error");
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        private void FinalizarServicio(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Stop();
        }
        #endregion

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            InicioServicio(null, null);
        }

        protected override void OnStop()
        {
            FinalizarServicio(null,null);
        }
    }
}
