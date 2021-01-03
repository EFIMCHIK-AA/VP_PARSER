using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Model;

namespace VK_PARSER.Services
{
    public static class VK
    {
        private static VkApi _api;
        private static ApiAuthParams _authParam;
        private static ulong _appId = 7713872;

        public static VkApi Api
        {
            get
            {
                return _api;
            }

            set
            {
                _api = value;
            }
        }

        public static ApiAuthParams AuthParams
        {
            get
            {
                return _authParam;
            }

            set
            {
                _authParam = value;
            }
        }

        public static ulong AppId
        {
            get
            {
                return _appId;
            }
        }
    }
}
