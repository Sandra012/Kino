using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino
{
    public class Booking
    {
        public string BookingNum { get; set; }
        public string CustName { get; set; }
        public string CustLasName { get; set; }
        public string MovieName { get; set; }
        public string DateTime { get; set; }
        public string RoomNum { get; set; }
        public string TotalPrice { get; set; }
        public Booking(string bookingNum, string custName, string custLastName, string movieName, string dateTime, string roomNum, string totalPrice) {
            BookingNum = bookingNum;
            CustName = custName;
            CustLasName = custLastName;
            MovieName = movieName;
            DateTime = dateTime;
            RoomNum = roomNum;
            TotalPrice = totalPrice;
            
          
        }
        public override string ToString()
        {
          //  return String.Format("{0,-50}{1,-50}{2,-50}{3,-50}{4,-50}{5,-50}{6,-50}", BookingNum, CustName, CustLasName, MovieName, DateTime, RoomNum, TotalPrice);
       //     return String.Format("%-20s %-20s %-20s %-20s %-20 %-20s %-20s", BookingNum, CustName, CustLasName, MovieName, DateTime, RoomNum, TotalPrice);
            return String.Format("{0,-50}{1,-50}{2,-50}{3,-50}", BookingNum, CustName, CustLasName, MovieName);
        
        }
        public string insertSpacesAtEnd(string input, int longest) {
            string output = input;
            int length = input.Length;
            string spaces = "";
            int numToInsert = longest - length;
            for (int i = 0; i < numToInsert; i++) {
                spaces += " ";
            }
            output += spaces;
            return output;
        }
    }
}
