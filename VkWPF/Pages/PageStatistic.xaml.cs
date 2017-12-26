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
using VkNet.Model;
using VkNet.Utils;

namespace VkWPF.Pages
{
    public partial class PageStatistic : Page
    {
        public Friends friendsControl;
        public Statistic statisticCotrol;
        VkApi _vk;

#region UserMethods
        private void UpdateFriends(bool online) {
            if (!online)
                try
                {
                    statisticCotrol.UpdateStatistic(int.Parse(tbxId.Text));
                    friendsControl.UpdateFriendsListFrom(long.Parse(tbxId.Text));
                }
                catch
                {
                    statisticCotrol.UpdateStatistic();
                    friendsControl.UpdateFriendsListFrom();
                }
            else
                try
                {
                    statisticCotrol.UpdateStatistic(int.Parse(tbxId.Text));
                    friendsControl.UpdateFriendsListFrom(long.Parse(tbxId.Text), false, true);
                }
                catch
                {
                    statisticCotrol.UpdateStatistic();
                    friendsControl.UpdateFriendsListFrom(null,false,true);
                }
        }
#endregion

        public PageStatistic()
        {
            InitializeComponent();
            _vk = Classes.Logining.Vk;

            statisticCotrol = new Statistic();
            frameStatistic.Content = statisticCotrol;

            friendsControl = new Friends();
            frameFriends.Content = friendsControl;
        }

        //Updating of friends
        private void tbxId_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateFriends(false);
        }

        private void btnFriends_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(false);
        }
        private void btnFriendsOnline_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(true);
        }

        private void frameFriends_MouseLeave(object sender, MouseEventArgs e)
        {
            var temp = friendsControl.GetSelected();
            if (temp != null)
                statisticCotrol.SelectedUser = temp;
        }
    }
}
