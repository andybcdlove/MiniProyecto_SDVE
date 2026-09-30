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
            PapeletaDinamica ventanaPapeleta = new PapeletaDinamica();
            ventanaPapeleta.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
