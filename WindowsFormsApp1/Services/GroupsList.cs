using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Services
{
    public class GroupsList
    {
        private String path = "Temp";
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public void SaveGroup(DataGridView dataGridView)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(File.Open(path + "/list.gf", FileMode.Create)))
                {
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        if (dataGridView["NameGroup", i].Value != null && dataGridView["NameGroup", i].Value.ToString() != String.Empty)
                        {
                            sw.WriteLine(dataGridView["NameGroup", i].Value.ToString());
                        }
                    }
                }

                LogViewer.WriteLog("Список групп успешно сохранен");
                MessageBox.Show("Список групп успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }

        public void LoadGroup(DataGridView dataGridView)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamReader sr = new StreamReader(File.Open(path + "/list.gf", FileMode.Open)))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        dataGridView.Rows.Add(line);
                    }
                }

                LogViewer.WriteLog("Список групп успешно восстановлен");
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }
    }
}
