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

        public Label lblMovieName { get; set; }
        public Label lblMovieGenreDration { get; set; }
        public Label lblTime { get; set; }
        public Label lblRoomNumber { get; set; }
        public Button btnBookNow { get; set; }

        public Panel panel;

        public ProgramItem(DataRow dr, OracleConnection conn, int CustomerId) {
            MovieName = dr[0].ToString();
            MovieGenre = dr[1].ToString();
            Duration = Convert.ToInt32(dr[2]);
            RoomNumber = Convert.ToInt16(dr[3]);
            Time = dr[4].ToString();
            if (Time.Length == 4)
                Time += "0";
            
            lblMovieGenreDration = new Label();
            lblMovieName = new Label();
            lblRoomNumber = new Label();
            lblTime = new Label();
            btnBookNow = new Button();

            ShowId = Convert.ToInt16(dr[5]);
            this.conn = conn;
            this.CustomerId = CustomerId;
        }

        public void Draw(Panel panel, int distance) {
            this.panel = panel;

            panel.Controls.Add(lblMovieGenreDration);
            panel.Controls.Add(lblMovieName);
            panel.Controls.Add(lblRoomNumber);
            panel.Controls.Add(lblTime);
            panel.Controls.Add(btnBookNow);

            lblMovieName.AutoSize = true;
            lblMovieGenreDration.AutoSize = true;
            lblRoomNumber.AutoSize = true;
            lblTime.AutoSize = true;

            lblMovieName.Text = MovieName;
            lblMovieGenreDration.Text = MovieGenre + " | " + Duration.ToString() + " minutes";      
            lblRoomNumber.Text = "Room: " + RoomNumber.ToString();
            lblTime.Text = Time;
            btnBookNow.Text = "BOOK NOW";

            lblMovieName.Location = new Point(10, distance);
            lblMovieGenreDration.Location = new Point(10, distance + 30);
            lblRoomNumber.Location = new Point(190, distance + 5);
            lblTime.Location = new Point(300, distance + 5);
            btnBookNow.Location = new Point(400, distance + 5);

            lblMovieName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline | FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblMovieName.Click += new System.EventHandler(this.lblMovieName_Click);
            this.lblMovieName.MouseEnter += new System.EventHandler(this.lblMovieName_MouseEnter);
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
        }



        private void lblMovieName_Click(object sender, EventArgs e) {
            MovieDetails newMovieDetailsForm = new MovieDetails(lblMovieName.Text, conn);
            newMovieDetailsForm.Show();
        }

        private void lblMovieName_MouseEnter(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Hand;
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
    }
}
