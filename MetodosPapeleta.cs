using System.Collections.Generic;

namespace MiniProyecto_SDVE_Apache
{
    internal class MetodosPapeleta
    {
        public List<string> ObtenerCandidatos(string convocatoria)
        {
            // Revisión de papeleta: cada convocatoria muestra únicamente a sus candidatos.
            if (convocatoria == "Sociedad de Alumnos")
            {
                return MemoriaElectoral.CandidatosSociedad;
            }

            if (convocatoria == "Consejo Universitario")
            {
                return MemoriaElectoral.CandidatosConsejo;
            }

            return MemoriaElectoral.CandidatosRepresentantes;
        }

        public bool RegistrarVoto(string convocatoria, string candidato)
        {
            for (int indice = 0; indice < MemoriaElectoral.DatosAlumno.Count; indice++)
            {
                Alumno alumno = MemoriaElectoral.DatosAlumno[indice];

                if (alumno.Matricula != MemoriaElectoral.MatriculaActiva)
                {
                    continue;
                }

                // Revisión de papeleta: evitamos registrar dos votos en la misma convocatoria.
                if (YaVotoConvocatoria(alumno, convocatoria))
                {
                    return false;
                }

                MemoriaElectoral.VotosEmitidos.Add(new Voto
                {
                    Convocatoria = convocatoria,
                    Candidato = candidato,
                    Centro = alumno.Centro,
                    Carrera = alumno.Carrera,
                    Grupo = alumno.Grupo
                });

                MarcarConvocatoriaComoVotada(ref alumno, convocatoria);
                MemoriaElectoral.DatosAlumno[indice] = alumno;
                return true;
            }

            return false;
        }

        private bool YaVotoConvocatoria(Alumno alumno, string convocatoria)
        {
            if (convocatoria == "Sociedad de Alumnos")
            {
                return alumno.VotoSociedad;
            }

            if (convocatoria == "Consejo Universitario")
            {
                return alumno.VotoConsejo;
            }

            return alumno.VotoRepresentantes;
        }

        private void MarcarConvocatoriaComoVotada(ref Alumno alumno, string convocatoria)
        {
            if (convocatoria == "Sociedad de Alumnos")
            {
                alumno.VotoSociedad = true;
            }
            else if (convocatoria == "Consejo Universitario")
            {
                alumno.VotoConsejo = true;
            }
            else
            {
                alumno.VotoRepresentantes = true;
            }
        }
    }
}
