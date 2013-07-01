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
using System.Configuration;

namespace Kino
{
    public partial class ProbaTabeli : Form
    {
        public ProbaTabeli()
        {
            InitializeComponent();
        }

        private void ProbaTabeli_Load(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(" User Id=DBA_20122013L_GRP_037 ;Password=5593940;Data Source=localhost:1521/ORCL");
                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand("SELECT M.MOVIENAME, M.GENRE, M.DURATION, SR.ROOMNUMBER, (EXTRACT(HOUR FROM TIME) || ':' || EXTRACT(MINUTE FROM TIME)) as \"TIME\" FROM MOVIES M, SHOWS SH, SCREENINGROOMS SR WHERE M.MOVIEID = SH.MOVIEID AND SH.ROOMNUMBER = SR.ROOMNUMBER AND TO_DATE(DATUM) =  TO_DATE('05-26-2013','MM-DD-YYYY')", conn);
                //da.SelectCommand = new OracleCommand("select * from shows where TO_DATE(DATUM) =  TO_DATE('05/26/2013','MM/DD/YYYY')", conn);
                
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                table.DataSource = dt;
                label1.Text = dt.Rows[0][0].ToString();
                
                conn.Clone();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
