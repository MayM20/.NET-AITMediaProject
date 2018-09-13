namespace AITMediaLibrary
{
    partial class AdminForm
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
            this.listOfUsersLabel = new System.Windows.Forms.Label();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.selectedUserLabel = new System.Windows.Forms.Label();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.deleteSelectedUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.userLevelComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.openEditorButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfUsersLabel
            // 
            this.listOfUsersLabel.AutoSize = true;
            this.listOfUsersLabel.Location = new System.Drawing.Point(13, 13);
            this.listOfUsersLabel.Name = "listOfUsersLabel";
            this.listOfUsersLabel.Size = new System.Drawing.Size(65, 13);
            this.listOfUsersLabel.TabIndex = 0;
            this.listOfUsersLabel.Text = "List of Users";
            // 
            // userGridView
            // 
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(16, 43);
            this.userGridView.Name = "userGridView";
            this.userGridView.Size = new System.Drawing.Size(240, 372);
            this.userGridView.TabIndex = 1;
            this.userGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellClick);
            // 
            // selectedUserLabel
            // 
            this.selectedUserLabel.AutoSize = true;
            this.selectedUserLabel.Location = new System.Drawing.Point(289, 43);
            this.selectedUserLabel.Name = "selectedUserLabel";
            this.selectedUserLabel.Size = new System.Drawing.Size(72, 13);
            this.selectedUserLabel.TabIndex = 2;
            this.selectedUserLabel.Text = "selectedUser:";
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(292, 76);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(78, 13);
            this.newPasswordLabel.TabIndex = 3;
            this.newPasswordLabel.Text = "New Password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.Location = new System.Drawing.Point(377, 76);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(157, 20);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.Location = new System.Drawing.Point(292, 111);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(242, 23);
            this.updatePasswordButton.TabIndex = 5;
            this.updatePasswordButton.Text = "Update Password";
            this.updatePasswordButton.UseVisualStyleBackColor = true;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // deleteSelectedUserButton
            // 
            this.deleteSelectedUserButton.Location = new System.Drawing.Point(292, 161);
            this.deleteSelectedUserButton.Name = "deleteSelectedUserButton";
            this.deleteSelectedUserButton.Size = new System.Drawing.Size(242, 23);
            this.deleteSelectedUserButton.TabIndex = 6;
            this.deleteSelectedUserButton.Text = "Deleted Selected User";
            this.deleteSelectedUserButton.UseVisualStyleBackColor = true;
            this.deleteSelectedUserButton.Click += new System.EventHandler(this.deleteSelectedUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "UserLevel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(377, 215);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(134, 20);
            this.usernameTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(377, 253);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(134, 20);
            this.passwordTextBox.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(377, 322);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(134, 20);
            this.emailTextBox.TabIndex = 13;
            // 
            // userLevelComboBox
            // 
            this.userLevelComboBox.FormattingEnabled = true;
            this.userLevelComboBox.Location = new System.Drawing.Point(377, 287);
            this.userLevelComboBox.Name = "userLevelComboBox";
            this.userLevelComboBox.Size = new System.Drawing.Size(134, 21);
            this.userLevelComboBox.TabIndex = 14;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(16, 444);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(292, 390);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(242, 23);
            this.addUserButton.TabIndex = 16;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // openEditorButton
            // 
            this.openEditorButton.Location = new System.Drawing.Point(16, 499);
            this.openEditorButton.Name = "openEditorButton";
            this.openEditorButton.Size = new System.Drawing.Size(116, 25);
            this.openEditorButton.TabIndex = 43;
            this.openEditorButton.Text = "Open Media Editor";
            this.openEditorButton.UseVisualStyleBackColor = true;
            this.openEditorButton.Click += new System.EventHandler(this.openEditorButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(458, 500);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 44;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 557);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.openEditorButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.userLevelComboBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteSelectedUserButton);
            this.Controls.Add(this.updatePasswordButton);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.selectedUserLabel);
            this.Controls.Add(this.userGridView);
            this.Controls.Add(this.listOfUsersLabel);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listOfUsersLabel;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Label selectedUserLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.Button deleteSelectedUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox userLevelComboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button openEditorButton;
        private System.Windows.Forms.Button logoutButton;
    }
}