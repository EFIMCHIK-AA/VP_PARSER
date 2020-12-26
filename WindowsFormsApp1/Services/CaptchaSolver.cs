using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet.Utils.AntiCaptcha;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Services
{
    class CaptchaSolver : ICaptchaSolver
    {
        public void CaptchaIsFalse()
        {
            throw new NotImplementedException();
        }

        public string Solve(string url)
        {
            CaptchaForm captchaForm = new CaptchaForm();
            captchaForm.Captcha_PB.Load(url);
            captchaForm.ShowDialog();
            return captchaForm.Answer_TB.Text.Trim();
        }
    }
}
