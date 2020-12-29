using NLog;
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
        private Color BorderColor = Color.FromArgb(0, 152, 217);

        private static Logger logger = LogManager.GetCurrentClassLogger();

        private async void Login_B_Click(object sender, EventArgs e)
        {
            try
            {
                Login_B.Text = "Выполняется авторизация, пожалуйста подождите..";
                Login_B.Enabled = false;
                _authorization = new Authorization(Login_TB.Text.Trim(), Password_TB.Text.Trim());

                if (await _authorization.Login())
                {
                    AppManager.MainForm.MainForm = new MainForm();
                    AppManager.MainForm.MainForm.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Login_B.Text = "Войти";
                Login_B.Enabled = true;
                logger.Error(ex.StackTrace);
                MessageBox.Show(this, ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }       
        }

        private async void Exit_B_Click(object sender, EventArgs e)
        {
            try
            {
                ExitService exitService = new ExitService();
                await exitService.Exit();
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
                Application.Exit();
            }
        }

        private void AuthorizationView_Load(object sender, EventArgs e)
        {

        }

        private void SearchPanel_P_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SearchPanel_P.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);

        }

        private void Logo_PB_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Logo_PB.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void ShowPassword_CB_CheckedChanged(object sender, EventArgs e)
        {
            Password_TB.UseSystemPasswordChar = !ShowPassword_CB.Checked;
        }

        private void AuthorizationView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_B.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
