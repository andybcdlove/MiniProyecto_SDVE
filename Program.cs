namespace MiniProyecto_SDVE_Apache
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Para personalizar la configuración de la aplicación, como el uso de DPI alto o la fuente predeterminada,
            // consulta https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}
