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
    public partial class Messenger : Page
    {
        public Messenger()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var vk = Classes.Logining.vk;
            if (vk!=null) {
                lbxFriends.ItemsSource = new Classes.Friends(vk).FriendsList.Select(x => x.FirstName + " " + x.LastName);
            }

        }
    }
}
