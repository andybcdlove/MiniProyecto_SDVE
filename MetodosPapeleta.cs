using System;
using System.Collections.Generic;

namespace MiniProyecto_SDVE_Apache
{
    public class MetodosPapeleta
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

        public bool YaVoto(string convocatoria)
        {
            Alumno alumno = ObtenerAlumnoActivo();

            if (convocatoria == "Sociedad de Alumnos")
                return alumno.VotoSociedad;

            if (convocatoria == "Consejo Universitario")
                return alumno.VotoConsejo;

            if (convocatoria == "Consejo de Representantes")
                return alumno.VotoRepresentantes;

            return false;
        }

        public bool ValidarCandidato(string candidato)
        {
            return !string.IsNullOrWhiteSpace(candidato);
        }

        public void RegistrarVoto(string convocatoria, string candidato)
        {
            Alumno alumno = ObtenerAlumnoActivo();

            Voto nuevoVoto = new Voto
            {
                Convocatoria = convocatoria,
                Candidato = candidato,
                Centro = alumno.Centro,
                Carrera = alumno.Carrera,
                Grupo = alumno.Grupo
            };

            MemoriaElectoral.VotosEmitidos.Add(nuevoVoto);

            MarcarVoto(convocatoria);
        }

        public void MarcarVoto(string convocatoria)
        {
            for (int i = 0; i < MemoriaElectoral.DatosAlumno.Count; i++)
            {
                if (MemoriaElectoral.DatosAlumno[i].Matricula ==
                    MemoriaElectoral.MatriculaActiva)
                {
                    Alumno alumno = MemoriaElectoral.DatosAlumno[i];

                    if (convocatoria == "Sociedad de Alumnos")
                        alumno.VotoSociedad = true;

                    if (convocatoria == "Consejo Universitario")
                        alumno.VotoConsejo = true;

                    if (convocatoria == "Consejo de Representantes")
                        alumno.VotoRepresentantes = true;

                    MemoriaElectoral.DatosAlumno[i] = alumno;

                    break;
                }
            }
        }
    }
}