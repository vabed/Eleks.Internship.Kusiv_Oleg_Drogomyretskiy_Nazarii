using System; // remove unuse usings
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF.Classes
{
    //good choice will be make class static or not use static methods here at all
    class Logining // maybe Authentication will be better name, there is no Logining word
    {
        public static ulong AppID { get; private set; } = 6284662;     // ID додатку отримане в Вк
        Settings scope;                                         // Права доступу додатку
        static string Login { get; set; }                       // email або телефон
        static string Pass { get; set; }                        // пароль для авторизації

        public static VkApi Vk { get; private set; }
        public static void SignOut() { Vk = null; }

        public VkApi GetCurrectVkApi() => Vk; 

        //Constructors
        public Logining(string login, string pass) {
            SignIn(login, pass);
        }
        public Logining() {}
        // if you use this code only once why you can't write it directly in constructor
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
                        ApplicationId = AppID,
                        Login = login,
                        Password = pass,
                        Settings = scope
                    }
                    );
                }
                catch (VkNet.Exception.VkApiAuthorizationException) { MessageBox.Show("Неправильно введені логін або пароль!"); Vk = null; }
                catch (VkNet.Exception.VkApiException) {MessageBox.Show("Неможливо з'єднатись з сервером!");Vk = null; }
            }
            return Vk;
        }
        // unuse method, you need to delete it
        public VkApi SignIn(string token) {
            if (Vk == null) {
                try
                {
                    Vk = new VkApi();
                    Vk.Authorize(new ApiAuthParams
                    {
                        AccessToken = token
                    }
                    );
                }
                catch (VkNet.Exception.VkApiAuthorizationException) { MessageBox.Show("Неправельно введені логін або пароль!"); Vk = null; }
                catch (VkNet.Exception.VkApiException) {MessageBox.Show("Включіть VPN!"); Vk = null; }
            }
            return Vk;
        }
        public async Task<VkApi> SignInAsync(string login, string pass) {
            scope = Settings.All;
            Login = login;
            Pass = pass;

            if (Vk == null)
            {
                try
                {
                    Vk = new VkApi();
                    await Vk.AuthorizeAsync(new ApiAuthParams
                    {
                        ApplicationId = AppID,
                        Login = login,
                        Password = pass,
                        Settings = scope
                    }
                    );
                }
                catch (VkNet.Exception.VkApiAuthorizationException) { MessageBox.Show("Неправельно введені логін або пароль!"); Vk = null; }
                catch (VkNet.Exception.VkApiException) { MessageBox.Show("Неможливо з'єднатись з сервером!"); Vk = null; }
            }
            return Vk;
        }
        
    }
}
