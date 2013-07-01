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
        OracleDataAdapter da;
        public string QueryMovieDetails { get; set; }
        public string QueryRoles { get; set; }

        public MovieDetails(string MovieName, OracleConnection conn)
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
            
            FillLabels();    
        }

        public void FillLabels() { 
            lbMovieName.Text = this.MovieName;

            tbDuration.Text = dtMovieDetails.Rows[0][2].ToString();
            tbYear.Text = dtMovieDetails.Rows[0][3].ToString();
            tbGenre.Text = dtMovieDetails.Rows[0][4].ToString();
            tbRating.Text = dtMovieDetails.Rows[0][5].ToString();
        
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
        private void btnAddRating_Click(object sender, EventArgs e)
        {
            if (tbAddRating.Text.Trim().Length > 0) {
                int rating = 0;
                int.TryParse(tbAddRating.Text, out rating);
                //боље да нема оценување од страна на клиентите зашто требаше да биде листа од рејтинзи полето рејтинг некако во базата. Вака нема како да го рачунаме :S
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
