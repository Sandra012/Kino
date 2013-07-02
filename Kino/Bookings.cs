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
    public partial class Bookings : Form
    {
        private string DateFrom;
        private string DateTo;
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public Bookings(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dt=new DataTable();
            da=new OracleDataAdapter();
            if (mtbFrom.Text.Trim().Length != 0 && mtbTo.Text.Trim().Length != 0)
            {
                DateFrom = mtbFrom.Text;
                DateTo = mtbTo.Text;
                da.SelectCommand = new OracleCommand("SELECT DISTINCT B.BOOKINGID as \"ID\", FIRSTNAME as \"Name\", LASTNAME as \"Last name\", M.MOVIENAME as \"Movie name\", SH.TIME as \"Time\",SH.ROOMNUMBER as \"Roomnumber\", B.TOTALPRICE as \"Total price\" FROM BOOKINGS B, TICKETS T, SHOWS SH, MOVIES M, CUSTOMERS C WHERE B.BOOKINGID IN(SELECT BOOKINGID FROM TICKETS WHERE SHOWID IN (SELECT SHOWID FROM SHOWS WHERE DATUM>TO_DATE('" + DateFrom + @"','DD-MM-YYYY') AND DATUM<TO_DATE('" + DateTo + @"','DD-MM-YYYY'))) AND B.BOOKINGID=T.BOOKINGID AND T.SHOWID=SH.SHOWID AND SH.MOVIEID=M.MOVIEID AND B.CUSTOMERID=C.CUSTOMERID ORDER BY SH.TIME ",conn);
                try
                {
                    da.Fill(dt);
                }
                catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); }
                dgvBookings.DataSource = dt;
            //    for (int i = 0; i < dt.Rows.Count; i++) {
               //     Booking b = new Booking(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString(), dt.Rows[i][6].ToString());
                 //   MessageBox.Show(b.ToString());
                 //   lbBookings.Items.Add(b.ToString());}
                    
                
               

            }

        }

        private void dgvBookings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvBookings.Rows.Count; i++) {
                if (i % 2 == 0)
                {
                    dgvBookings.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);

                }
                else {
                    dgvBookings.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
            dgvBookings.BackgroundColor = Color.White;
        }

        private void Bookings_Enter(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Bookings_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void mtbTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(sender, e);
            }

        }
    }
}
