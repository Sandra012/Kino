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
    public partial class NewShow : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public string Query;
        public int Roomnumber;
        public int MovieId;
        public string Date;
        public string Time;

        public NewShow(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void tbMovie_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRoom_TextChanged(object sender, EventArgs e)
        {

        }
        void insertInto(string Query)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = Query;
            try
            {
                int check = cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted  show.");///////////OD IZBRISHI GI POSLE
              //  tbDate.Clear();
              //  tbMovie.Clear();
              //  tbRoom.Clear();
              //  tbTime.Clear();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }
        private string selectCommand(string query)
        {
            try
            {
                da = new OracleDataAdapter();
                da.SelectCommand = new OracleCommand(query, conn);
                dt = new DataTable();
                
                da.Fill(dt);
                string id="";
                try
                {
                    id = dt.Rows[0][0].ToString();
                }
                catch (IndexOutOfRangeException ex) { MessageBox.Show(ex.Message); }
                return id;
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); return null; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MovieName = tbMovie.Text;
            da = new OracleDataAdapter();
            Query = "SELECT MOVIEID FROM MOVIES WHERE MOVIENAME='" + MovieName + "'";
            string MovieIdStr = selectCommand(Query);
            MovieId = Convert.ToInt32(MovieIdStr);
            string RoomNumstr = tbRoom.Text.Trim();
        
            try
            {
                Roomnumber = Convert.ToInt16(RoomNumstr);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            Date = tbDate.Text;
            Time = tbTime.Text;
            Query="INSERT INTO SHOWS VALUES(SHOWSEQUENCE.Nextval,'"+Date +"','"+Time+"',"+MovieId+","+Roomnumber+")";
            insertInto(Query);
         //   conn.Close();//OD IZBRISHI GI POSLEEEEEEEEEEEEEEE
         //   this.Close();
        }
    }
}
