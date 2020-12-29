using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Utils.AntiCaptcha;
using WindowsFormsApp1.Exceptions;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Services
{
    class CaptchaSolver : ICaptchaSolver
    {
        public CaptchaSolver() { }

        public void CaptchaIsFalse() { }

        public string Solve(string url)
        {
            CaptchaForm captchaForm = new CaptchaForm();

            captchaForm.Captcha_PB.Load(url);

            if (captchaForm.ShowDialog() == DialogResult.OK)
            {
                return captchaForm.Answer_TB.Text.Trim();
            }

            throw new CaptchaExceptions("CaptchaExceptions");
        }
    }
}
