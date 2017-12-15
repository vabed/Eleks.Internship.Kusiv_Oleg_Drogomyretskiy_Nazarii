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

            var vk = Classes.Logining.Vk;
            if (vk != null)
            {
                var info = vk.Account.GetProfileInfo();
                tFName.Text = info.FirstName;
                tLName.Text = info.LastName;
            }
            else this.Visibility = Visibility.Hidden;
        }
    }
}
