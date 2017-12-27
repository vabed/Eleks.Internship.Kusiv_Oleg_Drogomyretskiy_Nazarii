using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VkNet;
using VkNet.Model;

namespace VkWPF.Pages
{
    public partial class Statistic : Page
    {
        VkApi _vk;
        User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                if (value != null)
                    _selectedUser = value;
                UpdateStatistic(_selectedUser.Id);
            }
        }
        public Statistic()
        {
            InitializeComponent();
            _vk = Classes.Logining.Vk;
            UpdateStatistic();
        }
        private int[] GetCounts(Classes.Friends friends, bool forMine = true)
        {
            if (forMine)
                return new int[] {
                    friends.Count(), friends.FilterSex(VkNet.Enums.Sex.Female).Count, friends.FilterSex(VkNet.Enums.Sex.Male).Count,
                    friends.GetOdnoselchans().Count(), friends.WhoWorkWithMe().Count(), friends.GetFriendsListOnline().Count
                };
            else
                return new int[] {
                    friends.Count(), friends.FilterSex(VkNet.Enums.Sex.Female).Count, friends.FilterSex(VkNet.Enums.Sex.Male).Count,
                    friends.GetFriendsListOnline().Count
                };
        }
        public async void UpdateStatistic()
        {
            Classes.Friends friends = new Classes.Friends();
            var t1 = await Task<int[]>.Factory.StartNew(() => GetCounts(friends));

            lblUserName.Content = "Обрана статистика про: " + _vk.Account.GetProfileInfo().FirstName + " " + _vk.Account.GetProfileInfo().LastName + " UserId: " + _vk.UserId;
            lblCountFrends.Content = "Кількість друзів: " + t1[0];
            lblCountFrendsFemales.Content = "Кількість друзів слабкої статі: " + t1[1];
            lblCountFrendsMales.Content = "Кількість друзів сильної статі: " + t1[2];
            lblCountFrendsOnline.Content = "Кількість друзів онлайн: " + t1[5];
            lblLastAdded.Visibility = Visibility.Visible;
            lblLastAdded.Content = "Останні п'ять нових друзів:\n";
            foreach (var usr in friends.GetRecent(5))
                lblLastAdded.Content += "\n\t\t" + usr.FirstName + " " + usr.LastName + "\n";

            lblOdnoselchany.Visibility = Visibility.Visible;
            lblOdnoselchany.Content = "Кількість односельчан: " + t1[3];

            lblWork.Visibility = Visibility.Visible;
            lblWork.Content = "Кількість друзів які навчаються або працюють з Вами: " + t1[4];
            imgUser.Source = new BitmapImage(_vk.Users.Get(_vk.UserId.Value, VkNet.Enums.Filters.ProfileFields.Photo100).Photo100);
        }
        public async void UpdateStatistic(long id)
        {
            Classes.Friends friends = new Classes.Friends(id);
            var t1 = await Task<int[]>.Factory.StartNew(() => GetCounts(friends));

            lblUserName.Content = "Обрана статистика про: " + _selectedUser.FirstName + " " + _selectedUser.LastName + " UserId: " + SelectedUser.Id;
            lblCountFrends.Content = "Кількість друзів: " + t1[0];
            lblCountFrendsFemales.Content = "Кількість друзів слабкої статі: " + t1[1];
            lblCountFrendsMales.Content = "Кількість друзів сильної статі: " + t1[2];
            lblCountFrendsOnline.Content = "Кількість друзів онлайн: " + t1[3];
            imgUser.Source = new BitmapImage(SelectedUser.Photo100);

            lblLastAdded.Visibility = Visibility.Collapsed;
            lblOdnoselchany.Visibility = Visibility.Collapsed;
            lblWork.Visibility = Visibility.Collapsed;
        }
    }
}
