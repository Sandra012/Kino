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
    public partial class MovieProgramme : Form
    {
        OracleConnection conn;
        public string ChosenDate { get; set; }
        public string CustomerName { get; set; }
        ProgramContent ProgramContent;
        public int CustomerId { get; set; }
        RecommendedMovie RecommendedMovie1;

        public MovieProgramme(OracleConnection conn, int CustomerId)
        {
            InitializeComponent();
            this.conn = conn;
            ChosenDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            this.CustomerId = CustomerId;
            ProgramContent = new ProgramContent(conn, ChosenDate, CustomerId);
            CustomerName = ProgramContent.GetCustomerName(CustomerId);
            SetLoginLabel();
        }

        private void MovieProgramme_Load(object sender, EventArgs e)
        {
            ProgramContent.Draw(this.panel1);
            this.Size = new Size(panel1.Size.Width, panel1.Size.Height + 50);
            RecommendedMovie1 = new RecommendedMovie(CustomerId, panelReccomend, tbMovieName, conn);
            RecommendedMovie1.Draw();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ChosenDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            ProgramContent = new ProgramContent(conn, ChosenDate, CustomerId);
            ProgramContent.Draw(this.panel1);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;

        }

        private void MovieProgramme_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void SetLoginLabel() {
            CustomerName = ProgramContent.GetCustomerName(CustomerId);
            if (CustomerName != null)
            {
                lblLoggedIn.Text += CustomerName;
            }
            else {
                lblLoggedIn.Visible = false;
                lblLogout.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLoggedIn_Click(object sender, EventArgs e)
        {

        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            CustomerId = -1;
            SetLoginLabel();
        }

        private void lblLogout_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
