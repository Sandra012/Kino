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
    public partial class LogIn : Form
    {
        OracleConnection conn;
        public int ShowId { get; set; }

        public LogIn(OracleConnection conn, int ShowId)
        {
            InitializeComponent();
            this.conn = conn;
            this.ShowId = ShowId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginValidator LogVal = new LoginValidator(tbUsername.Text, tbPass.Text, conn);
            int CustomerId = LogVal.ValidateLogin();
            if (CustomerId >= 0)
            {
                DialogResult dr = MessageBox.Show("Successful login as Customer!", "Success!", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    MakeReservation MakeReservationForm = new MakeReservation(CustomerId, ShowId, conn);
                    MakeReservationForm.Show();
                }
            }
            else {
                MessageBox.Show("Invalid username or password. Try again.", "Login failed!");
                tbPass.Clear();
                tbUsername.Clear();
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //formata e gotova
        }
    }
}
