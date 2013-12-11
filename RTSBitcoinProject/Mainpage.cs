using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
            orderListview.FullRowSelect = true;
        }

        private void Mainpage_Load(object sender, EventArgs e)
        {
            AddCurrencies();
        }

        private void Mainpage_Shown(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void UpdatePrices()
        {
            var ticker = BtceApi.GetTicker(BtcePairHelper.FromString(currencyComboBox.SelectedItem.ToString()));

            var culture = CultureInfo.InvariantCulture;

            highpriceLabel.Text = ticker.High.ToString(culture);
            avgpriceLabel.Text = ticker.Average.ToString(culture);
            lowpriceLabel.Text = ticker.Low.ToString(culture);

            buypriceLabel.Text = ticker.Buy.ToString(culture);
            sellpriceLabel.Text = ticker.Sell.ToString(culture);
        }

        private void AddCurrencies()
        {
            foreach (var item in Enum.GetValues(typeof(BtcePair)))
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
