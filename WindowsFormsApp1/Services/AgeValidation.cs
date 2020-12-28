using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    public class AgeValidation
    {
        public Boolean Validation(String age)
        {
            if (String.IsNullOrWhiteSpace(age))
            {
                LogViewer.WriteLog("Необходимо указать параметр возраста");
                throw new Exception("Необходимо указать параметр возраста");
            }

            try
            {
                int tempAge = Convert.ToInt32(age);
            }
            catch(FormatException )
            {
                LogViewer.WriteLog("Параметр возраста должен быть числовым значением");
                throw new Exception("Параметр возраста должен быть числовым значением");
            }

            return true;
        }

        public Boolean ValidationRange(int StartAge, int EndAge)
        {
            if(StartAge <= 0 || StartAge > 150)
            {
                LogViewer.WriteLog("Пармаметр начального значения возраста должен быть в диапазоне [0..150]");
                throw new Exception("Пармаметр начального значения возраста должен быть в диапазоне [0..150]");
            }

            if (EndAge <= 0 || EndAge > 150)
            {
                LogViewer.WriteLog("Пармаметр конечного значения возраста должен быть в диапазоне [0..150]");
                throw new Exception("Пармаметр конечного значения возраста должен быть в диапазоне [0..150]");
            }

            if(StartAge >= EndAge)
            {
                LogViewer.WriteLog("Пармаметр начального значения возраста не может быть >= параметру конечного значения возраста");
                throw new Exception("Пармаметр начального значения возраста не может быть >= параметру конечного значения возраста");
            }

            return true;
        }
    }
}
