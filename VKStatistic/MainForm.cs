using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKStatistic
{
    public partial class MainForm : Form
    {
        VkAPI _ApiRequest;
        private string _Token;  //Токен, использующийся при запросах
        private string _UserId;  //ID пользователя
        private Dictionary<string, string> _Response;  //Ответ на запросы

        public MainForm()
        {
            InitializeComponent();
            if (File.Exists(@"..\Debug\UserInf.txt"))
            {
                Button_GetToken.Visible = false;
            }
        }

        private void Button_GetToken_Click(object sender, EventArgs e)
        {
            AutorizationForm GetToken = new AutorizationForm();
            GetToken.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                _UserId = ControlInf.ReadLine();
                ControlInf.Close();
                if (_Token != null)
                {
                    _ApiRequest = new VkAPI(_Token);
                    string[] Params = { "city", "country", "photo_max" };
                    _Response = _ApiRequest.GetInformation(_UserId, Params);
                    if (_Response != null)
                    {
                        User_ID.text = _UserId;
                        User_Photo.ImageLocation = _Response["photo_max"];
                        User_Name.Text = _Response["first_name"];
                        User_Surname.Text = _Response["last_name"];
                        User_Country.Text = _ApiRequest.GetCountryById(_Response["country"]);
                        User_City.Text = _ApiRequest.GetCityById(_Response["city"]);
                        
                    }
                }
            }
            catch { }
        }

        private void Button_GetInformation_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader ControlInf = new StreamReader("UserInf.txt");
                _Token = ControlInf.ReadLine();
                ControlInf.Close();
                _ApiRequest = new VkAPI(_Token);
                _UserId = User_ID.text;
                string[] Params = { "city", "country", "photo_max" };
                _Response = _ApiRequest.GetInformation(_UserId, Params);
                if (_Response != null)
                {
                    User_ID.text = _UserId;
                    User_Photo.ImageLocation = _Response["photo_max"];
                    User_Name.Text = _Response["first_name"];
                    User_Surname.Text = _Response["last_name"];
                    User_Country.Text = _ApiRequest.GetCountryById(_Response["country"]);
                    User_City.Text = _ApiRequest.GetCityById(_Response["city"]);
                    //User_Frends.Text = _ApiRequest.GetFriendsById(_Response[""]);
                    Button_GetToken.Visible = false;
                }
            }
            catch
            {

            }
        }

        private void User_Photo_Click(object sender, EventArgs e)
        {

        }

        private void minimase_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximase_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else 
                this.WindowState = FormWindowState.Maximized;
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }

}
