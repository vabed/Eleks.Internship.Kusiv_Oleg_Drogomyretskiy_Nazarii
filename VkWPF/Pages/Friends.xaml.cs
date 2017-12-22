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
        VkApi _vk;
        public Friends()
        {
            InitializeComponent();

            imgs = new List<Image>();
            _vk = Classes.Logining.Vk;

            var friends = new Classes.Friends().FriendsList;
            lbxFriends.ItemsSource = friends;

            BuferingOfImgs(friends);
        }
        private static List<Image> imgs;
        public static void BuferingOfImgs(VkCollection<User> FriendsList)
        {
            Image img;
            if (imgs == null)
            {
                imgs = new List<Image>();
                for (int i = 0; i < FriendsList.Count; i++)
                {
                    img = new Image()
                    {
                        Source = new BitmapImage(FriendsList[i].Photo100)
                    };
                    imgs.Add(img);
                }
            }
        }
        private void lbxFriends_Initialized(object sender, EventArgs e)
        {
           
        }
    }
}
