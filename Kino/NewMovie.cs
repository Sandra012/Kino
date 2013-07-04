using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Kino
{
    public partial class NewMovie : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public string Query { get; set; }
        public string MovieTitle{get;set;}
        public string Genre{get;set;}
        public long Duration { get; set; }
        public long Year { get; set; }
        public decimal Rating { get; set; }
        public string Actors { get; set; }
        public string Actresses { get;set;}
        public string Director{get;set;}
        public string Writer{get;set;}
        public readonly int actorsType = 1;
        public readonly int directorType = 2;
        public readonly int producerType = 3;
        public readonly int writerType = 4;
        public readonly int actressType = 5;
     
        
        public NewMovie(OracleConnection conn)
        {
            this.conn=conn;
            da=new OracleDataAdapter();
           
            InitializeComponent();

          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((tbMovieTitle.Text.Trim() == "") || (tbActors.Text.Trim() == "") || (tbActresses.Text.Trim() == "") || (tbDirector.Text.Trim() == "") || (tbDuration.Text.Trim() == "") || (tbGenre.Text.Trim() == "") || (tbWriter.Text.Trim() == "") || (tbYear.Text.Trim() == "") || (tbRating.Text.Trim() == ""))
            {
                MessageBox.Show("Внесете податоци во секое поле"); return;
            }
            else
            {
                MovieTitle = tbMovieTitle.Text;
                Genre = tbGenre.Text;
                Duration = (long)Convert.ToInt64(tbDuration.Text);
                Year = (long)Convert.ToInt64(tbYear.Text);
                Rating = Convert.ToDecimal(tbRating.Text);
                Actors = tbActors.Text;
                Actresses = tbActresses.Text;
                Director = tbDirector.Text;
                Writer = tbWriter.Text;

                int movieId = nextId("MOVIEID", "MOVIES");
                Query = "INSERT INTO MOVIES VALUES (nextmovieid.nextval, '" + MovieTitle + "'," + Duration + "," + Year + ",'" + Genre + ")";
                insertInto(Query);
                insertDataCast(tbActors.Text, actorsType, movieId);
                insertDataCast(tbActresses.Text, actressType, movieId);
                insertDataCast(tbDirector.Text, directorType, movieId);
                insertDataCast(tbWriter.Text, writerType, movieId);
                MessageBox.Show("Успешна регистрација!");
                tbMovieTitle.Text = "";
                tbActors.Text = "";
                tbActresses.Text = "";
                tbDirector.Text = "";
                tbDuration.Text = "";
                tbGenre.Text = "";
                tbWriter.Text = "";
                tbYear.Text = "";
                tbRating.Text = "";

            }
           

           
        }
        public void RateMovie(int rating)
        {
            //vnesi podatoci za rating vo bazata
            string NewBookingQuery = "INSERT INTO RATINGS VALUES(" + rating.ToString() + ", " + MovieId.ToString() + ", SYSDATE)";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = NewBookingQuery;
            int check = cmd.ExecuteNonQuery();

            //iskluci gi site radio buttons za da ne moze da glasa povtorno
            
        }
        int nextId(string ID, string Table){
            dt = new DataTable();
            try
            {
                da.SelectCommand = new OracleCommand("SELECT MAX(" + ID + ") FROM " + Table, conn);
                da.Fill(dt);
            }
            catch(OracleException ex) {
                MessageBox.Show(ex.Message);
            }
            int nextId = Convert.ToInt16(dt.Rows[0][0]) + 1;
            return nextId;
        }
        void insertInto(string Query) {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = Query;
            try
            {
                int check = cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            // if (check == 0) MessageBox.Show("Nishtooo");
            // else MessageBox.Show("top!");
        }
        void insertDataCast(string Query, int typeId,int movieId) {
            string[] nameParts = Query.Split(',');
            foreach (string name in nameParts)
            {
                int personId = nextId("PERSONID", "PERSONS");
                string[] nameSurname = name.Trim().Split(new char[] {' '},2);
                dt = new DataTable();

                try
                {
                    da.SelectCommand = new OracleCommand("SELECT PERSONID FROM PERSONS WHERE UPPER(FIRSTNAME)=UPPER('" + nameSurname[0] + "') AND UPPER(LASTNAME)=UPPER('" + nameSurname[1] + "')", conn);
                    da.Fill(dt);
                    label9.Text = dt.Rows[0][0].ToString();

                }
                catch (IndexOutOfRangeException ex)
                {
                    // MessageBox.Show(ex.Message);
                    insertInto("INSERT INTO PERSONS VALUES(PERSONSSEQUENCE.nextval,'" + nameSurname[0] + "','" + nameSurname[1] + "')");
                    da.SelectCommand = new OracleCommand("SELECT PERSONID FROM PERSONS WHERE UPPER(FIRSTNAME)=UPPER('" + nameSurname[0] + "') AND UPPER(LASTNAME)=UPPER('" + nameSurname[1] + "')", conn);
                    da.Fill(dt);
                    label9.Text = dt.Rows[0][0].ToString();
                }
                
                personId = Convert.ToInt16(dt.Rows[0][0]);
                insertInto("INSERT INTO ROLES VALUES(" + movieId + "," + typeId + "," + personId + ")");



            }
        }

        private void NewMovie_Enter(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
