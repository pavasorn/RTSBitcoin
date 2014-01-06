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
        private ListViewItem selectedItem;

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
        
        private void orderListview_MouseClick(object sender, MouseEventArgs e)
        {
            var myContextMenu = new ContextMenuStrip();
            selectedItem = orderListview.GetItemAt(e.X, e.Y);
            
            if (e.Button != MouseButtons.Right) return;
            if (selectedItem == null) return;
            
            myContextMenu.Items.Add("cancel");
            myContextMenu.Show(Cursor.Position);
            myContextMenu.ItemClicked += myContextMenu_ItemClicked;
        }
        
        private void myContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            orderListview.Items.Remove(selectedItem);
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

        private void buynowButton_Click(object sender, EventArgs e)
        {
            notationPic.Image = global::RTSBitcoinProject.Properties.Resources.greenArrow;
            updatePriceChart();
        }

        private void sellnowButton_Click(object sender, EventArgs e)
        {
            notationPic.Image = global::RTSBitcoinProject.Properties.Resources.redArrow;
        }
        private void updatePriceChart()
        {
            // adding date and high
            priceChart.Series["price"].Points.AddXY(1, 10f);
            // adding low
            priceChart.Series["price"].Points[0].YValues[1] = 8f;
            //adding open
            priceChart.Series["price"].Points[0].YValues[2] = 9f;
            // adding close
            priceChart.Series["price"].Points[0].YValues[3] = 9.5f;

            // adding date and high
            priceChart.Series["price"].Points.AddXY(2, 10f);
            // adding low
            priceChart.Series["price"].Points[1].YValues[1] = 8f;
            //adding open
            priceChart.Series["price"].Points[1].YValues[2] = 9.5f;
            // adding close
            priceChart.Series["price"].Points[1].YValues[3] = 9f;

            // adding date and high
            priceChart.Series["price"].Points.AddXY(3, 20f);
            // adding low
            priceChart.Series["price"].Points[2].YValues[1] = 18f;
            //adding open
            priceChart.Series["price"].Points[2].YValues[2] = 19.5f;
            // adding close
            priceChart.Series["price"].Points[2].YValues[3] = 19f;

            // adding date and high
            priceChart.Series["price"].Points.AddXY(4, 30f);
            // adding low
            priceChart.Series["price"].Points[3].YValues[1] = 10f;
            //adding open
            priceChart.Series["price"].Points[3].YValues[2] = 25.5f;
            // adding close
            priceChart.Series["price"].Points[3].YValues[3] = 13f;
        }
    }
}