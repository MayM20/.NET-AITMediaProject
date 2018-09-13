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
    public partial class AdminForm : Form
    {

        private UserLogic userLogic = new UserLogic();
        private MediaLogic mediaLogic = new MediaLogic();

        private UserModel selectedUser = null; 

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            userLevelComboBox.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));


        }

        private void RefreshUserList()
        {
            userGridView.DataSource = userLogic.GetListOfUsers(); 
        
        }


        private void userGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)//-1 is the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of user models
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;

                selectedUser = users.ElementAt<UserModel>(row);//get from this position

            
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            //TODO for assignment: make sure password matches basic criteria
            if (selectedUser != null) 
            {
                int rowsAffected = userLogic.UpdatePassword(newPasswordTextBox.Text, selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show(selectedUser.UserName + " password updated!");

                }
                else
                {
                    //didn;t
                
                }
                RefreshUserList(); 
            
            }
        }

        private void deleteSelectedUserButton_Click(object sender, EventArgs e)
        {
            if (selectedUser != null) 
            {
                int affectedRows = userLogic.DeleteUserByUserID(selectedUser.UserID, CurrentUser.UserLevel);
                //if affeectedRows > 0, deleted some peoples, else didnt

                selectedUser = null;

                RefreshUserList();
            
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //get enum back out of datasource of combo box............
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelComboBox.Text);

            int affectedRows = userLogic.AddNewUser(usernameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);
            //if affectedRows > 0, success!

            RefreshUserList();
        }

        //GO TO MEDIA EDITOR
        private void openEditorButton_Click(object sender, EventArgs e)
        {

            MediaLogic mediaLogic = new MediaLogic();

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenMediaEditor));
            t.Start();
            this.Close();


        }

        public static void OpenMediaEditor()
        {
            Application.Run(new MediaEditor());
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            CurrentUser.UserName = " ";
            CurrentUser.UserLevel = 0;
            CurrentUser.UserID = 0;

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLogin));
            t.Start();
            Close();

        }

        private void OpenLogin() 
        {
            Application.Run(new Form1());
 
        }

       
       

      
    }
}
