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
    class ProgramContent
    {
        OracleConnection conn;
        DataTable dt;
        DataTable dtName;
        OracleDataAdapter da;
        public string Date { get; set; }
        private List<ProgramItem> Items; 
        public string Query { get; set; }
        public int CustomerId { get; set; }


        public ProgramContent(OracleConnection conn, String ChosenDate, int CustomerId)
        {
            this.conn = conn;
            this.Date = ChosenDate;
            da = new OracleDataAdapter();
            dtName = new DataTable();
            dt = new DataTable();
            Items = new List<ProgramItem>();
            
            //site filmovi sto se prikazuvaat na toj den
            Query = "SELECT M.MOVIENAME, M.GENRE, M.DURATION, SR.ROOMNUMBER, (EXTRACT(HOUR FROM TIME) || ':' || EXTRACT(MINUTE FROM TIME)) as \"TIME\", SH.SHOWID FROM MOVIES M, SHOWS SH, SCREENINGROOMS SR WHERE M.MOVIEID = SH.MOVIEID AND SH.ROOMNUMBER = SR.ROOMNUMBER AND TO_DATE(DATUM) = TO_DATE('" + this.Date + "','MM-DD-YYYY') ORDER BY M.MOVIENAME";
            
            this.CustomerId = CustomerId;
            try
            {
                da.SelectCommand = new OracleCommand(Query, conn);
                da.Fill(dt);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataRow row in dt.Rows)
            {
                Items.Add(new ProgramItem(row, conn, CustomerId));
            }
        }

        public void Draw(Panel panel)
        {
            int distance = 10; //rastojanie od gornata granica na panelot
            foreach (ProgramItem Item in Items)
            {
                Item.Draw(panel, distance);
                distance += 120;
            }

            //panel.Invalidate();
        }

        public string GetCustomerName(int CustomerId){
            
            if (CustomerId != -1)
            {
                string Query = "SELECT FIRSTNAME || ' ' || LASTNAME FROM CUSTOMERS WHERE CUSTOMERID = " + CustomerId.ToString();
                da.SelectCommand = new OracleCommand(Query, conn);
                da.Fill(dtName);
                return dtName.Rows[0][0].ToString();
            }
            else 
            {
                this.CustomerId = CustomerId;
                foreach (ProgramItem item in Items)
                {
                    item.CustomerId = -1;
                }
                return null;
            }

        }
    }
}
