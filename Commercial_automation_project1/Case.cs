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
using DevExpress.Charts;
using DevExpress.XtraRichEdit.Export.Doc;
using DevExpress.XtraRichEdit.UI;
using System.IO;

namespace Commercial_automation_project1
{
    public partial class Case : Form
    {
        public Case()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void Customer_Action()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute Table_ActionCustomer1 ",sql_conn.Connention());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Companies_Action()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Execute Table_ActionComp ", sql_conn.Connention());
            da2.Fill(dt2);
            gridControl3.DataSource = dt2;
        }
        public string username;


        private void Case_Load(object sender, EventArgs e)

        {
            Expenses_List();
            labelAUser.Text = username;
            Customer_Action();
            Companies_Action();
            //Calculate to Total
            SqlCommand cmd = new SqlCommand("Select Sum(TUTAR) from Table_InvoiceDetails",sql_conn.Connention());  
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                labelTotal.Text = dr[0].ToString() + "TL";
            }
            sql_conn.Connention().Close();


            SqlCommand cmd2 = new SqlCommand("select (ELEKTRİK+SU+[DOĞAL GAZ]+İNTERNET+EKSTRA) from Table_Expenses order by ID asc",sql_conn.Connention());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                labelPayments.Text = dr2[0].ToString() + "TL";
            }
            sql_conn.Connention().Close();

            SqlCommand cmd3 = new SqlCommand("Select MAAŞLAR from Table_Expenses", sql_conn.Connention());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                labelStaffPayment.Text = dr3[0].ToString() + "TL";
            }
            sql_conn.Connention().Close();


            SqlCommand cmd4 = new SqlCommand("Select Count(*) from Table_Customers", sql_conn.Connention());
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                labelCustomer.Text = dr4[0].ToString() ;
            }
            sql_conn.Connention().Close();


            SqlCommand cmd5 = new SqlCommand("Select Count(*) from Table_Companies", sql_conn.Connention());
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                labelCompanies.Text = dr5[0].ToString();
            }
            sql_conn.Connention().Close();


            SqlCommand cmd6 = new SqlCommand("Select (Count(Distinct(Table_Companies.İL))+Count(Distinct(Table_Customers.İL))) from Table_Companies,Table_Customers", sql_conn.Connention());
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                labelProvince.Text = dr6[0].ToString();
            }
            sql_conn.Connention().Close();



            SqlCommand cmd7 = new SqlCommand("Select Count(*) from Table_Staff", sql_conn.Connention());
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                labelStaff.Text = dr7[0].ToString();
            }
            sql_conn.Connention().Close();



            SqlCommand cmd8 = new SqlCommand("Select Sum(ADET) from Table_Products", sql_conn.Connention());
            SqlDataReader dr8 = cmd8.ExecuteReader();
            while (dr8.Read())
            {
                labelStock.Text = dr8[0].ToString();
            }
            sql_conn.Connention().Close();

           



            
        }
        int timer = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer>0 && timer<=5)
            {
                //chart
                groupControl10.Text = "Elektrik Faturası";
                SqlCommand cmd9 = new SqlCommand("select top 4 AY,ELEKTRİK FROM Table_Expenses order by ID Desc", sql_conn.Connention());
                SqlDataReader dr9 = cmd9.ExecuteReader();
                while (dr9.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr9[0], dr9[1]));
                }
                sql_conn.Connention().Close();
            }
            if (timer > 5 && timer <= 10)
            {
                groupControl10.Text = "Su Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("select top 4 AY,SU FROM Table_Expenses order by ID Desc", sql_conn.Connention());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                sql_conn.Connention().Close();
            }
            if (timer > 10 && timer <= 15)
            {
                groupControl10.Text = "Doğalgaz Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("select top 4 AY,[DOĞAL GAZ] FROM Table_Expenses order by ID Desc", sql_conn.Connention());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                sql_conn.Connention().Close();
            }

            if (timer > 15 && timer <= 20)
            {
                groupControl10.Text = "İnternet Faturası";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("select top 4 AY,İNTERNET FROM Table_Expenses order by ID Desc", sql_conn.Connention());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                sql_conn.Connention().Close();
            }
            if (timer > 20 && timer <= 25)
            {
                groupControl10.Text = "Ekstralar";
                chartControl1.Series["Aylar"].Points.Clear();
                SqlCommand cmd10 = new SqlCommand("select top 4 AY,EKSTRA FROM Table_Expenses order by ID Desc", sql_conn.Connention());
                SqlDataReader dr10 = cmd10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                sql_conn.Connention().Close();
            }
            if (timer==26)
            {
                timer = 0;
            }
        }

        private void Expenses_List()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter adapter3 = new SqlDataAdapter("Select * from Table_Expenses Order By ID Asc ", sql_conn.Connention());
            adapter3.Fill(dt3);
            gridControl2.DataSource = dt3;

        }
    }
}
