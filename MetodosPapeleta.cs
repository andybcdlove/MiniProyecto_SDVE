using System.Collections.Generic;

namespace MiniProyecto_SDVE_Apache
{
    internal class MetodosPapeleta
    {
        public Alumno ObtenerAlumnoActivo()
        {
            foreach (Alumno alumno in MemoriaElectoral.DatosAlumno)
            {
                if (alumno.Matricula == MemoriaElectoral.MatriculaActiva)
                {
                    return alumno;
                }
            }

            return new Alumno();
        }

        public List<string> ObtenerCandidatosSociedad()
        {
            return MemoriaElectoral.CandidatosSociedad;
        }

        public List<string> ObtenerCandidatosConsejo()
        {
            return MemoriaElectoral.CandidatosConsejo;
        }

        public List<string> ObtenerCandidatosRepresentantes()
        {
            return MemoriaElectoral.CandidatosRepresentantes;
        }

        public List<string> ObtenerCandidatos(string convocatoria)
        {
            // Revisión de papeleta: cada convocatoria muestra únicamente a sus candidatos.
            if (convocatoria == "Sociedad de Alumnos")
            {
                return ObtenerCandidatosSociedad();
            }

            if (convocatoria == "Consejo Universitario")
            {
                return ObtenerCandidatosConsejo();
            }

            return ObtenerCandidatosRepresentantes();
        }

        public bool YaVoto(string convocatoria)
        {
            return YaVotoConvocatoria(ObtenerAlumnoActivo(), convocatoria);
        }

        public bool ValidarCandidato(string candidato)
        {
            return !string.IsNullOrWhiteSpace(candidato);
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

        public bool AlumnoTerminoVotaciones()
        {
            // Revisión de papeleta: comprobamos si el alumno ya terminó las tres elecciones.
            Alumno alumno = ObtenerAlumnoActivo();
            return alumno.VotoSociedad && alumno.VotoConsejo && alumno.VotoRepresentantes;
        }

        public void MarcarVoto(string convocatoria)
        {
            for (int indice = 0; indice < MemoriaElectoral.DatosAlumno.Count; indice++)
            {
                if (MemoriaElectoral.DatosAlumno[indice].Matricula == MemoriaElectoral.MatriculaActiva)
                {
                    Alumno alumno = MemoriaElectoral.DatosAlumno[indice];
                    MarcarConvocatoriaComoVotada(ref alumno, convocatoria);
                    MemoriaElectoral.DatosAlumno[indice] = alumno;
                    break;
                }
            }
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
            else if (convocatoria == "Consejo de Representantes")
            {
                alumno.VotoRepresentantes = true;
            }
        }
    }
}
