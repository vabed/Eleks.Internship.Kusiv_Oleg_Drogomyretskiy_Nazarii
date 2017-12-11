using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF.Classes
{
    class Logining
    {
        ulong appID = 6284662;                  // ID приложения
        Settings scope;                         // Приложение имеет доступ к друзьям
        string login;                           // email или телефон
        string pass;                            // пароль для авторизации
        public static VkApi vk { get; private set; }

        public Logining(string login, string pass) {
            SignIn(login, pass);
        }

        public Logining() {}

        public VkApi SignIn(string login, string pass) {
            scope = Settings.All;
            this.login = login;
            this.pass = pass;

            if (vk == null) {
                try
                {
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
                catch (VkNet.Exception.VkApiAuthorizationException ex) { MessageBox.Show("Неправельно введені логін або пароль!"); vk = null; }
                catch (VkNet.Exception.VkApiException) { MessageBox.Show("Включіть VPN!"); vk = null; }
            }
            return vk;
        }
    }
}
