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
    public partial class StockDetail : Form
    {
        public StockDetail()
        {
            InitializeComponent();
        }
        

        public string product_name;
        sqlconnection sql_conn = new sqlconnection();

        private void StockDetail_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_Products where [ÜRÜN İSMİ]= '"+product_name+  "' ",sql_conn.Connention());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    }
}
