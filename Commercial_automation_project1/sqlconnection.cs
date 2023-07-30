using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Commercial_automation_project1
{
    class sqlconnection
    {
        public SqlConnection Connention()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NQULA99;Initial Catalog=""DBO CommercialAutomation"";Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
