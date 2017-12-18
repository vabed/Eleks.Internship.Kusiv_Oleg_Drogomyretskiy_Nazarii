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
    public partial class Messenger : Page
    {
        VkApi vk;

        public Messenger()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            vk = Classes.Logining.Vk;
            if (vk!=null) {
                lbxFriends.ItemsSource = new Classes.Friends().FriendsList.Select(x => x.FirstName + " " + x.LastName);
            }

            /*
             var dialogsInfo = new Classes.Messenger().GetInfoAboutDialogs();
             tbxMessages.Text = String.Join("\n",dialogsInfo);
            */
        }

        private void btnFriendsOnline_Click(object sender, RoutedEventArgs e)
        {
            var vk = Classes.Logining.Vk;
            if (vk != null)
            {
                lbxFriends.ItemsSource = new Classes.Friends().GetFriendsListOnline().Select(x => x.FirstName + " " + x.LastName);
            }
        }

        private void btnFriends_Click(object sender, RoutedEventArgs e)
        {
            var vk = Classes.Logining.Vk;
            if (vk != null)
            {
                lbxFriends.ItemsSource = new Classes.Friends().FriendsList.Select(x => x.FirstName + " " + x.LastName);
            }
        }
    }
}
