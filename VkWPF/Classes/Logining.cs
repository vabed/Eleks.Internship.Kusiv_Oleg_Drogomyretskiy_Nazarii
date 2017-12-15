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
        static string Login { get; set; }                           // email или телефон
        static string Pass { get; set; }                         // пароль для авторизации

        public static VkApi Vk { get; private set; }

        public Logining(string login, string pass) {
            SignIn(login, pass);
        }
        public Logining() {}

        public VkApi SignIn(string login, string pass) {
            scope = Settings.All;
            Login = login;
            Pass = pass;

            if (Vk == null) {
                try
                {
                    Vk = new VkApi();
                    Vk.Authorize(new ApiAuthParams
                    {
                        ApplicationId = appID,
                        Login = login,
                        Password = pass,
                        Settings = scope
                    }
                    );
                }
                catch (VkNet.Exception.VkApiAuthorizationException ex) { MessageBox.Show("Неправельно введені логін або пароль!"); Vk = null; }
                catch (VkNet.Exception.VkApiException) { MessageBox.Show("Включіть VPN!"); Vk = null; }
            }
            return Vk;
        }
    }
}
