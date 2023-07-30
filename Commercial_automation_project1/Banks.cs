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
using System.Data.Common;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.UI;

namespace Commercial_automation_project1
{
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
        }
        private void Bank_List()
        {
            DataTable dt = new DataTable();
            //PROCEDUR

            SqlDataAdapter dataAdapter = new SqlDataAdapter("execute BankInfo1 ", sql_conn.Connention());
            dataAdapter.Fill(dt);
            gridControl1.DataSource = dt;

        }
        sqlconnection sql_conn = new sqlconnection();
        private void Banks_Load(object sender, EventArgs e)
        {
            Bank_List();
            Province_List();
            Company_List();
            Clear();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_save = new SqlCommand("insert into Table_Banks ([BANKA ADI],İL,İLÇE,ŞUBE,IBAN,[HESAP NUMARASI],[YETKİLİ KİŞİ],TELEFON,TARİH,[HESAP TÜRÜ],FİRMAID) " +
                "VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)",sql_conn.Connention());
            cmd_save.Parameters.AddWithValue("@P1",textBankName.Text);
            cmd_save.Parameters.AddWithValue("@P2", cmb_Province.Text);
            cmd_save.Parameters.AddWithValue("@P3",cmbCounty.Text);
            cmd_save.Parameters.AddWithValue("@P4", textBranch.Text);
            cmd_save.Parameters.AddWithValue("@P5", textIban.Text);
            cmd_save.Parameters.AddWithValue("@P6", textAccountNo.Text);
            cmd_save.Parameters.AddWithValue("@P7", textAuthorize_Person.Text);
            cmd_save.Parameters.AddWithValue("@P8", textPHONE_NO.Text);
            cmd_save.Parameters.AddWithValue("@P9", textDate.Text);
            cmd_save.Parameters.AddWithValue("@P10", textAccountType.Text);
            cmd_save.Parameters.AddWithValue("@P11", lookUpCompany.EditValue);
            cmd_save.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Banka bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bank_List();




        }
        private void Province_List()
        {
            SqlCommand cmd = new SqlCommand("Select PROVINCE From Provinces", sql_conn.Connention());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmb_Province.Properties.Items.Add(reader[0]);

            }
            sql_conn.Connention().Close();
        }
        private void Company_List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select ID,AD from Table_Companies ",sql_conn.Connention());
            dataAdapter.Fill(dt);
            
            lookUpCompany.Properties.ValueMember = "ID";
            lookUpCompany.Properties.DisplayMember = "AD";
            lookUpCompany.Properties.DataSource = dt;


        }

        private void cmb_Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCounty.Properties.Items.Clear();
            //
            SqlCommand cmd_c = new SqlCommand("Select COUNTY From Counties where PROVINCE=@P1", sql_conn.Connention());
            cmd_c.Parameters.AddWithValue("@P1", cmb_Province.SelectedIndex + 1);
            SqlDataReader reader = cmd_c.ExecuteReader();
            while (reader.Read())
            {
                cmbCounty.Properties.Items.Add(reader[0]);
            }
            sql_conn.Connention().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID.Text = dr["ID"].ToString();
                textBankName.Text = dr["BANKA ADI"].ToString();
                cmb_Province.Text = dr["İL"].ToString();
                cmbCounty.Text = dr["İLÇE"].ToString();
                textBranch.Text = dr["ŞUBE"].ToString();
                textIban.Text = dr["IBAN"].ToString();
                textAccountNo.Text = dr["HESAP NUMARASI"].ToString();
                textAuthorize_Person.Text = dr["YETKİLİ KİŞİ"].ToString();
                textPHONE_NO.Text = dr["TELEFON"].ToString();
                textDate.Text = dr["TARİH"].ToString();
                textAccountType.Text = dr["HESAP TÜRÜ"].ToString();
                lookUpCompany.Text = dr["AD"].ToString();
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Banka bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_Banks where ID=@P1", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textID.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Bank_List();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bank_List();
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("update Table_Banks set [BANKA ADI]=@P1,İL=@P2,İLÇE=@P3,ŞUBE=@P4,IBAN=@P5,[HESAP NUMARASI]=@P6,[YETKİLİ KİŞİ]=@P7,TELEFON=@P8,TARİH=@P9,[HESAP TÜRÜ]=@P10,FİRMAID = @P11 WHERE ID=@P12 ",sql_conn.Connention());
            cmd_update.Parameters.AddWithValue("@P1", textBankName.Text);
            cmd_update.Parameters.AddWithValue("@P2", cmb_Province.Text);
            cmd_update.Parameters.AddWithValue("@P3", cmbCounty.Text);
            cmd_update.Parameters.AddWithValue("@P4", textBranch.Text);
            cmd_update.Parameters.AddWithValue("@P5", textIban.Text);
            cmd_update.Parameters.AddWithValue("@P6", textAccountNo.Text);
            cmd_update.Parameters.AddWithValue("@P7", textAuthorize_Person.Text);
            cmd_update.Parameters.AddWithValue("@P8", textPHONE_NO.Text);
            cmd_update.Parameters.AddWithValue("@P9", textDate.Text);
            cmd_update.Parameters.AddWithValue("@P10", textAccountType.Text);
            cmd_update.Parameters.AddWithValue("@P11", lookUpCompany.EditValue);
            cmd_update.Parameters.AddWithValue("@P12",textID.Text);
            cmd_update.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Bank_List();
        }
        private void Clear()
        {
            textBankName.Text="" ;
            cmb_Province.Text="" ;
            cmbCounty.Text="" ;
            textBranch.Text="" ;
            textIban.Text="" ;
            textAccountNo.Text="" ;
            textAuthorize_Person.Text="" ;
            textPHONE_NO.Text="" ;
            textDate.Text="" ;
            textAccountType.Text="" ;
            lookUpCompany.EditValue="" ;
            textID.Text = "";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
