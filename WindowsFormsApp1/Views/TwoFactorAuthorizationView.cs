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
    public partial class TwoFactorAuthorizationView : Form
    {
        public TwoFactorAuthorizationView()
        {
            InitializeComponent();
        }

        private Color BorderColor = Color.FromArgb(0, 152, 217);


        private void TwoFactorAuthorizationView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(Code_TB.Text.Trim()))
                    {
                        throw new Exception("Необходимо указать код авторизации");
                    }
                }
                catch(Exception ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(this, ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void TwoFactorAuthorizationView_Load(object sender, EventArgs e)
        {

        }

        private void SearchPanel_P_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, SearchPanel_P.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }
    }
}
