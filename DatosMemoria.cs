using System;
using System.Collections.Generic;
using System.Text;

namespace MiniProyecto_SDVE_Apache
{
    // 1. Moldes de datos (Estructuras)
    public struct Alumno
    {
        public string Matricula { get; set; }
        public string Password { get; set; }
        public string Centro { get; set; }
        public string Carrera { get; set; }
        public string Grupo { get; set; }
        public bool VotoSociedad { get; set; }
        public bool VotoConsejo { get; set; }
        public bool VotoRepresentantes { get; set; }
    }

    public struct Voto
    {
        public string Convocatoria { get; set; }
        public string Candidato { get; set; }
        public string Centro { get; set; }
        public string Carrera { get; set; }
        public string Grupo { get; set; }
    }

    // 2. Clase estática central
    public static class MemoriaElectoral
    {
        public static string MatriculaActiva = "";

        // Listas de candidatos oficiales (5 por proceso)
        public static List<string> CandidatosSociedad = new List<string> { "Planilla Roja", "Planilla Azul", "Planilla Verde", "Planilla Blanca", "Planilla Dorada" };
        public static List<string> CandidatosConsejo = new List<string> { "Juan Pérez", "María López", "Luis García", "Ana Torres", "Pedro Martínez" };
        public static List<string> CandidatosRepresentantes = new List<string> { "Carlos Ruiz", "Laura Gómez", "Jorge Díaz", "Marta Sánchez", "Diego Fernández" };

