using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access.MediaDSTableAdapters;

namespace Data_Access
{
    //dao = data access object
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaTableAdapter; //read only
        private TabMediaTableAdapter MediaTableAdapter; //for data insert, delete, updates
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabDirectorTableAdapter directorTableAdapter;
        private TabReservedTableAdapter reserveTableAdapter;
        private TabBorrowTableAdapter borrowTableAdapter;
        private TabReturnTableAdapter returnTableAdapter;

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaTableAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            directorTableAdapter = new TabDirectorTableAdapter();
            MediaTableAdapter = new TabMediaTableAdapter();
            reserveTableAdapter = new TabReservedTableAdapter();
            borrowTableAdapter = new TabBorrowTableAdapter();
            returnTableAdapter = new TabReturnTableAdapter();
        }
        //TODO you guys deal with exception handling :P
        //get all media
        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaTableAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }


        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }

        //NEW STUFF 11-05-2017(only title because this is intended for my search criteria)
        public MediaDS.ViewMediaDataTable ListMediaByTitle(string title)
        {
            viewMediaTableAdapter.FillByTitle(mediaDataSet.ViewMedia, title);
            return mediaDataSet.ViewMedia;
        }
        //

        public MediaDS.ViewMediaDataTable ListMediaByBudget(int budget)
        {
            viewMediaTableAdapter.FillByBudget(mediaDataSet.ViewMedia, budget);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByGenreName(string genreName)
        {
            viewMediaTableAdapter.FillByGenreName(mediaDataSet.ViewMedia, genreName);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.TabLanguageDataTable ListLanguage()
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }
        public MediaDS.TabGenreDataTable ListGenre()
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }

        public MediaDS.TabDirectorDataTable ListDirector()
        {
            directorTableAdapter.Fill(mediaDataSet.TabDirector);
            return mediaDataSet.TabDirector;
        }

        public MediaDS.TabReservedDataTable ListReserve()
        {
            reserveTableAdapter.Fill(mediaDataSet.TabReserved);
            return mediaDataSet.TabReserved;
        }

        
        public MediaDS.TabReservedDataTable ListByUIDreserve()
        {
            reserveTableAdapter.Fill(mediaDataSet.TabReserved);
            return mediaDataSet.TabReserved;
        }

        public MediaDS.TabBorrowDataTable ListBorrow()
        {
            borrowTableAdapter.Fill(mediaDataSet.TabBorrow);
            return mediaDataSet.TabBorrow;
        
        }

        public MediaDS.TabReturnDataTable ListMediaByUID(int UID) {

            returnTableAdapter.Fill(mediaDataSet.TabReturn, UID);
            return mediaDataSet.TabReturn;
        }
       
           
        //INSERT NEW MEDIA
        public int InsertNewMedia(string title, int director, int genre, int language, int publishYear, int budget)
        {

            //return number of rows affected (1 good, 0 didn't insert)
            return MediaTableAdapter.InsertNewMedia(title, genre, director, language, publishYear, budget);
        }
        //UPDATE MEDIA
        public int UpdateMedia(string title, int director, int genre, int language, int publishYear, int budget, int mediaID)
        {
            //returns number of roews affected again (0 nothing change, 1+ entries changed)
            return MediaTableAdapter.UpdateMedia(title, director, genre, language, publishYear, budget, mediaID);


        }
        //DELETE MEDIA
        public int DeleteMedia(int mediaID)
        {
            try
            {

                return MediaTableAdapter.DeleteMedia(mediaID);

            }
            catch (Exception ex)
            {
                return 0;

            }

        }

        //INSERT NEW GENRE
        public int InsertNewGenre(string genreName)
        {

            //return number of rows affected (1 good, 0 didn't insert)
            return genreTableAdapter.InsertNewGenre(genreName);
        }

        //INSERT NEW LANGUAGE
        public int InsertNewLanguage(string language)
        {

            //return number of rows affected (1 good, 0 didn't insert)
            return languageTableAdapter.InsertNewLanguage(language);
        }

        //INSERT NEW DIRECTOR
        public int InsertNewDirector(string director)
        {

            //return number of rows affected (1 good, 0 didn't insert)
            return directorTableAdapter.InsertNewDirector(director);
        }

        //INSERT NEW RESERVE
        public int InsertReserve(int UID, int mediaID, string date)
        {
            try
            {

            //return number of rows affected (1 good, 0 didn't insert)
            return reserveTableAdapter.InsertReserve(UID, mediaID, date);

            }
            catch (Exception ex)
            {
                return 0;

            }
        }

        //DELETE RESERVE
        public int DeleteReserve(int RID)
        {
           
                return reserveTableAdapter.DeleteReserve(RID);

        }

        //RETURN
        public int ReturnByMediaIDAandUID(int MediaID)
        {

            return reserveTableAdapter.ReturnByMediaIDandUID(MediaID);

        }

        //INSERT BORROW
        public int InsertBorrow(int UID, int MediaID, string borrowDate, string returnDate)
        {
            try
            {
                //return number of rows affected (1 good, 0 didn't insert)
                return borrowTableAdapter.InsertBorrow(UID, MediaID, borrowDate, returnDate);

            }
            catch (Exception ex)
            {
                return 0;
            
            }
        }


        
    }
}
