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
    public partial class MediaBrowser : Form
    {
        private MediaLogic mediaLogic;
        private MediaModel media;
        private MediaModel2 media2 = null;
        private BorrowModel media3 = null;
        UserLogic users = new UserLogic();

        public MediaBrowser()
        {
            mediaLogic = new MediaLogic();
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
            userLabel.Text = "Username: " + CurrentUser.UserName;
            reserveGridView.DataSource = mediaLogic.ListByUIDreserve(CurrentUser.UserID);
            borrowGridView.DataSource = mediaLogic.ListBorrow();

            
            //RETURN COMBO BOX 
            borrowMediaComboBox.DataSource = mediaLogic.ListReturn(CurrentUser.UserID);
            borrowMediaComboBox.DisplayMember = "PairName";
            borrowMediaComboBox.ValueMember = "PairId";
        }

        private void yearSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByPublishYear(Int32.Parse(publishYearTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia(); //if error, list everything
            }
        }

        private void listAllButton_Click(object sender, EventArgs e)
        {
            mediaGridView.DataSource = mediaLogic.ListMedia();
        }

        private void mediaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //get which row was selected
            //if user clicks column headers, row = -1, so ignore
            if (row >= 0)
            {
                //cast dataSource from object back into what we put it in as
                List<MediaModel> medias = (List<MediaModel>)mediaGridView.DataSource;

                //get the individual media selected
                media = medias[row];

                selectedMediaLabel.Text = "Selected Media: " + media.MediaName;
            }

        }

        private void genreNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByGenreName(genreNameTextBox.Text);
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia(); //if error, list everything
            }
        }

        private void budgetButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByBudget(Int32.Parse(budgetTextBox.Text));
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia(); //if error, list everything
            }
        }

        private void titleSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                mediaGridView.DataSource = mediaLogic.ListMediaByTitle(titleTextBox.Text);
            }
            catch (Exception ex)
            {
                mediaGridView.DataSource = mediaLogic.ListMedia(); //if error, list everything
            }
        }

        //NEW RESERVE 24/05/2017


        //RESERVE BUTTON CLICK
        private void reserveButton_Click(object sender, EventArgs e)
        {
            if (mediaLogic.ListReserve(media.MediaId) == null)
            {
                int affectedRows = mediaLogic.InsertReserve(CurrentUser.UserID, media.MediaId, DateTime.Today.ToString("MM/dd/yyyy"));
                MessageBox.Show(media.MediaName + " this was succesfully reserved!");

            }

            else
                MessageBox.Show(media.MediaName + " sorry but you have already reserved this media!");

            RefreshUserList();

        }

        private void RefreshUserList()
        {
            reserveGridView.DataSource = mediaLogic.ListByUIDreserve(CurrentUser.UserID);

        }

        
        private void RefreshBorrowList()
        {
            borrowGridView.DataSource = mediaLogic.ListBorrow(CurrentUser.UserID);
        
        }

        //DELETE RESERVE BUTTON
        private void deleteReserveButton_Click(object sender, EventArgs e)
        {
            if (media2 != null)
            {
                int affectedRows = mediaLogic.DeleteReserve(media2.RID);

             
                media2 = null;

                RefreshUserList();

            }

        }



        //RESERVE GRID VIEW
        private void reserveGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //get which row was selected
            //if user clicks column headers, row = -1, so ignore
            if (row >= 0)
            {
                //cast dataSource from object back into what we put it in as
                List<MediaModel2> medias = (List<MediaModel2>)reserveGridView.DataSource;

                //get the individual media selected
                media2 = medias[row];

            }
        }

       //LOGOUT ACTION
        private void logout_Click(object sender, EventArgs e)
        {

            CurrentUser.UserName = " ";
            CurrentUser.UserLevel = 0;
            CurrentUser.UserID = 0;

            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLogin));
            t.Start();
            Close();

        }

        //useful to go to the same form after having logout 
        private void OpenLogin()
        { 
        Application.Run(new Form1());
        }

        //BORROW BUTTON 25-05-2017
        private void borrowButton_Click(object sender, EventArgs e)
        {
             if (mediaLogic.ListBorrow(media.MediaId).Count <= 0)
            {
                DateTime todayDate = DateTime.Today;
                string todaysDate = todayDate.ToString("MM/dd/yyyy");
                DateTime expDate = todayDate.AddDays(15);
                string expireDate = expDate.ToString("MM/dd/yyyy");
                int affectedRows = mediaLogic.InsertBorrow(CurrentUser.UserID, media.MediaId, todaysDate, expireDate);
                MessageBox.Show(media.MediaName + "has been borrowed for you!");

            }

            else
                MessageBox.Show(media.MediaName + " sorry but you cannot borrow this media, it has already been reserved");

            RefreshUserList();

        }

        //BORROW GRID VIEW
        private void borrowGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //get which row was selected
            //if user clicks column headers, row = -1, so ignore
            if (row >= 0)
            {
                //cast dataSource from object back into what we put it in as
                List<BorrowModel> medias = (List<BorrowModel>)borrowGridView.DataSource;

                //get the individual media selected
                media3 = medias[row];

            }
        }

        //RETURN BUTTON
        private void returnButton_Click(object sender, EventArgs e)
        {
            //borrowMediaComboBox
            try
            {
                if ((int)borrowMediaComboBox.SelectedValue != null)
                {
                    int affectedRows = mediaLogic.ReturnByMediaIDandUID((int)borrowMediaComboBox.SelectedValue);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nothing to return");
            
            }

            borrowMediaComboBox.DataSource = mediaLogic.ListReturn(CurrentUser.UserID);
            borrowMediaComboBox.DisplayMember = "PairName";
            borrowMediaComboBox.ValueMember = "PairId";
            borrowMediaComboBox.Text = " ";



            }
          

            }

        }
    