        // 3. Votos pre-cargados (Total: 21 votos emitidos, ordenados por resultados)
        public static List<Voto> VotosEmitidos = new List<Voto>()
        {
            // --- RESULTADOS: SOCIEDAD DE ALUMNOS (Total: 7 votos) ---
            // Planilla Roja: 3 votos
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Roja", Centro = "CCB", Carrera = "LITC", Grupo = "A" }, // Alumno 1001
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Roja", Centro = "CCS", Carrera = "Enfermería", Grupo = "A" }, // Alumno 1006
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Roja", Centro = "CCSyH", Carrera = "Psicología", Grupo = "B" }, // Alumno 1012
            
            // Planilla Azul: 2 votos
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Azul", Centro = "CCB", Carrera = "LITC", Grupo = "B" }, // Alumno 1002
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Azul", Centro = "CCEA", Carrera = "Administración", Grupo = "A" }, // Alumno 1008
            
            // Planilla Verde: 1 voto
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Verde", Centro = "CCI", Carrera = "Ingeniería Automotriz", Grupo = "A" }, // Alumno 1015
            
            // Planilla Blanca: 1 voto
            new Voto { Convocatoria = "Sociedad de Alumnos", Candidato = "Planilla Blanca", Centro = "CCS", Carrera = "Medicina", Grupo = "A" }, // Alumno 1005


            // --- RESULTADOS: CONSEJO UNIVERSITARIO (Total: 7 votos) ---
            // Juan Pérez: 3 votos
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "Juan Pérez", Centro = "CCB", Carrera = "LITC", Grupo = "A" }, // Alumno 1001
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "Juan Pérez", Centro = "CCS", Carrera = "Nutrición", Grupo = "B" }, // Alumno 1007
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "Juan Pérez", Centro = "CCI", Carrera = "Ingeniería Automotriz", Grupo = "A" }, // Alumno 1015
            
            // María López: 2 votos
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "María López", Centro = "CCB", Carrera = "LITC", Grupo = "B" }, // Alumno 1002
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "María López", Centro = "CCEA", Carrera = "Contaduría", Grupo = "A" }, // Alumno 1010
            
            // Luis García: 2 votos
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "Luis García", Centro = "CCS", Carrera = "Medicina", Grupo = "A" }, // Alumno 1005
            new Voto { Convocatoria = "Consejo Universitario", Candidato = "Luis García", Centro = "CCA", Carrera = "Agronomía", Grupo = "A" }, // Alumno 1017


            // --- RESULTADOS: CONSEJO DE REPRESENTANTES (Total: 7 votos) ---
            // Carlos Ruiz: 3 votos
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Carlos Ruiz", Centro = "CCB", Carrera = "LITC", Grupo = "A" }, // Alumno 1001
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Carlos Ruiz", Centro = "CCB", Carrera = "ISC", Grupo = "A" }, // Alumno 1003
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Carlos Ruiz", Centro = "CCI", Carrera = "Ingeniería Automotriz", Grupo = "A" }, // Alumno 1015
            
            // Laura Gómez: 1 voto
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Laura Gómez", Centro = "CCEA", Carrera = "Administración", Grupo = "A" }, // Alumno 1008
            
            // Ana Torres: 1 voto
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Ana Torres", Centro = "CCSyH", Carrera = "Derecho", Grupo = "A" }, // Alumno 1011
            
            // Candidatos no registrados (escritos por el alumno): 2 votos
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Independiente 1", Centro = "CCS", Carrera = "Medicina", Grupo = "A" }, // Alumno 1005
            new Voto { Convocatoria = "Consejo de Representantes", Candidato = "Independiente 2", Centro = "CCSyH", Carrera = "Psicología", Grupo = "B" } // Alumno 1012
        };


        // 4. Padrón oficial (Total: 20 registros. 12 han votado, 7 tienen abstención total, 1 administrador)
        public static List<Alumno> DatosAlumno = new List<Alumno>()
        {
            // --- ALUMNOS QUE SÍ HAN VOTADO (Sus banderas coinciden con la lista de arriba) ---
            new Alumno { Matricula = "1001", Password = "1234", Centro = "CCB", Carrera = "LITC", Grupo = "A", VotoSociedad = true, VotoConsejo = true, VotoRepresentantes = true },
            new Alumno { Matricula = "1002", Password = "2345", Centro = "CCB", Carrera = "LITC", Grupo = "B", VotoSociedad = true, VotoConsejo = true, VotoRepresentantes = false },
            new Alumno { Matricula = "1003", Password = "3456", Centro = "CCB", Carrera = "ISC", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = true },
            new Alumno { Matricula = "1005", Password = "5678", Centro = "CCS", Carrera = "Medicina", Grupo = "A", VotoSociedad = true, VotoConsejo = true, VotoRepresentantes = true },
            new Alumno { Matricula = "1006", Password = "6789", Centro = "CCS", Carrera = "Enfermería", Grupo = "A", VotoSociedad = true, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1007", Password = "7890", Centro = "CCS", Carrera = "Nutrición", Grupo = "B", VotoSociedad = false, VotoConsejo = true, VotoRepresentantes = false },
            new Alumno { Matricula = "1008", Password = "8901", Centro = "CCEA", Carrera = "Administración", Grupo = "A", VotoSociedad = true, VotoConsejo = false, VotoRepresentantes = true },
            new Alumno { Matricula = "1010", Password = "1122", Centro = "CCEA", Carrera = "Contaduría", Grupo = "A", VotoSociedad = false, VotoConsejo = true, VotoRepresentantes = false },
            new Alumno { Matricula = "1011", Password = "2233", Centro = "CCSyH", Carrera = "Derecho", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = true },
            new Alumno { Matricula = "1012", Password = "3344", Centro = "CCSyH", Carrera = "Psicología", Grupo = "B", VotoSociedad = true, VotoConsejo = false, VotoRepresentantes = true },
            new Alumno { Matricula = "1015", Password = "6677", Centro = "CCI", Carrera = "Ingeniería Automotriz", Grupo = "A", VotoSociedad = true, VotoConsejo = true, VotoRepresentantes = true },
            new Alumno { Matricula = "1017", Password = "8899", Centro = "CCA", Carrera = "Agronomía", Grupo = "A", VotoSociedad = false, VotoConsejo = true, VotoRepresentantes = false },

            // --- ALUMNOS CON ABSTENCIÓN TOTAL (Listos para tus pruebas) ---
            new Alumno { Matricula = "1004", Password = "4567", Centro = "CCB", Carrera = "LMA", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1009", Password = "9012", Centro = "CCEA", Carrera = "Administración", Grupo = "B", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1013", Password = "4455", Centro = "CCDC", Carrera = "Arquitectura", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1014", Password = "5566", Centro = "CCDC", Carrera = "Diseño Gráfico", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1016", Password = "7788", Centro = "CCI", Carrera = "Ingeniería Biomédica", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1018", Password = "9900", Centro = "CCA", Carrera = "Veterinaria", Grupo = "B", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
            new Alumno { Matricula = "1019", Password = "1010", Centro = "CCB", Carrera = "LITC", Grupo = "A", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false },
        
            // --- ADMINISTRADOR ---
            new Alumno { Matricula = "admin", Password = "0000", Centro = "Directivo", Carrera = "Admin", Grupo = "Unico", VotoSociedad = false, VotoConsejo = false, VotoRepresentantes = false }
        };
    }
}
