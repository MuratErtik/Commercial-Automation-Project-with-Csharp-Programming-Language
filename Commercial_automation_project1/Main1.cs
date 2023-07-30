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
using System.Xml;
using Commercial_automation_project1;
using DevExpress.XtraCharts;

namespace Commercial_automation_project1
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();
        private void Stocks()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select [ÜRÜN İSMİ],MARKA,MODEL,Sum(ADET) as 'Adet' From Table_Products group by [ÜRÜN İSMİ] , MARKA , MODEL having Sum(ADET)<=1000 order by Sum(ADET) ",sql_conn.Connention());
            da.Fill(dt);
            gridControlStock.DataSource = dt;
        }
        private void Schedule()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 5 TARİH,SAAT,BAŞLIK,DETAYLAR FROM Table_Note order by NOTID desc ",sql_conn.Connention());
            da.Fill(dt);
            gridControlSchedule.DataSource = dt;
        }
        private void Company_List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Exec MAinPCompanInfo", sql_conn.Connention());
            dataAdapter.Fill(dt);
            gridControlCompsnyAction.DataSource = dt;
        }
        private void CompanyInfo()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,[TEL NO1],MAİL FROM Table_Companies",sql_conn.Connention());
            da.Fill(dt);
            gridControlCInfo.DataSource = dt;
        }
        private void News()
        {
            XmlTextReader xmlread = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlread.Read())
            {
                if (xmlread.Name=="title")
                {
                    listBox1.Items.Add(xmlread.ReadString());
                }
            }
        }
        private void Main1_Load(object sender, EventArgs e)
        {
            Stocks();
            Schedule();
            Company_List();
            CompanyInfo();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
            News();
        }

        private void gridControlSchedule_DoubleClick(object sender, EventArgs e)
        {
            NoteDetails nd = new NoteDetails();
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr!=null)
            {
                nd.text = dr["DETAYLAR"].ToString();
            }
            nd.Show();
        }
     


        

    }
}

