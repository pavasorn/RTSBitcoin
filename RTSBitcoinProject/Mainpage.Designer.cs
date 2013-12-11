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
            this.buynowButton = new System.Windows.Forms.Button();
            this.volumeTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.sellatTextBox = new System.Windows.Forms.TextBox();
            this.buyatTextBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // buynowButton
            // 
            this.buynowButton.Location = new System.Drawing.Point(406, 37);
            this.buynowButton.Name = "buynowButton";
            this.buynowButton.Size = new System.Drawing.Size(75, 23);
            this.buynowButton.TabIndex = 41;
            this.buynowButton.Text = "Buy Now";
            this.buynowButton.UseVisualStyleBackColor = true;
            // 
            // volumeTextbox
            // 
            this.volumeTextbox.Location = new System.Drawing.Point(248, 40);
            this.volumeTextbox.Name = "volumeTextbox";
            this.volumeTextbox.Size = new System.Drawing.Size(130, 20);
            this.volumeTextbox.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Currency:";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(86, 40);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currencyComboBox.Size = new System.Drawing.Size(71, 21);
            this.currencyComboBox.TabIndex = 37;
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // sellatTextBox
            // 
            this.sellatTextBox.Location = new System.Drawing.Point(590, 69);
            this.sellatTextBox.Name = "sellatTextBox";
            this.sellatTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellatTextBox.TabIndex = 36;
            // 
            // buyatTextBox
            // 
            this.buyatTextBox.Location = new System.Drawing.Point(590, 37);
            this.buyatTextBox.Name = "buyatTextBox";
            this.buyatTextBox.Size = new System.Drawing.Size(100, 20);
            this.buyatTextBox.TabIndex = 35;
            // 
            // sellatButton
            // 
            this.sellatButton.Location = new System.Drawing.Point(498, 66);
            this.sellatButton.Name = "sellatButton";
            this.sellatButton.Size = new System.Drawing.Size(75, 23);
            this.sellatButton.TabIndex = 34;
            this.sellatButton.Text = "Sell at:";
            this.sellatButton.UseVisualStyleBackColor = true;
            this.sellatButton.Click += new System.EventHandler(this.sellatButton_Click);
            // 
            // buyatButton
            // 
            this.buyatButton.Location = new System.Drawing.Point(498, 37);
            this.buyatButton.Name = "buyatButton";
            this.buyatButton.Size = new System.Drawing.Size(75, 23);
            this.buyatButton.TabIndex = 33;
            this.buyatButton.Text = "Buy at:";
            this.buyatButton.UseVisualStyleBackColor = true;
            this.buyatButton.Click += new System.EventHandler(this.buyatButton_Click);
            // 
            // sellnowButton
            // 
            this.sellnowButton.Location = new System.Drawing.Point(406, 66);
            this.sellnowButton.Name = "sellnowButton";
            this.sellnowButton.Size = new System.Drawing.Size(75, 23);
            this.sellnowButton.TabIndex = 32;
            this.sellnowButton.Text = "Sell Now";
            this.sellnowButton.UseVisualStyleBackColor = true;
            // 
            // sellpriceLabel
            // 
            this.sellpriceLabel.AutoSize = true;
            this.sellpriceLabel.Location = new System.Drawing.Point(625, 177);
            this.sellpriceLabel.Name = "sellpriceLabel";
            this.sellpriceLabel.Size = new System.Drawing.Size(83, 13);
            this.sellpriceLabel.TabIndex = 31;
            this.sellpriceLabel.Text = "<sellpriceLabel>";
            // 
            // buypriceLabel
            // 
            this.buypriceLabel.AutoSize = true;
            this.buypriceLabel.Location = new System.Drawing.Point(493, 177);
            this.buypriceLabel.Name = "buypriceLabel";
            this.buypriceLabel.Size = new System.Drawing.Size(85, 13);
            this.buypriceLabel.TabIndex = 30;
            this.buypriceLabel.Text = "<buypriceLabel>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(655, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Sell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Buy";
            // 
            // avgpriceLabel
            // 
            this.avgpriceLabel.AutoSize = true;
            this.avgpriceLabel.Location = new System.Drawing.Point(184, 177);
            this.avgpriceLabel.Name = "avgpriceLabel";
            this.avgpriceLabel.Size = new System.Drawing.Size(86, 13);
            this.avgpriceLabel.TabIndex = 27;
            this.avgpriceLabel.Text = "<avgpriceLabel>";
            // 
            // lowpriceLabel
            // 
            this.lowpriceLabel.AutoSize = true;
            this.lowpriceLabel.Location = new System.Drawing.Point(346, 176);
            this.lowpriceLabel.Name = "lowpriceLabel";
            this.lowpriceLabel.Size = new System.Drawing.Size(84, 13);
            this.lowpriceLabel.TabIndex = 26;
            this.lowpriceLabel.Text = "<lowpriceLabel>";
            // 
            // highpriceLabel
            // 
            this.highpriceLabel.AutoSize = true;
            this.highpriceLabel.Location = new System.Drawing.Point(20, 176);
            this.highpriceLabel.Name = "highpriceLabel";
            this.highpriceLabel.Size = new System.Drawing.Size(88, 13);
            this.highpriceLabel.TabIndex = 25;
            this.highpriceLabel.Text = "<highpriceLabel>";
            this.highpriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Low";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 144);
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
            this.orderListview.Location = new System.Drawing.Point(23, 230);
            this.orderListview.Name = "orderListview";
            this.orderListview.Size = new System.Drawing.Size(685, 141);
            this.orderListview.TabIndex = 42;
            this.orderListview.UseCompatibleStateImageBehavior = false;
            this.orderListview.View = System.Windows.Forms.View.Details;
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
            this.UpdatePricesTimer.Enabled = true;
            this.UpdatePricesTimer.Interval = 5000;
            this.UpdatePricesTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 412);
            this.Controls.Add(this.orderListview);
            this.Controls.Add(this.buynowButton);
            this.Controls.Add(this.volumeTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.sellatTextBox);
            this.Controls.Add(this.buyatTextBox);
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
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "Mainpage";
            this.Text = "Mainpage";
            this.Load += new System.EventHandler(this.Mainpage_Load);
            this.Shown += new System.EventHandler(this.Mainpage_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buynowButton;
        private System.Windows.Forms.TextBox volumeTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.TextBox sellatTextBox;
        private System.Windows.Forms.TextBox buyatTextBox;
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

    }
}

