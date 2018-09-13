namespace AITMediaLibrary
{
    partial class MediaEditor
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
            this.genreGridView = new System.Windows.Forms.DataGridView();
            this.addMediaButton = new System.Windows.Forms.Button();
            this.deleteMediaButton = new System.Windows.Forms.Button();
            this.updateMediaButton = new System.Windows.Forms.Button();
            this.refreshButtonMedia = new System.Windows.Forms.Button();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.budgetTextBox = new System.Windows.Forms.TextBox();
            this.labelMediaTitle = new System.Windows.Forms.Label();
            this.selectedMediaLabel = new System.Windows.Forms.Label();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.mediaGridView = new System.Windows.Forms.DataGridView();
            this.newGenreTextBox = new System.Windows.Forms.TextBox();
            this.newGenreLabel = new System.Windows.Forms.Label();
            this.directorComboBox = new System.Windows.Forms.ComboBox();
            this.directorGridView = new System.Windows.Forms.DataGridView();
            this.newLanguageLabel = new System.Windows.Forms.Label();
            this.newLanguageTextBox = new System.Windows.Forms.TextBox();
            this.languageGridView = new System.Windows.Forms.DataGridView();
            this.newDirectorLabel = new System.Windows.Forms.Label();
            this.newDirectorTextBox = new System.Windows.Forms.TextBox();
            this.addDirectorButton = new System.Windows.Forms.Button();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genreGridView
            // 
            this.genreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreGridView.Location = new System.Drawing.Point(694, 47);
            this.genreGridView.Name = "genreGridView";
            this.genreGridView.Size = new System.Drawing.Size(240, 150);
            this.genreGridView.TabIndex = 64;
            this.genreGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreGridView_CellContentClick);
            // 
            // addMediaButton
            // 
            this.addMediaButton.Location = new System.Drawing.Point(296, 280);
            this.addMediaButton.Name = "addMediaButton";
            this.addMediaButton.Size = new System.Drawing.Size(241, 23);
            this.addMediaButton.TabIndex = 63;
            this.addMediaButton.Text = "Add Media";
            this.addMediaButton.UseVisualStyleBackColor = true;
            this.addMediaButton.Click += new System.EventHandler(this.addMediaButton_Click);
            // 
            // deleteMediaButton
            // 
            this.deleteMediaButton.Location = new System.Drawing.Point(298, 359);
            this.deleteMediaButton.Name = "deleteMediaButton";
            this.deleteMediaButton.Size = new System.Drawing.Size(241, 23);
            this.deleteMediaButton.TabIndex = 62;
            this.deleteMediaButton.Text = "Delete Media";
            this.deleteMediaButton.UseVisualStyleBackColor = true;
            this.deleteMediaButton.Click += new System.EventHandler(this.deleteMediaButton_Click);
            // 
            // updateMediaButton
            // 
            this.updateMediaButton.Location = new System.Drawing.Point(297, 316);
            this.updateMediaButton.Name = "updateMediaButton";
            this.updateMediaButton.Size = new System.Drawing.Size(242, 23);
            this.updateMediaButton.TabIndex = 61;
            this.updateMediaButton.Text = "Update Media";
            this.updateMediaButton.UseVisualStyleBackColor = true;
            this.updateMediaButton.Click += new System.EventHandler(this.updateMediaButton_Click);
            // 
            // refreshButtonMedia
            // 
            this.refreshButtonMedia.Location = new System.Drawing.Point(12, 433);
            this.refreshButtonMedia.Name = "refreshButtonMedia";
            this.refreshButtonMedia.Size = new System.Drawing.Size(75, 23);
            this.refreshButtonMedia.TabIndex = 60;
            this.refreshButtonMedia.Text = "Refresh";
            this.refreshButtonMedia.UseVisualStyleBackColor = true;
            this.refreshButtonMedia.Click += new System.EventHandler(this.refreshButtonMedia_Click);
            // 
            // languageComboBox
            // 
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(348, 166);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(189, 21);
            this.languageComboBox.TabIndex = 59;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(288, 152);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 58;
            this.languageLabel.Text = "Language";
            // 
            // budgetTextBox
            // 
            this.budgetTextBox.Location = new System.Drawing.Point(348, 117);
            this.budgetTextBox.Name = "budgetTextBox";
            this.budgetTextBox.Size = new System.Drawing.Size(187, 20);
            this.budgetTextBox.TabIndex = 57;
            // 
            // labelMediaTitle
            // 
            this.labelMediaTitle.AutoSize = true;
            this.labelMediaTitle.Location = new System.Drawing.Point(12, 19);
            this.labelMediaTitle.Name = "labelMediaTitle";
            this.labelMediaTitle.Size = new System.Drawing.Size(36, 13);
            this.labelMediaTitle.TabIndex = 55;
            this.labelMediaTitle.Text = "Media";
            // 
            // selectedMediaLabel
            // 
            this.selectedMediaLabel.AutoSize = true;
            this.selectedMediaLabel.Location = new System.Drawing.Point(287, 15);
            this.selectedMediaLabel.Name = "selectedMediaLabel";
            this.selectedMediaLabel.Size = new System.Drawing.Size(84, 13);
            this.selectedMediaLabel.TabIndex = 52;
            this.selectedMediaLabel.Text = "Selected Media:";
            // 
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Location = new System.Drawing.Point(287, 120);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(44, 13);
            this.budgetLabel.TabIndex = 50;
            this.budgetLabel.Text = "Budget:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(348, 80);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(187, 20);
            this.yearTextBox.TabIndex = 49;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(291, 83);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 48;
            this.yearLabel.Text = "Year:";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(348, 239);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(189, 21);
            this.genreComboBox.TabIndex = 47;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(293, 247);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(39, 13);
            this.genreLabel.TabIndex = 46;
            this.genreLabel.Text = "Genre:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(291, 204);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(47, 13);
            this.directorLabel.TabIndex = 45;
            this.directorLabel.Text = "Director:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(288, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 43;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(348, 47);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(187, 20);
            this.titleTextBox.TabIndex = 42;
            // 
            // mediaGridView
            // 
            this.mediaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaGridView.Location = new System.Drawing.Point(12, 47);
            this.mediaGridView.Name = "mediaGridView";
            this.mediaGridView.Size = new System.Drawing.Size(240, 366);
            this.mediaGridView.TabIndex = 41;
            this.mediaGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaGridView_CellContentClick);
            // 
            // newGenreTextBox
            // 
            this.newGenreTextBox.Location = new System.Drawing.Point(765, 220);
            this.newGenreTextBox.Name = "newGenreTextBox";
            this.newGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.newGenreTextBox.TabIndex = 66;
            // 
            // newGenreLabel
            // 
            this.newGenreLabel.AutoSize = true;
            this.newGenreLabel.Location = new System.Drawing.Point(695, 220);
            this.newGenreLabel.Name = "newGenreLabel";
            this.newGenreLabel.Size = new System.Drawing.Size(64, 13);
            this.newGenreLabel.TabIndex = 65;
            this.newGenreLabel.Text = "New Genre:";
            // 
            // directorComboBox
            // 
            this.directorComboBox.FormattingEnabled = true;
            this.directorComboBox.Location = new System.Drawing.Point(348, 201);
            this.directorComboBox.Name = "directorComboBox";
            this.directorComboBox.Size = new System.Drawing.Size(189, 21);
            this.directorComboBox.TabIndex = 67;
            // 
            // directorGridView
            // 
            this.directorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorGridView.Location = new System.Drawing.Point(690, 309);
            this.directorGridView.Name = "directorGridView";
            this.directorGridView.Size = new System.Drawing.Size(240, 150);
            this.directorGridView.TabIndex = 68;
            this.directorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.directorGridView_CellContentClick);
            // 
            // newLanguageLabel
            // 
            this.newLanguageLabel.AutoSize = true;
            this.newLanguageLabel.Location = new System.Drawing.Point(295, 564);
            this.newLanguageLabel.Name = "newLanguageLabel";
            this.newLanguageLabel.Size = new System.Drawing.Size(83, 13);
            this.newLanguageLabel.TabIndex = 69;
            this.newLanguageLabel.Text = "New Language:";
            // 
            // newLanguageTextBox
            // 
            this.newLanguageTextBox.Location = new System.Drawing.Point(402, 561);
            this.newLanguageTextBox.Name = "newLanguageTextBox";
            this.newLanguageTextBox.Size = new System.Drawing.Size(100, 20);
            this.newLanguageTextBox.TabIndex = 70;
            this.newLanguageTextBox.TextChanged += new System.EventHandler(this.newLanguageTextBox_TextChanged);
            // 
            // languageGridView
            // 
            this.languageGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.languageGridView.Location = new System.Drawing.Point(296, 399);
            this.languageGridView.Name = "languageGridView";
            this.languageGridView.Size = new System.Drawing.Size(240, 150);
            this.languageGridView.TabIndex = 71;
            this.languageGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.languageGridView_CellContentClick);
            // 
            // newDirectorLabel
            // 
            this.newDirectorLabel.AutoSize = true;
            this.newDirectorLabel.Location = new System.Drawing.Point(691, 478);
            this.newDirectorLabel.Name = "newDirectorLabel";
            this.newDirectorLabel.Size = new System.Drawing.Size(72, 13);
            this.newDirectorLabel.TabIndex = 72;
            this.newDirectorLabel.Text = "New Director:";
            // 
            // newDirectorTextBox
            // 
            this.newDirectorTextBox.Location = new System.Drawing.Point(769, 475);
            this.newDirectorTextBox.Name = "newDirectorTextBox";
            this.newDirectorTextBox.Size = new System.Drawing.Size(100, 20);
            this.newDirectorTextBox.TabIndex = 73;
            // 
            // addDirectorButton
            // 
            this.addDirectorButton.Location = new System.Drawing.Point(690, 511);
            this.addDirectorButton.Name = "addDirectorButton";
            this.addDirectorButton.Size = new System.Drawing.Size(239, 23);
            this.addDirectorButton.TabIndex = 74;
            this.addDirectorButton.Text = "Add Director";
            this.addDirectorButton.UseVisualStyleBackColor = true;
            this.addDirectorButton.Click += new System.EventHandler(this.addDirectorButton_Click);
            // 
            // addGenreButton
            // 
            this.addGenreButton.Location = new System.Drawing.Point(698, 261);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(232, 23);
            this.addGenreButton.TabIndex = 75;
            this.addGenreButton.Text = "Add Genre";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Location = new System.Drawing.Point(298, 587);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(244, 23);
            this.addLanguageButton.TabIndex = 76;
            this.addLanguageButton.Text = "Add Language";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(12, 501);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 77;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MediaEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 622);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.addLanguageButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.addDirectorButton);
            this.Controls.Add(this.newDirectorTextBox);
            this.Controls.Add(this.newDirectorLabel);
            this.Controls.Add(this.languageGridView);
            this.Controls.Add(this.newLanguageTextBox);
            this.Controls.Add(this.newLanguageLabel);
            this.Controls.Add(this.directorGridView);
            this.Controls.Add(this.directorComboBox);
            this.Controls.Add(this.newGenreTextBox);
            this.Controls.Add(this.newGenreLabel);
            this.Controls.Add(this.genreGridView);
            this.Controls.Add(this.addMediaButton);
            this.Controls.Add(this.deleteMediaButton);
            this.Controls.Add(this.updateMediaButton);
            this.Controls.Add(this.refreshButtonMedia);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.budgetTextBox);
            this.Controls.Add(this.labelMediaTitle);
            this.Controls.Add(this.selectedMediaLabel);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.mediaGridView);
            this.Name = "MediaEditor";
            this.Text = "MediaEditor";
            this.Load += new System.EventHandler(this.MediaEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languageGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView genreGridView;
        private System.Windows.Forms.Button addMediaButton;
        private System.Windows.Forms.Button deleteMediaButton;
        private System.Windows.Forms.Button updateMediaButton;
        private System.Windows.Forms.Button refreshButtonMedia;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.TextBox budgetTextBox;
        private System.Windows.Forms.Label labelMediaTitle;
        private System.Windows.Forms.Label selectedMediaLabel;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DataGridView mediaGridView;
        private System.Windows.Forms.TextBox newGenreTextBox;
        private System.Windows.Forms.Label newGenreLabel;
        private System.Windows.Forms.ComboBox directorComboBox;
        private System.Windows.Forms.DataGridView directorGridView;
        private System.Windows.Forms.Label newLanguageLabel;
        private System.Windows.Forms.TextBox newLanguageTextBox;
        private System.Windows.Forms.DataGridView languageGridView;
        private System.Windows.Forms.Label newDirectorLabel;
        private System.Windows.Forms.TextBox newDirectorTextBox;
        private System.Windows.Forms.Button addDirectorButton;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Button logoutButton;

    }
}