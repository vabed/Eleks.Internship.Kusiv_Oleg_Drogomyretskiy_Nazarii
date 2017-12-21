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

namespace VkWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFriends.xaml
    /// </summary>
    public partial class PageFriends : Page
    {
        Page controlFriends;
        public PageFriends()
        {
            InitializeComponent();
            controlFriends = new Pages.Friends();
            frameFriends.Content = controlFriends;
        }
    }
}
