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
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void Contacts_Load(object sender, EventArgs e)
        {
            // Customers Information
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select AD,SOYAD,[TEL NO],MAİL From Table_Customers",sql_conn.Connention());
            adapter.Fill(dt);
            gridControl1.DataSource= dt;

            //Companies Information
            DataTable dt2 = new DataTable();
            SqlDataAdapter adapter2 = new SqlDataAdapter("Select AD,[YETKİLİ KİŞİ],[TEL NO1],[TEL NO2],[TEL NO3],MAİL,FAX From Table_Companies", sql_conn.Connention());
            adapter2.Fill(dt2);
            gridControl2.DataSource = dt2;


        }

       

       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Mail mail1 = new Mail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                mail1.mail = dr["MAİL"].ToString();
            }
            mail1.Show();
        }

       

        

        private void gridControl2_DoubleClick_1(object sender, EventArgs e)
        {
            Mail mail2 = new Mail();
            DataRow dr2 = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr2 != null)
            {
                mail2.mail = dr2["MAİL"].ToString();
            }
            mail2.Show();
        }
    }
}
