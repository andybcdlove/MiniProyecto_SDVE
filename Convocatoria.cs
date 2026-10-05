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

            // Revisión de convocatoria: al abrirse se bloquean las elecciones ya realizadas.
            CargarConvocatoriasPendientes();
            Activated += Convocatoria_Activated;
        }

        private void bContinuar_Click(object sender, EventArgs e)
        {
            MetodosConvocatoria metodosConvocatoria = new MetodosConvocatoria();
            List<string> convocatoriasSeleccionadas = metodosConvocatoria.ObtenerConvocatoriasSeleccionadas(
                chkSociedadAlumno.Checked,
                chkConsejoUniversitario.Checked,
                chkConsejoRepresentantes.Checked);

            // Revisión de convocatoria: la papeleta actual muestra una elección por vez.
            if (convocatoriasSeleccionadas.Count == 0)
            {
                MessageBox.Show("Selecciona una convocatoria pendiente para continuar.");
                return;
            }

            if (convocatoriasSeleccionadas.Count > 1)
            {
                MessageBox.Show("Selecciona una sola convocatoria. Podrás regresar para votar las demás pendientes.");
                return;
            }

            PapeletaDinamica frmPapeleta = new PapeletaDinamica(convocatoriasSeleccionadas[0]);
            frmPapeleta.Owner = this;
            frmPapeleta.Show();
            this.Hide();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            // Revisión de convocatoria: cerramos la sesión y mostramos el Login original.
            MemoriaElectoral.MatriculaActiva = "";
            Owner?.Show();
            this.Close();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarConvocatoriasPendientes()
        {
            MetodosConvocatoria metodosConvocatoria = new MetodosConvocatoria();

            // Revisión de convocatoria: una elección terminada no se puede volver a seleccionar.
            chkSociedadAlumno.Enabled = !metodosConvocatoria.YaVotoConvocatoria("Sociedad de Alumnos");
            chkConsejoUniversitario.Enabled = !metodosConvocatoria.YaVotoConvocatoria("Consejo Universitario");
            chkConsejoRepresentantes.Enabled = !metodosConvocatoria.YaVotoConvocatoria("Consejo de Representantes");

            chkSociedadAlumno.Checked = false;
            chkConsejoUniversitario.Checked = false;
            chkConsejoRepresentantes.Checked = false;
        }

        private void Convocatoria_Activated(object? sender, EventArgs e)
        {
            // Revisión de convocatoria: al regresar de la papeleta, actualizamos los bloqueos.
            CargarConvocatoriasPendientes();
        }
    }
}