using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VK_PARSER.Services
{
    public static class LogViewer
    {
        public static TextBox Textbox_logger_control;

        public static void WriteLog(String message)
        {
            if(Textbox_logger_control != null)
            {
                Textbox_logger_control.AppendText(message + Environment.NewLine);
            }
        }

        public static void Reset()
        {
            if (Textbox_logger_control != null)
            {
                Textbox_logger_control.Clear();
            }
        } 
    }
}
