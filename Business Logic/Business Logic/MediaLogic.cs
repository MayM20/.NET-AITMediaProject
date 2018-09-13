using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
        }

        public List<MediaModel> ListMedia()
        {
            //empty list of media models to start us off
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMedia();
            //for every row in the table returned -
            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                //create a model representing that row
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);//add it to our list of medias
            }

            return medias;
        }

        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByBudget(int budget)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByBudget(budget);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByGenreName(string genreName)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByGenreName(genreName);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            MediaDS.ViewMediaDataTable mediaTable = mediaDAO.ListMediaByTitle(title);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        public List<PairModel> ListGenre()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabGenreDataTable genreTable = mediaDAO.ListGenre();

            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListLanguage()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabLanguageDataTable languageTable = mediaDAO.ListLanguage();

            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListDirector()
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabDirectorDataTable directorTable = mediaDAO.ListDirector();

            foreach (MediaDS.TabDirectorRow row in directorTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<PairModel> ListReturn(int UID)
        {
            List<PairModel> pairs = new List<PairModel>();
            MediaDS.TabReturnDataTable returnTable = mediaDAO.ListMediaByUID(UID);

            foreach (MediaDS.TabReturnRow row in returnTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                pairs.Add(pair);
            }
            return pairs;
        }

        public List<MediaModel2> ListReserve(int mediaID)
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserve();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                if (row.MediaID == mediaID) {
                MediaModel2 media = MediaModel2.Parse(row);
                medias.Add(media);
                }
            }
            if (medias.Count== 0 ) 
                medias=null; 
            return medias;
        }

        public List<MediaModel2> ListByUIDreserve(int uID)
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListByUIDreserve();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
                if (row.UID ==uID)
                {
                    MediaModel2 media = MediaModel2.Parse(row);
                    medias.Add(media);
                }
            }
           
            return medias;
        }


        public List<MediaModel2> ListReserve()
        {
            List<MediaModel2> medias = new List<MediaModel2>();
            MediaDS.TabReservedDataTable reservedTable = mediaDAO.ListReserve();

            foreach (MediaDS.TabReservedRow row in reservedTable.Rows)
            {
              
                    MediaModel2 media = MediaModel2.Parse(row);
                    medias.Add(media);
               
            }
          
            return medias;
        }

        public List<BorrowModel> ListBorrow()
        {
            List<BorrowModel> medias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowTable = mediaDAO.ListBorrow();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {

                BorrowModel media = BorrowModel.Parse(row);
                medias.Add(media);

            }

            return medias;
        }

        public List<BorrowModel> ListBorrow(int mediaID)
        {
            List<BorrowModel> medias = new List<BorrowModel>();
            MediaDS.TabBorrowDataTable borrowTable = mediaDAO.ListBorrow();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {
                if (row.MediaID == mediaID)
                {
                    BorrowModel media = BorrowModel.Parse(row);
                    medias.Add(media);
                }
            }

            return medias;
        }






        //INSERT NEW MEDIA
        public int InsertNewMedia(string title, int director, int genre, int language, int publishYear, int budget )
        {
            return mediaDAO.InsertNewMedia(title, director, genre, language, publishYear, budget);

        }
        //UPDATE MEDIA
        public int UpdateMedia(string title, int director, int genre, int language, int publishYear, int budget, int mediaID)
        {
            return mediaDAO.UpdateMedia(title, director, genre, language, publishYear, budget, mediaID);

        }
        //DELETE MEDIA
        public int DeleteMedia(int mediaID)
        {
            return mediaDAO.DeleteMedia(mediaID);
           
        }

        //INSERT NEW GENRE
        public int InsertNewGenre(string genreName)
        {
            return mediaDAO.InsertNewGenre(genreName);

        }
        //INSERT NEW LANGUAGE
        public int InsertNewLanguage(string language)
        {
            return mediaDAO.InsertNewLanguage(language);

        }
        //INSERT NEW DIRECTOR
        public int InsertNewDirector(string director)
        {
            return mediaDAO.InsertNewDirector(director);

        }
        //INSERT NEW RESERVE
        public int InsertReserve(int UID, int mediaID, string date)
        {
            return mediaDAO.InsertReserve(UID, mediaID, date);

        }
        //DELETE RESERVE
        public int DeleteReserve(int RID)
        {
            return mediaDAO.DeleteReserve(RID);

        }

        //RETURN 
        public int ReturnByMediaIDandUID(int MediaID)
        {
            return mediaDAO.ReturnByMediaIDAandUID(MediaID);
        
        }


        //INSERT BORROW
        public int InsertBorrow(int UID, int MediaID, string borrowDate, string returnDate)
        {
            return mediaDAO.InsertBorrow(UID, MediaID, borrowDate, returnDate);

        }


        

    }
}
