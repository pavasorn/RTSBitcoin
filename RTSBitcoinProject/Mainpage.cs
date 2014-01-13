using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        #region Not implemented functions
        // chart functions
        //UpdatePriceChart();
        #endregion

        #region Initialisation
        readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        readonly Control _control = new Control();
        private ListViewItem _selectedItem;
        private Ticker _ticker;
        private string _pair;

        public Mainpage()
        {
            InitializeComponent();
            orderListview.FullRowSelect = true;
        }
        #endregion

        #region MainRegion
        private void Mainpage_Shown(object sender, EventArgs e)
        {
            try
            {
                AddCurrencies();
                UpdatePricesTimer.Enabled = true;
                UpdatePrices();
                balanceLabel.Text = _control.UpdateBalance();
                UpdateOrderHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddCurrencies()
        {
            currencyComboBox.Items.AddRange(_control.AddCurrencies());
            currencyComboBox.SelectedIndex = currencyComboBox.Items.IndexOf("LTC_USD");
        }

        private void UpdatePrices()
        {
            _pair = currencyComboBox.SelectedItem.ToString();
            _ticker = _control.UpdatePrices(_pair);

            decimal oldTradePrice;
            
            decimal.TryParse(buyPriceLabel.Text, NumberStyles.Any, _culture, out oldTradePrice);
            buyPriceLabel.Text = _ticker.Buy.ToString(_culture);
            if (oldTradePrice!=0) UpdateArrow(oldTradePrice, _ticker.Buy, buyArrowPictureBox);

            decimal.TryParse(sellPriceLabel.Text, NumberStyles.Any, _culture, out oldTradePrice);
            sellPriceLabel.Text = _ticker.Sell.ToString(_culture);
            if (oldTradePrice != 0) UpdateArrow(oldTradePrice, _ticker.Sell, sellArrowPictureBox);
            
            depthLabel.Text = _ticker.VolumeCurrent.ToString(_culture);

            highpriceLabel.Text = _ticker.High.ToString(_culture);
            avgpriceLabel.Text = _ticker.Average.ToString(_culture);
            lowpriceLabel.Text = _ticker.Low.ToString(_culture);
            
            UpdateTradeAtComboBox();
        }

        private void UpdateTradeAtComboBox()
        {
            decimal percentage;
            
            if (buyAutoUpdateCheckBox.Checked && buyAtComboBox.SelectedItem!=null)
            {
                switch (buyAtComboBox.SelectedItem.ToString())
                {
                    case "1%": percentage = 0.99m; break;
                    case "2%": percentage = 0.98m; break;
                    case "3%": percentage = 0.97m; break;
                    case "4%": percentage = 0.96m; break;
                    case "5%": percentage = 0.95m; break;
                    case "10%": percentage = 0.90m; break;
                    default: percentage = 1m; break;
                }
                buyAtTextBox.Text = (_ticker.Buy * percentage).ToString(_culture);
            }

            if (!sellAutoUpdateCheckBox.Checked || sellAtComboBox.SelectedItem==null) return;

            switch (sellAtComboBox.SelectedItem.ToString())
            {
                case "1%": percentage = 1.01m; break;
                case "2%": percentage = 1.02m; break;
                case "3%": percentage = 1.03m; break;
                case "4%": percentage = 1.04m; break;
                case "5%": percentage = 1.05m; break;
                case "10%": percentage = 1.1m; break;
                default: percentage = 1m; break;
            }
            sellAtTextBox.Text = (_ticker.Sell * percentage).ToString(_culture);
        }  

        private void UpdatePriceChart()
        {
            // adding date and high
            priceChart.Series["price"].Points.AddXY("11:33", 10f);
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
        #endregion

        #region MouseEvents

        #region CurrencyComboBox
        private void currencyComboBox_Click(object sender, EventArgs e)
        {
            UpdatePrices();
        }

        private void currencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrices();
        }
        #endregion

        #region OrdersHistory
        private void myContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var cancelOrderId = int.Parse(_selectedItem.Text);
            var cancelOrderAnswer = _control.CancelOrder(cancelOrderId);
            if (cancelOrderAnswer == null) return;

            balanceLabel.Text = cancelOrderAnswer.Funds.Ltc.ToString();
            orderListview.Items.Remove(_selectedItem);
        }

        private void orderListview_MouseClick(object sender, MouseEventArgs e)
        {
            var myContextMenu = new ContextMenuStrip();
            _selectedItem = orderListview.GetItemAt(e.X, e.Y);

            if (e.Button != MouseButtons.Right) return;
            if (_selectedItem == null) return;

            myContextMenu.Items.Add("cancel");
            myContextMenu.Show(Cursor.Position);
            myContextMenu.ItemClicked += myContextMenu_ItemClicked;
        }

        private void UpdateOrderHistory()
        {
            orderListview.Items.Clear();
            var activeOrdersDictionary = _control.GetActiveOrderList();
            if (activeOrdersDictionary == null) return;

            foreach (var order in activeOrdersDictionary.@return)
            {
                var item = new ListViewItem(order.Key);
                item.SubItems.Add(order.Value.Timestamp_Created.ToString());
                item.SubItems.Add(order.Value.Type.ToString());
                item.SubItems.Add(order.Value.Amount.ToString());
                item.SubItems.Add(order.Value.Rate.ToString());
                item.SubItems.Add(order.Value.Pair.ToString());
                orderListview.Items.Add(item);
            }
        }
        #endregion

        #region Buy
        private void buynowButton_Click(object sender, EventArgs e)
        {
            try
            {
                var operationPrice = Decimal.Parse(buyPriceLabel.Text,_culture);
                var operationAmount = Decimal.Parse(buyAmountTextBox.Text, _culture);

                var tradeAnswer = _control.Buy(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
                UpdateOrderHistory();
                SucessMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buyatButton_Click(object sender, EventArgs e)
        {
            try
            {
                var operationPrice = Decimal.Parse(buyAtTextBox.Text, _culture);
                var operationAmount = Decimal.Parse(buyAmountTextBox.Text, _culture);

                var tradeAnswer = _control.Buy(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
                UpdateOrderHistory();
                SucessMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Sell
        private void sellnowButton_Click(object sender, EventArgs e)
        {
            try
            {
                var operationPrice = Decimal.Parse(sellPriceLabel.Text, _culture);
                var operationAmount = Decimal.Parse(sellAmountTextBox.Text, _culture);

                var tradeAnswer = _control.Sell(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
                UpdateOrderHistory();
                SucessMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sellatButton_Click(object sender, EventArgs e)
        {
            try
            {
                var operationPrice = Decimal.Parse(sellAtTextBox.Text, _culture);
                var operationAmount = Decimal.Parse(sellAmountTextBox.Text, _culture);

                var tradeAnswer = _control.Sell(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
                UpdateOrderHistory();
                SucessMessage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #endregion

        #region Tools
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdatePrices();
            _control.UpdateBalance();
        }
        private void Mainpage_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SucessMessage()
        {
            MessageBox.Show(@"Transaction performed successfully");
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdatePriceChart();
        }
        private static void UpdateArrow(decimal val1, decimal val2 , PictureBox pictureBox)
        {
            if (val1 < val2)
                pictureBox.Image = Properties.Resources.greenArrow;
            else 
                if (val1 > val2) 
                    pictureBox.Image = Properties.Resources.redArrow;
        }
    }
}