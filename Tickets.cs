using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace entrevistaGA
{
    internal class Tickets
    {
        public string Id_Tienda { get; set; }
        public string Id_Registradora{ get; set; }
        public DateTime FechaHora { get; set; }
        public int Ticket { get; set; }
        public float Impuesto { get; set; }
        public float Total{ get; set; }
        public DateTime FechaHora_Creacion { get; set; }
    }
}
