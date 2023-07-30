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
using DevExpress.Office.Utils;

namespace Commercial_automation_project1
{
    public partial class Product_form : Form
    {
        public Product_form()
        {
            InitializeComponent();
        }
        sqlconnection sqlconn = new sqlconnection();
        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table_Products", sqlconn.Connention());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        

        private void gridControl1_Load(object sender, EventArgs e)
        {
            List();
            Clear();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_Products([ÜRÜN İSMİ],MARKA,MODEL,YIL,ADET,[ALIŞ FİYATI],[SATIŞ FİYATI],DETAYLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",sqlconn.Connention());
            cmd.Parameters.AddWithValue("@p1",textNAME.Text);
            cmd.Parameters.AddWithValue("@p2",textBRAND.Text);
            cmd.Parameters.AddWithValue("@p3",textMODEL.Text);
            cmd.Parameters.AddWithValue("@p4",textYEAR.Text);
            cmd.Parameters.AddWithValue("@p5", int.Parse((numericNUMBER.Value).ToString()));
            cmd.Parameters.AddWithValue("@p6", decimal.Parse(textPURCHASE.Text));
            cmd.Parameters.AddWithValue("@p7", decimal.Parse(textSALE.Text));
            cmd.Parameters.AddWithValue("@p8", textDETAILS.Text);
            cmd.ExecuteNonQuery();
            sqlconn.Connention().Close();
            MessageBox.Show("Ürün başarılı bir şekilde sisteme eklenmiştir!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            List();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            //
            SqlCommand cmd_delete = new SqlCommand("DELETE FROM Table_Products WHERE ID=@P1",sqlconn.Connention());
            cmd_delete.Parameters.AddWithValue("@p1",textID.Text);
            cmd_delete.ExecuteNonQuery();
            sqlconn.Connention().Close();
            MessageBox.Show("Seçtiğiniz ürün silinmiştir!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            List();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            textID.Text = dt["ID"].ToString();
            textNAME.Text = dt["ÜRÜN İSMİ"].ToString();
            textBRAND.Text = dt["MARKA"].ToString();
            textMODEL.Text = dt["MODEL"].ToString();
            textYEAR.Text = dt["YIL"].ToString();
            numericNUMBER.Value = decimal.Parse(dt["ADET"].ToString());
            textPURCHASE.Text = dt["ALIŞ FİYATI"].ToString();
            textSALE.Text = dt["SATIŞ FİYATI"].ToString();
            textDETAILS.Text = dt["DETAYLAR"].ToString();
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            //
            SqlCommand cmd_update = new SqlCommand("update Table_Products set [ÜRÜN İSMİ]=@P1,MARKA=@P2,MODEL=@P3,YIL=@P4,ADET=@P5,[ALIŞ FİYATI]=@P6,[SATIŞ FİYATI]=@P7,DETAYLAR=@P8 where ID=@P9",sqlconn.Connention());
            cmd_update.Parameters.AddWithValue("@P1",textNAME.Text);
            cmd_update.Parameters.AddWithValue("@P2",textBRAND.Text);
            cmd_update.Parameters.AddWithValue("@P3",textMODEL.Text);
            cmd_update.Parameters.AddWithValue("@P4",textYEAR.Text);
            cmd_update.Parameters.AddWithValue("@P5",int.Parse(numericNUMBER.Value.ToString()));
            cmd_update.Parameters.AddWithValue("@P6",decimal.Parse(textPURCHASE.Text));
            cmd_update.Parameters.AddWithValue("@P7",decimal.Parse(textSALE.Text));
            cmd_update.Parameters.AddWithValue("@P8",textDETAILS.Text);
            cmd_update.Parameters.AddWithValue("@P9",textID.Text);
            cmd_update.ExecuteNonQuery();
            sqlconn.Connention().Close();
            MessageBox.Show("Ürün bilgisi başarıyla güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            List();

        }
        private void Clear()
        {
            textNAME.Text = "";
            textBRAND.Text = "";
            textMODEL.Text = "";
            textYEAR.Text = "";
            numericNUMBER.Value = 0;
            textPURCHASE.Text = "";
            textSALE.Text = "";
            textDETAILS.Text = "";
            textID.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public int productId;
    }
}
