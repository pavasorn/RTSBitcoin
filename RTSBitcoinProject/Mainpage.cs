using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;
using CandleSticks;
using System.Collections;
using System.Collections.Generic;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {

        #region Initialisation
        readonly CultureInfo _culture = CultureInfo.InvariantCulture;
        readonly Control _control = new Control();
        private ListViewItem _selectedItem;
        private Ticker _ticker;
        private string _pair;
        private double highValue = -1 ;
        private double lowValue = -1;
        private double startValue = -1;
        private double endValue = -1;
        private double highest = -1;
        private double lowest = -1;
        private bool clean = false;
        public Mainpage()
        {
            var timer = new Timer();
            timer.Tick += timer_Tick;
            timer.Interval = 10000; //60 seconds
            timer.Start();

            InitializeComponent();
            orderListview.FullRowSelect = true;
            
           
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            UpdatePriceChart();
            resetHighandLow();
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
            
            
            UpdateDynamicStick();
            depthLabel.Text = _ticker.VolumeCurrent.ToString(_culture);

            highpriceLabel.Text = _ticker.High.ToString(_culture);
            avgpriceLabel.Text = _ticker.Average.ToString(_culture);
            lowpriceLabel.Text = _ticker.Low.ToString(_culture);
            
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

        private void UpdateDynamicStick()
        {
            if (clean == false)
            {
                var cleanchart = new XmlForCandleSticks();
                cleanchart.CleanElement();
                clean = true;
            }
            if (this.highValue == -1 && lowValue == -1)
            {
                highValue = double.Parse(_ticker.Buy.ToString());
                lowValue = double.Parse(_ticker.Buy.ToString());
                startValue = double.Parse(_ticker.Buy.ToString());
                endValue = double.Parse(_ticker.Buy.ToString());
            }
            if (this.highest == -1 && lowest == -1)
            {
                highest = double.Parse(_ticker.Buy.ToString());
                lowest = double.Parse(_ticker.Buy.ToString());
            }
            if (updateHigh(double.Parse(_ticker.Buy.ToString())))
            {
                this.highValue = double.Parse(_ticker.Buy.ToString());
            }
            if (updateLow(double.Parse(_ticker.Buy.ToString())))
            {
                this.lowValue = double.Parse(_ticker.Buy.ToString());
            }
            this.endValue = double.Parse(_ticker.Buy.ToString());

            

            var chart = new XmlForCandleSticks();
            try
            {
                priceChart.ChartAreas[0].AxisY.Minimum = lowest - 0.5;
                priceChart.ChartAreas[0].AxisY.Maximum = highest + 0.5;
                try
                {
                    priceChart.Series["price"].Points[29].SetValueXY(DateTime.Now.ToString("HH:mm:ss tt"), highValue);
                    priceChart.Series["price"].Points[29].YValues[1] = lowValue;
                    priceChart.Series["price"].Points[29].YValues[3] = endValue;
                }
                catch (Exception)
                {
                    for (int count = 0; count < 29; count++)
                    {
                        priceChart.Series["price"].Points.AddXY("00:00:00 AM", 0);
                        priceChart.Series["price"].Points[count].YValues[1] = 0;
                        priceChart.Series["price"].Points[count].YValues[2] = 0;
                        priceChart.Series["price"].Points[count].YValues[3] = 0;
                    }
                    priceChart.Series["price"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"), double.Parse(_ticker.Buy.ToString()));
                    priceChart.Series["price"].Points[29].YValues[1] = double.Parse(_ticker.Buy.ToString());
                    priceChart.Series["price"].Points[29].YValues[2] = double.Parse(_ticker.Buy.ToString());
                    priceChart.Series["price"].Points[29].YValues[3] = double.Parse(_ticker.Buy.ToString());
                }
            }
            catch (Exception) {}
        }
        private void UpdatePriceChart()
        {

            var chart = new XmlForCandleSticks();
            List<PriceData> priceChartValues;
            if (highValue == -1 && lowValue == -1)
            {
                highValue = double.Parse(_ticker.Buy.ToString());
                lowValue = double.Parse(_ticker.Buy.ToString());
                startValue = double.Parse(_ticker.Buy.ToString());
                endValue = double.Parse(_ticker.Buy.ToString());
            }

            if (updateHigh(double.Parse(_ticker.Buy.ToString())))
            {
                this.highValue = double.Parse(_ticker.Buy.ToString());
            }
            if (updateLow(double.Parse(_ticker.Buy.ToString())))
            {
                this.lowValue = double.Parse(_ticker.Buy.ToString());
            }
            this.endValue = double.Parse(_ticker.Buy.ToString());
            UpdateDynamicStick();
            try
            {
                priceChartValues = chart.ReadAllElements();   
                if (chart.CountElement() != 29)
                {
                    for (int countindex = 0; countindex < 28; countindex++)
                    {
                        chart.AddElement("", "00:00:00 AM", "0", "0", "0", "0");
                    }
                    chart.AddElement(DateTime.Now.ToString("M/d/yyyy"), DateTime.Now.ToString("HH:mm:ss tt"),startValue.ToString(),endValue.ToString(),highValue.ToString(),lowValue.ToString());
                }
                else
                {
                    chart.DeleteElement(0);
                    chart.AddElement(DateTime.Now.ToString("M/d/yyyy"), DateTime.Now.ToString("HH:mm:ss tt"), startValue.ToString(), endValue.ToString(), highValue.ToString(), lowValue.ToString());
                }
                priceChart.Series["price"].Points.Clear();
                priceChart.ChartAreas[0].AxisY.Minimum = lowest - 0.5;
                priceChart.ChartAreas[0].AxisY.Maximum = highest + 0.5;
            }
            catch (Exception)
            {
            }

            priceChartValues = chart.ReadAllElements();

            for (int count = 0; count < priceChartValues.Count; count++)
            {

                priceChart.Series["price"].Points.AddXY(priceChartValues[count].time,double.Parse( priceChartValues[count].high));
                priceChart.Series["price"].Points[count].YValues[1] = double.Parse(priceChartValues[count].low);
                priceChart.Series["price"].Points[count].YValues[2] = double.Parse(priceChartValues[count].start);
                priceChart.Series["price"].Points[count].YValues[3] = double.Parse(priceChartValues[count].end);
            }
            priceChart.Series["price"].Points.AddXY(DateTime.Now.ToString("HH:mm:ss tt"),double.Parse( _ticker.Buy.ToString()));
            priceChart.Series["price"].Points[29].YValues[1] = double.Parse(_ticker.Buy.ToString());
            priceChart.Series["price"].Points[29].YValues[2] = double.Parse(_ticker.Buy.ToString());
            priceChart.Series["price"].Points[29].YValues[3] = double.Parse(_ticker.Buy.ToString());
            
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
        private bool updateHigh(double value)
        {
            if (this.highValue < value)
            {
                this.highValue = value;
                if(highValue > highest){
                    highest = highValue;
                }
                return true;
            }
            return false;
        }
        private bool updateLow(double value)
        {
            if (this.lowValue > value)
            {
                this.lowValue = value;
                if (lowest > lowValue)
                {
                    lowest = lowValue;
                }
                return true;
            }
            return false;
        }
        private void resetHighandLow()
        {
            this.highValue = -1;
            this.lowValue = -1;
        }
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

        private static void UpdateArrow(decimal val1, decimal val2, PictureBox pictureBox)
        {
            if (val1 < val2)
                pictureBox.Image = Properties.Resources.greenArrow;
            else
                if (val1 > val2)
                    pictureBox.Image = Properties.Resources.redArrow;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdatePriceChart();
        }

    }
}