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

namespace Kino
{
    public partial class SignUp : Form
    {
        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;
        public readonly int type = 0;
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public SignUp(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
            da = new OracleDataAdapter();
           

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text.Trim() == "") || (tbPass.Text.Trim() == "") || (tbFirstName.Text.Trim() == "") || (tbLastName.Text.Trim() == "") || (tbEMail.Text.Trim() == "") || (tbTelNum.Text.Trim() == ""))
            {
                MessageBox.Show("Внесете податоци во секое поле");
            }
            else
            {
                UserName = tbUsername.Text;
                Password = tbPass.Text;
                FirstName = tbFirstName.Text;
                LastName = tbLastName.Text;
                EMail = tbEMail.Text;
                PhoneNumber = tbTelNum.Text;
                int customerId = nextId("CUSTOMERID", "CUSTOMERS");

                string Query = "INSERT INTO CUSTOMERS VALUES ('" + LastName + "','" + PhoneNumber + "',CUSTOMERSEQUENCE.nextval,'" + FirstName + "','" + EMail + "','" + UserName + "','" + Password + "'," + type + ")";
                insertInto(Query);
                tbUsername.Text = "";
                tbPass.Text = "";
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbEMail.Text = "";
                tbTelNum.Text = "";
            }

            
        }
        int nextId(string ID, string Table)
        {
            dt = new DataTable();
            try
            {
                da.SelectCommand = new OracleCommand("SELECT MAX(" + ID + ") FROM " + Table, conn);
                da.Fill(dt);
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            int nextId = Convert.ToInt16(dt.Rows[0][0]) + 1;
            return nextId;
        }
        void insertInto(string Query)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = Query;
           
            try
            {
               int check = cmd.ExecuteNonQuery();
               MessageBox.Show("Успешна регистрација!");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
             //if (check == 0) MessageBox.Show("Nishtooo");
             //else MessageBox.Show("top!");
        }

 

    }
}
