using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Logic;

namespace AITMediaLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        private void login() {
            UserLogic userLogic = new UserLogic();

            List<UserModel> users = userLogic.GetListOfUsersByUserNameAndPassword(usernameTextBox.Text, passwordTextBox.Text);

            //if got some users
            if (users.Count > 0)
            {
                CurrentUser.UserName = users[0].UserName;
                CurrentUser.UserLevel = users[0].UserLevel;
                CurrentUser.UserID = users[0].UserID;

                //we only care about the first user in the list
                if (users[0].UserLevel == 3)
                {
                    //go to admin page/form
                    //admin logins:
                    //lenny 1234
                    //julio 1
                    //Matt matt
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminForm));

                    t.Start();
                }
                else
                {
                    //go to student/normal form
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaForm));

                    t.Start();
                }
                //kill this form
                this.Close();
            }
            else
            {
                //ERROR, no match
                errorLabel.Text = "Error: no user matching this username and password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        public static void OpenMediaForm()
        {
            Application.Run(new MediaBrowser());
        }

        public static void OpenAdminForm() 
        {
            Application.Run(new AdminForm());
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            login(); 
        }
    }
}
