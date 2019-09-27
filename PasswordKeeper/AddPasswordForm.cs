using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.IO;

namespace PasswordKeeper
{
    public partial class AddPasswordForm : Telerik.WinControls.UI.RadForm
    {
        Methods variable = new Methods();
       // BindingList<Password> passwordList;
        
        public AddPasswordForm()
        {
            InitializeComponent();
            //passwordList = variable.getPasswordList();

        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.ShowDialog();
        }

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            this.Hide();
            CurrentPasswordForm cpf = new CurrentPasswordForm();
            cpf.ShowDialog();
        }

        private void savePassword_Click(object sender, EventArgs e)
        {
           // Methods methods = new Methods();
            string name = nameTextBox.Text;
            string user = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string notes = descriptionTextBox.Text;

            Password newPassword = new Password(name, user, password, notes);
            variable.passwordList.Add(newPassword);

            // Fill in List from stored file
            string fileName = "PasswordData.txt"; // The file of where we writing the data to
            StreamWriter writer = new StreamWriter(fileName, true);

            string tempLine = name + '|' + user + '|' + variable.encrypt(password, variable.getPassPhrase()) + '|' + notes;

            writer.WriteLine(tempLine);

            writer.Close();
            writer.Dispose();

            nameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            //Methods methods = new Methods();
            string random = variable.genNewPassword();

            passwordTextBox.Text = random;
        }

        private void removePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemovePasswordForm rpf = new RemovePasswordForm();
            rpf.ShowDialog();
        }

        private void currentPasswords_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = currentPasswords.Height;
            panelCurrPass.Top = currentPasswords.Top;
        }

        private void checkStrengthButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = checkStrengthButton.Height;
            panelCurrPass.Top = checkStrengthButton.Top;
        }

        private void addPassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = addPassButton.Height;
            panelCurrPass.Top = addPassButton.Top;
        }

        private void removePassButton_MouseHover(object sender, EventArgs e)
        {
            panelCurrPass.Height = removePassButton.Height;
            panelCurrPass.Top = removePassButton.Top;
        }

        private void checkStrengthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckStrengthForm csf = new CheckStrengthForm();
            csf.ShowDialog();
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.ShowDialog();
        }

        private void logoPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.ShowDialog();
        }

        private void AddPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void chromeButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Google Chrome";
        }

        private void gmailButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Gmail";
        }

        private void googleDriveButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Google Drive";
        }

        private void yahooButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Yahoo";
        }

        private void outlookButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Outlook";
        }

        private void amazonButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Amazon";
        }

        private void facebookButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Facebook";
        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Instagram";
        }

        private void snapchatButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Snapchat";
        }

        private void twitchButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Twitch";
        }
    }
}
