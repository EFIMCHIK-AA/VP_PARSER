using Flurl;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using NLog;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Enums.SafetyEnums;
using VkNet.Exception;
using VkNet.Infrastructure;
using VkNet.Model;
using VkNet.Utils.AntiCaptcha;
using VK_PARSER.Exceptions;
using VK_PARSER.Views;

namespace VK_PARSER.Services
{
    public class Authorization
    {
        private AuthorizationResult _authorizationResult;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static String _revokeDefault = "0";
        private static String _revoke;
        private static String _configKeyRevoke = "revoke";

        private static String _stateDefault = "123456";
        private static String _state;
        private static String _configKeyState = "state";

        public Authorization(AuthorizationResult authorizationResult,string email)
        {
            _authorizationResult = authorizationResult;

            VK.Api = new VkApi(null, new CaptchaSolver());

            VK.AuthParams = new ApiAuthParams
            {
                ApplicationId = VK.AppId,
                Login = email
            };

            if(_authorizationResult != null)
            {
                VK.AuthParams.AccessToken = _authorizationResult.AccessToken;
            }
            else
            {
                logger.Error("Получен пустой объект авторизационных параметров");
            }
        }

        public Authorization() { }

        public async Task<Boolean> Login()
        {
            try
            {
                if (VK.Api != null)
                {
                    if (VK.Api.IsAuthorized)
                    {
                        return true;
                    }

                    await VK.Api.AuthorizeAsync(VK.AuthParams);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);

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
                logger.Error(ex.StackTrace);

                throw new Exception(ex.Message);
            }
        }

        public static String Revoke
        {
            get
            {
                if(_revoke != null && _revoke != String.Empty)
                {
                    return _revoke;
                }
                else
                {
                    return _revokeDefault;
                }
            }
        }

        public static String State
        {
            get
            {
                if (_state != null && _state != String.Empty)
                {
                    return _state;
                }
                else
                {
                    return _stateDefault;
                }
            }
        }

        public static void GetAuthorizationUrlParameters()
        {
            _revoke = ConfigurationManager.AppSettings[_configKeyRevoke];

            if (_revoke == null)
            {
                _revoke = _revokeDefault;
            }

            _state = ConfigurationManager.AppSettings[_configKeyState];

            if (_state == null)
            {
                _state = _stateDefault;
            }
        }

        private static Url CreateAuthorizeUrl()
        {
            var url = new Url("https://oauth.vk.com/authorize")
                .SetQueryParam("client_id", VK.AppId)
                .SetQueryParam("redirect_uri", "https://oauth.vk.com/blank.html")
                .SetQueryParam("display", Display.Mobile)
                .SetQueryParam("scope", Settings.Offline.ToUInt64())
                .SetQueryParam("response_type", "token")
                .SetQueryParam("v", new VkApiVersionManager().Version)
                .SetQueryParam("state", _state)
                .SetQueryParam("revoke", _revoke);

            return url;
        }

        public static Uri GetAuthorizeUrl()
        {
            return CreateAuthorizeUrl().ToUri();
        }
    }
}
