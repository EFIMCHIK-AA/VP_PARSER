using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;
using VkNet.Utils.AntiCaptcha;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Services
{
    public class Authorization
    {
        public Authorization(String login, String password)
        {
            VK.Api = new VkApi();

            VK.AuthParams = new ApiAuthParams
            {
                Login = login,
                Password = password,
                ApplicationId = VK.AppId,
                Settings = Settings.All
            };
        }


        public async Task<Boolean> Login()
        {
            try
            {
                await VK.Api.AuthorizeAsync(VK.AuthParams);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }

        public async Task<Boolean> Logout()
        {
            try
            {
                await VK.Api.LogOutAsync();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
