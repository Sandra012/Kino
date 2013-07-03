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
using System.Configuration;

namespace Kino
{
    public partial class Form1 : Form

    {
        OracleConnection conn;
        LoginValidator LogValidator;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(" User Id=DBA_20122013L_GRP_037 ;Password=5593940;Data Source=localhost:1521/ORCL");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRepertoar_Click(object sender, EventArgs e)
        {

        }

        private void btnRepertoar_Click_1(object sender, EventArgs e)
        {
            Form MovieProgrammeForm = new MovieProgramme(conn, -1); //korisnikot ne e najaven, otvori repertoar
            MovieProgrammeForm.Show();
            this.Hide(); // za da ne se otvoreni mnogu prozorci
        }

        private void btnNewMovie_Click(object sender, EventArgs e)
        {
            Form NewMovieForm = new NewMovie(conn);
            NewMovieForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form NewSignUp = new SignUp(conn);
            NewSignUp.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogValidator = new LoginValidator(tbUsername.Text, tbPassword.Text, conn);
            int CustomerId = LogValidator.ValidateLogin(); //vrakja CustomerId ako e najden ili -1 ako ne postoi takov Username/Password par

            if (CustomerId >= 0)
            { //ako e uspesno logiranjeto

                if (LogValidator.isAdmin(CustomerId))
                {  // ako e admin, otvori forma za administracija
                    DialogResult dr = MessageBox.Show("Successful login as Administrator!", "Success", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        Administration AdminForm = new Administration(conn);
                        AdminForm.Show();
                        this.Hide();
                    }
                }

                else
                {                                  //ako e korisnik, daj mu go repertoarot
                    DialogResult dr = MessageBox.Show("Successful login as Customer!", "Success!", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        MovieProgramme NewMovieProgramme = new MovieProgramme(conn, CustomerId);
                        NewMovieProgramme.Show();
                        this.Hide();
                    }
                }
            }
            else {
                MessageBox.Show("Invalid username or password. Try again.", "Login failed!");
                tbPassword.Clear();
                tbUsername.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMovie m = new NewMovie(conn);
            m.Show();
        }

        private void AddShow_Click(object sender, EventArgs e)
        {
            NewShow n = new NewShow(conn);
            n.Show();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Movies m = new Movies(conn);
            m.Show();
        }
        
    }
}

