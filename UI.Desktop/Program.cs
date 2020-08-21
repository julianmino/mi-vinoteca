using System;
using System.Windows.Forms;
namespace UI.Desktop {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ClienteLogic cliLog = new ClienteLogic();
            //cliLog.Baja(48);
            //cliLog.Modificacion(25, "Ignacio", "Justiniano", "groncho", "qwe@.com.ar", "321321", DateTime.Parse("2003-12-12"), true, null);
            Application.Run(new AdminMenu());
            }
        }
    }
