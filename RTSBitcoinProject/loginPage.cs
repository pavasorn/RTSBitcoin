using System;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class LoginPage : Form
    {
        public static string Key { get; set; }
        public static string Secret { get; set; }
        public static UserInfo UserInfo { get; set; }
        private readonly Mainpage _mainPage = new Mainpage();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            Key = apikeyTextBox.Text;
            Secret = apisecretTextBox.Text;
            
            Login();
        }

        private void Login()
        {
            try
            {
                if (_mainPage.UpdateBalance())
                {
                    Hide();
                    _mainPage.Show();
                }
            }
            catch (Exception)
            {
                AlertLabel.Visible = true;
            }
        }
    }
}