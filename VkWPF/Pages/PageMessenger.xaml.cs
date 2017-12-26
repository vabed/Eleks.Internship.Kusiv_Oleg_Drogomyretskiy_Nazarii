﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using VkNet.Model;
using VkNet.Model.RequestParams;

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
        List<Message> _messages;
        List<Message> Messages {
            get => _messages;
            set {
                if (value != null && value.Count() != 0)
                {
                    _messages = value;

                    txblkHistory.Items.Clear();
                    if (imgs != null)
                        foreach (var temp in Messages.Select(x => new { x.Body, image = (x.FromId == _vk.UserId) ? imgs[0] : imgs[1] }).Reverse())
                        {
                            txblkHistory.Items.Add(temp);
                        }
                    else
                        foreach (var temp in Messages.Select(x => new { x.Body, image = _vk.Users.Get(x.UserId.Value, ProfileFields.Photo50).Photo50 }).Reverse())
                        {
                            txblkHistory.Items.Add(temp);
                        }
                }
                SubscribeOnMessages();
            }
        }

        #region Constructors
        public PageMessenger()
        {
            InitializeComponent();
            friendsControl = new Friends();
            frameFriends.Content = friendsControl;
            _vk = Classes.Logining.Vk;
        }
        #endregion
        #region UserMethods
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
        private async void SubscribeOnMessages() {
            var t = await Task<MessagesGetObject>.Factory.StartNew(() => logic.GetHistoryChat());
            Messages = t.Messages.ToList();
        }
        #endregion

        private void btnFriends_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(false);
            if (tbxSearch.Text.Length != 0) friendsControl.FilterName(tbxSearch.Text);
        }

        private void btnFriendsOnline_Click(object sender, RoutedEventArgs e)
        {
            UpdateFriends(true);
            if(tbxSearch.Text.Length != 0) friendsControl.FilterName(tbxSearch.Text, online: true);
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
            User selected = friendsControl.GetSelected();
            if (selected != null)
            {
                logic = new Classes.Messenger(selected);
                imgs = logic.GetImages();
                Messages = logic.GetHistoryChat().Messages.ToList();
            }
            else txblkSendMessage.Text = "Ніц нема!"; 
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) friendsControl.FilterName(tbxSearch.Text);
        }
    }
}
