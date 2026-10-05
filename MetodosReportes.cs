using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MiniProyecto_SDVE_Apache
{
    internal class ResultadoReporte
    {
        public string Convocatoria { get; set; } = "";
        public string Candidato { get; set; } = "";
        public int Votos { get; set; }
        public double Porcentaje { get; set; }
    }

    internal class EstadisticasParticipacion
    {
        public int TotalPadron { get; set; }
        public int Participantes { get; set; }
        public int Abstenciones { get; set; }
        public double PorcentajeParticipacion { get; set; }
        public double PorcentajeAbstencion { get; set; }
    }

    internal class MetodosReportes
    {
        public List<ResultadoReporte> ObtenerResultados()
        {
            // Revisión de reportes: agrupamos los votos por convocatoria y candidato.
            List<ResultadoReporte> resultados = new List<ResultadoReporte>();

            foreach (IGrouping<string, Voto> votosPorConvocatoria in MemoriaElectoral.VotosEmitidos.GroupBy(voto => voto.Convocatoria))
            {
                int totalVotosConvocatoria = votosPorConvocatoria.Count();

                foreach (IGrouping<string, Voto> votosPorCandidato in votosPorConvocatoria.GroupBy(voto => voto.Candidato))
                {
                    int votosCandidato = votosPorCandidato.Count();

                    resultados.Add(new ResultadoReporte
                    {
                        Convocatoria = votosPorConvocatoria.Key,
                        Candidato = votosPorCandidato.Key,
                        Votos = votosCandidato,
                        Porcentaje = CalcularPorcentaje(votosCandidato, totalVotosConvocatoria)
                    });
                }
            }

            return resultados
                .OrderBy(resultado => resultado.Convocatoria)
                .ThenByDescending(resultado => resultado.Votos)
                .ThenBy(resultado => resultado.Candidato)
                .ToList();
        }

        public EstadisticasParticipacion ObtenerEstadisticasParticipacion()
        {
            // Revisión de reportes: el administrador no forma parte del padrón electoral.
            List<Alumno> alumnos = MemoriaElectoral.DatosAlumno
                .Where(alumno => alumno.Matricula != "admin")
                .ToList();

            int participantes = alumnos.Count(alumno => alumno.VotoSociedad || alumno.VotoConsejo || alumno.VotoRepresentantes);
            int abstenciones = alumnos.Count - participantes;

            return new EstadisticasParticipacion
            {
                TotalPadron = alumnos.Count,
                Participantes = participantes,
                Abstenciones = abstenciones,
                PorcentajeParticipacion = CalcularPorcentaje(participantes, alumnos.Count),
                PorcentajeAbstencion = CalcularPorcentaje(abstenciones, alumnos.Count)
            };
        }

        public double CalcularPorcentaje(int cantidad, int total)
        {
            if (total == 0)
            {
                return 0;
            }

            return Math.Round((double)cantidad * 100 / total, 2);
        }

        public bool ExportarCsv(string rutaArchivo)
        {
            try
            {
                List<string> lineas = new List<string>
                {
                    "Convocatoria,Candidato,Centro Universitario,Carrera,Grupo,Votos"
                };

                // Revisión de reportes: el CSV conserva el desglose por centro, carrera y grupo.
                foreach (IGrouping<(string Convocatoria, string Candidato, string Centro, string Carrera, string Grupo), Voto> grupo in MemoriaElectoral.VotosEmitidos
                    .GroupBy(voto => (voto.Convocatoria, voto.Candidato, voto.Centro, voto.Carrera, voto.Grupo))
                    .OrderBy(grupo => grupo.Key.Convocatoria)
                    .ThenBy(grupo => grupo.Key.Candidato))
                {
                    lineas.Add(string.Join(",", new[]
                    {
                        EscaparCampo(grupo.Key.Convocatoria),
                        EscaparCampo(grupo.Key.Candidato),
                        EscaparCampo(grupo.Key.Centro),
                        EscaparCampo(grupo.Key.Carrera),
                        EscaparCampo(grupo.Key.Grupo),
                        grupo.Count().ToString()
                    }));
                }

                EstadisticasParticipacion estadisticas = ObtenerEstadisticasParticipacion();
                lineas.Add($"Total de Participación,,,,,{estadisticas.Participantes}");
                lineas.Add($"Total de Abstencionismo,,,,,{estadisticas.Abstenciones}");

                File.WriteAllLines(rutaArchivo, lineas, new UTF8Encoding(true));
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        private string EscaparCampo(string valor)
        {
            if (valor.Contains(',') || valor.Contains('"') || valor.Contains('\n'))
            {
                return $"\"{valor.Replace("\"", "\"\"")}\"";
            }

            return valor;
        }
    }
}
