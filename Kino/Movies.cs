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
    public partial class Movies : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public Movies(OracleConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
            da = new OracleDataAdapter();
            dt = new DataTable();
            selectCommand("SELECT * FROM MOVIES");
            cbOrderBy.SelectedIndex = 0;
            
        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Year = "2013";
            if ((tbYear.Text.Trim().Length != 0) && (tbGenre.Text.Trim().Length != 0))
            {
                Year = tbYear.Text;
                string OrderBy = cbOrderBy.Items[cbOrderBy.SelectedIndex].ToString() ;
                string Genre = tbGenre.Text;
               
                selectCommand("SELECT * FROM MOVIES WHERE YEAR=" + Year + " AND GENRE='" + Genre + "' ORDER BY " + OrderBy);
            }
            
        }
        private void selectCommand(string query) {
            try
            {
                lbMovies.Items.Clear();
                da.SelectCommand = new OracleCommand(query, conn);
                dt = new DataTable();
                da.Fill(dt);
                for(int i=0;i<dt.Rows.Count;i++){
                    Movie m = new Movie(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString(), dt.Rows[i][2].ToString(), dt.Rows[i][3].ToString(), dt.Rows[i][4].ToString(), dt.Rows[i][5].ToString());
                    lbMovies.Items.Add(m);
                    }
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }
        }
    }
}
