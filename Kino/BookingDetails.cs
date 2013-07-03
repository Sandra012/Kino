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
    public partial class BookingDetails : Form
    {
        OracleConnection conn;
        DataTable dt;
        OracleDataAdapter da;
        NewReservationContent Content;

        public int ShowId { get; set; }
        public int CustomerId { get; set; }
        public List<Button> Seats { get; set; }
        public int TotalPrice { get; set; }
        public int RoomNumber { get; set; }

        public BookingDetails(int ShowId, int CustomerId, List<Button> Seats, int Price, int RoomNumber, OracleConnection conn)
        {
            InitializeComponent();
            this.ShowId = ShowId;
            this.CustomerId = CustomerId;
            this.Seats = Seats;
            this.conn = conn;
            this.TotalPrice = Seats.Count * Price;

            da = new OracleDataAdapter();
            this.RoomNumber = GetRoomNumber();
        }

        private void BookingDetails_Load(object sender, EventArgs e)
        {
            foreach (Button btn in Seats) { //smesti gi rezerviranite sedista vo ListBox
                lbSeats.Items.Add(btn.Name);
            }

            string Query = @"SELECT M.MOVIENAME, TO_CHAR(S.DATUM, 'DD-MM-YY'), (EXTRACT(HOUR FROM S.TIME) || ':' || EXTRACT(MINUTE FROM S.TIME)) AS TIME, ROOMNUMBER
                            FROM MOVIES M, SHOWS S
                            WHERE S.MOVIEID = M.MOVIEID AND SHOWID = " + ShowId.ToString(); // site detali za odredeno ShowId 
            
            try{
                da.SelectCommand = new OracleCommand(Query, conn);
                dt.Dispose();
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            String MovieName = dt.Rows[0][0].ToString();
            String Date = dt.Rows[0][1].ToString();
            String Time = dt.Rows[0][2].ToString();
            if (Time.Trim().Length < 5)
                Time += "0";
            String RoomNumber = dt.Rows[0][3].ToString();

            lblShow.Text = MovieName + "    " + Date + "    " + Time + "    " + "Room: " + RoomNumber;
            tbTotalPrice.Text = TotalPrice.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string BookingNumber = CreateNewBooking();
            CreateNewTickets(BookingNumber);
            DialogResult result = MessageBox.Show("Your booking number is " + BookingNumber + "\nYou can take your tickets at the entrance!");
            if (result == DialogResult.OK) {
                this.Close();
            }
        }

        public string CreateNewBooking() {
            //vnesi podatoci za Booking vo bazata
            string NewBookingQuery = "INSERT INTO BOOKINGS VALUES(BOOKINGSEQUENCE.NEXTVAL, " + TotalPrice + ", " + CustomerId + ")";
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = NewBookingQuery;
            try
            {
                int check = cmd.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            //najdi go i vrati go brojot na rezervacijata
            string GetBookingNumberQuery = "SELECT MAX(BOOKINGID) FROM BOOKINGS"; 
            da.SelectCommand = new OracleCommand(GetBookingNumberQuery, conn);
            dt.Dispose();
            dt = new DataTable();
            da.Fill(dt);
            string BookingNumber = dt.Rows[0][0].ToString().Trim();
            return BookingNumber;
        }

        public void CreateNewTickets(string BookingNumber) {
            foreach (Button seat in Seats) {
                int SeatId = GetSeatId(seat.Name, RoomNumber);
                String Query = "INSERT INTO TICKETS VALUES(TICKETSEQUENCE.NEXTVAL, " + (TotalPrice / Seats.Count).ToString() + ", 0, " + ShowId.ToString() + ", " + SeatId.ToString() +", " + BookingNumber + ")";
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
            }
        }

        //za daden broj na sediste i prostorija, vraka SeatId sto treba da se vnese vo Tickets
        public int GetSeatId(string SeatNumber, int RoomNumber) {
            string Query = "SELECT SEATID FROM SEATS, SCREENINGROOMS S WHERE SEATS.ROOMNUMBER = S.ROOMNUMBER AND SEATS.SEATNUMBER = '" + SeatNumber + "' AND S.ROOMNUMBER = " + RoomNumber.ToString();
            da.SelectCommand = new OracleCommand(Query, conn);
            dt.Dispose();
            dt = new DataTable();
            da.Fill(dt);
            int SeatId = Convert.ToInt16(dt.Rows[0][0].ToString().Trim());
            return SeatId;
        }

        public int GetRoomNumber() {
            String Query = "SELECT ROOMNUMBER FROM SHOWS WHERE SHOWID = " + ShowId.ToString();
            da.SelectCommand = new OracleCommand(Query, conn);
            
            dt = new DataTable();
            da.Fill(dt);
            return Convert.ToInt16(dt.Rows[0][0].ToString().Trim());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbBack_Click(object sender, EventArgs e)
        {
            MakeReservation MakeReservationForm = new MakeReservation(CustomerId, ShowId, conn);
            MakeReservationForm.Show();
            this.Close();
        }
    }
}
