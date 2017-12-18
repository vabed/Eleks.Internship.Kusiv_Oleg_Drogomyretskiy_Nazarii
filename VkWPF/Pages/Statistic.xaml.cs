﻿using System;
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
    public partial class Statistic : Page
    {
        public Friends pageFriends;
        VkApi _vk;

        //UserMethods
        private void UpdateFriendsList(int id) {
            var friendsList = new Classes.Friends(id).FriendsList;
            if (friendsList.Count != 0)
                pageFriends.lbxFriends.ItemsSource = friendsList;
            else pageFriends.lbxFriends.ItemsSource = new Classes.Friends().FriendsList;
        }
        private void UpdateFriendsListOnline(int id)
        {
            var friendsList = new Classes.Friends(id).GetFriendsListOnline();
            if (friendsList.Count != 0)
                pageFriends.lbxFriends.ItemsSource = friendsList;
            else pageFriends.lbxFriends.ItemsSource = new Classes.Friends().GetFriendsListOnline();
        }
        private void UpdateFriends(bool online) {
            if (!online)
                try
                {
                    UpdateFriendsList(int.Parse(tbxId.Text));
                }
                catch
                {
                    UpdateFriendsList((int)_vk.UserId);
                }
            else
                try
                {
                    UpdateFriendsListOnline(int.Parse(tbxId.Text));
                }
                catch
                {
                    UpdateFriendsListOnline((int)_vk.UserId);
                }
        }

        public Statistic()
        {
            InitializeComponent();
            _vk = Classes.Logining.Vk;
        }

        private void pageStatistic_Initialized(object sender, EventArgs e)
        {
            pageFriends = new Friends();
            frameFriends.Content = pageFriends;
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
    }
}
