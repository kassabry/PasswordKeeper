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
    public partial class RemovePasswordForm : Telerik.WinControls.UI.RadForm
    {
        Methods methods = new Methods();
        public RemovePasswordForm()
        {
            InitializeComponent();
            BindListBox();
        }

        private void BindListBox()
        {
            passwordBox.DataSource = methods.passwordList;
            passwordBox.DisplayMember = "displayName";
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

        private void addPassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPasswordForm apf = new AddPasswordForm();
            apf.ShowDialog();
        }

        private void checkStrengthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckStrengthForm csf = new CheckStrengthForm();
            csf.ShowDialog();
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

        private void passwordBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(passwordBox.SelectedIndex > -1)
            {
                nameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getWebName();
                usernameTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getUserName();
                passwordTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getPassword();
                descriptionTextBox.Text = methods.passwordList[passwordBox.SelectedIndex].getNotes();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (methods.passwordList.Count == 1)
            {
                passwordBox.SelectedIndex = 0;
                passwordBox_SelectedIndexChanged(sender, e);
                passwordBox.Update();
            }

            Password tempPassword = methods.passwordList[passwordBox.SelectedIndex];

            methods.passwordList.Remove(tempPassword);

            string fileName = "PasswordData.txt"; // Fill in whatever we are storing the data in here

            if (File.Exists(fileName))
            {
                string tempFile = Path.GetTempFileName();
                StreamWriter tempWriter = new StreamWriter(tempFile);
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] tempArr = line.Split('|');

                        string webName = tempArr[0];
                        string userName = tempArr[1];
                        string password = methods.decrypt(tempArr[2], methods.getPassPhrase());
                        string notes = tempArr[3];

                        if (!tempPassword.getWebName().Equals(webName))
                        {
                            tempWriter.WriteLine(line);

                            break;
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                }

                tempWriter.Close();

                File.Delete(fileName);
                File.Move(tempFile, fileName);



                
            }

            nameTextBox.Text = "";
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void chromeButton_Click(object sender, EventArgs e)
        {

            for(int i  = 0; i < passwordBox.Items.Count; i++)
            {
                if(methods.passwordList[i].getWebName().Equals("Google Chrome"))
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
