using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public partial class CaptchaForm : Form
    {
        public CaptchaForm()
        {
            InitializeComponent();
        }

        private Color BorderColor = Color.FromArgb(0, 152, 217);

        private void Login_B_Click(object sender, EventArgs e)
        {

        }

        private void CaptchaForm_Load(object sender, EventArgs e)
        {

        }

        private void CaptchaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Captcha_PB_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, Captcha_PB.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void SearchPanel_P_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SearchPanel_P.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void Cancel_B_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
