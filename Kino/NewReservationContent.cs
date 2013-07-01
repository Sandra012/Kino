﻿using System;
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
    class NewReservationContent
    {
        MakeReservation MainForm;
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public string QueryAvailableSeats { get; set; }
        ListBox lbAvailable { get; set; }
        List<Button> seats;

        public NewReservationContent(MakeReservation Form, OracleConnection conn, ListBox lb) {
            this.MainForm = Form;
            this.conn = conn;
            da = new OracleDataAdapter();
            dt = new DataTable();
            this.lbAvailable = lb;
            seats = new List<Button>();
            this.QueryAvailableSeats = @"SELECT DISTINCT SE.SEATID, SE.SEATNUMBER
                                        FROM SEATS SE, SHOWS SH, MOVIES M, SCREENINGROOMS SR
                                        WHERE SH.ROOMNUMBER = SR.ROOMNUMBER AND SE.ROOMNUMBER = SR.ROOMNUMBER AND SH.SHOWID = " + MainForm.ShowId.ToString() + @" AND SE.SEATID NOT IN
                                        (SELECT SE.SEATID
                                        FROM SEATS SE, SHOWS SH, MOVIES M, SCREENINGROOMS SR, TICKETS T
                                        WHERE SH.SHOWID = " + MainForm.ShowId.ToString() + @" AND SH.ROOMNUMBER = SR.ROOMNUMBER AND SE.ROOMNUMBER = SR.ROOMNUMBER AND SE.SEATID = T.SEATID AND T.SHOWID = SH.SHOWID) 
                                        ORDER BY SEATNUMBER";
            
        }

        public void FillAvailableSeats(Label lbl) {
            da.SelectCommand = new OracleCommand(QueryAvailableSeats, conn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                //lbAvailable.Items.Add(dr[1].ToString());
                MainForm.gbSeats.Controls.Find(dr[1].ToString(), true)[1].BackColor = Color.Red;
            }
            lbl.Text = MainForm.ShowId.ToString();
            lbAvailable.Invalidate(true);
        }
    }
}
