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

            // Revisión de login: validamos las credenciales antes de abrir otra pantalla.
            bool puedeEntrar = login.ValidarUsuario(tID.Text.Trim(), tContrasena.Text);

            if (puedeEntrar == true)
            {
                if (MemoriaElectoral.MatriculaActiva == "admin")
                {
                    // Revisión de login: el administrador no vota; entra directo a reportes.
                    Reportes ventanaAdmin = new Reportes();
                    ventanaAdmin.Owner = this;
                    ventanaAdmin.Show();
                    this.Hide();
                }
                else
                {
                    // Revisión de login: bloqueamos al alumno que ya terminó las tres elecciones.
                    bool yaVoto = login.YaVotoEnTodo(MemoriaElectoral.MatriculaActiva);

                    if (yaVoto == true)
                    {
                        MessageBox.Show("Ya has participado en todas las convocatorias. Tu voto ha sido registrado anteriormente.");

                        tID.Clear();
                        tContrasena.Clear();
                        MemoriaElectoral.MatriculaActiva = "";
                    }
                    else
                    {
                        // Revisión de login: se guarda la matrícula activa para Convocatoria.
                        Convocatoria ventanaAlumno = new Convocatoria();
                        ventanaAlumno.Owner = this;
                        ventanaAlumno.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Matrícula o contraseña incorrecta.");
                tContrasena.Clear();
                tContrasena.Focus();
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
