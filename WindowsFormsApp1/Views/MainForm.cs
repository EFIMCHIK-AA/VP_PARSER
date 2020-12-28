using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private static Logger logger = LogManager.GetCurrentClassLogger();
        Parser parser = null;

        private bool IsWork = false;

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsWork)
                {
                    if(parser != null)
                    {
                        parser.StopWork();
                    }

                    IsWork = false;

                    LogViewer.WriteLog("Остановка работы, пожалуйста подождите");

                    Start_B.Text = "Начать";
                    return;
                }

                LogViewer.Reset();

                LogViewer.WriteLog("Проверка параметров");

                Data_DGV.Rows.Clear();

                Export_B.Enabled = false;
                Export_B.Visible = false;
                ExportSplit_B.Enabled = false;
                ExportSplit_B.Visible = false;

                List<String> groups = new List<string>();

                for (int i = 0; i < Groups_DGV.Rows.Count; i++)
                {
                    if (Groups_DGV["NameGroup", i].Value != null && Groups_DGV["NameGroup", i].Value.ToString() != String.Empty)
                    {
                        groups.Add(Groups_DGV["NameGroup", i].Value.ToString());
                    }
                }

                if (groups.Count <= 0)
                {
                    LogViewer.WriteLog("Необходимо указать хотя бы одну группу");
                    throw new Exception("Необходимо указать хотя бы одну группу");
                }

                int start = 0;
                int end = 0;

                if (UserAgeFilter_CB.Checked)
                {
                    AgeValidation validation = new AgeValidation();

                    if (validation.Validation(StartRangeAge_TB.Text.Trim()))
                    {
                        start = Convert.ToInt32(StartRangeAge_TB.Text.Trim());
                    }

                    if (validation.Validation(EndRangeAge_TB.Text.Trim()))
                    {
                        end = Convert.ToInt32(EndRangeAge_TB.Text.Trim());
                    }

                    validation.ValidationRange(start, end);

                    LogViewer.WriteLog("Валидация возраста успешно");
                }

                LogViewer.WriteLog("Проверка параметров успешно");

                LogViewer.WriteLog("Начало работы");
                parser = new Parser(UserAgeFilter_CB.Checked, start, end);

                IsWork = true;
                Start_B.Text = "Остановить";

                ExportLists lists = await parser.StartParse(groups);

                FillData(Data_DGV, lists);

                if(lists.phonesFemale.Count > 0 || lists.phonesMale.Count > 0)
                {
                    Export_B.Enabled = true;
                    Export_B.Visible = true;
                    ExportSplit_B.Enabled = true;
                    ExportSplit_B.Visible = true;
                }
                else
                {
                    Export_B.Enabled = false;
                    Export_B.Visible = false;
                    ExportSplit_B.Enabled = false;
                    ExportSplit_B.Visible = false;
                }

                LogViewer.WriteLog("Работа завершена");
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
                MessageBox.Show(this, ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            LogViewer.Textbox_logger_control = Log_TB;
            Export_B.Enabled = false;
            Export_B.Visible = false;
            ExportSplit_B.Enabled = false;
            ExportSplit_B.Visible = false;

            LogViewer.WriteLog("Добро пожаловать!");

            try
            {
                new GroupsList().LoadGroup(Groups_DGV);
            }
            catch (Exception)
            {
                LogViewer.WriteLog("Ошибка при восстановлении групп");
            }
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
            StartRange_L.Enabled = UserAgeFilter_CB.Checked;
            StartRange_P.Visible = UserAgeFilter_CB.Checked;
            StartRange_P.Enabled = UserAgeFilter_CB.Checked;

            EndRange_L.Visible = UserAgeFilter_CB.Checked;
            EndRange_L.Enabled = UserAgeFilter_CB.Checked;
            EndRange_P.Visible = UserAgeFilter_CB.Checked;
            EndRange_P.Enabled = UserAgeFilter_CB.Checked;
        }

        private async void UserName_B_Click(object sender, EventArgs e)
        {
            ExitService exitService = new ExitService();
            await exitService.Exit();
        }

        private void Export_B_Click(object sender, EventArgs e)
        {
            if(parser != null)
            {
                parser.ExportData();
            }
        }

        private void ExportSplit_B_Click(object sender, EventArgs e)
        {
            if (parser != null)
            {
                parser.ExportSplitData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                new GroupsList().SaveGroup(Groups_DGV);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }      
    }
}
