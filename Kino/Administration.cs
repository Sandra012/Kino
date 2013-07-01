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
    public partial class Administration : Form
    {
        OracleConnection conn;

        public Administration(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            Customers form = new Customers(conn);
            form.Show();
        }

        private void btnAddNewMovie_Click(object sender, EventArgs e)
        {
            NewMovie form = new NewMovie(conn);
            form.Show();
        }

        private void btnAddNewShow_Click(object sender, EventArgs e)
        {
            NewShow form = new NewShow(conn);
            form.Show();
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            Bookings form = new Bookings(conn);
            form.Show();
        }

        // Мислам дека нема потреба од додавање нова сала, бидејќи каде побогу после градењето на киното, си видел да си додаваат уште по некоја саличка како им текне? а и доста се 4 screeningrooms мислам? м?
    }
}
