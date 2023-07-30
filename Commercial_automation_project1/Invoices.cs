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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void InvoicesList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Table_InvoiceInfo", sql_conn.Connention());
            dataAdapter.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void Clear()
        {
            textID.Text = "";
            textSeries.Text = "";
            textNumber.Text="";
            textDate.Text = "";
            textTime.Text = "";
            textTexAdmin.Text = "";
            textCustomerName.Text = "";
            textDeliveredBy.Text = "";
            textReceivingBy.Text = "";  




        }
        private void Invoices_Load(object sender, EventArgs e)
        {
            InvoicesList();
            
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
          
            if (textInvoiceId.Text == "" )
            {
                SqlCommand cmdsave1 = new SqlCommand("insert into Table_InvoiceInfo (SERİ,[SIRA NO],TARİH,SAAT,[VERGİ DAİRESİ],[MÜŞTERİ ADI],[TESLİM EDEN],[TESLİM ALAN]) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", sql_conn.Connention());
                cmdsave1.Parameters.AddWithValue("@P1", textSeries.Text);
                cmdsave1.Parameters.AddWithValue("@P2", textNumber.Text);
                cmdsave1.Parameters.AddWithValue("@P3", textDate.Text);
                cmdsave1.Parameters.AddWithValue("@P4", textTime.Text);
                cmdsave1.Parameters.AddWithValue("@P5", textTexAdmin.Text);
                cmdsave1.Parameters.AddWithValue("@P6", textCustomerName.Text);
                cmdsave1.Parameters.AddWithValue("@P7", textDeliveredBy.Text);
                cmdsave1.Parameters.AddWithValue("@P8", textReceivingBy.Text);
                cmdsave1.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Fatura bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoicesList();
         
            }
            // if Company purchase something
            if (textInvoiceId.Text!="" && comboBox1.Text == "Firma")
            {
                double amount, price, total;
                price=Convert.ToDouble(textPrice.Text);
                amount = Convert.ToInt16(textAmount.Text);
                total= amount*price;
                textTotal.Text = total.ToString();
                SqlCommand cmdsave2 = new SqlCommand("insert into Table_InvoiceDetails ([ÜRÜN ADI],MİKTAR,FİYAT,TUTAR,FATURAID) VALUES (@P1,@P2,@P3,@P4,@P5) ",sql_conn.Connention());
                cmdsave2.Parameters.AddWithValue("@P1",textProductName.Text);
                cmdsave2.Parameters.AddWithValue("@P2", Convert.ToDecimal( textAmount.Text));
                cmdsave2.Parameters.AddWithValue("@P3", Convert.ToDecimal( textPrice.Text));
                cmdsave2.Parameters.AddWithValue("@P4", Convert.ToDecimal(textTotal.Text));
                cmdsave2.Parameters.AddWithValue("@P5", textInvoiceId.Text);
                
                cmdsave2.ExecuteNonQuery();
                sql_conn.Connention().Close();

                //when users add data in Invoice section that data goes the Action section the same time.
                SqlCommand cmd2 = new SqlCommand("insert into Table_ActionsComp ([ÜRÜNID],ADET,PERSONEL,FİRMA,FİYAT,TOPLAM,FATURAID,TARİH) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8) ",sql_conn.Connention());
                cmd2.Parameters.AddWithValue("@P1",textIddetails.Text);
                cmd2.Parameters.AddWithValue("@P2", Convert.ToDecimal(textAmount.Text));
                cmd2.Parameters.AddWithValue("@P3",textsStaff.Text);
                cmd2.Parameters.AddWithValue("@P4",textCompany.Text);
                cmd2.Parameters.AddWithValue("@P5", Convert.ToDecimal(textPrice.Text));
                cmd2.Parameters.AddWithValue("@P6", Convert.ToDecimal(textTotal.Text));
                cmd2.Parameters.AddWithValue("@P7",textInvoiceId.Text);
                cmd2.Parameters.AddWithValue("@P8",textDate.Text);
                cmd2.ExecuteNonQuery();
                sql_conn.Connention().Close();


                // reducing the number of stocks
                SqlCommand cmd3 = new SqlCommand("update Table_Products set ADET=ADET-@P1 WHERE ID = @P2",sql_conn.Connention());
                cmd3.Parameters.AddWithValue("@P1",textAmount.Text);
                cmd3.Parameters.AddWithValue("@P2",textIddetails.Text);
                cmd3.ExecuteNonQuery();
                sql_conn.Connention().Close();  

                MessageBox.Show("Faturaya ait ürün bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoicesList();

            }




            
            
            // if customer purchase something
            if (textInvoiceId.Text != "" && comboBox1.Text == "Müşteri")
            {
                double amount, price, total;
                price = Convert.ToDouble(textPrice.Text);
                amount = Convert.ToInt16(textAmount.Text);
                total = amount * price;
                textTotal.Text = total.ToString();
                SqlCommand cmdsave2 = new SqlCommand("insert into Table_InvoiceDetails ([ÜRÜN ADI],MİKTAR,FİYAT,TUTAR,FATURAID) VALUES (@P1,@P2,@P3,@P4,@P5) ", sql_conn.Connention());
                cmdsave2.Parameters.AddWithValue("@P1", textProductName.Text);
                cmdsave2.Parameters.AddWithValue("@P2", Convert.ToDecimal(textAmount.Text));
                cmdsave2.Parameters.AddWithValue("@P3", Convert.ToDecimal(textPrice.Text));
                cmdsave2.Parameters.AddWithValue("@P4", Convert.ToDecimal(textTotal.Text));
                cmdsave2.Parameters.AddWithValue("@P5", textInvoiceId.Text);

                cmdsave2.ExecuteNonQuery();
                sql_conn.Connention().Close();

                //when users add data in Invoice section that data goes the Action section the same time.
                SqlCommand cmd2 = new SqlCommand("insert into Table_ActionCustomer ([ÜRÜNID],ADET,PERSONEL,MÜŞTERİ,FİYAT,TOPLAM,FATURAID,TARİH) VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8) ", sql_conn.Connention());
                cmd2.Parameters.AddWithValue("@P1", textIddetails.Text);
                cmd2.Parameters.AddWithValue("@P2", Convert.ToDecimal(textAmount.Text));
                cmd2.Parameters.AddWithValue("@P3", textsStaff.Text);
                cmd2.Parameters.AddWithValue("@P4", textCompany.Text);
                cmd2.Parameters.AddWithValue("@P5", Convert.ToDecimal(textPrice.Text));
                cmd2.Parameters.AddWithValue("@P6", Convert.ToDecimal(textTotal.Text));
                cmd2.Parameters.AddWithValue("@P7", textInvoiceId.Text);
                cmd2.Parameters.AddWithValue("@P8", textDate.Text);
                cmd2.ExecuteNonQuery();
                sql_conn.Connention().Close();


                // reducing the number of stocks
                SqlCommand cmd3 = new SqlCommand("update Table_Products set ADET=ADET-@P1 WHERE ID = @P2", sql_conn.Connention());
                cmd3.Parameters.AddWithValue("@P1", textAmount.Text);
                cmd3.Parameters.AddWithValue("@P2", textIddetails.Text);
                cmd3.ExecuteNonQuery();
                sql_conn.Connention().Close();

                MessageBox.Show("Faturaya ait ürün bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoicesList();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID.Text = dr["FATURABİLGİID"].ToString();
                textSeries.Text = dr["SERİ"].ToString();
                textNumber.Text = dr["SIRA NO"].ToString();
                textDate.Text = dr["TARİH"].ToString();
                textTime.Text = dr["SAAT"].ToString();
                textTexAdmin.Text = dr["VERGİ DAİRESİ"].ToString();
                textCustomerName.Text = dr["MÜŞTERİ ADI"].ToString();
                textDeliveredBy.Text = dr["TESLİM EDEN"].ToString();
                textReceivingBy.Text = dr["TESLİM ALAN"].ToString();
               

            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Fatura bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_InvoiceInfo where FATURABİLGİID=@P1", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textID.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InvoicesList();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InvoicesList();
            }
            
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("update Table_InvoiceInfo set SERİ=@P1,[SIRA NO]=@P2,TARİH=@P3,SAAT=@P4,[VERGİ DAİRESİ]=@P5,[MÜŞTERİ ADI]=@P6,[TESLİM EDEN]=@P7,[TESLİM ALAN]=@P8 where FATURABİLGİID=@P9",sql_conn.Connention());
            cmd_update.Parameters.AddWithValue("@P1", textSeries.Text);
            cmd_update.Parameters.AddWithValue("@P2", textNumber.Text);
            cmd_update.Parameters.AddWithValue("@P3", textDate.Text);
            cmd_update.Parameters.AddWithValue("@P4", textTime.Text);
            cmd_update.Parameters.AddWithValue("@P5", textTexAdmin.Text);
            cmd_update.Parameters.AddWithValue("@P6", textCustomerName.Text);
            cmd_update.Parameters.AddWithValue("@P7", textDeliveredBy.Text);
            cmd_update.Parameters.AddWithValue("@P8", textReceivingBy.Text);
            cmd_update.Parameters.AddWithValue("@P9",textID.Text);
            cmd_update.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InvoicesList();
        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select [ÜRÜN İSMİ],MARKA,MODEL, [SATIŞ FİYATI] from Table_Products where ID=@P1",sql_conn.Connention());
            
            
            cmd.Parameters.AddWithValue("@P1",textIddetails.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textProductName.Text = dr[0].ToString();
                textEditProductDetail.Text = dr[1].ToString() + " " + dr[2].ToString();
                textPrice.Text = dr[3].ToString();
            }
            sql_conn.Connention().Close();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            InvoiceProductInfo ipi = new InvoiceProductInfo();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                ipi.id = dr["FATURABİLGİID"].ToString();
            }
            ipi.Show();
        }
    }
}
