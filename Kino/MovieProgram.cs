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
    public partial class MovieProgram : Form
    {
        OracleConnection conn;
        public string ConnectionString { get; set; }

        public MovieProgram()
        {
            InitializeComponent();
            ConnectionString = "";
        }

        private void MovieProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
