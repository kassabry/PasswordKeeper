namespace PasswordKeeper
{
    partial class CheckStrengthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckStrengthForm));
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.logoLabel = new System.Windows.Forms.Label();
            this.panelLEFT = new System.Windows.Forms.Panel();
            this.homepageButton = new System.Windows.Forms.Button();
            this.cpyrtLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.removePassButton = new System.Windows.Forms.Button();
            this.addPassButton = new System.Windows.Forms.Button();
            this.checkStrengthButton = new System.Windows.Forms.Button();
            this.currentPasswords = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.panelCurrPass = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pswLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.strengthTitle = new System.Windows.Forms.Label();
            this.tipsLabel = new System.Windows.Forms.Label();
            this.tipsTitle = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.panelLEFT.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoLabel.Location = new System.Drawing.Point(33, 4);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(136, 96);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "SP";
            this.logoLabel.Click += new System.EventHandler(this.logoLabel_Click);
            // 
            // panelLEFT
            // 
            this.panelLEFT.Controls.Add(this.homepageButton);
            this.panelLEFT.Controls.Add(this.cpyrtLabel);
            this.panelLEFT.Controls.Add(this.companyLabel);
            this.panelLEFT.Controls.Add(this.removePassButton);
            this.panelLEFT.Controls.Add(this.addPassButton);
            this.panelLEFT.Controls.Add(this.checkStrengthButton);
            this.panelLEFT.Controls.Add(this.currentPasswords);
            this.panelLEFT.Controls.Add(this.logoPanel);
            this.panelLEFT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLEFT.Location = new System.Drawing.Point(0, 0);
            this.panelLEFT.Name = "panelLEFT";
            this.panelLEFT.Size = new System.Drawing.Size(200, 719);
            this.panelLEFT.TabIndex = 1;
            // 
            // homepageButton
            // 
            this.homepageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.Image = ((System.Drawing.Image)(resources.GetObject("homepageButton.Image")));
            this.homepageButton.Location = new System.Drawing.Point(49, 592);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(93, 91);
            this.homepageButton.TabIndex = 7;
            this.homepageButton.TabStop = false;
            this.homepageButton.UseVisualStyleBackColor = true;
            this.homepageButton.Click += new System.EventHandler(this.homepageButton_Click);
            // 
            // cpyrtLabel
            // 
            this.cpyrtLabel.AutoSize = true;
            this.cpyrtLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpyrtLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cpyrtLabel.Location = new System.Drawing.Point(100, 704);
            this.cpyrtLabel.Name = "cpyrtLabel";
            this.cpyrtLabel.Size = new System.Drawing.Size(87, 15);
            this.cpyrtLabel.TabIndex = 6;
            this.cpyrtLabel.Text = "Copyright 2018";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.ForeColor = System.Drawing.Color.DimGray;
            this.companyLabel.Location = new System.Drawing.Point(3, 704);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(91, 15);
            this.companyLabel.TabIndex = 5;
            this.companyLabel.Text = "Smart Password";
            // 
            // removePassButton
            // 
            this.removePassButton.BackColor = System.Drawing.Color.Transparent;
            this.removePassButton.FlatAppearance.BorderSize = 0;
            this.removePassButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removePassButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.removePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removePassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.removePassButton.Image = ((System.Drawing.Image)(resources.GetObject("removePassButton.Image")));
            this.removePassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removePassButton.Location = new System.Drawing.Point(0, 461);
            this.removePassButton.Name = "removePassButton";
            this.removePassButton.Size = new System.Drawing.Size(200, 106);
            this.removePassButton.TabIndex = 4;
            this.removePassButton.TabStop = false;
            this.removePassButton.Text = " Remove Password";
            this.removePassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removePassButton.UseVisualStyleBackColor = false;
            this.removePassButton.Click += new System.EventHandler(this.removePassButton_Click);
            this.removePassButton.MouseHover += new System.EventHandler(this.removePassButton_MouseHover);
            // 
            // addPassButton
            // 
            this.addPassButton.BackColor = System.Drawing.Color.Transparent;
            this.addPassButton.FlatAppearance.BorderSize = 0;
            this.addPassButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPassButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPassButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addPassButton.Image = ((System.Drawing.Image)(resources.GetObject("addPassButton.Image")));
            this.addPassButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPassButton.Location = new System.Drawing.Point(0, 349);
            this.addPassButton.Name = "addPassButton";
            this.addPassButton.Size = new System.Drawing.Size(200, 106);
            this.addPassButton.TabIndex = 3;
            this.addPassButton.TabStop = false;
            this.addPassButton.Text = "       Add New Password";
            this.addPassButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPassButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addPassButton.UseVisualStyleBackColor = false;
            this.addPassButton.Click += new System.EventHandler(this.addPassButton_Click);
            this.addPassButton.MouseHover += new System.EventHandler(this.addPassButton_MouseHover);
            // 
            // checkStrengthButton
            // 
            this.checkStrengthButton.BackColor = System.Drawing.Color.Transparent;
            this.checkStrengthButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkStrengthButton.FlatAppearance.BorderSize = 0;
            this.checkStrengthButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkStrengthButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkStrengthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStrengthButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkStrengthButton.ForeColor = System.Drawing.Color.Transparent;
            this.checkStrengthButton.Image = ((System.Drawing.Image)(resources.GetObject("checkStrengthButton.Image")));
            this.checkStrengthButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkStrengthButton.Location = new System.Drawing.Point(0, 237);
            this.checkStrengthButton.Name = "checkStrengthButton";
            this.checkStrengthButton.Size = new System.Drawing.Size(200, 106);
            this.checkStrengthButton.TabIndex = 2;
            this.checkStrengthButton.TabStop = false;
            this.checkStrengthButton.Text = "Check Password Strength";
            this.checkStrengthButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkStrengthButton.UseVisualStyleBackColor = false;
            this.checkStrengthButton.MouseHover += new System.EventHandler(this.checkStrengthButton_MouseHover);
            // 
            // currentPasswords
            // 
            this.currentPasswords.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswords.FlatAppearance.BorderSize = 0;
            this.currentPasswords.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.currentPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentPasswords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswords.ForeColor = System.Drawing.Color.White;
            this.currentPasswords.Image = ((System.Drawing.Image)(resources.GetObject("currentPasswords.Image")));
            this.currentPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentPasswords.Location = new System.Drawing.Point(0, 125);
            this.currentPasswords.Name = "currentPasswords";
            this.currentPasswords.Size = new System.Drawing.Size(200, 106);
            this.currentPasswords.TabIndex = 1;
            this.currentPasswords.TabStop = false;
            this.currentPasswords.Text = "Current Passwords";
            this.currentPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.currentPasswords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.currentPasswords.UseVisualStyleBackColor = false;
            this.currentPasswords.Click += new System.EventHandler(this.currentPasswords_Click);
            this.currentPasswords.MouseHover += new System.EventHandler(this.currentPasswords_MouseHover);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 100);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Click += new System.EventHandler(this.logoPanel_Click);
            // 
            // panelCurrPass
            // 
            this.panelCurrPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelCurrPass.Location = new System.Drawing.Point(199, 125);
            this.panelCurrPass.Name = "panelCurrPass";
            this.panelCurrPass.Size = new System.Drawing.Size(7, 106);
            this.panelCurrPass.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(294, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(824, 45);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Think you have a good password? Test and find out!";
            // 
            // pswLabel
            // 
            this.pswLabel.AutoSize = true;
            this.pswLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.pswLabel.Location = new System.Drawing.Point(479, 215);
            this.pswLabel.Name = "pswLabel";
            this.pswLabel.Size = new System.Drawing.Size(166, 32);
            this.pswLabel.TabIndex = 4;
            this.pswLabel.Text = "Your Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(442, 264);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(235, 29);
            this.passwordTextBox.TabIndex = 0;
            // 
            // strengthTitle
            // 
            this.strengthTitle.AutoSize = true;
            this.strengthTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.strengthTitle.Location = new System.Drawing.Point(508, 461);
            this.strengthTitle.Name = "strengthTitle";
            this.strengthTitle.Size = new System.Drawing.Size(106, 32);
            this.strengthTitle.TabIndex = 6;
            this.strengthTitle.Text = "Strength";
            // 
            // tipsLabel
            // 
            this.tipsLabel.AutoSize = true;
            this.tipsLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.tipsLabel.Location = new System.Drawing.Point(788, 273);
            this.tipsLabel.Name = "tipsLabel";
            this.tipsLabel.Size = new System.Drawing.Size(281, 196);
            this.tipsLabel.TabIndex = 9;
            this.tipsLabel.Text = "-Minimum size of 8\r\n-At least two special characters\r\n-At least two numbers\r\n-At " +
    "least two upper case letters\r\n-At least two lower case letters\r\n-No complete wor" +
    "ds\r\n\r\n";
            // 
            // tipsTitle
            // 
            this.tipsTitle.AutoSize = true;
            this.tipsTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tipsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tipsTitle.Location = new System.Drawing.Point(787, 227);
            this.tipsTitle.Name = "tipsTitle";
            this.tipsTitle.Size = new System.Drawing.Size(278, 32);
            this.tipsTitle.TabIndex = 10;
            this.tipsTitle.Text = "Tips For Good Passwords";
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Location = new System.Drawing.Point(506, 320);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(108, 47);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Test!";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.strengthLabel.Location = new System.Drawing.Point(539, 504);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(0, 21);
            this.strengthLabel.TabIndex = 12;
            // 
            // CheckStrengthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 719);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.tipsTitle);
            this.Controls.Add(this.tipsLabel);
            this.Controls.Add(this.strengthTitle);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.pswLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.panelCurrPass);
            this.Controls.Add(this.panelLEFT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1188, 752);
            this.MinimumSize = new System.Drawing.Size(1188, 752);
            this.Name = "CheckStrengthForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1188, 752);
            this.Text = "Smarter Password";
            this.ThemeName = "FluentDark";
            this.panelLEFT.ResumeLayout(false);
            this.panelLEFT.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel panelLEFT;
        private System.Windows.Forms.Button currentPasswords;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Button removePassButton;
        private System.Windows.Forms.Button addPassButton;
        private System.Windows.Forms.Button checkStrengthButton;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label cpyrtLabel;
        private System.Windows.Forms.Panel panelCurrPass;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label pswLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label strengthTitle;
        private System.Windows.Forms.Label tipsLabel;
        private System.Windows.Forms.Label tipsTitle;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label strengthLabel;
    }
}
