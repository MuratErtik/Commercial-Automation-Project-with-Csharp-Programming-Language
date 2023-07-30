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
    public partial class InvoiceProductInfo : Form
    {
        public InvoiceProductInfo()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();
        private void ProductInfoList()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_InvoiceDetails where FATURAID='"+id+ "'",sql_conn.Connention());
            da.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }

        public string id;
        private void InvoiceProductInfo_Load(object sender, EventArgs e)
        {
            ProductInfoList();
        }

       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            InvoiceProductupdate ipu = new InvoiceProductupdate();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                ipu.productid = dr["FATURAÜRÜNID"].ToString();
            }
            ipu.Show();
        }
    }
}
