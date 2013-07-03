using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.Web;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Kino
{
    public partial class Customers : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        DataTable dtOverAverage;
        DataTable dtFavouriteActors;
        private string QueryAll { get; set; }
        private string QueryOverAverage { get; set; }
        private string QueryFavouriteActors { get; set; }

        public Customers(OracleConnection conn)
        {     
            InitializeComponent();
            this.conn = conn;
            ShowAll();
            btnFavouriteActors.BringToFront();
        }
        private void selectCommand(string query) {
            try
            {
                da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand(query, conn);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }

        }

        private void dgwCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgwCustomers.RowHeadersDefaultCellStyle.BackColor = Color.Wheat;
            for (int i=0;i<dgwCustomers.Rows.Count;i++)
            {

                if (i % 2 == 0)
                    dgwCustomers.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                else {
                    dgwCustomers.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }

        public void ShowAll() {
            QueryAll = "SELECT customerid as \"ID\", firstname as \"Name\",lastname as \"Last Name\", telnumber as \"Number\", email as \"Email\", username as \"Username\", Password as \"Password\", TYPE as \"Type\" FROM CUSTOMERS";
            selectCommand(QueryAll);
            dgwCustomers.DataSource = dt;
        }

        public void ShowOverAverage() {
            QueryOverAverage = @"SELECT *
FROM CUSTOMERS
WHERE CUSTOMERID IN (SELECT CUSTOMERID FROM (SELECT CUSTOMERID, SUM(TOTALPRICE) SUM FROM BOOKINGS GROUP BY CUSTOMERID) A
WHERE A.SUM > (SELECT AVG(TOTALPRICE) FROM BOOKINGS))";
            da.SelectCommand = new OracleCommand(QueryOverAverage, conn);
            dtOverAverage = new DataTable();
            da.Fill(dtOverAverage);
            dgwCustomers.DataSource = dtOverAverage;
        }

        private void rbOverAverage_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbAll_MouseClick(object sender, MouseEventArgs e)
        {
            ShowAll();
        }

        private void rbOverAverage_MouseClick(object sender, MouseEventArgs e)
        {
            ShowOverAverage();
        }

        private void rbFirstName_Click(object sender, EventArgs e)
        {
            dgwCustomers.Sort(dgwCustomers.Columns[3], ListSortDirection.Ascending);
        }

        private void rbLastName_MouseClick(object sender, MouseEventArgs e)
        {
            dgwCustomers.Sort(dgwCustomers.Columns[0], ListSortDirection.Ascending);
        }

        private void rbID_MouseClick(object sender, MouseEventArgs e)
        {
            dgwCustomers.Sort(dgwCustomers.Columns[2], ListSortDirection.Ascending);

        }

        private void btnFavouriteActors_Click(object sender, EventArgs e)
        {
            QueryFavouriteActors = @"SELECT C.FIRSTNAME || ' ' || C.LASTNAME as CUSTOMER, P.FIRSTNAME || ' ' || P.LASTNAME AS ACTOR
FROM CUSTOMERS C, PERSONS P,
(SELECT A.CUSTOMERID, A.PERSONID
FROM (SELECT CUSTOMERS.CUSTOMERID, PERSONID, COUNT(PERSONID) COUNT
FROM ROLES, SHOWS, TICKETS, BOOKINGS, CUSTOMERS
WHERE TYPEID = (SELECT TYPEID 
FROM ROLETYPES
WHERE TYPE = 'Actor') 
AND ROLES.MOVIEID = SHOWS.MOVIEID
AND TICKETS.SHOWID = SHOWS.SHOWID
AND BOOKINGS.BOOKINGID = TICKETS.BOOKINGID
AND BOOKINGS.CUSTOMERID = CUSTOMERS.CUSTOMERID
GROUP BY CUSTOMERS.CUSTOMERID, PERSONID) A,
(SELECT CUSTOMERID, MAX(COUNT) COUNT
FROM (SELECT CUSTOMERS.CUSTOMERID CUSTOMERID, PERSONID, COUNT(PERSONID) COUNT
FROM ROLES, SHOWS, TICKETS, BOOKINGS, CUSTOMERS
WHERE TYPEID = (SELECT TYPEID 
FROM ROLETYPES
WHERE TYPE = 'Actor') 
AND ROLES.MOVIEID = SHOWS.MOVIEID
AND TICKETS.SHOWID = SHOWS.SHOWID
AND BOOKINGS.BOOKINGID = TICKETS.BOOKINGID
AND BOOKINGS.CUSTOMERID = CUSTOMERS.CUSTOMERID
GROUP BY CUSTOMERS.CUSTOMERID, PERSONID)
GROUP BY CUSTOMERID) B
WHERE
A.CUSTOMERID = B.CUSTOMERID AND A.COUNT = B.COUNT) A
WHERE
A.CUSTOMERID = C.CUSTOMERID AND A.PERSONID = P.PERSONID
ORDER BY C.CUSTOMERID";

            da.SelectCommand = new OracleCommand(QueryFavouriteActors, conn);
            dtFavouriteActors = new DataTable();
            try
            {
                da.Fill(dtFavouriteActors);
            }
            catch (OracleException ex) {
                MessageBox.Show(ex.Message);
            }
            dgwCustomers.DataSource = dtFavouriteActors;
        }

        private void dgwCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
