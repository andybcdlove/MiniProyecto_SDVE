using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniProyecto_SDVE_Apache
{
    public partial class Convocatoria : Form
    {
        public Convocatoria()
        {
            InitializeComponent();
        }

        private void bContinuar_Click(object sender, EventArgs e)
        {
            PapeletaDinamica frmPapeleta = new PapeletaDinamica();
            frmPapeleta.Show();
            this.Hide();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}