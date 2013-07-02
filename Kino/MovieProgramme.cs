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
    public partial class MovieProgramme : Form
    {
        OracleConnection conn;
        public string ChosenDate { get; set; }
        ProgramContent ProgramContent;
        public int CustomerId { get; set; }

        public MovieProgramme(OracleConnection conn, int CustomerId)
        {
            InitializeComponent();
            this.conn = conn;
            ChosenDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            label1.Text = ChosenDate;
            this.CustomerId = CustomerId;
            ProgramContent = new ProgramContent(conn, ChosenDate, CustomerId);
        }

        private void MovieProgramme_Load(object sender, EventArgs e)
        {
            ProgramContent.Draw(this.panel1);
            this.Size = new Size(panel1.Size.Width, panel1.Size.Height + 50);
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
    }
}