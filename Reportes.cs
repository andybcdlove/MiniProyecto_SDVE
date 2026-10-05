using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniProyecto_SDVE_Apache
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
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
            List<ResultadoReporte> resultados = metodosReportes.ObtenerResultados();
            EstadisticasParticipacion estadisticas = metodosReportes.ObtenerEstadisticasParticipacion();

            // Revisión de reportes: cargamos la tabla con votos y porcentajes por convocatoria.
            dataGridView1.Rows.Clear();
            foreach (ResultadoReporte resultado in resultados)
            {
                dataGridView1.Rows.Add(
                    resultado.Convocatoria,
                    resultado.Candidato,
                    resultado.Votos,
                    $"{resultado.Porcentaje:0.00}%");
            }

            lParticipacion.Text = $"{estadisticas.Participantes} ({estadisticas.PorcentajeParticipacion:0.00}%)";
            lAbstinencia.Text = $"{estadisticas.Abstenciones} ({estadisticas.PorcentajeAbstencion:0.00}%)";

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
                IsValueShownAsLabel = false
            };

            foreach (ResultadoReporte resultado in resultados)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(resultado.Candidato, resultado.Votos);
                punto.Color = ObtenerColorConvocatoria(resultado.Convocatoria);
                punto.ToolTip = $"{resultado.Convocatoria}: {resultado.Candidato} - {resultado.Votos} votos";
                serie.Points.Add(punto);
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
