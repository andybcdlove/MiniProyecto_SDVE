using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniProyecto_SDVE_Apache
{
    public partial class Reportes : Form
    {
        private List<ResultadoReporte> resultadosCompletos = new List<ResultadoReporte>();
        private ComboBox cmbFiltroConvocatoria = new ComboBox();
        private Label lblFiltroConvocatoria = new Label();

        public Reportes()
        {
            InitializeComponent();
            ConfigurarFiltroConvocatoria();
            Load += Reportes_Load;
            bExportar.Click += bExportar_Click;
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

        private void Reportes_Load(object? sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            MetodosReportes metodosReportes = new MetodosReportes();
            resultadosCompletos = metodosReportes.ObtenerResultados();
            EstadisticasParticipacion estadisticas = metodosReportes.ObtenerEstadisticasParticipacion();

            lParticipacion.Text = $"{estadisticas.Participantes} ({estadisticas.PorcentajeParticipacion:0.00}%)";
            lAbstinencia.Text = $"{estadisticas.Abstenciones} ({estadisticas.PorcentajeAbstencion:0.00}%)";
            ActualizarResultadosMostrados();
        }

        private void ConfigurarFiltroConvocatoria()
        {
            // Revisión de filtro: permite consultar una convocatoria o todas las elecciones.
            lblFiltroConvocatoria.AutoSize = true;
            lblFiltroConvocatoria.Font = new Font("Verdana", 10F);
            lblFiltroConvocatoria.Location = new Point(650, 109);
            lblFiltroConvocatoria.Text = "Filtrar convocatoria:";

            cmbFiltroConvocatoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroConvocatoria.Font = new Font("Verdana", 10F);
            cmbFiltroConvocatoria.Location = new Point(830, 105);
            cmbFiltroConvocatoria.Size = new Size(230, 24);
            cmbFiltroConvocatoria.Items.AddRange(new object[]
            {
                "Todas las convocatorias",
                "Sociedad de Alumnos",
                "Consejo Universitario",
                "Consejo de Representantes"
            });
            cmbFiltroConvocatoria.SelectedIndex = 0;
            cmbFiltroConvocatoria.SelectedIndexChanged += cmbFiltroConvocatoria_SelectedIndexChanged;

            Controls.Add(lblFiltroConvocatoria);
            Controls.Add(cmbFiltroConvocatoria);
        }

        private void cmbFiltroConvocatoria_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Revisión de filtro: actualizamos la tabla y la gráfica al cambiar la convocatoria.
            ActualizarResultadosMostrados();
        }

        private void ActualizarResultadosMostrados()
        {
            string filtroSeleccionado = cmbFiltroConvocatoria.SelectedItem?.ToString() ?? "Todas las convocatorias";
            List<ResultadoReporte> resultadosVisibles = resultadosCompletos;

            if (filtroSeleccionado != "Todas las convocatorias")
            {
                resultadosVisibles = resultadosCompletos
                    .Where(resultado => resultado.Convocatoria == filtroSeleccionado)
                    .ToList();
            }

            // Revisión de reportes: cargamos la tabla con votos y porcentajes por convocatoria.
            dataGridView1.Rows.Clear();
            foreach (ResultadoReporte resultado in resultadosVisibles)
            {
                dataGridView1.Rows.Add(
                    resultado.Convocatoria,
                    resultado.Candidato,
                    resultado.Votos,
                    $"{resultado.Porcentaje:0.00}%");
            }

            // Revisión de reportes: la gráfica muestra los votos absolutos de cada candidato.
            chartResultado.Series.Clear();
            ChartArea areaGrafica = chartResultado.ChartAreas[0];
            areaGrafica.AxisX.Interval = 1;
            areaGrafica.AxisX.LabelStyle.Angle = -45;
            areaGrafica.AxisX.LabelStyle.Font = new Font("Verdana", 7F);
            areaGrafica.AxisX.MajorGrid.Enabled = false;
            areaGrafica.AxisY.Interval = 1;
            areaGrafica.AxisY.Title = "Votos";

            chartResultado.Legends.Clear();
            chartResultado.Titles.Clear();
            chartResultado.Titles.Add("Azul: Sociedad | Naranja: Consejo | Rojo: Representantes");

            // Revisión de gráfica: una sola serie evita que las barras de diferentes convocatorias se sobrepongan.
            Series serie = new Series("Resultados")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = false,
                XValueType = ChartValueType.Int32
            };

            int posicionCandidato = 1;
            foreach (ResultadoReporte resultado in resultadosVisibles)
            {
                DataPoint punto = new DataPoint();
                // Revisión de gráfica: cada candidato recibe una posición distinta para no superponer barras.
                punto.SetValueXY(posicionCandidato, resultado.Votos);
                punto.AxisLabel = resultado.Candidato;
                punto.Color = ObtenerColorConvocatoria(resultado.Convocatoria);
                punto.ToolTip = $"{resultado.Convocatoria}: {resultado.Candidato} - {resultado.Votos} votos";
                serie.Points.Add(punto);
                posicionCandidato++;
            }

            chartResultado.Series.Add(serie);
        }

        private Color ObtenerColorConvocatoria(string convocatoria)
        {
            if (convocatoria == "Sociedad de Alumnos")
            {
                return Color.DodgerBlue;
            }

            if (convocatoria == "Consejo Universitario")
            {
                return Color.DarkOrange;
            }

            return Color.Firebrick;
        }

        private void bExportar_Click(object? sender, EventArgs e)
        {
            using SaveFileDialog ventanaGuardar = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Guardar resultados electorales",
                FileName = "ResultadosElectorales.csv"
            };

            if (ventanaGuardar.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            MetodosReportes metodosReportes = new MetodosReportes();
            bool exportado = metodosReportes.ExportarCsv(ventanaGuardar.FileName);

            if (exportado)
            {
                MessageBox.Show("El archivo CSV se exportó correctamente.");
            }
            else
            {
                MessageBox.Show("No fue posible exportar el archivo CSV.");
            }
        }
    }
}
