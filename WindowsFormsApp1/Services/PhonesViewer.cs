using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Services
{
    public static class PhonesViewer
    {
        public static DataGridView Phones_viwer_control;

        private static int counterMale = 0;
        private static int counterFemale = 0;

        public static void SetMalePhone(String phone)
        {
            counterMale++;

            if (Phones_viwer_control != null)
            {
                if (Phones_viwer_control.Rows.Count < counterMale)
                {
                    Phones_viwer_control.RowCount++;
                }

                Phones_viwer_control["Male", counterMale - 1].Value = phone;
            }
        }

        public static void SetFemalePhone(String phone)
        {
            counterFemale++;

            if (Phones_viwer_control != null)
            {
                if (Phones_viwer_control.Rows.Count < counterFemale)
                {
                    Phones_viwer_control.RowCount++;
                }

                Phones_viwer_control["Female", counterFemale - 1].Value = phone;
            }
        }

        public static void ResetViewer()
        {
            counterMale = 0;
            counterFemale = 0;

            Phones_viwer_control.Rows.Clear();
        }
    }
}
