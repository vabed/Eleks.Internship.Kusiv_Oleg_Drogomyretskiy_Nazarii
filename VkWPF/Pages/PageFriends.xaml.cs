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

namespace VkWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFriends.xaml
    /// </summary>
    public partial class PageFriends : Page
    {
        Pages.Friends controlFriends;
        public PageFriends()
        {
            InitializeComponent();
            controlFriends = new Pages.Friends(); // simplify the name
            frameFriends.Content = controlFriends;

            var a = new Classes.Friends().GetYears(); // really not the best choice for variable name
            comboYearsFilter.ItemsSource = a;
            a.Insert(0,null); // why you do it?
        }

        private void comboYearsFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (comboYearsFilter.SelectedValue != null)
                controlFriends.FilterOld(int.Parse(comboYearsFilter.SelectedValue.ToString()));
            else controlFriends.UpdateFriendsListFrom();
        }
    }
}
