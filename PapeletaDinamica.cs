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
        private string convocatoriaSeleccionada = "";
        private List<string> convocatoriasPendientes = new List<string>();

        public PapeletaDinamica()
        {
            InitializeComponent();
            rbCandidatoLibre.CheckedChanged += rbCandidatoLibre_CheckedChanged;
        }

        public PapeletaDinamica(string convocatoria) : this(new List<string> { convocatoria })
        {
        }

        public PapeletaDinamica(List<string> convocatorias) : this()
        {
            // Revisión de papeleta: guardamos las elecciones seleccionadas para mostrarlas una por una.
            convocatoriasPendientes = new List<string>(convocatorias);
            convocatoriaSeleccionada = convocatoriasPendientes[0];
            lTipoVotacion.Text = convocatoriaSeleccionada;
            CargarCandidatos();
        }

        private void bConfirmar_Click(object sender, EventArgs e)
        {
            if (rbCandidatoLibre.Checked && string.IsNullOrWhiteSpace(tCandidatoLibre.Text))
            {
                MessageBox.Show("Escribe el nombre del candidato no registrado.");
                return;
            }

            string candidatoSeleccionado = ObtenerCandidatoSeleccionado();

            if (string.IsNullOrWhiteSpace(candidatoSeleccionado))
            {
                MessageBox.Show("Selecciona un candidato antes de confirmar tu voto.");
                return;
            }

            MetodosPapeleta metodosPapeleta = new MetodosPapeleta();
            bool votoRegistrado = metodosPapeleta.RegistrarVoto(convocatoriaSeleccionada, candidatoSeleccionado);

            if (!votoRegistrado)
            {
                MessageBox.Show("No fue posible registrar el voto. Esta convocatoria ya fue votada.");
                return;
            }

            if (metodosPapeleta.AlumnoTerminoVotaciones())
            {
                // Revisión de papeleta: al terminar las tres elecciones, mostramos los reportes.
                MessageBox.Show("Tu voto fue registrado correctamente. Terminaste todas las convocatorias.");
                Reportes ventanaReportes = new Reportes();
                ventanaReportes.Owner = Owner?.Owner;
                ventanaReportes.Show();
                Owner?.Close();
                Close();
            }
            else if (convocatoriasPendientes.Count > 1)
            {
                // Revisión de papeleta: continuamos con la siguiente elección marcada por el alumno.
                convocatoriasPendientes.Remove(convocatoriaSeleccionada);
                PapeletaDinamica siguientePapeleta = new PapeletaDinamica(convocatoriasPendientes);
                siguientePapeleta.Owner = Owner;
                siguientePapeleta.Show();
                Close();
            }
            else
            {
                // Revisión de papeleta: volvemos a Convocatoria para votar las elecciones pendientes.
                MessageBox.Show("Tu voto fue registrado correctamente.");
                Owner?.Show();
                Close();
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRegresar_Click(object sender, EventArgs e)
        {
            // Revisión de papeleta: regresamos sin registrar cambios.
            Owner?.Show();
            this.Close();
        }

        private void CargarCandidatos()
        {
            MetodosPapeleta metodosPapeleta = new MetodosPapeleta();
            List<string> candidatos = metodosPapeleta.ObtenerCandidatos(convocatoriaSeleccionada);
            RadioButton[] opciones = { rbCandidato1, rbCandidato2, rbCandidato3, rbCandidato4, rbCandidato5 };

            for (int indice = 0; indice < opciones.Length; indice++)
            {
                opciones[indice].Visible = indice < candidatos.Count;
                opciones[indice].Checked = false;

                if (indice < candidatos.Count)
                {
                    opciones[indice].Text = candidatos[indice];
                }
            }

            rbCandidatoLibre.Checked = false;
            tCandidatoLibre.Clear();
            tCandidatoLibre.Enabled = false;
        }

        private string ObtenerCandidatoSeleccionado()
        {
            RadioButton[] opciones = { rbCandidato1, rbCandidato2, rbCandidato3, rbCandidato4, rbCandidato5 };

            foreach (RadioButton opcion in opciones)
            {
                if (opcion.Checked)
                {
                    return opcion.Text;
                }
            }

            if (rbCandidatoLibre.Checked && !string.IsNullOrWhiteSpace(tCandidatoLibre.Text))
            {
                return tCandidatoLibre.Text.Trim();
            }

            return "";
        }

        private void rbCandidatoLibre_CheckedChanged(object? sender, EventArgs e)
        {
            // Revisión de papeleta: el campo libre solo se habilita al seleccionar esta opción.
            tCandidatoLibre.Enabled = rbCandidatoLibre.Checked;
        }
    }
}
