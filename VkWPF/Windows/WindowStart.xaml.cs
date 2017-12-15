using System;
using System.Windows;
using System.Windows.Controls;

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

        private void frameMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
        }

        private void StartWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            gridMenu.ColumnDefinitions[0].Width = new GridLength(40);
        }

        private void StartWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
