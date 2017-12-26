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

namespace VkWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageUserInfo.xaml
    /// </summary>
    public partial class PageUserInfo : Page
    {
        VkApi _vk;
        public PageUserInfo()
        {
            InitializeComponent();
            _vk = Classes.Logining.Vk;
            txtblcFirstName.Text = _vk.Account.GetProfileInfo().FirstName;
            txtblcLastName.Text = _vk.Account.GetProfileInfo().LastName;

        }
    }
}
