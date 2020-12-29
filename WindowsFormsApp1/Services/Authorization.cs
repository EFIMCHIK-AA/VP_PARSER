using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;
using VkNet.Utils.AntiCaptcha;
using WindowsFormsApp1.Exceptions;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Services
{
    public class Authorization
    {
        public Authorization(String login, String password)
        {
            VK.Api = new VkApi(null, new CaptchaSolver());

            VK.AuthParams = new ApiAuthParams
            {
                Login = login,
                Password = password,
                ApplicationId = VK.AppId,
                Settings = Settings.All,
                TwoFactorAuthorization = () =>
                {
                    TwoFactorAuthorizationView two = new TwoFactorAuthorizationView();

                    if (two.ShowDialog() == DialogResult.OK)
                    {
                        return two.Code_TB.Text.Trim();
                    }

                    throw new TwoFactorExceptions("TwoFactorException");
                }
            };
        }

        public Authorization() { }

        public async Task<Boolean> Login()
        {
            try
            {
                if (VK.Api != null)
                {
                    await VK.Api.AuthorizeAsync(VK.AuthParams);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Boolean> Logout()
        {
            try
            {
                if (VK.Api != null)
                {
                    await VK.Api.LogOutAsync();
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
