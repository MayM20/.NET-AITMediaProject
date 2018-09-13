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
    public partial class MediaEditor : Form
    {
        private UserLogic userLogic = new UserLogic();
        private MediaLogic mediaLogic = new MediaLogic();

        private MediaModel selectedMedia = null; 

        public MediaEditor()
        {
            InitializeComponent();
        }

        //LOAD (useful to display all my info unlike the text box where you type information)
        private void MediaEditor_Load(object sender, EventArgs e)
        {
            RefreshMediaList();

            //GENRE COMBO BOX 
            genreComboBox.DataSource = mediaLogic.ListGenre();
            genreComboBox.DisplayMember = "PairName";
            genreComboBox.ValueMember = "PairId";

            //LANGUAGE COMBO BOX
            languageComboBox.DataSource = mediaLogic.ListLanguage();
            languageComboBox.DisplayMember = "PairName";
            languageComboBox.ValueMember = "PairId";

            //DIRECTOR COMBO BOX
            directorComboBox.DataSource = mediaLogic.ListDirector();
            directorComboBox.DisplayMember = "PairName";
            directorComboBox.ValueMember = "PairId";

            directorGridView.DataSource = mediaLogic.ListDirector();
            languageGridView.DataSource = mediaLogic.ListLanguage();
            genreGridView.DataSource = mediaLogic.ListGenre();
        }


        private void RefreshMediaList()
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();

        }

        private void mediaGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            if (row > -1)//-1 is the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of media model
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;

                selectedMedia = medias.ElementAt<MediaModel>(row);//get from this position
                titleTextBox.Text = selectedMedia.MediaName;
                
                yearTextBox.Text = Convert.ToString(selectedMedia.PublishYear);
                budgetTextBox.Text = Convert.ToString(selectedMedia.Budget);

                //this section is made for get the actual value when you select one of your rows
                genreComboBox.SelectedValue = selectedMedia.getGenre();
                languageComboBox.SelectedValue = selectedMedia.getLanguage();
                directorComboBox.SelectedValue = selectedMedia.getDirector();

            }
        }

        private void refreshButtonMedia_Click(object sender, EventArgs e)
        {
            RefreshMediaList();
        }


        //ADD NEW MEDIA BUTTON
        private void addMediaButton_Click(object sender, EventArgs e)
        {

            int affectedRows = mediaLogic.InsertNewMedia(titleTextBox.Text, (int)directorComboBox.SelectedValue, (int)genreComboBox.SelectedValue, (int)languageComboBox.SelectedValue, int.Parse(yearTextBox.Text), int.Parse(budgetTextBox.Text));
            
            
            //if affectedRows > 0, success!

            RefreshMediaList();
        }

        
        //UPDATE MEDIA
        private void updateMediaButton_Click(object sender, EventArgs e)
        {
            if (selectedMedia != null)
            {
                int rowsAffected = mediaLogic.UpdateMedia(titleTextBox.Text, (int)directorComboBox.SelectedValue, (int)genreComboBox.SelectedValue, (int)languageComboBox.SelectedValue, Int32.Parse(yearTextBox.Text), Int32.Parse(budgetTextBox.Text), selectedMedia.MediaId);
                if (rowsAffected > 0)
                {
                    //worked
                    MessageBox.Show(/*selectedMedia.MediaName + */" media updated!");

                }
                else
                {
                    //didn;t

                }
                RefreshMediaList();

            }
        }

        //DELETE MEDIA
        private void deleteMediaButton_Click(object sender, EventArgs e)
        {
            
            if (selectedMedia != null)
            {
                int affectedRows = mediaLogic.DeleteMedia(selectedMedia.MediaId);

                if (affectedRows > 0)
                {
                    //worked
                    MessageBox.Show(selectedMedia.MediaName + " media deleted!");

                }
                else
                {
                    //didn;t
                    MessageBox.Show(selectedMedia.MediaName + " sorry but this media cannot be deleted!");

                }
               

                selectedMedia = null;

                RefreshMediaList();

            }

        }

        //GRIDVIEW DIRECTOR
        private void directorGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)//-1 is the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of media model
                List<MediaModel> medias = (List<MediaModel>)directorGridView.DataSource;

                selectedMedia = medias.ElementAt<MediaModel>(row);//get from this position
                newDirectorTextBox.Text = selectedMedia.DirectorName;
            

            }
        }

        //ADD NEW DIRECTOR BUTTON
        private void addDirectorButton_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.InsertNewDirector(newDirectorTextBox.Text);


            //if affectedRows > 0, success!

            RefreshMediaList();
        }

        //GRIDVIEW LANGUAGE
        private void languageGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)//-1 is the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of media model
                List<MediaModel> medias = (List<MediaModel>)directorGridView.DataSource;

                selectedMedia = medias.ElementAt<MediaModel>(row);//get from this position
                newLanguageTextBox.Text = selectedMedia.LanguageName;


            }

        }

        //ADD NEW LANGUAGE BUTTON
        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.InsertNewLanguage(newLanguageTextBox.Text);


            //if affectedRows > 0, success!

            RefreshMediaList();

        }

        //GRIDVIEW GENRE
        private void genreGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row > -1)//-1 is the header row, dont care about it
            {
                //cast datasource from "object" to list of models. throw exception if not actually
                //a list of media model
                List<MediaModel> medias = (List<MediaModel>)genreGridView.DataSource;

                selectedMedia = medias.ElementAt<MediaModel>(row);//get from this position
                newGenreTextBox.Text = selectedMedia.GenreName;


            }
        }

        //ADD NEW GENRE BUTTON
        private void addGenreButton_Click(object sender, EventArgs e)
        {
            int affectedRows = mediaLogic.InsertNewGenre(newGenreTextBox.Text);


            //if affectedRows > 0, success!

            RefreshMediaList();
        }

        


        //ignore these
        private void newLanguageTextBox_TextChanged(object sender, EventArgs e)
        {

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
