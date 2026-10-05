using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniProyecto_SDVE_Apache
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            // Revisión de reportes: al salir de reportes volvemos al Login.
            MemoriaElectoral.MatriculaActiva = "";
            Owner?.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
