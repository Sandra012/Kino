using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.Web;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;

namespace Kino
{
    public partial class Customers : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        private string Query { get; set; }
        public Customers(OracleConnection conn)
        {     
            InitializeComponent();
            this.conn = conn;
            Query = "SELECT customerid as \"ID\", firstname as \"Name\",lastname as \"Last Name\", telnumber as \"Number\", email as \"Email\", username as \"Username\", Password as \"Password\", TYPE as \"Type\" FROM CUSTOMERS";
            selectCommand(Query);
            dgwCustomers.DataSource = dt;
            conn.Close();
            
        }
        private void selectCommand(string query) {
            try
            {
                da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand(query, conn);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }

        }

        private void dgwCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgwCustomers.RowHeadersDefaultCellStyle.BackColor = Color.Wheat;
            for (int i=0;i<dgwCustomers.Rows.Count;i++)
            {

                if (i % 2 == 0)
                    dgwCustomers.Rows[i].DefaultCellStyle.BackColor = Color.LemonChiffon;
                else {
                    dgwCustomers.Rows[i].DefaultCellStyle.BackColor = Color.Wheat;
                }
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
