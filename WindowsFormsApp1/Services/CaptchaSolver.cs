using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Utils.AntiCaptcha;
using VK_PARSER.Exceptions;
using VK_PARSER.Views;

namespace VK_PARSER.Services
{
    class CaptchaSolver : ICaptchaSolver
    {
        public CaptchaSolver() { }

        public void CaptchaIsFalse() { }

        public string Solve(string url)
        {
            CaptchaForm captchaForm = new CaptchaForm();

            captchaForm.Captcha_PB.ImageLocation = url;

            if (captchaForm.ShowDialog() == DialogResult.OK)
            {
                return captchaForm.Answer_TB.Text.Trim();
            }

            throw new CaptchaExceptions("CaptchaExceptions");
        }
    }
}
