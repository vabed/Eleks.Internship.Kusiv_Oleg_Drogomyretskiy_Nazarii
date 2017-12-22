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
    /// Логика взаимодействия для PageMessenger.xaml
    /// </summary>
    public partial class PageMessenger : Page
    {
        public Friends friendsControl;
        VkApi _vk;

        //UserMethods
        private void UpdateFriendsList(int id)
        {
            var friendsList = new Classes.Friends(id).FriendsList;
            if (friendsList.Count != 0)
                friendsControl.lbxFriends.ItemsSource = friendsList;
            else friendsControl.lbxFriends.ItemsSource = new Classes.Friends().FriendsList;
        }
        private void UpdateFriendsListOnline(int id)
        {
            var friendsList = new Classes.Friends(id).GetFriendsListOnline();
            if (friendsList.Count != 0)
                friendsControl.lbxFriends.ItemsSource = friendsList;
            else friendsControl.lbxFriends.ItemsSource = new Classes.Friends().GetFriendsListOnline();
        }
        private void UpdateFriends(bool online)
        {
            if (!online)
                UpdateFriendsList((int)_vk.UserId);
            else
                UpdateFriendsListOnline((int)_vk.UserId);
        }

        public PageMessenger()
        {
            InitializeComponent();
            friendsControl = new Friends();
            frameFriends.Content = friendsControl;
            _vk = Classes.Logining.Vk;
        }

        private void btnFriends_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(false);
        }

        private void btnFriendsOnline_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(true);
        }

   
    }
}
