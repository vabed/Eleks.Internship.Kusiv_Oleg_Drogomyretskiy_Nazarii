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

namespace VkWPF.Pages
{
   
    public partial class Statistic : Page
    {
        Dictionary<int, double> value;
        public Statistic()
        {
            InitializeComponent();

            value = new Dictionary<int, double>();
            for (int i = 1; i <= 2; i++)
                value.Add(i, 10 * i);

            //Chart chart = this.FindName("MyWinformChart") as Chart;
            //chart.DataSource = value;
            //chart.Series["series"].XValueMember = "Key";
            //chart.Series["series"].YValueMembers = "Value";

            //Chart chart1 = this.FindName("MyWinformChart1") as Chart;
            //chart1.DataSource = value;
            //chart1.Series["series"].XValueMember = "Key";
            //chart1.Series["series"].YValueMembers = "Value";

            Classes.Friends friends = new Classes.Friends();


            lblCountFrends.Content = "Кількість друзів: " + friends.Count();
            lblCountFrendsFemales.Content = "Кількість друзів слабкої статі: " + friends.Count(friends.FilterSex(VkNet.Enums.Sex.Female));
            lblCountFrendsMales.Content = "Кількість друзів сильної статі: " + friends.Count(friends.FilterSex(VkNet.Enums.Sex.Male));
            lblLastAdded.Content = "Останні п'ять нових друзів:\n";
            foreach (var usr in friends.GetRecent(5))
                lblLastAdded.Content += "\n\t\t" + usr.FirstName + " " + usr.LastName + "\n";
            lblOdnoselchany.Content = "Кількість односельчан: "+friends.GetOdnoselchans().Count();
            lblWork.Content = "Кількість друзів які навчаються або працюють з Вами: "+friends.WhoWorkWithMe().Count();
            lblFriends.Content = string.Join("\n",friends.FilterOld(1998));
        }
    }
}
