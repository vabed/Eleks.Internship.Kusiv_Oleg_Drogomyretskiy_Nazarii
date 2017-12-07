using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageUserInfo.xaml
    /// </summary>
    public partial class PageUserInfo : Page
    {
        public PageUserInfo()
        {
            InitializeComponent();
            ulong appID = 6284662;                  // ID приложения
            string email = "reskot@mail.ua";        // email или телефон
            string pass = "ok2504762936OK";         // пароль для авторизации
            Settings scope = Settings.All;          // Приложение имеет доступ к друзьям

            var vk = new VkApi();
            vk.Authorize(new ApiAuthParams
            {
                ApplicationId = appID,
                Login = email,
                Password = pass,
                Settings = scope
            }
            );
            var info = vk.Account.GetProfileInfo();
            tFName.Text = info.FirstName;
            tLName.Text = info.LastName;
        }
    }
}
