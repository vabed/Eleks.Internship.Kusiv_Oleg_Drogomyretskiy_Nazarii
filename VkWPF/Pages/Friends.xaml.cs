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
using VkNet.Model;
using VkNet.Utils;

namespace VkWPF.Pages
{
    public partial class Friends : Page
    {

        public Friends()
        {
            InitializeComponent();
        }

        private void lbxFriends_Initialized(object sender, EventArgs e)
        {
            lbxFriends.ItemsSource = new Classes.Friends().FriendsList;
        }
    }
}
