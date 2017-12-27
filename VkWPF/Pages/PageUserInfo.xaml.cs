using System.Windows.Controls;
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
