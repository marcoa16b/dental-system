
/* UNED: Proyecto III Cuatrimestre
 * Proyecto #1: Aplicacion para gestionar citas de una clinica dental
 * Estidiante: Marco Fernando Ag�ero Barboza
 * Fecha: 11/10/2023
 * 
 * Clase principal del programa, se encarga de inicializar la aplicacion.
 */

namespace Proyecto1_Citas_Dentales
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMainMenu());
        }
    }
}