using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF.Classes
{
    class Logining
    {
        ulong appID = 6284662;                  // ID приложения
        Settings scope;                         // Приложение имеет доступ к друзьям
        string login;        // email или телефон
        string pass;         // пароль для авторизации
        public VkApi vk { get; private set; }

        public Logining(string login, string pass) {
            SignIn(login, pass);
        }

        public Logining() {
            SignIn();
        }

        public VkApi SignIn(string login = "reskot@mail.ua", string pass = "ok2504762936OK") {
            scope = Settings.All;
            this.login = login;
            this.pass = pass;

            if (vk == null) {
                vk = new VkApi();
                vk.Authorize(new ApiAuthParams
                    {
                        ApplicationId = appID,
                        Login = login,
                        Password = pass,
                        Settings = scope
                    }
                );
            }
            return vk;
        }
    }
}
