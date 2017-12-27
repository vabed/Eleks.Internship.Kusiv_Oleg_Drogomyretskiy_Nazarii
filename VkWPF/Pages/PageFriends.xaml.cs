using System;
using System.Windows.Controls;

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
            controlFriends = new Pages.Friends();
            frameFriends.Content = controlFriends;

            var a = new Classes.Friends().GetYears();
            comboYearsFilter.ItemsSource = a;
            a.Insert(0,null);
        }

        private void comboYearsFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (comboYearsFilter.SelectedValue != null)
                controlFriends.FilterOld(int.Parse(comboYearsFilter.SelectedValue.ToString()));
            else controlFriends.UpdateFriendsListFrom();
        }
    }
}
