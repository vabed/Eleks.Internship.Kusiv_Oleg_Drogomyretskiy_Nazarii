using System;
using System.Collections.Generic;
using System.IO;
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

namespace VkWPF.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowToketSignIn.xaml
    /// </summary>
    public partial class WindowToketSignIn : Window
    {
        public WindowToketSignIn()
        {
            InitializeComponent();
            GetToken.LoadCompleted += GetToken_DocumentCompleted;
            //GetToken.Navigate("https://oauth.vk.com/authorize?client_id="+Classes.Logining.AppID+"&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends&response_type=token&v=5.52");
            GetToken.Navigate("http://vk.com");
        }

        private void GetToken_DocumentCompleted(object sender, NavigationEventArgs e)
        {
            if (GetToken.Source.ToString().IndexOf("access_token=") != 0)
            {
                var a = GetToken.Source;
            }
        }
        private void GetUserToken()
        {
            char[] Symbols = { '=', '&' };
            string[] URL = GetToken.Source.ToString().Split(Symbols);
            File.WriteAllText("UserInf.txt", URL[1] + "\n");
            File.AppendAllText("UserInf.txt", URL[5]);

        }

    }
}
