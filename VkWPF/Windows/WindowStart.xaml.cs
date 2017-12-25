using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using VkNet;

namespace VkWPF.Windows
{
    public partial class WindowStart
    {
        VkApi _vk;

        public WindowStart()
        {
            InitializeComponent();
            _vk = Classes.Logining.Vk;
            
            Image image = new Image();
            image.Source = new BitmapImage(_vk.Users.Get(_vk.UserId.Value, VkNet.Enums.Filters.ProfileFields.PhotoMaxOrig).PhotoMaxOrig);
            image.Effect = new BlurEffect() { Radius = 25, KernelType = KernelType.Gaussian,RenderingBias=RenderingBias.Quality};
            Back.Visual = image;
        }

        private void btnUserInfo_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Pages.PageUserInfo();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Pages.PageSettings(); 
        }

        private void StartWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void StartWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menuMessenger_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            frameMain.Content = new Pages.PageMessenger();
        }

        private void menuFriends_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            frameMain.Content = new Pages.PageFriends();
        }

        private void menuStatistic_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            frameMain.Content = new Pages.PageStatistic();
        }

        private void btnChangeUser_Click(object sender, RoutedEventArgs e)
        {
            Classes.Logining.SignOut();
            new Windows.WindowLogin().Show();
            this.Hide();
        }
    }
}
