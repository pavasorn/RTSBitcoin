﻿using System;
using System.Globalization;
using System.Windows.Forms;
using BtcE;

namespace RTSBitcoinProject
{
    public partial class Mainpage : Form
    {
        #region Not implemented functions
        // Arrow and chart functions
        //notationPic.Image = Properties.Resources.greenArrow;
        //notationPic.Image = Properties.Resources.redArrow;
        //UpdatePriceChart();

        // Add item function
        //var item1 = new ListViewItem("Time");
        //item1.SubItems.Add("SubItem1a");
        //item1.SubItems.Add("SubItem1b");
        //item1.SubItems.Add("SubItem1c");
        //item1.SubItems.Add("SubItem1d");
        //item1.SubItems.Add("Buy");
        //orderListview.Items.Add(item1);
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
                balanceLabel.Text = _control.UpdateBalance();
                UpdatePricesTimer.Enabled = true;
                UpdatePrices();
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
            
            highpriceLabel.Text = _ticker.High.ToString(_culture);
            avgpriceLabel.Text = _ticker.Average.ToString(_culture);
            lowpriceLabel.Text = _ticker.Low.ToString(_culture);
            
            buypriceLabel.Text = _ticker.Buy.ToString(_culture);
            sellPriceLabel.Text = _ticker.Sell.ToString(_culture);

            if (!buyAutoUpdateCheckBox.Checked) return;
            buyAtTextBox.Text = (_ticker.Buy * 0.99m).ToString(_culture);

            if (!sellAutoUpdateCheckBox.Checked) return;
            sellAtTextBox.Text = (_ticker.Sell * 1.02m).ToString(_culture);
        }

        private void UpdatePriceChart()
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
        #endregion

        #region MouseEvents

        #region currencyComboBox
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
        #endregion

        #region Buy
        private void buynowButton_Click(object sender, EventArgs e)
        {
            try
            {
                var operationPrice = Decimal.Parse(buypriceLabel.Text,_culture);
                var operationAmount = Decimal.Parse(buyAmountTextBox.Text, _culture);

                var tradeAnswer = _control.Buy(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
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

                var tradeAnswer = _control.Buy(_pair, operationPrice, operationAmount);
                balanceLabel.Text = _control.UpdateBalance();
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
    }
}