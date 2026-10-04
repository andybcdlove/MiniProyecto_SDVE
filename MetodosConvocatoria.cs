using System.Collections.Generic;

namespace MiniProyecto_SDVE_Apache
{
    internal class MetodosConvocatoria
    {
        public Alumno? ObtenerAlumnoActivo()
        {
            // Revisión de convocatoria: buscamos los datos del alumno que inició sesión.
            foreach (Alumno alumno in MemoriaElectoral.DatosAlumno)
            {
                if (alumno.Matricula == MemoriaElectoral.MatriculaActiva)
                {
                    return alumno;
                }
            }

            return null;
        }

        public bool YaVotoConvocatoria(string convocatoria)
        {
            Alumno? alumnoActivo = ObtenerAlumnoActivo();

            if (!alumnoActivo.HasValue)
            {
                return true;
            }

            Alumno alumno = alumnoActivo.Value;

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

        public List<string> ObtenerConvocatoriasSeleccionadas(bool sociedad, bool consejo, bool representantes)
        {
            // Revisión de convocatoria: solo aceptamos elecciones que sigan pendientes.
            List<string> convocatorias = new List<string>();

            if (sociedad && !YaVotoConvocatoria("Sociedad de Alumnos"))
            {
                convocatorias.Add("Sociedad de Alumnos");
            }

            if (consejo && !YaVotoConvocatoria("Consejo Universitario"))
            {
                convocatorias.Add("Consejo Universitario");
            }

            if (representantes && !YaVotoConvocatoria("Consejo de Representantes"))
            {
                convocatorias.Add("Consejo de Representantes");
            }

            return convocatorias;
        }
    }
}
