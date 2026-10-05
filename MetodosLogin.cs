using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProyecto_SDVE_Apache
{
    internal class MetodosLogin
    {
        public bool ValidarUsuario(string matricula, string password)
        {
            // Revisión de login: evitamos que espacios accidentales impidan el acceso.
            matricula = matricula.Trim();

            foreach (Alumno estudiante in MemoriaElectoral.DatosAlumno)
            {
                if (estudiante.Matricula == matricula && estudiante.Password == password)
                {
                    MemoriaElectoral.MatriculaActiva = matricula;
                    return true;
                }
            }

            return false;
        }

        public bool YaVotoEnTodo(string matricula)
        {
            // Revisión de login: esta validación solo se utiliza para alumnos.
            foreach (Alumno estudiante in MemoriaElectoral.DatosAlumno)
            {
                if (estudiante.Matricula == matricula)
                {
                    // Si las tres elecciones están en true, ya terminó todo su proceso
                    if (estudiante.VotoSociedad == true && estudiante.VotoConsejo == true && estudiante.VotoRepresentantes == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
