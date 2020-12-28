using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class ExportLists
    {
        public List<String> phonesMale; //Мужской 
        public List<String> phonesFemale; // Женский

        public int GetMaxCount()
        {
            int temp = phonesMale.Count;

            if(temp < phonesFemale.Count)
            {
                temp = phonesFemale.Count;
            }

            return temp;
        }
    }
}
