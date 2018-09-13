using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access;

namespace Business_Logic
{
    public class MediaModel
    {
        //propfull - tab, tab
        //attribute
        private int mediaId;
        //property (helps manage the attribute above)
        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        private string mediaName;

        public string MediaName
        {
            get { return mediaName; }
            set { mediaName = value; }
        }

        //propfull, then press tab twice
        private int publishYear;

        public int PublishYear
        {
            get { return publishYear; }
            set { publishYear = value; }
        }

        //BUDGET
        //attribute
        private int budget;
        //property
        public int Budget
        {
            get { return budget; }
            set { budget = value; }
        
        }

        //GENRE NAME
        //attribute
        private string genreName;
        //property
        public string GenreName
        {
            get { return genreName; }
            set { genreName = value; }
        }

        //DIRECTOR NAME
        //attribute
        private string directorName;
        //property
        public string DirectorName
        {
            get { return directorName; }
            set { directorName = value; }
        
        }

        //LANGUAGE NAME
        //attribute
        private string languageName;
        //property
        public string LanguageName
        {
            get { return languageName; }
            set { languageName = value; }

        }
        
        //setters and getters in order to display my selected value on the combo box once I click on them 
        //NOTE: -> DIFFERENT FROM ATTRIBUTE AND PROPERTY, this helps to set and the value of the member property specified 
        
        //GENRE
        private int genre;
        public void setGenre(int g)
        {
            genre = g;
        }

        public int getGenre()
        {
            return genre;
        }
        //LANGUAGE
        private int language;
        public void setLanguage(int l)
        {
            language = l;
        
        }
        public int getLanguage()
        {
            return language;
        
        }

        
        //DIRECTOR
        private int director;
        public void setDirector(int d)
        {
            director = d;
        
        }
        public int getDirector()
        {
            return director;
        
        }


        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel media = new MediaModel();
            media.MediaId = mediaRow.MediaID;
            media.MediaName = mediaRow.Title;
            media.PublishYear = mediaRow.PublishYear;
            media.Budget = (int) mediaRow.Budget;
            media.GenreName = mediaRow.GenreName;
            media.DirectorName = mediaRow.DirectorName;
            media.LanguageName = mediaRow.LanguageName;
            media.setGenre(mediaRow.Genre);
            media.setLanguage(mediaRow.Language);
            media.setDirector(mediaRow.Director);

            return media;

        }
       

    }

    public class MediaModel2
    {
        private int mediaId;
        //property (helps manage the attribute above)
        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        //DATE
        private string date;
        //property
        public string Date
        {
            get { return date; }
            set { date = value; }

        }

        //RID
        private int rid;
        //property
        public int RID
        {
            get { return rid; }
            set { rid = value; }

        }

        //UID
        private int uid;
        //property
        public int UID
        {
            get { return uid; }
            set { uid = value; }

        }

        public static MediaModel2 Parse(MediaDS.TabReservedRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel2 media = new MediaModel2();
            media.MediaId = mediaRow.MediaID;
            media.date = mediaRow.ReservedDate.ToString("MM/dd/yyyy");
            media.RID = mediaRow.RID;
            media.UID = mediaRow.UID;


            return media;

        }
    }

public class BorrowModel
    {

        private int mediaId;
        //property (helps manage the attribute above)
        public int MediaId
        {
            get { return mediaId; }
            set { mediaId = value; }
        }

        //UID
        private int uid;
        //property
        public int UID
        {
            get { return uid; }
            set { uid = value; }

        }

        //DATE BORROW
        private string borrowDate;
        //property
        public string BorrowDate
        {
            get { return borrowDate; }
            set { borrowDate = value; }

        }

        //DATE RETURN BORROW
        private string returnDate;
        //property
        public string ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }

        }

        public static BorrowModel Parse(MediaDS.TabBorrowRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            BorrowModel media = new BorrowModel();
            media.MediaId = mediaRow.MediaID;
            media.UID = mediaRow.UID;
            media.borrowDate = mediaRow.BorrowDate.ToString("MM/dd/yyyy");
            media.returnDate = mediaRow.ReturnDate.ToString("MM/dd/yyyy");
 


            return media;

        }

    }
}
