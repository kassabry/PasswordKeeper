namespace PasswordKeeper
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.allBackground = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descBorder1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numPSWDESC = new System.Windows.Forms.Label();
            this.numPSW = new System.Windows.Forms.Label();
            this.weakBackground = new System.Windows.Forms.Label();
            this.unsafeLabel = new System.Windows.Forms.Label();
            this.numUnsafePSW = new System.Windows.Forms.Label();
            this.reusedBackground = new System.Windows.Forms.Label();
            this.reuseLabel = new System.Windows.Forms.Label();
            this.numReusedPSW = new System.Windows.Forms.Label();
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
            this.homepageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homepageButton.BackgroundImage")));
            this.homepageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homepageButton.FlatAppearance.BorderSize = 0;
            this.homepageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageButton.Location = new System.Drawing.Point(49, 592);
            this.homepageButton.Name = "homepageButton";
            this.homepageButton.Size = new System.Drawing.Size(93, 91);
            this.homepageButton.TabIndex = 7;
            this.homepageButton.TabStop = false;
            this.homepageButton.UseVisualStyleBackColor = true;
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
            this.checkStrengthButton.Click += new System.EventHandler(this.genNewPassButton_Click);
            this.checkStrengthButton.MouseHover += new System.EventHandler(this.genNewPassButton_MouseHover);
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
            // 
            // panelCurrPass
            // 
            this.panelCurrPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelCurrPass.Location = new System.Drawing.Point(199, 125);
            this.panelCurrPass.Name = "panelCurrPass";
            this.panelCurrPass.Size = new System.Drawing.Size(7, 106);
            this.panelCurrPass.TabIndex = 2;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Sitka Heading", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(355, 26);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(640, 69);
            this.welcomeLabel.TabIndex = 3;
            this.welcomeLabel.Text = "Welcome to Smarter Password";
            // 
            // allBackground
            // 
            this.allBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.allBackground.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.allBackground.Location = new System.Drawing.Point(524, 195);
            this.allBackground.Name = "allBackground";
            this.allBackground.Size = new System.Drawing.Size(257, 75);
            this.allBackground.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.descriptionLabel.Location = new System.Drawing.Point(284, 618);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(868, 90);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // descBorder1
            // 
            this.descBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.descBorder1.Location = new System.Drawing.Point(199, 603);
            this.descBorder1.Name = "descBorder1";
            this.descBorder1.Size = new System.Drawing.Size(982, 12);
            this.descBorder1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(199, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 112);
            this.panel1.TabIndex = 10;
            // 
            // numPSWDESC
            // 
            this.numPSWDESC.AutoSize = true;
            this.numPSWDESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numPSWDESC.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPSWDESC.ForeColor = System.Drawing.Color.Black;
            this.numPSWDESC.Location = new System.Drawing.Point(597, 205);
            this.numPSWDESC.Name = "numPSWDESC";
            this.numPSWDESC.Size = new System.Drawing.Size(116, 22);
            this.numPSWDESC.TabIndex = 11;
            this.numPSWDESC.Text = "All Passwords";
            this.numPSWDESC.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numPSW
            // 
            this.numPSW.AutoSize = true;
            this.numPSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numPSW.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPSW.ForeColor = System.Drawing.Color.Black;
            this.numPSW.Location = new System.Drawing.Point(635, 227);
            this.numPSW.Name = "numPSW";
            this.numPSW.Size = new System.Drawing.Size(25, 30);
            this.numPSW.TabIndex = 12;
            this.numPSW.Text = "0";
            // 
            // weakBackground
            // 
            this.weakBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.weakBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.weakBackground.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.weakBackground.Location = new System.Drawing.Point(524, 461);
            this.weakBackground.Name = "weakBackground";
            this.weakBackground.Size = new System.Drawing.Size(257, 77);
            this.weakBackground.TabIndex = 13;
            // 
            // unsafeLabel
            // 
            this.unsafeLabel.AutoSize = true;
            this.unsafeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.unsafeLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsafeLabel.ForeColor = System.Drawing.Color.Black;
            this.unsafeLabel.Location = new System.Drawing.Point(588, 471);
            this.unsafeLabel.Name = "unsafeLabel";
            this.unsafeLabel.Size = new System.Drawing.Size(143, 22);
            this.unsafeLabel.TabIndex = 14;
            this.unsafeLabel.Text = "Unsafe Passwords";
            this.unsafeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numUnsafePSW
            // 
            this.numUnsafePSW.AutoSize = true;
            this.numUnsafePSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numUnsafePSW.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUnsafePSW.ForeColor = System.Drawing.Color.Black;
            this.numUnsafePSW.Location = new System.Drawing.Point(635, 497);
            this.numUnsafePSW.Name = "numUnsafePSW";
            this.numUnsafePSW.Size = new System.Drawing.Size(25, 30);
            this.numUnsafePSW.TabIndex = 15;
            this.numUnsafePSW.Text = "0";
            // 
            // reusedBackground
            // 
            this.reusedBackground.BackColor = System.Drawing.Color.SeaGreen;
            this.reusedBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reusedBackground.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.reusedBackground.Location = new System.Drawing.Point(524, 336);
            this.reusedBackground.Name = "reusedBackground";
            this.reusedBackground.Size = new System.Drawing.Size(257, 75);
            this.reusedBackground.TabIndex = 16;
            // 
            // reuseLabel
            // 
            this.reuseLabel.AutoSize = true;
            this.reuseLabel.BackColor = System.Drawing.Color.SeaGreen;
            this.reuseLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reuseLabel.ForeColor = System.Drawing.Color.Black;
            this.reuseLabel.Location = new System.Drawing.Point(587, 346);
            this.reuseLabel.Name = "reuseLabel";
            this.reuseLabel.Size = new System.Drawing.Size(144, 22);
            this.reuseLabel.TabIndex = 17;
            this.reuseLabel.Text = "Reused Passwords";
            this.reuseLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // numReusedPSW
            // 
            this.numReusedPSW.AutoSize = true;
            this.numReusedPSW.BackColor = System.Drawing.Color.SeaGreen;
            this.numReusedPSW.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numReusedPSW.ForeColor = System.Drawing.Color.Black;
            this.numReusedPSW.Location = new System.Drawing.Point(635, 368);
            this.numReusedPSW.Name = "numReusedPSW";
            this.numReusedPSW.Size = new System.Drawing.Size(25, 30);
            this.numReusedPSW.TabIndex = 18;
            this.numReusedPSW.Text = "0";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 719);
            this.Controls.Add(this.numReusedPSW);
            this.Controls.Add(this.reuseLabel);
            this.Controls.Add(this.reusedBackground);
            this.Controls.Add(this.numUnsafePSW);
            this.Controls.Add(this.unsafeLabel);
            this.Controls.Add(this.weakBackground);
            this.Controls.Add(this.numPSW);
            this.Controls.Add(this.numPSWDESC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descBorder1);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.allBackground);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.panelCurrPass);
            this.Controls.Add(this.panelLEFT);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1188, 752);
            this.MinimumSize = new System.Drawing.Size(1188, 752);
            this.Name = "RadForm1";
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
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label allBackground;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel descBorder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button homepageButton;
        private System.Windows.Forms.Label numPSWDESC;
        private System.Windows.Forms.Label numPSW;
        private System.Windows.Forms.Label weakBackground;
        private System.Windows.Forms.Label unsafeLabel;
        private System.Windows.Forms.Label numUnsafePSW;
        private System.Windows.Forms.Label reusedBackground;
        private System.Windows.Forms.Label reuseLabel;
        private System.Windows.Forms.Label numReusedPSW;
    }
}