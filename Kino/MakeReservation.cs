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
    public partial class MakeReservation : Form
    {
        OracleConnection conn;
        DataTable dt;
        DataTable dtDayWeek;
        OracleDataAdapter da;
        NewReservationContent Content;
        
        public int ShowId { get; set; }
        public int CustomerId { get; set; }
        public int RoomNumber { get; set; }

        public int Price { get; set; }
        public int DayOfTheWeek { get; set; }

        private int NumberSeats { get; set; } //kolku sedista saka da rezervira
        private List<Button> Selected { get; set; } //rezervirani sedista
            
        public MakeReservation(int CustomerId, int ShowId, OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            this.CustomerId = CustomerId;
            this.ShowId = ShowId;
            Content = new NewReservationContent(this, conn);
            da = new OracleDataAdapter();
            dt = new DataTable();
            dtDayWeek = new DataTable();
            
            NumberSeats = Convert.ToInt16(tbNumberSeats.Text);
            Selected = new List<Button>();

            DayOfTheWeek = GetDay();
            if (DayOfTheWeek == 2 || DayOfTheWeek == 4)
                Price = 160;
            else if (DayOfTheWeek == 1 || DayOfTheWeek == 3)
                Price = 190;
            else
                Price = 210;

            tbTotalPrice.Text = (NumberSeats * Price).ToString();
        }

        private void MakeReservation_Load(object sender, EventArgs e)
        {
            Content.FillAvailableSeats();
        }


        private void btnContinue_Click(object sender, EventArgs e)
        {
          /*da = new OracleDataAdapter();
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
          label1.Text = SeatNum.ToString();*/

            BookingDetails BookingDetails1 = new BookingDetails(ShowId, CustomerId, Selected, Price, RoomNumber, conn);
            BookingDetails1.Show();
            this.Close();
        }

        public void ReserveSeat(object sender) {
            Button seat = sender as Button;
            if (Selected.Count < NumberSeats && seat.BackColor == Color.CornflowerBlue) //ako sedisteto e slobodno i ako korisnikot se uste gi nema izbereno site sedista
            {
                Selected.Add(seat);
                seat.BackColor = Color.LightGreen;
            }
            else if (seat.BackColor == Color.LightGreen) { //ako veke go izbral i se predomislil
                Selected.Remove(seat);
                seat.BackColor = Color.CornflowerBlue;
            }
        }

        private void A1_Click_1(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void tbNumberSeats_TextChanged(object sender, EventArgs e)
        {
            NumberSeats = Convert.ToInt16(tbNumberSeats.Text);
            tbTotalPrice.Text = (NumberSeats * Price).ToString();
        }

        public int GetDay() {
            string Query = @"SELECT TO_CHAR(DATUM, 'D') D
                           FROM SHOWS
                           WHERE SHOWID = " + ShowId.ToString();
            da.SelectCommand = new OracleCommand(Query, conn);
            da.Fill(dtDayWeek);
            return Convert.ToInt16(dtDayWeek.Rows[0][0]);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void B6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void D6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void E1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void E2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void E3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void E4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);   
        }

        private void E5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void E6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void F1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void F2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);    
        }

        private void F3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);    
        }

        private void F4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);    
        }

        private void F5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void F6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void G6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void H1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void H2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);    
        }

        private void H3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void H4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void H5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void H6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void I6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void J1_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void J2_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void J3_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void J4_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void J5_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);    
        }

        private void J6_Click(object sender, EventArgs e)
        {
            ReserveSeat(sender);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
