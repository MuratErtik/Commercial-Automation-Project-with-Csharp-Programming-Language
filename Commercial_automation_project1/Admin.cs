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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Table_Admin where [KULLANICI ADI]=@P1 AND ŞİFRE=@P2",sql_conn.Connention());
            cmd.Parameters.AddWithValue("@P1",textUserName.Text);
            cmd.Parameters.AddWithValue("@P2",textPassword.Text);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Main_Page mnp=new Main_Page();
                mnp.username1 = textUserName.Text;
                mnp.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Hatalı kullkanıcı adı veya şifre","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            sql_conn.Connention().Close();

        }

        private void hyperLinkEdit1_OpenLink(object sender, DevExpress.XtraEditors.Controls.OpenLinkEventArgs e)
        {
            New_Account na = new New_Account();
            na.Show();
        }
    }
}
