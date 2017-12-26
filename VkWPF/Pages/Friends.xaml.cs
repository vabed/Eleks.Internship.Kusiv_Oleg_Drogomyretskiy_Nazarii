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
        public VkCollection<User> _friendsList;
        public VkCollection<User> FriendsList {
            get => _friendsList;
            set {
                _friendsList = value;
                lbxFriends.ItemsSource = FriendsList;
            }
        }

        public User GetSelected()
        {
            if (lbxFriends.SelectedIndex != -1)
                return (lbxFriends.ItemsSource as VkCollection<User>)[lbxFriends.SelectedIndex];
            else return null;
        }
        public void FilterName(string searchedName, long? userId=null,bool online = false) {
            var logic = new Classes.Friends();
            if (!online)
            {
                if (userId == null)
                    FriendsList = new Classes.Friends().FilterName(searchedName);
                else
                    FriendsList = new Classes.Friends(userId.Value).FilterName(searchedName); ;
            }
            else
            {
                if (userId == null)
                    FriendsList = new Classes.Friends().FilterName(logic.GetFriendsListOnline(),searchedName);
                else
                    FriendsList = new Classes.Friends(userId.Value).FilterName(new Classes.Friends(userId.Value).GetFriendsListOnline(), searchedName);
            }
        }

        /// <summary>
        /// Заливає дані в lbxFriends.
        /// </summary>
        /// <param name="friendsIn">Якщо не вказувати то буде обрано друзів залогіненого користувача.</param>
        /// <param name="bufered">Вказує чи потрібно буферити дані в пам'яті чи підгружати в процесі підгрузки.</param>
        /// <param name="online">Вказує чи обрати тільки користувачів які онлайн.</param>
        public void UpdateFriendsListFrom(long?  userId = null, bool bufered=true, bool online = false)
        {
            if (!online)
            {
                if (userId == null)
                    FriendsList = new Classes.Friends().FriendsList;
                else
                    FriendsList = new Classes.Friends(userId.Value).FriendsList;
            }
            else
            {
                if (userId == null)
                    FriendsList = new Classes.Friends().GetFriendsListOnline();
                else
                    FriendsList = new Classes.Friends(userId.Value).GetFriendsListOnline();
            }

            if(bufered && FriendsList.Count>=12)
                BuferingOfImgs();
        }

        private List<Image> imgs;
        private void BuferingOfImgs()
        {
            if (imgs == null)
            {

                imgs = new List<Image>();
                var task1 = Task.Run(() => getBuferedPart(0,FriendsList.Count/3));

                var task2 = Task.Run(() => getBuferedPart(FriendsList.Count / 3, FriendsList.Count / 3 * 2));

                var task3 = Task.Run(() => getBuferedPart(FriendsList.Count / 3 *2, FriendsList.Count));
                Task.WaitAll(task1,task2,task3);

                imgs.AddRange(task1.Result);
                imgs.AddRange(task2.Result);
                imgs.AddRange(task3.Result);
            }
        }
        private List<Image> getBuferedPart(int startPos, int endPos) {
            List<Image> imgs = new List<Image>();
            Image img = new Image();
            for (int i = startPos; i < endPos; i++)
            {
                img = new Image() { Source = new BitmapImage(FriendsList[i].Photo100) };
                imgs.Add(img);
            }
            return imgs;
        }

        public Friends()
        {
            InitializeComponent();
            imgs = new List<Image>();
            _vk = Classes.Logining.Vk;

            UpdateFriendsListFrom(bufered: true);
        }
        ~Friends() {
            imgs = null;
        }
        
    }
}
