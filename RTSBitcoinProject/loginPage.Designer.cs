namespace RTSBitcoinProject
{
    partial class LoginPage
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
            this.remembermeCheckbox = new System.Windows.Forms.CheckBox();
            this.AlertLabel = new System.Windows.Forms.Label();
            this.apisecretTextBox = new System.Windows.Forms.TextBox();
            this.apisecretLabel = new System.Windows.Forms.Label();
            this.apikeyLabel = new System.Windows.Forms.Label();
            this.apikeyTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remembermeCheckbox
            // 
            this.remembermeCheckbox.AutoSize = true;
            this.remembermeCheckbox.Location = new System.Drawing.Point(245, 109);
            this.remembermeCheckbox.Name = "remembermeCheckbox";
            this.remembermeCheckbox.Size = new System.Drawing.Size(118, 17);
            this.remembermeCheckbox.TabIndex = 15;
            this.remembermeCheckbox.Text = "Remember API Info";
            this.remembermeCheckbox.UseVisualStyleBackColor = true;
            // 
            // AlertLabel
            // 
            this.AlertLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertLabel.ForeColor = System.Drawing.Color.Red;
            this.AlertLabel.Location = new System.Drawing.Point(70, 137);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(366, 20);
            this.AlertLabel.TabIndex = 14;
            this.AlertLabel.Text = "Key and/or Secret does not exist or is wrong.";
            this.AlertLabel.Visible = false;
            // 
            // apisecretTextBox
            // 
            this.apisecretTextBox.Location = new System.Drawing.Point(74, 64);
            this.apisecretTextBox.Name = "apisecretTextBox";
            this.apisecretTextBox.Size = new System.Drawing.Size(398, 20);
            this.apisecretTextBox.TabIndex = 13;
            this.apisecretTextBox.Text = "79b2562155534c1842b85725358fc8ac3adbc7ef0952c0e9a772ced1f0a93369";
            // 
            // apisecretLabel
            // 
            this.apisecretLabel.AutoSize = true;
            this.apisecretLabel.Location = new System.Drawing.Point(9, 71);
            this.apisecretLabel.Name = "apisecretLabel";
            this.apisecretLabel.Size = new System.Drawing.Size(61, 13);
            this.apisecretLabel.TabIndex = 12;
            this.apisecretLabel.Text = "API Secret:";
            // 
            // apikeyLabel
            // 
            this.apikeyLabel.AutoSize = true;
            this.apikeyLabel.Location = new System.Drawing.Point(22, 31);
            this.apikeyLabel.Name = "apikeyLabel";
            this.apikeyLabel.Size = new System.Drawing.Size(48, 13);
            this.apikeyLabel.TabIndex = 11;
            this.apikeyLabel.Text = "API Key:";
            // 
            // apikeyTextBox
            // 
            this.apikeyTextBox.Location = new System.Drawing.Point(74, 28);
            this.apikeyTextBox.Name = "apikeyTextBox";
            this.apikeyTextBox.Size = new System.Drawing.Size(398, 20);
            this.apikeyTextBox.TabIndex = 10;
            this.apikeyTextBox.Text = "KR3Y5845-RJ9P21RY-C8AFMBDV-DLTSDRBM-GKN022V9";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(140, 104);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(83, 24);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 166);
            this.Controls.Add(this.remembermeCheckbox);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.apisecretTextBox);
            this.Controls.Add(this.apisecretLabel);
            this.Controls.Add(this.apikeyLabel);
            this.Controls.Add(this.apikeyTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginPage";
            this.Text = "loginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox remembermeCheckbox;
        private System.Windows.Forms.Label AlertLabel;
        private System.Windows.Forms.TextBox apisecretTextBox;
        private System.Windows.Forms.Label apisecretLabel;
        private System.Windows.Forms.Label apikeyLabel;
        private System.Windows.Forms.TextBox apikeyTextBox;
        private System.Windows.Forms.Button loginButton;

    }
}