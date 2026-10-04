using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MiniProyecto_SDVE_Apache
{
    public partial class PapeletaDinamica : Form
    {
        public PapeletaDinamica()
        {
            InitializeComponent();
        }

        public PapeletaDinamica(string convocatoria) : this()
        {
            // Revisión de convocatoria: recibimos la elección para que la papeleta se configure después.
            lTipoVotacion.Text = convocatoria;
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            Reportes frmReportes = new Reportes();
            frmReportes.Show();
            this.Hide();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            Convocatoria ventanaConvocatoria = new Convocatoria();
            ventanaConvocatoria.Show();
            this.Close();
        }
    }
}
