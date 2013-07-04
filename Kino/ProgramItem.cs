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
    class ProgramItem
    {
        OracleConnection conn;

        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int Duration { get; set; }
        public int RoomNumber { get; set; }
        public string Time { get; set; }
        
        public int ShowId { get; set; }
        public int CustomerId { get; set; }

        //labeli so podatoci za sekoj film i pretstava
        public Label lblMovieName { get; set; }
        public Label lblMovieGenreDration { get; set; }
        public Label lblTime { get; set; }
        public Label lblRoomNumber { get; set; }
        public Button btnBookNow { get; set; }
        public PictureBox pbPhoto {get; set;}

        public Panel panel;
        
        //slika za filmot
        public Bitmap Photo;
        

        //konstruktor
        public ProgramItem(DataRow dr, OracleConnection conn, int CustomerId) {
            //podatoci sto se zemaat od sekoj red od tabelata so filmovi i  pretstavi
            MovieName = dr[0].ToString();
            MovieGenre = dr[1].ToString();
            Duration = Convert.ToInt32(dr[2]);
            RoomNumber = Convert.ToInt16(dr[3]);
            Time = dr[4].ToString();
            if (Time.Length == 4) //ako nedostasuva 0 na kraj
                Time += "0";
            
            //inicijalizacija na labelite i kopcinjata
            lblMovieGenreDration = new Label();
            lblMovieName = new Label();
            lblRoomNumber = new Label();
            lblTime = new Label();
            btnBookNow = new Button();
            pbPhoto = new PictureBox();

            //imeto na slikata od Resorces (site prazni mesta i znaci da se zamenat so _)
            String PhotoName = MovieName;

            PhotoName = PhotoName.Replace(' ', '_');
            PhotoName = PhotoName.Replace('&', '_');
            PhotoName = PhotoName.Replace('.', '_');

            System.Resources.ResourceManager mng = new System.Resources.ResourceManager("Kino.Properties.Resources", typeof(Properties.Resources).Assembly); 
            Photo = (Bitmap)mng.GetObject(PhotoName);

            ShowId = Convert.ToInt16(dr[5]);
            this.conn = conn;
            this.CustomerId = CustomerId;
        }

        public void Draw(Panel panel, int distance) {
            this.panel = panel;

            //dodavanje na kontrolite vo panelot
            panel.Controls.Add(lblMovieGenreDration);
            panel.Controls.Add(lblMovieName);
            panel.Controls.Add(lblRoomNumber);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(btnBookNow);
            panel.Controls.Add(pbPhoto);

            //goleminata da se menuva
            lblMovieName.AutoSize = true;
            lblMovieGenreDration.AutoSize = true;
            lblRoomNumber.AutoSize = true;
            lblTime.AutoSize = true;
            
            //dimenzii na slikata
            pbPhoto.Width = 80;
            pbPhoto.Height = 110;
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            //inicijalizacija na tekst vo labelite
            lblMovieName.Text = MovieName;
            lblMovieGenreDration.Text = MovieGenre + " | " + Duration.ToString() + " minutes";      
            lblRoomNumber.Text = "Room: " + RoomNumber.ToString();
            lblTime.Text = Time;
            btnBookNow.Text = "BOOK NOW";
            pbPhoto.Image = Photo;

            //postavuvanje na lokacijata na labelite i kopcinjata za sekoj item
            lblMovieName.Location = new Point(110, distance);
            lblMovieGenreDration.Location = new Point(110, distance + 30);
            lblRoomNumber.Location = new Point(280, distance + 5);
            lblTime.Location = new Point(400, distance + 5);
            btnBookNow.Location = new Point(500, distance + 5);
            pbPhoto.Location = new Point(10, distance);

            //detali za labelite
            lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline | FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //eventi za labelite i kopcinjata
            this.lblMovieName.Click += new System.EventHandler(this.lblMovieName_Click);
            this.lblMovieName.MouseEnter += new System.EventHandler(this.lblMovieName_MouseEnter);
            this.lblMovieName.MouseLeave += new System.EventHandler(this.lblMovieName_MouseLeave);
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            this.btnBookNow.MouseEnter += new System.EventHandler(this.btnBookNow_Enter);
            this.btnBookNow.MouseLeave += new System.EventHandler(this.btnBookNow_Leave);
            this.pbPhoto.Click += new System.EventHandler(this.lblMovieName_Click);
            this.pbPhoto.MouseEnter += new System.EventHandler(this.btnBookNow_Enter);
            this.pbPhoto.MouseLeave += new System.EventHandler(this.btnBookNow_Leave);
        }

        private void lblMovieName_Click(object sender, EventArgs e) {
            MovieDetails newMovieDetailsForm = new MovieDetails(lblMovieName.Text, Photo, conn);
            newMovieDetailsForm.Show();
        }

        private void lblMovieName_MouseEnter(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Hand;
        }

        private void lblMovieName_MouseLeave(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Arrow;
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            if (CustomerId >= 0)
            {
                MakeReservation MakeReservationForm = new MakeReservation(CustomerId, ShowId, conn);
                MakeReservationForm.Show();
            }
            else {
                MessageBox.Show("You have to login first!");
                LogIn LogInForm = new LogIn(conn, ShowId);
                LogInForm.Show();
            }
        }

        private void btnBookNow_Enter(object sender, EventArgs e) {
            panel.Cursor = Cursors.Hand;
        }

        private void btnBookNow_Leave(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Arrow;
        }
    }
}
