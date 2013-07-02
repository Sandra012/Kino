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
    class LoginValidator
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string QueryAllCustomers { get; set; }
        public string QueryCustomerById { get; set; }
        public int CustomerId { get; set; }

        OracleConnection conn;
        OracleDataAdapter da;
        DataTable dt;

        public LoginValidator(string username, string password, OracleConnection conn)
        {
            this.Username = username;
            this.Password = password;
            this.conn = conn;
            this.QueryAllCustomers = "SELECT CUSTOMERID, USERNAME, PASSWORD FROM CUSTOMERS";
            this.QueryCustomerById = "SELECT TYPE FROM CUSTOMERS WHERE CUSTOMERID = ";
            da = new OracleDataAdapter();
            dt = new DataTable();
        }

        public int ValidateLogin() {
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryAllCustomers, conn);
            dt.Clear(); da.Fill(dt);
            foreach (DataRow dr in dt.Rows) {
                int cmp = String.Compare(dr[1].ToString(), this.Username, true);
                if (cmp == 0 && dr[2].ToString() == this.Password) {
                    return Convert.ToInt16(dr[0]);
                }
            }
            return -1;
        }

        public bool isAdmin(int CustomerId) {
            da.Dispose();
            da.SelectCommand = new OracleCommand(QueryCustomerById + CustomerId.ToString(), conn);
            dt.Clear();
            DataTable tmp = new DataTable();
            da.Fill(tmp);
            if (tmp.Rows[0][0].ToString() == "1")
                return true;
            else
                return false;
        }
    }
}
