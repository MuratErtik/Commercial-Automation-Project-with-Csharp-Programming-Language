using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Commercial_automation_project1
{
    public partial class Actions : Form
    {
        public Actions()
        {
            InitializeComponent();
        }

        sqlconnection sql_conn = new sqlconnection();
        private void CompanyList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Exec Table_ActionComp",sql_conn.Connention());
            
            dataAdapter.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void CustomerList()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter("Exec Table_ActionCustomer1", sql_conn.Connention());

            dataAdapter1.Fill(dt1);
            gridControl1.DataSource = dt1;
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            CompanyList();
            CustomerList();
        }
    }
}
