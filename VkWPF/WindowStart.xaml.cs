using MahApps.Metro.Controls;
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
using System.Windows.Shapes;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
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
            frameMain.Content = new Pages.PageSettings();
        }
    }
}
