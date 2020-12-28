using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;
using VkNet.Utils;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Color BorderColor = Color.FromArgb(0, 152, 217);

        private void button2_Click(object sender, EventArgs e)
        {
            Data_DGV.Rows.Clear();

            List<String> groups = new List<string>();

            for(int i = 0; i < Groups_DGV.Rows.Count; i++)
            {
                if(Groups_DGV["NameGroup", i].Value != null && Groups_DGV["NameGroup", i].Value.ToString() != String.Empty)
                {
                    groups.Add(Groups_DGV["NameGroup", i].Value.ToString());
                }
            }

            int start = 0;
            int end = 0;

            if (UserAgeFilter_CB.Checked)
            {
                start = Convert.ToInt32(StartRangeAge_TB.Text.Trim());
                end = Convert.ToInt32(EndRangeAge_TB.Text.Trim());
            }

            Parser parser = new Parser(UserAgeFilter_CB.Checked, start, end);
            ExportLists lists = parser.StartParse(groups);

            FillData(Data_DGV, lists);
        }

        private void FillData(DataGridView dataGridView, ExportLists lists)
        {
            dataGridView.RowCount = lists.GetMaxCount() + 1;

            dataGridView["Male", 0].Value = lists.phonesMale.Count.ToString() + "шт.";
            dataGridView["Female", 0].Value = lists.phonesFemale.Count.ToString() + "шт.";

            for (int i = 1; i < dataGridView.RowCount; i++)
            {
                if (i - 1 <= lists.phonesMale.Count - 1)
                {
                    dataGridView["Male", i].Value = lists.phonesMale[i - 1];
                }

                if (i - 1 <= lists.phonesFemale.Count - 1)
                {
                    dataGridView["Female", i].Value = lists.phonesFemale[i - 1];
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, EndRange_P.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, StartRange_P.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        private void UserAgeFilter_CB_CheckedChanged(object sender, EventArgs e)
        {
            StartRange_L.Visible = UserAgeFilter_CB.Checked;
            StartRange_L.Enabled= UserAgeFilter_CB.Checked;
            StartRange_P.Visible = UserAgeFilter_CB.Checked;
            StartRange_P.Enabled = UserAgeFilter_CB.Checked;

            EndRange_L.Visible = UserAgeFilter_CB.Checked;
            EndRange_L.Enabled = UserAgeFilter_CB.Checked;
            EndRange_P.Visible = UserAgeFilter_CB.Checked;
            EndRange_P.Enabled = UserAgeFilter_CB.Checked;
        }
    }
}
