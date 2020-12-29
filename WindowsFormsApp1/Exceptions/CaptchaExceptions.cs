using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Exceptions
{
    public class CaptchaExceptions : Exception
    {
        public CaptchaExceptions(string message): base(message) { }
    }
}
