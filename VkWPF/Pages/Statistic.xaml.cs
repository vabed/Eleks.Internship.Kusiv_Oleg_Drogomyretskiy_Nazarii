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
        //Dictionary<int, double> value;
        User _selectedUser;
        public User SelectedUser {
            get => _selectedUser;
            set {
                _selectedUser = value;
                lblSelected.Content = _selectedUser.FirstName;
            }
        }
        public Statistic()
        {
            InitializeComponent();
            UpdateStatistic();

            /*
             * value = new Dictionary<int, double>();
            for (int i = 1; i <= 2; i++)
                value.Add(i, 10 * i);
                */
            //Chart chart = this.FindName("MyWinformChart") as Chart;
            //chart.DataSource = value;
            //chart.Series["series"].XValueMember = "Key";
            //chart.Series["series"].YValueMembers = "Value";

            //Chart chart1 = this.FindName("MyWinformChart1") as Chart;
            //chart1.DataSource = value;
            //chart1.Series["series"].XValueMember = "Key";
            //chart1.Series["series"].YValueMembers = "Value";

        }
        private int[] GetCounts(Classes.Friends friends, bool forMine = true) {
            if(forMine)
                return new int[] {
                    friends.Count(), friends.Count(friends.FilterSex(VkNet.Enums.Sex.Female)), friends.Count(friends.FilterSex(VkNet.Enums.Sex.Male)),
                    friends.GetOdnoselchans().Count(), friends.WhoWorkWithMe().Count()
                };
            else
                return new int[] {
                    friends.Count(), friends.Count(friends.FilterSex(VkNet.Enums.Sex.Female)), friends.Count(friends.FilterSex(VkNet.Enums.Sex.Male)),
                };
        }
        public async void UpdateStatistic() {
            Classes.Friends friends = new Classes.Friends();
            var t1 = await Task<int[]>.Factory.StartNew( () => GetCounts(friends));
            lblCountFrends.Content = "Кількість друзів: " + t1[0];
            lblCountFrendsFemales.Content = "Кількість друзів слабкої статі: " + t1[1];
            lblCountFrendsMales.Content = "Кількість друзів сильної статі: " + t1[2];

            lblLastAdded.Visibility = Visibility.Visible;
            lblLastAdded.Content = "Останні п'ять нових друзів:\n";
            foreach (var usr in friends.GetRecent(5))
                lblLastAdded.Content += "\n\t\t" + usr.FirstName + " " + usr.LastName + "\n";

            lblOdnoselchany.Visibility = Visibility.Visible;
            lblOdnoselchany.Content = "Кількість односельчан: " + t1[3];

            lblWork.Visibility = Visibility.Visible;
            lblWork.Content = "Кількість друзів які навчаються або працюють з Вами: " + t1[4];

            lblFriends.Visibility = Visibility.Visible;
            lblFriends.Content = friends.FilterOld(1998).Select(x=>x.FirstName);
        }
        public async void UpdateStatistic(int id)
        {
            Classes.Friends friends = new Classes.Friends(id);
            var t1 = await Task<int[]>.Factory.StartNew(() => GetCounts(friends));

            lblCountFrends.Content = "Кількість друзів: " + t1[0];
            lblCountFrendsFemales.Content = "Кількість друзів слабкої статі: " + t1[1];
            lblCountFrendsMales.Content = "Кількість друзів сильної статі: " + t1[2];

            lblLastAdded.Visibility = Visibility.Collapsed;
            lblOdnoselchany.Visibility = Visibility.Collapsed;
            lblWork.Visibility = Visibility.Collapsed;
            lblFriends.Visibility = Visibility.Collapsed;
            //lblFriends.Content = string.Join("\n", friends.FilterOld(1998));
        }
    }
}
