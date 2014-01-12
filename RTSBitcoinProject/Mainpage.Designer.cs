﻿namespace RTSBitcoinProject
{
    partial class Mainpage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buynowButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.sellatButton = new System.Windows.Forms.Button();
            this.buyatButton = new System.Windows.Forms.Button();
            this.sellnowButton = new System.Windows.Forms.Button();
            this.sellPriceLabel = new System.Windows.Forms.Label();
            this.buypriceLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.avgpriceLabel = new System.Windows.Forms.Label();
            this.lowpriceLabel = new System.Windows.Forms.Label();
            this.highpriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderListview = new System.Windows.Forms.ListView();
            this.orderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdatePricesTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notationPic = new System.Windows.Forms.PictureBox();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.buyAmountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sellAmountTextBox = new System.Windows.Forms.TextBox();
            this.buyAtTextBox = new System.Windows.Forms.TextBox();
            this.sellAtTextBox = new System.Windows.Forms.TextBox();
            this.buyAutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.sellAutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notationPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // buynowButton
            // 
            this.buynowButton.Location = new System.Drawing.Point(151, 85);
            this.buynowButton.Name = "buynowButton";
            this.buynowButton.Size = new System.Drawing.Size(75, 23);
            this.buynowButton.TabIndex = 41;
            this.buynowButton.Text = "Now";
            this.buynowButton.UseVisualStyleBackColor = true;
            this.buynowButton.Click += new System.EventHandler(this.buynowButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Currency:";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(79, 6);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currencyComboBox.Size = new System.Drawing.Size(81, 21);
            this.currencyComboBox.TabIndex = 37;
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            this.currencyComboBox.Click += new System.EventHandler(this.currencyComboBox_Click);
            // 
            // sellatButton
            // 
            this.sellatButton.Location = new System.Drawing.Point(232, 116);
            this.sellatButton.Name = "sellatButton";
            this.sellatButton.Size = new System.Drawing.Size(75, 23);
            this.sellatButton.TabIndex = 34;
            this.sellatButton.Text = "At";
            this.sellatButton.UseVisualStyleBackColor = true;
            this.sellatButton.Click += new System.EventHandler(this.sellatButton_Click);
            // 
            // buyatButton
            // 
            this.buyatButton.Location = new System.Drawing.Point(232, 85);
            this.buyatButton.Name = "buyatButton";
            this.buyatButton.Size = new System.Drawing.Size(75, 23);
            this.buyatButton.TabIndex = 33;
            this.buyatButton.Text = "At";
            this.buyatButton.UseVisualStyleBackColor = true;
            this.buyatButton.Click += new System.EventHandler(this.buyatButton_Click);
            // 
            // sellnowButton
            // 
            this.sellnowButton.Location = new System.Drawing.Point(151, 116);
            this.sellnowButton.Name = "sellnowButton";
            this.sellnowButton.Size = new System.Drawing.Size(75, 23);
            this.sellnowButton.TabIndex = 32;
            this.sellnowButton.Text = "Now";
            this.sellnowButton.UseVisualStyleBackColor = true;
            this.sellnowButton.Click += new System.EventHandler(this.sellnowButton_Click);
            // 
            // sellPriceLabel
            // 
            this.sellPriceLabel.Location = new System.Drawing.Point(244, 58);
            this.sellPriceLabel.Name = "sellPriceLabel";
            this.sellPriceLabel.Size = new System.Drawing.Size(51, 13);
            this.sellPriceLabel.TabIndex = 31;
            this.sellPriceLabel.Text = "<sellpriceLabel>";
            // 
            // buypriceLabel
            // 
            this.buypriceLabel.Location = new System.Drawing.Point(149, 58);
            this.buypriceLabel.Name = "buypriceLabel";
            this.buypriceLabel.Size = new System.Drawing.Size(60, 13);
            this.buypriceLabel.TabIndex = 30;
            this.buypriceLabel.Text = "<buypriceLabel>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sell Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Buy Price";
            // 
            // avgpriceLabel
            // 
            this.avgpriceLabel.Location = new System.Drawing.Point(229, 178);
            this.avgpriceLabel.Name = "avgpriceLabel";
            this.avgpriceLabel.Size = new System.Drawing.Size(86, 13);
            this.avgpriceLabel.TabIndex = 27;
            this.avgpriceLabel.Text = "<avgpriceLabel>";
            // 
            // lowpriceLabel
            // 
            this.lowpriceLabel.Location = new System.Drawing.Point(363, 178);
            this.lowpriceLabel.Name = "lowpriceLabel";
            this.lowpriceLabel.Size = new System.Drawing.Size(63, 13);
            this.lowpriceLabel.TabIndex = 26;
            this.lowpriceLabel.Text = "<lowpriceLabel>";
            // 
            // highpriceLabel
            // 
            this.highpriceLabel.AutoSize = true;
            this.highpriceLabel.Location = new System.Drawing.Point(113, 178);
            this.highpriceLabel.Name = "highpriceLabel";
            this.highpriceLabel.Size = new System.Drawing.Size(88, 13);
            this.highpriceLabel.TabIndex = 25;
            this.highpriceLabel.Text = "<highpriceLabel>";
            this.highpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Low";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "High";
            // 
            // orderListview
            // 
            this.orderListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderId,
            this.orderTime,
            this.orderType,
            this.volume,
            this.price,
            this.currency});
            this.orderListview.Location = new System.Drawing.Point(23, 238);
            this.orderListview.Name = "orderListview";
            this.orderListview.Size = new System.Drawing.Size(496, 162);
            this.orderListview.TabIndex = 42;
            this.orderListview.UseCompatibleStateImageBehavior = false;
            this.orderListview.View = System.Windows.Forms.View.Details;
            this.orderListview.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orderListview_MouseClick);
            // 
            // orderTime
            // 
            this.orderTime.Text = "Order Time";
            this.orderTime.Width = 87;
            // 
            // orderId
            // 
            this.orderId.Text = "Order Id";
            this.orderId.Width = 75;
            // 
            // orderType
            // 
            this.orderType.Text = "Order Type";
            this.orderType.Width = 69;
            // 
            // volume
            // 
            this.volume.Text = "Volume";
            this.volume.Width = 79;
            // 
            // price
            // 
            this.price.Text = "Rate";
            this.price.Width = 94;
            // 
            // currency
            // 
            this.currency.Text = "Currency";
            this.currency.Width = 86;
            // 
            // UpdatePricesTimer
            // 
            this.UpdatePricesTimer.Interval = 10000;
            this.UpdatePricesTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceLabel.Location = new System.Drawing.Point(420, 6);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(99, 25);
            this.balanceLabel.TabIndex = 44;
            this.balanceLabel.Text = "<balance>";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Pending transactions";
            // 
            // notationPic
            // 
            this.notationPic.Image = global::RTSBitcoinProject.Properties.Resources.redArrow;
            this.notationPic.Location = new System.Drawing.Point(93, 156);
            this.notationPic.Name = "notationPic";
            this.notationPic.Size = new System.Drawing.Size(16, 13);
            this.notationPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.notationPic.TabIndex = 46;
            this.notationPic.TabStop = false;
            // 
            // priceChart
            // 
            this.priceChart.BackImageTransparentColor = System.Drawing.Color.Black;
            this.priceChart.BackSecondaryColor = System.Drawing.Color.Black;
            this.priceChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea2.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.priceChart.Legends.Add(legend2);
            this.priceChart.Location = new System.Drawing.Point(26, 406);
            this.priceChart.Name = "priceChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.CustomProperties = "LabelValueType=Open, PriceDownColor=Red, PriceUpColor=Lime";
            series2.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Navy;
            series2.MarkerColor = System.Drawing.Color.DarkBlue;
            series2.MarkerImageTransparentColor = System.Drawing.Color.White;
            series2.Name = "price";
            series2.YValuesPerPoint = 4;
            this.priceChart.Series.Add(series2);
            this.priceChart.Size = new System.Drawing.Size(496, 155);
            this.priceChart.TabIndex = 47;
            this.priceChart.Text = "priceChart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Buy";
            // 
            // buyAmountTextBox
            // 
            this.buyAmountTextBox.AcceptsTab = true;
            this.buyAmountTextBox.Location = new System.Drawing.Point(78, 87);
            this.buyAmountTextBox.Name = "buyAmountTextBox";
            this.buyAmountTextBox.Size = new System.Drawing.Size(68, 20);
            this.buyAmountTextBox.TabIndex = 49;
            this.buyAmountTextBox.Text = "0.1";
            this.buyAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Sell";
            // 
            // sellAmountTextBox
            // 
            this.sellAmountTextBox.Location = new System.Drawing.Point(77, 117);
            this.sellAmountTextBox.Name = "sellAmountTextBox";
            this.sellAmountTextBox.Size = new System.Drawing.Size(68, 20);
            this.sellAmountTextBox.TabIndex = 51;
            this.sellAmountTextBox.Text = "0.1";
            this.sellAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buyAtTextBox
            // 
            this.buyAtTextBox.Location = new System.Drawing.Point(314, 85);
            this.buyAtTextBox.MaxLength = 12;
            this.buyAtTextBox.Name = "buyAtTextBox";
            this.buyAtTextBox.Size = new System.Drawing.Size(89, 20);
            this.buyAtTextBox.TabIndex = 52;
            // 
            // sellAtTextBox
            // 
            this.sellAtTextBox.Location = new System.Drawing.Point(313, 119);
            this.sellAtTextBox.MaxLength = 12;
            this.sellAtTextBox.Name = "sellAtTextBox";
            this.sellAtTextBox.Size = new System.Drawing.Size(90, 20);
            this.sellAtTextBox.TabIndex = 53;
            // 
            // buyAutoUpdateCheckBox
            // 
            this.buyAutoUpdateCheckBox.AutoSize = true;
            this.buyAutoUpdateCheckBox.Checked = true;
            this.buyAutoUpdateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buyAutoUpdateCheckBox.Location = new System.Drawing.Point(410, 87);
            this.buyAutoUpdateCheckBox.Name = "buyAutoUpdateCheckBox";
            this.buyAutoUpdateCheckBox.Size = new System.Drawing.Size(83, 17);
            this.buyAutoUpdateCheckBox.TabIndex = 54;
            this.buyAutoUpdateCheckBox.Text = "AutoUpdate";
            this.buyAutoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // sellAutoUpdateCheckBox
            // 
            this.sellAutoUpdateCheckBox.AutoSize = true;
            this.sellAutoUpdateCheckBox.Checked = true;
            this.sellAutoUpdateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sellAutoUpdateCheckBox.Location = new System.Drawing.Point(410, 121);
            this.sellAutoUpdateCheckBox.Name = "sellAutoUpdateCheckBox";
            this.sellAutoUpdateCheckBox.Size = new System.Drawing.Size(83, 17);
            this.sellAutoUpdateCheckBox.TabIndex = 55;
            this.sellAutoUpdateCheckBox.Text = "AutoUpdate";
            this.sellAutoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // depthLabel
            // 
            this.depthLabel.Location = new System.Drawing.Point(330, 58);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(73, 13);
            this.depthLabel.TabIndex = 57;
            this.depthLabel.Text = "<depthLabel>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Depth";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 562);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sellAutoUpdateCheckBox);
            this.Controls.Add(this.buyAutoUpdateCheckBox);
            this.Controls.Add(this.sellAtTextBox);
            this.Controls.Add(this.buyAtTextBox);
            this.Controls.Add(this.sellAmountTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buyAmountTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceChart);
            this.Controls.Add(this.notationPic);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderListview);
            this.Controls.Add(this.buynowButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.sellatButton);
            this.Controls.Add(this.buyatButton);
            this.Controls.Add(this.sellnowButton);
            this.Controls.Add(this.sellPriceLabel);
            this.Controls.Add(this.buypriceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avgpriceLabel);
            this.Controls.Add(this.lowpriceLabel);
            this.Controls.Add(this.highpriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 600);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "Mainpage";
            this.Text = "Mainpage";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainpage_Closed);
            this.Shown += new System.EventHandler(this.Mainpage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.notationPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buynowButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Button sellatButton;
        private System.Windows.Forms.Button buyatButton;
        private System.Windows.Forms.Button sellnowButton;
        private System.Windows.Forms.Label sellPriceLabel;
        private System.Windows.Forms.Label buypriceLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label avgpriceLabel;
        private System.Windows.Forms.Label lowpriceLabel;
        private System.Windows.Forms.Label highpriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView orderListview;
        private System.Windows.Forms.ColumnHeader orderTime;
        private System.Windows.Forms.ColumnHeader orderType;
        private System.Windows.Forms.ColumnHeader volume;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader currency;
        private System.Windows.Forms.Timer UpdatePricesTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox notationPic;
        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buyAmountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox sellAmountTextBox;
        private System.Windows.Forms.TextBox buyAtTextBox;
        private System.Windows.Forms.TextBox sellAtTextBox;
        private System.Windows.Forms.CheckBox buyAutoUpdateCheckBox;
        private System.Windows.Forms.CheckBox sellAutoUpdateCheckBox;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label label12;

    }
}

