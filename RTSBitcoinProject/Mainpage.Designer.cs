namespace RTSBitcoinProject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buynowButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.sellatButton = new System.Windows.Forms.Button();
            this.buyatButton = new System.Windows.Forms.Button();
            this.sellnowButton = new System.Windows.Forms.Button();
            this.sellpriceLabel = new System.Windows.Forms.Label();
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
            this.orderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.volume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.currency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdatePricesTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notationPic = new System.Windows.Forms.PictureBox();
            this.priceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.notationPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // buynowButton
            // 
            this.buynowButton.Location = new System.Drawing.Point(193, 86);
            this.buynowButton.Name = "buynowButton";
            this.buynowButton.Size = new System.Drawing.Size(75, 23);
            this.buynowButton.TabIndex = 41;
            this.buynowButton.Text = "Buy Now";
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
            this.currencyComboBox.Size = new System.Drawing.Size(71, 21);
            this.currencyComboBox.TabIndex = 37;
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // sellatButton
            // 
            this.sellatButton.Location = new System.Drawing.Point(285, 115);
            this.sellatButton.Name = "sellatButton";
            this.sellatButton.Size = new System.Drawing.Size(75, 23);
            this.sellatButton.TabIndex = 34;
            this.sellatButton.Text = "Sell at";
            this.sellatButton.UseVisualStyleBackColor = true;
            this.sellatButton.Click += new System.EventHandler(this.sellatButton_Click);
            // 
            // buyatButton
            // 
            this.buyatButton.Location = new System.Drawing.Point(193, 115);
            this.buyatButton.Name = "buyatButton";
            this.buyatButton.Size = new System.Drawing.Size(75, 23);
            this.buyatButton.TabIndex = 33;
            this.buyatButton.Text = "Buy at";
            this.buyatButton.UseVisualStyleBackColor = true;
            this.buyatButton.Click += new System.EventHandler(this.buyatButton_Click);
            // 
            // sellnowButton
            // 
            this.sellnowButton.Location = new System.Drawing.Point(285, 86);
            this.sellnowButton.Name = "sellnowButton";
            this.sellnowButton.Size = new System.Drawing.Size(75, 23);
            this.sellnowButton.TabIndex = 32;
            this.sellnowButton.Text = "Sell Now";
            this.sellnowButton.UseVisualStyleBackColor = true;
            this.sellnowButton.Click += new System.EventHandler(this.sellnowButton_Click);
            // 
            // sellpriceLabel
            // 
            this.sellpriceLabel.Location = new System.Drawing.Point(301, 58);
            this.sellpriceLabel.Name = "sellpriceLabel";
            this.sellpriceLabel.Size = new System.Drawing.Size(51, 13);
            this.sellpriceLabel.TabIndex = 31;
            this.sellpriceLabel.Text = "<sellpriceLabel>";
            // 
            // buypriceLabel
            // 
            this.buypriceLabel.Location = new System.Drawing.Point(206, 58);
            this.buypriceLabel.Name = "buypriceLabel";
            this.buypriceLabel.Size = new System.Drawing.Size(60, 13);
            this.buypriceLabel.TabIndex = 30;
            this.buypriceLabel.Text = "<buypriceLabel>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Buy";
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
            this.orderTime,
            this.orderType,
            this.volume,
            this.price,
            this.currency,
            this.status});
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
            this.orderTime.Text = "orderTime";
            this.orderTime.Width = 114;
            // 
            // orderType
            // 
            this.orderType.Text = "orderType";
            this.orderType.Width = 114;
            // 
            // volume
            // 
            this.volume.Text = "volume";
            this.volume.Width = 114;
            // 
            // price
            // 
            this.price.Text = "price";
            this.price.Width = 114;
            // 
            // currency
            // 
            this.currency.Text = "currency";
            this.currency.Width = 114;
            // 
            // status
            // 
            this.status.Text = "status";
            this.status.Width = 114;
            // 
            // UpdatePricesTimer
            // 
            this.UpdatePricesTimer.Interval = 1000;
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
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.priceChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.priceChart.Legends.Add(legend1);
            this.priceChart.Location = new System.Drawing.Point(226, 245);
            this.priceChart.Name = "priceChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "LabelValueType=Open, PriceDownColor=Red, PriceUpColor=Lime";
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Navy;
            series1.MarkerColor = System.Drawing.Color.DarkBlue;
            series1.MarkerImageTransparentColor = System.Drawing.Color.White;
            series1.Name = "price";
            series1.YValuesPerPoint = 4;
            this.priceChart.Series.Add(series1);
            this.priceChart.Size = new System.Drawing.Size(496, 155);
            this.priceChart.TabIndex = 47;
            this.priceChart.Text = "priceChart";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
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
            this.Controls.Add(this.sellpriceLabel);
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
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "Mainpage";
            this.Text = "Mainpage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainpage_Closed);
            this.Load += new System.EventHandler(this.Mainpage_Load);
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
        private System.Windows.Forms.Label sellpriceLabel;
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
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Timer UpdatePricesTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox notationPic;
        private System.Windows.Forms.DataVisualization.Charting.Chart priceChart;

    }
}

