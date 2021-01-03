using HtmlAgilityPack;
using NLog;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VkNet.Model;
using VkNet.Utils;
using WindowsFormsApp1.Services;

namespace WindowsFormsApp1.Views
{
    public partial class AuthorizationView : Form
    {
        public AuthorizationView()
        {
            InitializeComponent();
        }

        [DllImport("wininet.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

        private Authorization _authorization;

        private void AuthorizationView_Load(object sender, EventArgs e)
        {
            var ptr = Marshal.AllocHGlobal(4);
            Marshal.WriteInt32(ptr, 3);
            InternetSetOption(IntPtr.Zero, 81, ptr, 4);
            Marshal.Release(ptr);

            Web_WB.IsWebBrowserContextMenuEnabled = false;

            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);

            Microsoft.Win32.Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, 11000, Microsoft.Win32.RegistryValueKind.DWord);

            Authorization.GetAuthorizationUrlParameters();
            Web_WB.Navigate(Services.Authorization.GetAuthorizeUrl(), null, null, "User-Agent: CustomUserAgent");
        }

        private async void Web_WB_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {     
            Extensions.WebExtension.SetSilent(Web_WB);

            VkAuthorization2 result;

            try
            {
                result = VkAuthorization2.From(e.Url.AbsoluteUri);
            }
            catch
            {
                return;
            }

            if(e.Url.AbsoluteUri == $"https://oauth.vk.com/blank.html#error=access_denied&error_reason=user_denied&error_description=User%20denied%20your%20request&state={Authorization.State}")
            {
                MessageBox.Show(this, "Ошибка при авторизации пользователя в приложении. Необходимо разрешить права для использования пророграммы. Работа приложения будет завершена", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Windows.Forms.Application.Exit();
                return;
            }

            if (!result.IsAuthorized)
            {
                return;
            }

            AuthorizationResult authorizationResult = new AuthorizationResult
            {
                AccessToken = result.AccessToken,
                ExpiresIn = result.ExpiresIn,
                UserId = result.UserId,
                State = result.State
            };

            _authorization = new Authorization(authorizationResult, result.UserId.ToString());

            if (await _authorization.Login())
            {
                AppManager.MainForm.MainForm = new MainForm();
                AppManager.MainForm.MainForm.Show();
                this.Hide();
            }
        }

        private void Web_WB_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            Web_WB.Visible = false;
            LoaderTable_TLP.Visible = true;
        }

        private void Web_WB_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if(e.CurrentProgress == e.MaximumProgress)
            {
                Web_WB.Visible = true;
                LoaderTable_TLP.Visible = false;
            }
        }
    }
}
