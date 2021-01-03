using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK_PARSER.Exceptions
{
    public class TwoFactorExceptions : Exception
    {
        public TwoFactorExceptions(string message) : base(message) { }
    }
}
