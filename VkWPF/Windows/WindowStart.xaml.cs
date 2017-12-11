using System.Windows;

namespace VkWPF.Windows
{
    public partial class WindowStart
    {
        public WindowStart()
        {
            InitializeComponent();
        }

        private void btnUserInfo_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Pages.PageUserInfo();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Pages.Messenger();
        }
    }
}
