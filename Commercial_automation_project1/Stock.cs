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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();


        private void Stock_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("",);
            SqlDataAdapter da = new SqlDataAdapter("Select [ÜRÜN İSMİ],SUM(ADET) as 'Miktar' from Table_Products group by [ÜRÜN İSMİ]",sql_conn.Connention());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            // Amount of stock List Add to Chart
            SqlCommand cmd = new SqlCommand("Select [ÜRÜN İSMİ],SUM(ADET) as 'Miktar' from Table_Products group by [ÜRÜN İSMİ]",sql_conn.Connention());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), Convert.ToInt32(dr[1]));
            }
            sql_conn.Connention().Close();

            // Company-Province List Add to Char
            SqlCommand cmd2 = new SqlCommand("Select İL,COUNT(*) FROM Table_Companies Group By İL",sql_conn.Connention());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), Convert.ToInt32(dr2[1]));
            }
            sql_conn.Connention().Close();
        }

       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            StockDetail Sd = new StockDetail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                Sd.product_name = dr["ÜRÜN İSMİ"].ToString();

            }
            Sd.Show();
        }
    }
}
