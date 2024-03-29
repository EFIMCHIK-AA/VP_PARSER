﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VK_PARSER.Views;

namespace VK_PARSER.Services
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
                AuthorizationView authorizationView = new AuthorizationView();
                AppManager.MainForm.MainForm = authorizationView;

                await authorization.Logout();
                AppManager.MainForm.MainForm.Show();
                owner.Close();
            }
        }
    }
}
