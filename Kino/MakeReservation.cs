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

//// ова е од страната на корисникот!
namespace Kino
{
    public partial class MakeReservation : Form
    {
        OracleConnection conn;
        DataTable dt;
        OracleDataAdapter da;
        NewReservationContent Content;
        public int ShowId { get; set; }
        public int CustomerId { get; set; }
        public int RoomNumber { get; set; }

        
            
        public MakeReservation(int CustomerId, int ShowId, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.CustomerId = CustomerId;
            this.ShowId = ShowId;

            //Content = new NewReservationContent(this, conn, this.lbAvailableSeats);

         //   this.RoomNumber = RoomNumber;
          //  Content = new NewReservationContent(this, conn, this.lbAvailableSeats);/////ОВА ФУНКЦИОНИРАШЕ ПОРАНО СО ЛИСТБОКС. НЕЈЌЕ ПОЈЌЕ :S

        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
           // Content.FillAvailableSeats(this.lblTest);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tbTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbNumberSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void A1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
          da = new OracleDataAdapter();
          dt = new DataTable();
          int SeatNum;
          string Query = @"SELECT ROOMNUMBER,SEATNUMBER 
                           FROM SEATS WHERE ROOMNUMBER=" + RoomNumber + @" 
                           AND SEATNUMBER=(SELECT SEATNUMBER FROM SEATS 
                           WHERE SEATID=
                                (SELECT SEATID 
                                FROM (SELECT SEATID,COUNT (*) COUNT 
                                    FROM (SELECT SEATID FROM TICKETS 
                                    WHERE SEATID IN
                                        (SELECT SEATID FROM SEATS 
                                        WHERE ROOMNUMBER=" + RoomNumber.ToString() + @")) 
                                        GROUP BY SEATID)a 
                                    WHERE a.COUNT=(SELECT MAX(COUNT) 
                                        FROM (SELECT SEATID,COUNT (*) COUNT 
                                               FROM (SELECT SEATID FROM TICKETS 
                                               WHERE SEATID IN(SELECT SEATID FROM SEATS 
                                                    WHERE ROOMNUMBER=" + RoomNumber.ToString() + @")) GROUP BY SEATID))))";
          try
          {
              da.SelectCommand = new OracleCommand(Query, conn);
              da.Fill(dt);
          }
          catch (OracleException ex) { MessageBox.Show(ex.Message); }
          SeatNum = Convert.ToInt16(dt.Rows[0][0]);
          label1.Text = SeatNum.ToString();

        }
    }
}
