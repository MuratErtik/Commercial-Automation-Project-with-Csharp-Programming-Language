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
    public partial class New_Account : Form
    {
        public New_Account()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void Clean()
        {
            textPassword.Text = "";
            textRePassword.Text = "";
            

        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textPassword.Text==textRePassword.Text)
            {

                SqlCommand cmd_save = new SqlCommand("insert into Table_Admin ([KULLANICI ADI],ŞİFRE) values (@P1,@P2)",sql_conn.Connention());
                cmd_save.Parameters.AddWithValue("@P1",textUserName.Text);
                cmd_save.Parameters.AddWithValue("@P2",textPassword.Text);
                cmd_save.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Hesap bilgisi başarıyla kaydedildi! Sekmeyi kapatıp Bilgilerinizi girerek hesaba giriş yapabilirsiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                
                MessageBox.Show("Girilen şifreler birbiri ile uyuşmuyor lütfen tekrar deneyiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);



                Clean();
            }
        }
    }
}
