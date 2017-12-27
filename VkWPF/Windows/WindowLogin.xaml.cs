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
using System.Windows.Shapes;
using VkNet;
using VkNet.Enums.Filters;

namespace VkWPF.Windows
{
    public partial class WindowLogin
    {
        public WindowLogin()
        {

            InitializeComponent();
            string[] usrinf = File.ReadAllLines("UserInf.txt");
            try
            {
                tbxLogin.Text = usrinf[0];
                tbxPass.Password = usrinf[1];
            }
            catch { } // if you do nothing in catch you can just delete it
            finally {
                if(usrinf.Count()==2)
                    LoginingAsync();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginingAsync();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) LoginingAsync();
        }
        void  Logining() {
            if (new Classes.Logining(tbxLogin.Text, tbxPass.Password).GetCurrectVkApi() != null)
            {
                new WindowStart().Show();
                this.Hide();
                File.WriteAllText("UserInf.txt", tbxLogin.Text);
            }
        }
        async void LoginingAsync() {
            VkApi t = await new Classes.Logining().SignInAsync(tbxLogin.Text, tbxPass.Password);
            
            if (t != null)
            {
                new WindowStart().Show();
                this.Hide();
                File.WriteAllText("UserInf.txt", tbxLogin.Text+"\n"+tbxPass.Password);// for real projects it is not secure to store password like this, you need to ecrypt it
            }

        }

    }
}
