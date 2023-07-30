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
    public partial class InvoiceProductupdate : Form
    {
        public InvoiceProductupdate()
        {
            InitializeComponent();
        }
        public string productid;
        sqlconnection sql_conn = new sqlconnection();

        private void InvoiceProductupdate_Load(object sender, EventArgs e)
        {
            textProductId.Text = productid;
            SqlCommand cmd = new SqlCommand("select * from Table_InvoiceDetails where FATURAÜRÜNID=@P1", sql_conn.Connention());
            cmd.Parameters.AddWithValue("@P1", productid);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                textPrice.Text = dataReader[3].ToString();
                textAmount.Text = dataReader[2].ToString();
                texttotal.Text = dataReader[4].ToString();
                textPName.Text = dataReader[1].ToString();
                sql_conn.Connention().Close();  
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            double amount, price, total;
            price = Convert.ToDouble(textPrice.Text);
            amount = Convert.ToDouble(textAmount.Text);
            total = amount * price;
            texttotal.Text = total.ToString();
            SqlCommand cmdupdate = new SqlCommand("update Table_InvoiceDetails set [ÜRÜN ADI]=@P1,MİKTAR=@P2,FİYAT=@P3,TUTAR=@P4 WHERE FATURAÜRÜNID = @P5 ",sql_conn.Connention());
            cmdupdate.Parameters.AddWithValue("@P1",textPName.Text);
            cmdupdate.Parameters.AddWithValue("@P2", textAmount.Text);
            cmdupdate.Parameters.AddWithValue("@P3",decimal.Parse( textPrice.Text));
            cmdupdate.Parameters.AddWithValue("@P4",decimal.Parse( texttotal.Text));
            cmdupdate.Parameters.AddWithValue("@P5", textProductId.Text);
            cmdupdate.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            
            
            DialogResult result = MessageBox.Show("Faturadaki ürün bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_InvoiceDetails where FATURAÜRÜNID=@P1", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textProductId.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
