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
    public partial class CurrentPasswordForm : Telerik.WinControls.UI.RadForm
    {
        Methods methods = new Methods();
        public CurrentPasswordForm()
        {
            InitializeComponent();
            BindListBox();
        }

        private void BindListBox()
        {
            passwordBox.DataSource = methods.passwordList;
            passwordBox.DisplayMember = "displayName";
        }

        private void currentPasswords_MouseHover(object sender, EventArgs e)
        {
            //Sets yellow bar to left of current button
            panelCurrPass.Height = currentPasswords.Height;
            panelCurrPass.Top = currentPasswords.Top;
        }

        private void genNewPassButton_MouseHover(object sender, EventArgs e)
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

        private void currentPasswords_Click(object sender, EventArgs e)
        {
            
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.Show();
        }

        private void homepageButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RadForm1 rf = new RadForm1();
            rf.Show();
        }

        private void addPassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPasswordForm apf = new AddPasswordForm();
            apf.ShowDialog();
        }

        private void removePassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemovePasswordForm rpf = new RemovePasswordForm();
            rpf.ShowDialog();
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

        private void passwordBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (passwordBox.SelectedIndex > -1)
            {
                nameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getWebName();
                usernameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getUserName();
                passwordTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getPassword();
                descriptionTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getNotes();
            }
        }

        private void chromeButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Google Chrome"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void gmailButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Gmail"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }

        }

        private void googleDriveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Google Drive"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void yahooButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Yahoo"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void outlookButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Outlook"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }

        }

        private void amazonButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Amazon"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }

        }

        private void facebookButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Facebook"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void instagramButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Instagram"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void snapchatButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Snapchat"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }

        private void twitchButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < passwordBox.Items.Count; i++)
            {
                if (methods.passwordList[i].getWebName().Equals("Twitch"))
                {
                    passwordBox.SelectedIndex = i;
                }
            }
        }
    }
}

