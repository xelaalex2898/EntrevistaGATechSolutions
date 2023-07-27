namespace entrevistaGA
{
    partial class FormService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IniciarServicio = new System.Windows.Forms.Button();
            this.FinalizaServicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniciarServicio
            // 
            this.IniciarServicio.Location = new System.Drawing.Point(115, 234);
            this.IniciarServicio.Name = "IniciarServicio";
            this.IniciarServicio.Size = new System.Drawing.Size(162, 71);
            this.IniciarServicio.TabIndex = 0;
            this.IniciarServicio.Text = "Iniciar";
            this.IniciarServicio.UseVisualStyleBackColor = true;
            this.IniciarServicio.Click += new System.EventHandler(this.InicioServicio);
            // 
            // FinalizaServicio
            // 
            this.FinalizaServicio.Location = new System.Drawing.Point(293, 234);
            this.FinalizaServicio.Name = "FinalizaServicio";
            this.FinalizaServicio.Size = new System.Drawing.Size(175, 71);
            this.FinalizaServicio.TabIndex = 1;
            this.FinalizaServicio.Text = "Finalizar";
            this.FinalizaServicio.UseVisualStyleBackColor = true;
            this.FinalizaServicio.Click += new System.EventHandler(this.FinalizarServicio);
            // 
            // FormService
            // 
            this.ClientSize = new System.Drawing.Size(726, 435);
            this.Controls.Add(this.FinalizaServicio);
            this.Controls.Add(this.IniciarServicio);
            this.Name = "FormService";
            this.Load += new System.EventHandler(this.FormService_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Button Finalizar;
        private System.Windows.Forms.Button IniciarServicio;
        private System.Windows.Forms.Button FinalizaServicio;
    }
}