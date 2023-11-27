using XIIRPL2_23_Ticketing.MasterForm;

namespace XIIRPL2_23_Ticketing
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
            //FrmLogin frmLogin = new FrmLogin();
            //FrmLogin.Show();
            bandara bandara = new bandara();
            bandara.Show();
            Application.Run();
        }
    }
}