using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        readonly CultureInfo _culture = CultureInfo.InvariantCulture;
       
        public Mainpage()
        {
            InitializeComponent();
            orderListview.FullRowSelect = true;
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
            AddCurrencies();
            UpdateBalance();
        }

        private void Mainpage_Shown(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void UpdateBalance()
        {
            // Key, Secret
            var btceApi = new BtceApi("KR3Y5845-RJ9P21RY-C8AFMBDV-DLTSDRBM-GKN022V9", "79b2562155534c1842b85725358fc8ac3adbc7ef0952c0e9a772ced1f0a93369");
            var info = btceApi.GetInfo();
            balanceLabel.Text = "€" + info.Funds.Eur.ToString(_culture);

        }

        private void UpdatePrices()
        {
            var ticker = BtceApi.GetTicker(BtcePairHelper.FromString(currencyComboBox.SelectedItem.ToString()));

            highpriceLabel.Text = ticker.High.ToString(_culture);
            avgpriceLabel.Text = ticker.Average.ToString(_culture);
            lowpriceLabel.Text = ticker.Low.ToString(_culture);

            buypriceLabel.Text = ticker.Buy.ToString(_culture);
            sellpriceLabel.Text = ticker.Sell.ToString(_culture);
        }

        private void AddCurrencies()
        {
            foreach (object item in Enum.GetValues(typeof (BtcePair)))
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
    }
}