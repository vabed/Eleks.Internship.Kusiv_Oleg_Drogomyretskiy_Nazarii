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
        Classes.Messenger logic;
        BitmapImage[] imgs;

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

        private void txblkSendMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                logic.SendMessage(txblkSendMessage.Text);
                txblkSendMessage.Text = null;
                txblkHistory.Items.Insert(txblkHistory.Items.Count, logic.GetHistoryChat(1).Messages.Select(x => new { x.Body, image = imgs[0] }));
            }
        }

        private void frameFriends_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            txblkHistory.Items.Clear();
            VkNet.Model.User selected = friendsControl.GetSelected();

            if (selected != null)
            {
                logic = new Classes.Messenger(selected);
                imgs = logic.GetImages();

                foreach ( var temp in logic.GetHistoryChat().Messages.Select(x => new { x.Body, image = (x.FromId == _vk.UserId)?imgs[0]:imgs[1] }).Reverse())
                {
                    txblkHistory.Items.Add(temp);
                }
            }
            else txblkSendMessage.Text = "Ніхуя нема"; 
        }

        private void btnDialogs_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
