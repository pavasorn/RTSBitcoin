using System;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class LoginPage : Form
    {
        public static UserInfo UserInfo { get; set; }
        private readonly Mainpage _mainPage = new Mainpage();
        public static string Key;
        public static string Secret;

        private void LoginPage_Load(object sender, EventArgs e)
        {
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            Secret = apisecretTextBox.Text;
            Key = apikeyTextBox.Text;
            Login();
        }

        private void Login()
        {
            try
            {
                if (new Control().UpdateBalance()==null) return;

                Hide();
                _mainPage.Show();
            }
            catch (Exception)
            {
                AlertLabel.Visible = true;
            }
        }
    }
}