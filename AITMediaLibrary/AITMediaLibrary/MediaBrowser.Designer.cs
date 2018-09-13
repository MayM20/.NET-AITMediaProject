namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            this.userLabel = new System.Windows.Forms.Label();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.PublishYearLabel = new System.Windows.Forms.Label();
            this.publishYearTextBox = new System.Windows.Forms.TextBox();
            this.yearSearchButton = new System.Windows.Forms.Button();
            this.listAllButton = new System.Windows.Forms.Button();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.GenreNameLabel = new System.Windows.Forms.Label();
            this.genreNameTextBox = new System.Windows.Forms.TextBox();
            this.BudgetLabel = new System.Windows.Forms.Label();
            this.genreNameButton = new System.Windows.Forms.Button();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.budgetButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleSearchButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.reserveGridView = new System.Windows.Forms.DataGridView();
            this.deleteReserveButton = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.borrowGridView = new System.Windows.Forms.DataGridView();
            this.borrowMediaComboBox = new System.Windows.Forms.ComboBox();
            this.borrowMediaLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(13, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(35, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User: ";
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(16, 42);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(638, 231);
            this.mediaGridView.TabIndex = 1;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellClick);
            // 
            // PublishYearLabel
            // 
            this.PublishYearLabel.AutoSize = true;
            this.PublishYearLabel.Location = new System.Drawing.Point(12, 300);
            this.PublishYearLabel.Name = "PublishYearLabel";
            this.PublishYearLabel.Size = new System.Drawing.Size(69, 13);
            this.PublishYearLabel.TabIndex = 2;
            this.PublishYearLabel.Text = "Publish Year:";
            // 
            // publishYearTextBox
            // 
            this.publishYearTextBox.Location = new System.Drawing.Point(88, 297);
            this.publishYearTextBox.Name = "publishYearTextBox";
            this.publishYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.publishYearTextBox.TabIndex = 3;
            // 
            // yearSearchButton
            // 
            this.yearSearchButton.Location = new System.Drawing.Point(203, 297);
            this.yearSearchButton.Name = "yearSearchButton";
            this.yearSearchButton.Size = new System.Drawing.Size(126, 23);
            this.yearSearchButton.TabIndex = 4;
            this.yearSearchButton.Text = "Search";
            this.yearSearchButton.UseVisualStyleBackColor = true;
            this.yearSearchButton.Click += new System.EventHandler(this.yearSearchButton_Click);
            // 
            // listAllButton
            // 
            this.listAllButton.Location = new System.Drawing.Point(675, 42);
            this.listAllButton.Name = "listAllButton";
            this.listAllButton.Size = new System.Drawing.Size(120, 23);
            this.listAllButton.TabIndex = 5;
            this.listAllButton.Text = "List All Media";
            this.listAllButton.UseVisualStyleBackColor = true;
            this.listAllButton.Click += new System.EventHandler(this.listAllButton_Click);
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(682, 84);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 6;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // GenreNameLabel
            // 
            this.GenreNameLabel.AutoSize = true;
            this.GenreNameLabel.Location = new System.Drawing.Point(12, 339);
            this.GenreNameLabel.Name = "GenreNameLabel";
            this.GenreNameLabel.Size = new System.Drawing.Size(70, 13);
            this.GenreNameLabel.TabIndex = 7;
            this.GenreNameLabel.Text = "Genre Name:";
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.Location = new System.Drawing.Point(88, 339);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.genreNameTextBox.TabIndex = 8;
            // 
            // BudgetLabel
            // 
            this.BudgetLabel.AutoSize = true;
            this.BudgetLabel.Location = new System.Drawing.Point(354, 303);
            this.BudgetLabel.Name = "BudgetLabel";
            this.BudgetLabel.Size = new System.Drawing.Size(44, 13);
            this.BudgetLabel.TabIndex = 9;
            this.BudgetLabel.Text = "Budget:";
            // 
            // genreNameButton
            // 
            this.genreNameButton.Location = new System.Drawing.Point(203, 337);
            this.genreNameButton.Name = "genreNameButton";
            this.genreNameButton.Size = new System.Drawing.Size(126, 23);
            this.genreNameButton.TabIndex = 10;
            this.genreNameButton.Text = "Search";
            this.genreNameButton.UseVisualStyleBackColor = true;
            this.genreNameButton.Click += new System.EventHandler(this.genreNameButton_Click);
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(413, 300);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.budgetTextBox.TabIndex = 11;
            // 
            // budgetButton
            // 
            this.budgetButton.Location = new System.Drawing.Point(528, 300);
            this.budgetButton.Name = "budgetButton";
            this.budgetButton.Size = new System.Drawing.Size(126, 23);
            this.budgetButton.TabIndex = 12;
            this.budgetButton.Text = "Search";
            this.budgetButton.UseVisualStyleBackColor = true;
            this.budgetButton.Click += new System.EventHandler(this.budgetButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(354, 339);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(413, 334);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 14;
            // 
            // titleSearchButton
            // 
            this.titleSearchButton.Location = new System.Drawing.Point(528, 334);
            this.titleSearchButton.Name = "titleSearchButton";
            this.titleSearchButton.Size = new System.Drawing.Size(126, 23);
            this.titleSearchButton.TabIndex = 15;
            this.titleSearchButton.Text = "Search";
            this.titleSearchButton.UseVisualStyleBackColor = true;
            this.titleSearchButton.Click += new System.EventHandler(this.titleSearchButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.Location = new System.Drawing.Point(212, 407);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(117, 43);
            this.reserveButton.TabIndex = 16;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = true;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // reserveGridView
            // 
            this.reserveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserveGridView.Location = new System.Drawing.Point(841, 42);
            this.reserveGridView.Name = "reserveGridView";
            this.reserveGridView.Size = new System.Drawing.Size(340, 184);
            this.reserveGridView.TabIndex = 17;
            this.reserveGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reserveGridView_CellClick);
            // 
            // deleteReserveButton
            // 
            this.deleteReserveButton.Location = new System.Drawing.Point(841, 250);
            this.deleteReserveButton.Name = "deleteReserveButton";
            this.deleteReserveButton.Size = new System.Drawing.Size(340, 23);
            this.deleteReserveButton.TabIndex = 18;
            this.deleteReserveButton.Text = "Delete Reservation";
            this.deleteReserveButton.UseVisualStyleBackColor = true;
            this.deleteReserveButton.Click += new System.EventHandler(this.deleteReserveButton_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(20, 489);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 23);
            this.logout.TabIndex = 19;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Location = new System.Drawing.Point(381, 407);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(117, 44);
            this.borrowButton.TabIndex = 20;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // borrowGridView
            // 
            this.borrowGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowGridView.Location = new System.Drawing.Point(841, 300);
            this.borrowGridView.Name = "borrowGridView";
            this.borrowGridView.Size = new System.Drawing.Size(348, 193);
            this.borrowGridView.TabIndex = 21;
            this.borrowGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowGridView_CellClick);
            // 
            // borrowMediaComboBox
            // 
            this.borrowMediaComboBox.FormattingEnabled = true;
            this.borrowMediaComboBox.Location = new System.Drawing.Point(685, 379);
            this.borrowMediaComboBox.Name = "borrowMediaComboBox";
            this.borrowMediaComboBox.Size = new System.Drawing.Size(121, 21);
            this.borrowMediaComboBox.TabIndex = 22;
            // 
            // borrowMediaLabel
            // 
            this.borrowMediaLabel.AutoSize = true;
            this.borrowMediaLabel.Location = new System.Drawing.Point(584, 382);
            this.borrowMediaLabel.Name = "borrowMediaLabel";
            this.borrowMediaLabel.Size = new System.Drawing.Size(86, 13);
            this.borrowMediaLabel.TabIndex = 23;
            this.borrowMediaLabel.Text = "Borrowed media:";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(577, 441);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(121, 37);
            this.returnButton.TabIndex = 24;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 570);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.borrowMediaLabel);
            this.Controls.Add(this.borrowMediaComboBox);
            this.Controls.Add(this.borrowGridView);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.deleteReserveButton);
            this.Controls.Add(this.reserveGridView);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.titleSearchButton);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.budgetButton);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.genreNameButton);
            this.Controls.Add(this.BudgetLabel);
            this.Controls.Add(this.genreNameTextBox);
            this.Controls.Add(this.GenreNameLabel);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.listAllButton);
            this.Controls.Add(this.yearSearchButton);
            this.Controls.Add(this.publishYearTextBox);
            this.Controls.Add(this.PublishYearLabel);
            this.Controls.Add(this.mediaGridView);
            this.Controls.Add(this.userLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MediaBrowser";
            this.Text = "MediaBrowser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.Label PublishYearLabel;
        private System.Windows.Forms.TextBox publishYearTextBox;
        private System.Windows.Forms.Button yearSearchButton;
        private System.Windows.Forms.Button listAllButton;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Label GenreNameLabel;
        private System.Windows.Forms.TextBox genreNameTextBox;
        private System.Windows.Forms.Label BudgetLabel;
        private System.Windows.Forms.Button genreNameButton;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Button budgetButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button titleSearchButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.DataGridView reserveGridView;
        private System.Windows.Forms.Button deleteReserveButton;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.DataGridView borrowGridView;
        private System.Windows.Forms.ComboBox borrowMediaComboBox;
        private System.Windows.Forms.Label borrowMediaLabel;
        private System.Windows.Forms.Button returnButton;
    }
}