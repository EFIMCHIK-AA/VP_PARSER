using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Views
{
    public partial class AuthorizationView : Form
    {
        public AuthorizationView()
        {
            InitializeComponent();
        }

        Authorization _authorization;

        private async void Login_B_Click(object sender, EventArgs e)
        {
            _authorization = new Authorization(Login_TB.Text.Trim(), Password_TB.Text.Trim());

            if(await _authorization.Login())
            {
                AppManager.MainForm = new MainForm();
                AppManager.MainForm.Show();
                this.Hide();
            }

        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthorizationView_Load(object sender, EventArgs e)
        {

        }
    }
}
