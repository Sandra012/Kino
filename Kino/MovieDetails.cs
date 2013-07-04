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
    public partial class MovieDetails : Form
    {
        public string MovieName { get; set; }
        OracleConnection conn;
        DataTable dtMovieDetails;
        DataTable dtActors;
        DataTable dtActresses;
        DataTable dtDirector;
        DataTable dtWriter;
        DataTable dtMovieId;
        DataTable dtRating;
        OracleDataAdapter da;

        public string QueryMovieDetails { get; set; }
        public string QueryRoles { get; set; }
        public int MovieId { get; set; }
        public decimal Rating { get; set; }

        public MovieDetails(string MovieName, Bitmap photo, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.MovieName = MovieName;
            
            QueryMovieDetails = "SELECT * FROM MOVIES WHERE MOVIENAME = '" + MovieName + "'";
            QueryRoles = "SELECT FIRSTNAME, LASTNAME FROM MOVIES M, ROLES R, ROLETYPES RT, PERSONS P WHERE M.MOVIENAME = '" + this.MovieName +"' AND R.MOVIEID = M.MOVIEID AND R.TYPEID = RT.TYPEID AND R.PERSONID = P.PERSONID AND RT.TYPE = ";
            da = new OracleDataAdapter();
            dtMovieDetails = new DataTable();
            dtActors = new DataTable();
            dtActresses = new DataTable();
            dtDirector = new DataTable();
            dtWriter = new DataTable();
            dtMovieId = new DataTable();
            dtRating = new DataTable();

            //slikata
            pbPhoto.Image = photo;
            pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;

            da.SelectCommand = new OracleCommand(QueryMovieDetails, conn);
            da.Fill(dtMovieDetails);
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryRoles + "'Actor'", conn);
            da.Fill(dtActors);
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryRoles + "'Actress'", conn);
            da.Fill(dtActresses);
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryRoles + "'Director'", conn);
            da.Fill(dtDirector);
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryRoles + "'Writer'", conn);
            da.Fill(dtWriter);

            MovieId = GetMovieId();
            Rating = CalculateRating();
            FillLabels();    
        }

        public void FillLabels() { 
            lbMovieName.Text = this.MovieName;

            tbDuration.Text = dtMovieDetails.Rows[0][2].ToString();
            tbYear.Text = dtMovieDetails.Rows[0][3].ToString();
            tbGenre.Text = dtMovieDetails.Rows[0][4].ToString();
            tbRating.Text = Rating.ToString();
        
            foreach(DataRow dr in dtActors.Rows){
                tbActors.Text += dr[0].ToString() + " " + dr[1].ToString() + "; ";
            }

            foreach(DataRow dr in dtActresses.Rows){
                tbActresses.Text += dr[0].ToString() + " " + dr[1].ToString() + "; ";
            }

            foreach(DataRow dr in dtDirector.Rows){
                tbDirector.Text += dr[0].ToString() + " " + dr[1].ToString() + "; ";
            }

            foreach(DataRow dr in dtWriter.Rows){
                tbWriter.Text += dr[0].ToString() + " " + dr[1].ToString() + "; ";
            }
        }
        
        /*private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (tbAddRating.Text.Trim().Length > 0) {
                int rating = 0;
                int.TryParse(tbAddRating.Text, out rating);
                //боље да нема оценување од страна на клиентите зашто требаше да биде листа од рејтинзи полето рејтинг некако во базата. Вака нема како да го рачунаме :S
            }
        }*/
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        public int GetMovieId() {
            String Query = "SELECT MOVIEID FROM MOVIES WHERE MOVIENAME = '" + MovieName.Trim() + "'";
            da.SelectCommand = new OracleCommand(Query, conn);
            da.Fill(dtMovieId);
            return Convert.ToInt16(dtMovieId.Rows[0][0].ToString().Trim());
        }

        public decimal CalculateRating() {
            //presmetaj go prosekot od rejtinzite za filmot sekogas koga nekoj ke glasa
            String Query = "SELECT CAST(AVG(RATING) AS DECIMAL (5, 2)) FROM RATINGS WHERE MOVIEID = " + MovieId;
            da.SelectCommand = new OracleCommand(Query, conn);
            dtRating.Dispose();
            dtRating = new DataTable();
            da.Fill(dtRating);
            if (dtRating.Rows.Count > 0)
                return Convert.ToDecimal(dtRating.Rows[0][0].ToString().Trim());
            else
                return 5;
        }

        public void RateMovie(int rating) {
            //vnesi podatoci za rating vo bazata
            string NewBookingQuery = "INSERT INTO RATINGS VALUES(" + rating.ToString() + ", " + MovieId.ToString() + ", SYSDATE)";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = NewBookingQuery;
            int check = cmd.ExecuteNonQuery();
           
            //iskluci gi site radio buttons za da ne moze da glasa povtorno
            DisableAllButtons();

            Rating = CalculateRating();
            tbRating.Text = Rating.ToString();
        }

        //kako gi pravam disable ovie so eden for znaci..
        public void DisableAllButtons() {
            for (int i = 1; i <= 10; i++) {
                this.Controls.Find("radioButton" + i.ToString(), true)[0].Enabled = false;
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(2);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(3);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(4);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(6);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(7);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(8);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(9);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RateMovie(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
