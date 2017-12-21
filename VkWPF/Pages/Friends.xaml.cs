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
    public partial class Friends : Page
    {
        List<Image> imgs;
        VkApi _vk;
        public Friends()
        {
            InitializeComponent();

            imgs = new List<Image>();
            _vk = Classes.Logining.Vk;

            var friends = new Classes.Friends().FriendsList;
            lbxFriends.ItemsSource = friends;

            for (int i = 0; i < friends.Count; i++)
            {
                Image img = new Image()
                {
                    Source = new BitmapImage(friends[i].Photo100)
                };
                imgs.Add(img);
            }
        }

        private void lbxFriends_Initialized(object sender, EventArgs e)
        {
           
        }
    }
}
