using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commercial_automation_project1
{
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        sqlconnection sql_conn = new sqlconnection();
        private void Expenses_List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Table_Expenses Order By ID Asc ",sql_conn.Connention());
            adapter.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void Expenses_Load(object sender, EventArgs e)
        {
            Expenses_List();
            Clear();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_save = new SqlCommand("insert into Table_Expenses (AY,YIL,ELEKTRİK,SU,[DOĞAL GAZ],İNTERNET,MAAŞLAR,EKSTRA,NOTLAR) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)",sql_conn.Connention());
            cmd_save.Parameters.AddWithValue("@P1",cmb_Month.Text);
            cmd_save.Parameters.AddWithValue("@P2", cmb_Year.Text);
            cmd_save.Parameters.AddWithValue("@P3",decimal.Parse(textElectric.Text));
            cmd_save.Parameters.AddWithValue("@P4",decimal.Parse( textWater.Text));
            cmd_save.Parameters.AddWithValue("@P5",decimal.Parse( textGas.Text));
            cmd_save.Parameters.AddWithValue("@P6",decimal.Parse( textInternet.Text));
            cmd_save.Parameters.AddWithValue("@P7",decimal.Parse( textPayment.Text));
            cmd_save.Parameters.AddWithValue("@P8",decimal.Parse( textExtra.Text));
            cmd_save.Parameters.AddWithValue("@P9", textNotes.Text);
            cmd_save.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Gider bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Expenses_List();








        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)
            {
                textID.Text = dr["ID"].ToString();
                cmb_Month.Text = dr["AY"].ToString();
                cmb_Year.Text = dr["YIL"].ToString();
                textElectric.Text = dr["ELEKTRİK"].ToString();
                textWater.Text = dr["SU"].ToString();
                textGas.Text = dr["DOĞAL GAZ"].ToString();
                textInternet.Text = dr["İNTERNET"].ToString();
                textPayment.Text = dr["MAAŞLAR"].ToString();
                textExtra.Text = dr["EKSTRA"].ToString();
                textNotes.Text = dr["NOTLAR"].ToString();

            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Müşteri bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_Expenses where ID=@P1", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textID.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Expenses_List();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Expenses_List();
            }

        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("update Table_Expenses set AY=@P1,YIL=@P2,ELEKTRİK=@P3,SU=@P4,[DOĞAL GAZ]=@P5,İNTERNET=@P6,MAAŞLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 WHERE ID=@P10",sql_conn.Connention());
            cmd_update.Parameters.AddWithValue("@P1", cmb_Month.Text);
            cmd_update.Parameters.AddWithValue("@P2", cmb_Year.Text);
            cmd_update.Parameters.AddWithValue("@P3", decimal.Parse(textElectric.Text));
            cmd_update.Parameters.AddWithValue("@P4", decimal.Parse(textWater.Text));
            cmd_update.Parameters.AddWithValue("@P5", decimal.Parse(textGas.Text));
            cmd_update.Parameters.AddWithValue("@P6", decimal.Parse(textInternet.Text));
            cmd_update.Parameters.AddWithValue("@P7", decimal.Parse(textPayment.Text));
            cmd_update.Parameters.AddWithValue("@P8", decimal.Parse(textExtra.Text));
            cmd_update.Parameters.AddWithValue("@P9", textNotes.Text);
            cmd_update.Parameters.AddWithValue("@P10", textID.Text);
            cmd_update.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Expenses_List();
        }
        private void Clear()
        {
            cmb_Month.Text = "";
            cmb_Year.Text = "";
            textElectric.Text = "";
            textWater.Text = "";
            textGas.Text = "";
            textInternet.Text = "";
            textPayment.Text = "";
            textExtra.Text = "";
            textNotes.Text = "";
            textID.Text=""; 
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
