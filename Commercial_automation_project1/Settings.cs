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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void SettingList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_Admin",sql_conn.Connention());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            SettingList();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            if (ButtonUpdate.Text == "GÜNCELLE")
            {
                SqlCommand cmd_update = new SqlCommand("update Table_Admin set ŞİFRE=@P2 WHERE [KULLANICI ADI]=@P1", sql_conn.Connention());
                cmd_update.Parameters.AddWithValue("@P1",textUserName.Text);
                cmd_update.Parameters.AddWithValue("@P2",textPassword.Text);
                cmd_update.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Şifre bilgisi başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SettingList();
                Clear();
            }
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textUserName.Text = dr["KULLANICI ADI"].ToString();
                textPassword.Text = dr["ŞİFRE"].ToString();
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesap bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_Admin where [KULLANICI ADI]=@P1 AND ŞİFRE=@P2", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textDUsername.Text);
                cmd_delete.Parameters.AddWithValue("@P2",textDPassword.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SettingList();
                Clear();
                

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                
            }
        }
        private void Clear()
        {
            textPassword.Text = "";
            textUserName.Text = "";
            textDPassword.Text = "";
            textDUsername.Text = "";
        }
    }
}

