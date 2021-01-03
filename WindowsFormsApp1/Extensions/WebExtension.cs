using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Extensions
{
    public static class WebExtension
    {
        public static void SetSilent(WebBrowser wb)
        {
            var fiComWebBrowser = typeof(WebBrowser).GetField("_axIWebBrowser",BindingFlags.Instance | BindingFlags.NonPublic);

            if (fiComWebBrowser == null)
            {
                return;
            }

            var objComWebBrowser = fiComWebBrowser.GetValue(wb);

            objComWebBrowser?.GetType().InvokeMember("Silent",BindingFlags.SetProperty,null,objComWebBrowser,new object[]{true});
        }
    }
}
