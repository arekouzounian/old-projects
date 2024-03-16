namespace ArekLoginWFA
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.userField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.moneyAmtStr = new System.Windows.Forms.Label();
            this.welcomeStr = new System.Windows.Forms.Label();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.submitAmt = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.loggedInPanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.deWiPanel = new System.Windows.Forms.Panel();
            this.deWiMoneyAmt = new System.Windows.Forms.Label();
            this.deWiLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.loggedInPanel.SuspendLayout();
            this.deWiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // userField
            // 
            this.userField.Location = new System.Drawing.Point(111, 181);
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(98, 22);
            this.userField.TabIndex = 1;
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(266, 181);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(103, 22);
            this.passField.TabIndex = 2;
            this.passField.UseSystemPasswordChar = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(123, 147);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(73, 17);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(272, 147);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moneyAmtStr
            // 
            this.moneyAmtStr.AutoSize = true;
            this.moneyAmtStr.Location = new System.Drawing.Point(154, 123);
            this.moneyAmtStr.Name = "moneyAmtStr";
            this.moneyAmtStr.Size = new System.Drawing.Size(110, 17);
            this.moneyAmtStr.TabIndex = 6;
            this.moneyAmtStr.Text = "Money Amount: ";
            // 
            // welcomeStr
            // 
            this.welcomeStr.AutoSize = true;
            this.welcomeStr.Location = new System.Drawing.Point(206, 58);
            this.welcomeStr.Name = "welcomeStr";
            this.welcomeStr.Size = new System.Drawing.Size(69, 17);
            this.welcomeStr.TabIndex = 7;
            this.welcomeStr.Text = "Welcome!";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(275, 181);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(105, 29);
            this.withdrawButton.TabIndex = 9;
            this.withdrawButton.Text = "Withdrawal";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(126, 181);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(105, 29);
            this.depositButton.TabIndex = 9;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 10;
            // 
            // submitAmt
            // 
            this.submitAmt.Location = new System.Drawing.Point(206, 198);
            this.submitAmt.Name = "submitAmt";
            this.submitAmt.Size = new System.Drawing.Size(75, 29);
            this.submitAmt.TabIndex = 11;
            this.submitAmt.Text = "Submit";
            this.submitAmt.UseVisualStyleBackColor = true;
            this.submitAmt.Click += new System.EventHandler(this.submitAmt_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.registerButton);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.userLabel);
            this.loginPanel.Controls.Add(this.passLabel);
            this.loginPanel.Controls.Add(this.userField);
            this.loginPanel.Controls.Add(this.passField);
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(479, 416);
            this.loginPanel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Please Enter your new Username and Password.";
            this.label2.Visible = false;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(193, 343);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(88, 31);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loggedInPanel
            // 
            this.loggedInPanel.Controls.Add(this.loginPanel);
            this.loggedInPanel.Controls.Add(this.logoutButton);
            this.loggedInPanel.Controls.Add(this.welcomeStr);
            this.loggedInPanel.Controls.Add(this.moneyAmtStr);
            this.loggedInPanel.Controls.Add(this.depositButton);
            this.loggedInPanel.Controls.Add(this.withdrawButton);
            this.loggedInPanel.Location = new System.Drawing.Point(147, 29);
            this.loggedInPanel.Name = "loggedInPanel";
            this.loggedInPanel.Size = new System.Drawing.Size(479, 416);
            this.loggedInPanel.TabIndex = 13;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(200, 309);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(91, 28);
            this.logoutButton.TabIndex = 10;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // deWiPanel
            // 
            this.deWiPanel.Controls.Add(this.deWiMoneyAmt);
            this.deWiPanel.Controls.Add(this.deWiLabel);
            this.deWiPanel.Controls.Add(this.textBox1);
            this.deWiPanel.Controls.Add(this.submitAmt);
            this.deWiPanel.Location = new System.Drawing.Point(147, 26);
            this.deWiPanel.Name = "deWiPanel";
            this.deWiPanel.Size = new System.Drawing.Size(479, 416);
            this.deWiPanel.TabIndex = 14;
            // 
            // deWiMoneyAmt
            // 
            this.deWiMoneyAmt.AutoSize = true;
            this.deWiMoneyAmt.Location = new System.Drawing.Point(119, 123);
            this.deWiMoneyAmt.Name = "deWiMoneyAmt";
            this.deWiMoneyAmt.Size = new System.Drawing.Size(110, 17);
            this.deWiMoneyAmt.TabIndex = 13;
            this.deWiMoneyAmt.Text = "Money Amount: ";
            // 
            // deWiLabel
            // 
            this.deWiLabel.AutoSize = true;
            this.deWiLabel.Location = new System.Drawing.Point(90, 58);
            this.deWiLabel.Name = "deWiLabel";
            this.deWiLabel.Size = new System.Drawing.Size(46, 17);
            this.deWiLabel.TabIndex = 12;
            this.deWiLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 493);
            this.Controls.Add(this.loggedInPanel);
            this.Controls.Add(this.deWiPanel);
            this.Name = "Form1";
            this.Text = "Bank Account Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.loggedInPanel.ResumeLayout(false);
            this.loggedInPanel.PerformLayout();
            this.deWiPanel.ResumeLayout(false);
            this.deWiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label moneyAmtStr;
        private System.Windows.Forms.Label welcomeStr;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button submitAmt;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel loggedInPanel;
        private System.Windows.Forms.Panel deWiPanel;
        private System.Windows.Forms.Label deWiMoneyAmt;
        private System.Windows.Forms.Label deWiLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label label2;
    }
}

