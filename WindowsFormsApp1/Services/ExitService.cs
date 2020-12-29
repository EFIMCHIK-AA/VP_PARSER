using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Services
{
    public class ExitService
    {
        public async Task Exit()
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Authorization authorization = new Authorization();
                await authorization.Logout();
                System.Windows.Forms.Application.Exit();
            }
        }

        public async Task Logouot(Form owner)
        {
            if (MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Authorization authorization = new Authorization();
                AppManager.MainForm.MainForm = new AuthorizationView();
                await authorization.Logout();
                AppManager.MainForm.MainForm.Show();
                owner.Close();
            }
        }
    }
}
