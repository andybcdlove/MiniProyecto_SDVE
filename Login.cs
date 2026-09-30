namespace MiniProyecto_SDVE_Apache
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            MetodosLogin login = new MetodosLogin();

            // 1. Primero validamos si existe y la contraseña está bien
            bool puedeEntrar = login.ValidarUsuario(tID.Text, tContrasena.Text);

            if (puedeEntrar == true)
            {
                if (MemoriaElectoral.MatriculaActiva == "admin")
                {
                    Reportes ventanaAdmin = new Reportes();
                    ventanaAdmin.Show();
                    this.Hide();
                }
                else
                {
                    // 2. Si es alumno, revisamos si ya votó en todo antes de abrirle la ventana
                    bool yaVoto = login.YaVotoEnTodo(tID.Text);

                    if (yaVoto == true)
                    {
                        // Le avisamos y lo dejamos en el Login sin abrir nada
                        MessageBox.Show("Ya has participado en todas las convocatorias. Tu voto ha sido registrado anteriormente.");

                        // Opcional: Limpiamos las cajas de texto para el siguiente
                        tID.Clear();
                        tContrasena.Clear();
                    }
                    else
                    {
                        // Si le falta al menos un voto, lo dejamos pasar
                        Convocatoria ventanaAlumno = new Convocatoria();
                        ventanaAlumno.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Matrícula o contraseña incorrecta.");
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
