using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        private Ticker _ticker = null;

        public Mainpage()
        {
            InitializeComponent();
            orderListview.FullRowSelect = true;
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {

        }

        private void Mainpage_Shown(object sender, EventArgs e)
        {
            UpdatePricesTimer.Enabled = true;
            AddCurrencies();
            UpdatePrices(); 
            UpdateBalance();
        }

        public bool UpdateBalance()
        {
            var btceApi = new BtceApi(LoginPage.Key, LoginPage.Secret);
            var userInfo = btceApi.GetInfo();

            if (btceApi.Equals(null)) return false;

            balanceLabel.Text = userInfo.Funds.Ltc.ToString(_culture) + "LTC";
            return true;
        }

        private void UpdatePrices()
        {
            _ticker = BtceApi.GetTicker(BtcePairHelper.FromString(currencyComboBox.SelectedItem.ToString()));

            highpriceLabel.Text = _ticker.High.ToString(_culture);
            avgpriceLabel.Text = _ticker.Average.ToString(_culture);
            lowpriceLabel.Text = _ticker.Low.ToString(_culture);

            buypriceLabel.Text = _ticker.Buy.ToString(_culture);
            sellpriceLabel.Text = _ticker.Sell.ToString(_culture);
        }

        private void AddCurrencies()
        {
            foreach (var item in Enum.GetValues(typeof (BtcePair)))
            {
                currencyComboBox.Items.Add(item);
            }
            currencyComboBox.SelectedIndex = 0;
        }

        private void buyatButton_Click(object sender, EventArgs e)
        {
            var item1 = new ListViewItem("Time");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");
            item1.SubItems.Add("SubItem1d");
            item1.SubItems.Add("Buy");
            orderListview.Items.Add(item1);
        }

        private void sellatButton_Click(object sender, EventArgs e)
        {
            var item1 = new ListViewItem("Time");
            item1.SubItems.Add("SubItem1a");
            item1.SubItems.Add("SubItem1b");
            item1.SubItems.Add("SubItem1c");
            item1.SubItems.Add("SubItem1d");
            item1.SubItems.Add("Sell");
            orderListview.Items.Add(item1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void Mainpage_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}