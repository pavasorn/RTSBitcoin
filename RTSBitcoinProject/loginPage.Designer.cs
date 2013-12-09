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
            this.remembermeCheckbox.Location = new System.Drawing.Point(167, 132);
            this.remembermeCheckbox.Name = "remembermeCheckbox";
            this.remembermeCheckbox.Size = new System.Drawing.Size(118, 17);
            this.remembermeCheckbox.TabIndex = 15;
            this.remembermeCheckbox.Text = "Remember API Info";
            this.remembermeCheckbox.UseVisualStyleBackColor = true;
            // 
            // AlertLabel
            // 
            this.AlertLabel.AutoSize = true;
            this.AlertLabel.Location = new System.Drawing.Point(471, 132);
            this.AlertLabel.Name = "AlertLabel";
            this.AlertLabel.Size = new System.Drawing.Size(28, 13);
            this.AlertLabel.TabIndex = 14;
            this.AlertLabel.Text = "Alert";
            // 
            // apisecretTextBox
            // 
            this.apisecretTextBox.Location = new System.Drawing.Point(101, 83);
            this.apisecretTextBox.Name = "apisecretTextBox";
            this.apisecretTextBox.Size = new System.Drawing.Size(653, 20);
            this.apisecretTextBox.TabIndex = 13;
            // 
            // apisecretLabel
            // 
            this.apisecretLabel.AutoSize = true;
            this.apisecretLabel.Location = new System.Drawing.Point(36, 90);
            this.apisecretLabel.Name = "apisecretLabel";
            this.apisecretLabel.Size = new System.Drawing.Size(61, 13);
            this.apisecretLabel.TabIndex = 12;
            this.apisecretLabel.Text = "API Secret:";
            // 
            // apikeyLabel
            // 
            this.apikeyLabel.AutoSize = true;
            this.apikeyLabel.Location = new System.Drawing.Point(49, 50);
            this.apikeyLabel.Name = "apikeyLabel";
            this.apikeyLabel.Size = new System.Drawing.Size(48, 13);
            this.apikeyLabel.TabIndex = 11;
            this.apikeyLabel.Text = "API Key:";
            // 
            // apikeyTextBox
            // 
            this.apikeyTextBox.Location = new System.Drawing.Point(101, 47);
            this.apikeyTextBox.Name = "apikeyTextBox";
            this.apikeyTextBox.Size = new System.Drawing.Size(653, 20);
            this.apikeyTextBox.TabIndex = 10;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(101, 125);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(45, 36);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 208);
            this.Controls.Add(this.remembermeCheckbox);
            this.Controls.Add(this.AlertLabel);
            this.Controls.Add(this.apisecretTextBox);
            this.Controls.Add(this.apisecretLabel);
            this.Controls.Add(this.apikeyLabel);
            this.Controls.Add(this.apikeyTextBox);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginPage";
            this.Text = "loginPage";
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