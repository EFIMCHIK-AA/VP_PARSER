using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VK_PARSER.Services;
using VK_PARSER.Views;

namespace VK_PARSER
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppManager.MainForm = new ApplicationContext();
            AppManager.MainForm.MainForm = new AuthorizationView();

            Application.Run(AppManager.MainForm);
        }
    }
}
