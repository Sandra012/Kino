using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Kino
{
    class RecommendedMovie
    {
        /* Ako korisnikot e najaven i postoi film od negoviot zanr sto seuste go nema gledano, togas
         * vo delot Recommenden for you se prikazuva filmot od omileniot zanr so najvisok rejting sto go nema gledano
         * Dokolku korisnikot ne e najaven ili ne postoi film od omeleniot zanr sto ne go gledal
         * se prikazuva filmot so najgolem rejting voopsto sto go nema gledano */


        OracleConnection conn;
        DataTable dt;
        OracleDataAdapter da;

        public int CustomerId { get; set; }
        public string MovieName { get; set; }

        public Panel panel { get; set; }
        public PictureBox pbPhoto { get; set; }
        public Bitmap bmp { get; set; }
        public TextBox tbMovieName { get; set; }

        System.Resources.ResourceManager Mng;

        public RecommendedMovie(int CustomerId, Panel panel, TextBox tbMovieName, OracleConnection conn)
        {
            this.CustomerId = CustomerId;
            this.panel = panel;
            this.tbMovieName = tbMovieName;
            
            this.conn = conn;
            da = new OracleDataAdapter();
            dt = new DataTable();
            pbPhoto = new PictureBox();

            Mng = new System.Resources.ResourceManager("Kino.Properties.Resources", typeof(Properties.Resources).Assembly);

            MovieName = GetRecommendedMovieId();
        }

        public void Draw() {
            //postavuvanje na slika vo PictureBox
            panel.Controls.Add(pbPhoto);
            string PhotoName = GetPhotoName();
            bmp = (Bitmap)Mng.GetObject(PhotoName);
            pbPhoto.Image = bmp;
            
            //detali za slikata
            pbPhoto.Height = 180;
            pbPhoto.Width = 140;
            pbPhoto.BorderStyle = BorderStyle.Fixed3D;
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbPhoto.Location = new Point(10, 10);

            //postavuvanje na imeto pod slikata
            tbMovieName.Text = MovieName;

            this.pbPhoto.Click += new System.EventHandler(this.lblMovieName_Click);
            this.pbPhoto.MouseEnter += new System.EventHandler(this.btnBookNow_Enter);
            this.pbPhoto.MouseLeave += new System.EventHandler(this.btnBookNow_Leave);
        }


        public string GetPhotoName() {
            string PhotoName = MovieName;
            PhotoName = PhotoName.Replace(' ', '_');
            PhotoName = PhotoName.Replace('&', '_');
            PhotoName = PhotoName.Replace('.', '_');
            return PhotoName;
        }




        public string GetRecommendedMovieId() {
            string Query = @"SELECT MOVIENAME FROM MOVIES WHERE MOVIEID =  (SELECT MOVIEID FROM (SELECT MOVIEID, AVG(RATING) RATING
FROM RATINGS WHERE MOVIEID IN (SELECT MOVIEID FROM (SELECT MOVIEID FROM MOVIES WHERE GENRE = (SELECT GENRE
FROM (select MOVIES.GENRE, COUNT(MOVIES.GENRE) COUNT from MOVIES MOVIES, TICKETS TICKETS, SHOWS SHOWS, CUSTOMERS CUSTOMERS, BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID and TICKETS.TICKETID=SHOWS.SHOWID and SHOWS.MOVIEID=MOVIES.MOVIEID AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"
GROUP BY MOVIES.GENRE) A
WHERE A.COUNT = (SELECT MAX(COUNT) FROM (select MOVIES.GENRE, COUNT(MOVIES.GENRE) COUNT
 from MOVIES MOVIES, TICKETS TICKETS, SHOWS SHOWS, CUSTOMERS CUSTOMERS, BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID and TICKETS.TICKETID=SHOWS.SHOWID and SHOWS.MOVIEID=MOVIES.MOVIEID AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"
GROUP BY MOVIES.GENRE)))) A WHERE MOVIEID NOT IN (select MOVIES.MOVIEID as MOVIEID from MOVIES MOVIES, TICKETS TICKETS, SHOWS SHOWS, CUSTOMERS CUSTOMERS, BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID and TICKETS.SHOWID=SHOWS.SHOWID and SHOWS.MOVIEID=MOVIES.MOVIEID AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"))
GROUP BY MOVIEID) A
WHERE A.RATING = (SELECT MAX(RATING) FROM (SELECT MOVIEID, AVG(RATING) RATING FROM RATINGS
WHERE MOVIEID IN (SELECT MOVIEID FROM (SELECT MOVIEID FROM MOVIES WHERE GENRE = (SELECT GENRE FROM (select MOVIES.GENRE, COUNT(MOVIES.GENRE) COUNT
 from MOVIES MOVIES, TICKETS TICKETS, SHOWS SHOWS, CUSTOMERS CUSTOMERS, BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID
    and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID
    and TICKETS.TICKETID=SHOWS.SHOWID
    and SHOWS.MOVIEID=MOVIES.MOVIEID
    AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"
GROUP BY MOVIES.GENRE) A
WHERE A.COUNT = (SELECT MAX(COUNT) FROM (select MOVIES.GENRE, COUNT(MOVIES.GENRE) COUNT
 from MOVIES MOVIES,
    TICKETS TICKETS,
    SHOWS SHOWS,
    CUSTOMERS CUSTOMERS,
    BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID
    and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID
    and TICKETS.TICKETID=SHOWS.SHOWID
    and SHOWS.MOVIEID=MOVIES.MOVIEID
    AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"
GROUP BY MOVIES.GENRE)))) A
WHERE MOVIEID NOT IN (select MOVIES.MOVIEID as MOVIEID 
 from MOVIES MOVIES,
    TICKETS TICKETS,
    SHOWS SHOWS,
    CUSTOMERS CUSTOMERS,
    BOOKINGS BOOKINGS 
 where BOOKINGS.CUSTOMERID=CUSTOMERS.CUSTOMERID
    and TICKETS.BOOKINGID=BOOKINGS.BOOKINGID
    and TICKETS.TICKETID=SHOWS.SHOWID
    and SHOWS.MOVIEID=MOVIES.MOVIEID
    AND CUSTOMERS.CUSTOMERID = " + CustomerId.ToString() + @"))
GROUP BY MOVIEID)))";

            da.SelectCommand = new OracleCommand(Query, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0) //ako korisnikot e najaven i postoi takov film
                return dt.Rows[0][0].ToString().Trim();
            else // ako ne e najaven ili nema takov film, prikazi mu go onoj so najvisok rejting voopsto, sto go nema gledano
                return GetBestRatingMovieName();
        }

        public string GetBestRatingMovieName() {
            string Query = @"SELECT MOVIENAME FROM MOVIES WHERE MOVIEID =
(SELECT MOVIEID 
FROM (SELECT MOVIEID FROM MOVIES WHERE MOVIEID NOT IN (SELECT DISTINCT M.MOVIEID
FROM MOVIES M, SHOWS S, TICKETS T, BOOKINGS B, CUSTOMERS C
WHERE M.MOVIEID = S.MOVIEID AND T.SHOWID = S.SHOWID AND T.BOOKINGID = B.BOOKINGID AND B.CUSTOMERID = C.CUSTOMERID AND C.CUSTOMERID = " + CustomerId.ToString() + @")) A
WHERE A.MOVIEID = (SELECT MOVIEID
FROM (SELECT MOVIEID, AVG(RATING) RATING
FROM RATINGS
WHERE MOVIEID IN (SELECT MOVIEID FROM MOVIES WHERE MOVIEID NOT IN (SELECT DISTINCT M.MOVIEID
FROM MOVIES M, SHOWS S, TICKETS T, BOOKINGS B, CUSTOMERS C
WHERE M.MOVIEID = S.MOVIEID AND T.SHOWID = S.SHOWID AND T.BOOKINGID = B.BOOKINGID AND B.CUSTOMERID = C.CUSTOMERID AND C.CUSTOMERID = " + CustomerId.ToString() + @"))
GROUP BY MOVIEID) A  
WHERE A.RATING = (
SELECT MAX(RATING)
FROM (SELECT MOVIEID, AVG(RATING) RATING
FROM RATINGS
WHERE MOVIEID IN (SELECT MOVIEID FROM MOVIES WHERE MOVIEID NOT IN (SELECT DISTINCT M.MOVIEID
FROM MOVIES M, SHOWS S, TICKETS T, BOOKINGS B, CUSTOMERS C
WHERE M.MOVIEID = S.MOVIEID AND T.SHOWID = S.SHOWID AND T.BOOKINGID = B.BOOKINGID AND B.CUSTOMERID = C.CUSTOMERID AND C.CUSTOMERID = " + CustomerId.ToString() + @"))
GROUP BY MOVIEID))))";

            da.SelectCommand = new OracleCommand(Query, conn);
            dt.Dispose();
            dt = new DataTable();
            da.Fill(dt);
            return dt.Rows[0][0].ToString().Trim();
        }

        private void lblMovieName_Click(object sender, EventArgs e)
        {
            MovieDetails newMovieDetailsForm = new MovieDetails(MovieName, bmp, conn);
            newMovieDetailsForm.Show();
        }

        private void btnBookNow_Enter(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Hand;
        }

        private void btnBookNow_Leave(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Arrow;
        }

    }
}
