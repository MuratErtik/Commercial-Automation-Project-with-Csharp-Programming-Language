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
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }

        sqlconnection sqlconn = new sqlconnection();
        void Companies_List()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From Table_Companies ",sqlconn.Connention());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void Companies_Load(object sender, EventArgs e)
        {
           
            Companies_List();
            
            Province_List();
            Code_Details();
            Clear();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID.Text = dr["ID"].ToString();
                textCName.Text = dr["AD"].ToString();
                textCSector.Text = dr["SEKTÖR"].ToString();
                textAuthorizedName.Text = dr["YETKİLİ KİŞİ"].ToString();
                textAuthorizedStatu.Text = dr["YETKİLİ KİŞİ STATÜSÜ"].ToString();
                textauthorizedID.Text = dr["YETKİLİ TC"].ToString();
                textPhoneNo1.Text = dr["TEL NO1"].ToString();
                textPhoneNo2.Text = dr["TEL NO2"].ToString();
                textPhoneNo3.Text = dr["TEL NO3"].ToString();
                textCMail.Text = dr["MAİL"].ToString();
                textFAX.Text = dr["FAX"].ToString();
                comboBoxProvince.Text = dr["İL"].ToString();
                comboBoxCounty.Text = dr["İLÇE"].ToString();
                textTEXADM.Text = dr["VERGİ DAİRESİ"].ToString();
                textCAdress.Text = dr["ADRES"].ToString();
                textCODE1.Text = dr["ÖZEL KOD1"].ToString();
                textCODE2.Text = dr["ÖZEL KOD2"].ToString();
                textCODE3.Text = dr["ÖZEL KOD3"].ToString();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_save = new SqlCommand("insert into Table_Companies (AD,SEKTÖR,[YETKİLİ KİŞİ],[YETKİLİ KİŞİ STATÜSÜ],[YETKİLİ TC],[TEL NO1],[TEL NO2],[TEL NO3],MAİL,FAX,İL,İLÇE,[VERGİ DAİRESİ],ADRES,[ÖZEL KOD1],[ÖZEL KOD2],[ÖZEL KOD3]) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12,@P13,@P14,@P15,@P16,@P17)", sqlconn.Connention());
            cmd_save.Parameters.AddWithValue("@P1", textCName.Text);
            cmd_save.Parameters.AddWithValue("@P2", textCSector.Text);
            cmd_save.Parameters.AddWithValue("@P3", textAuthorizedName.Text);
            cmd_save.Parameters.AddWithValue("@P4", textAuthorizedStatu.Text);
            cmd_save.Parameters.AddWithValue("@P5", textauthorizedID.Text);
            cmd_save.Parameters.AddWithValue("@P6", textPhoneNo1.Text);
            cmd_save.Parameters.AddWithValue("@P7", textPhoneNo2.Text);
            cmd_save.Parameters.AddWithValue("@P8", textPhoneNo3.Text);
            cmd_save.Parameters.AddWithValue("@P9", textCMail.Text);
            cmd_save.Parameters.AddWithValue("@P10", textFAX.Text);
            cmd_save.Parameters.AddWithValue("@P11", comboBoxProvince.Text);
            cmd_save.Parameters.AddWithValue("@P12", comboBoxCounty.Text);
            cmd_save.Parameters.AddWithValue("@P13", textTEXADM.Text);
            cmd_save.Parameters.AddWithValue("@P14", textCAdress.Text);
            cmd_save.Parameters.AddWithValue("@P15", textCODE1.Text);
            cmd_save.Parameters.AddWithValue("@P16", textCODE2.Text);
            cmd_save.Parameters.AddWithValue("@P17", textCODE3.Text);
            cmd_save.ExecuteNonQuery();
            sqlconn.Connention().Close();
            MessageBox.Show("Firma bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Companies_List();
            
        }
        private void Clear()
            ////
        {
            textID.Text = "";
            textCName.Text = "";
            textCSector.Text = "";
            textAuthorizedName.Text = "";
            textAuthorizedStatu.Text = "";
            textauthorizedID.Text = "";
            textPhoneNo1.Text = "";
            textPhoneNo2.Text = "";
            textPhoneNo3.Text = "";
            textCMail.Text = "";
            textFAX.Text = "";
            comboBoxProvince.Text = "";
            comboBoxCounty.Text = "";
            textTEXADM.Text = "";
            textCAdress.Text = "";
            textCODE1.Text = "";
            textCODE2.Text = "";
            textCODE3.Text = "";
           
        }
        private void Province_List()
        {
            SqlCommand cmd = new SqlCommand("Select PROVINCE From Provinces", sqlconn.Connention());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxProvince.Properties.Items.Add(reader[0]);

            }
            sqlconn.Connention().Close();
        }

        private void comboBoxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCounty.Properties.Items.Clear();
            //
            SqlCommand cmd_c = new SqlCommand("Select COUNTY From Counties where PROVINCE=@P1", sqlconn.Connention());
            cmd_c.Parameters.AddWithValue("@P1", comboBoxProvince.SelectedIndex + 1);
            SqlDataReader reader = cmd_c.ExecuteReader();
            while (reader.Read())
            {
                comboBoxCounty.Properties.Items.Add(reader[0]);
            }
            sqlconn.Connention().Close();
        }
        private void Code_Details()
        {
            SqlCommand cmd = new SqlCommand("Select [FİRMA KOD1] From Table_Codes",sqlconn.Connention());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                richTextCode1.Text = reader[0].ToString();
            }
            sqlconn.Connention().Close();

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Müşteri bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_Companies where ID=@P1", sqlconn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textID.Text);
                cmd_delete.ExecuteNonQuery();
                sqlconn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Companies_List();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Companies_List();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("Update Table_Companies set AD=@P1,SEKTÖR=@P2,[YETKİLİ KİŞİ]=@P3,[YETKİLİ KİŞİ STATÜSÜ]=@P4,[YETKİLİ TC]=@P5,[TEL NO1]=@P6,[TEL NO2]=@P7,[TEL NO3]=@P8,MAİL=@P9,FAX=@P10,İL=@P11,İLÇE=@P12,[VERGİ DAİRESİ]=@P13,ADRES=@P14,[ÖZEL KOD1]=@P15,[ÖZEL KOD2]=@P16,[ÖZEL KOD3]=@P17 where ID=@P18",sqlconn.Connention());
            cmd_update.Parameters.AddWithValue("@P1", textCName.Text);
            cmd_update.Parameters.AddWithValue("@P2", textCSector.Text);
            cmd_update.Parameters.AddWithValue("@P3", textAuthorizedName.Text);
            cmd_update.Parameters.AddWithValue("@P4", textAuthorizedStatu.Text);
            cmd_update.Parameters.AddWithValue("@P5", textauthorizedID.Text);
            cmd_update.Parameters.AddWithValue("@P6", textPhoneNo1.Text);
            cmd_update.Parameters.AddWithValue("@P7", textPhoneNo2.Text);
            cmd_update.Parameters.AddWithValue("@P8", textPhoneNo3.Text);
            cmd_update.Parameters.AddWithValue("@P9", textCMail.Text);
            cmd_update.Parameters.AddWithValue("@P10", textFAX.Text);
            cmd_update.Parameters.AddWithValue("@P11", comboBoxProvince.Text);
            cmd_update.Parameters.AddWithValue("@P12", comboBoxCounty.Text);
            cmd_update.Parameters.AddWithValue("@P13", textTEXADM.Text);
            cmd_update.Parameters.AddWithValue("@P14", textCAdress.Text);
            cmd_update.Parameters.AddWithValue("@P15", textCODE1.Text);
            cmd_update.Parameters.AddWithValue("@P16", textCODE2.Text);
            cmd_update.Parameters.AddWithValue("@P17", textCODE3.Text);
            cmd_update.Parameters.AddWithValue("@P18",textID.Text);
            cmd_update.ExecuteNonQuery();
            sqlconn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Companies_List();
            Clear();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
