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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }
        sqlconnection sql_conn = new sqlconnection();
        private void NoteList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_Note",sql_conn.Connention());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void Notes_Load(object sender, EventArgs e)
        {
            NoteList();
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_save = new SqlCommand("insert into Table_Note (TARİH,SAAT,BAŞLIK,DETAYLAR,[NOTU YAZAN],[NOT KİME]) VALUES (@P1,@P2,@P3,@P4,@P5,@P6) ",sql_conn.Connention());
            cmd_save.Parameters.AddWithValue("@P1",textDate.Text);
            cmd_save.Parameters.AddWithValue("@P2", textTime.Text);
            cmd_save.Parameters.AddWithValue("@P3", textTitle.Text);
            cmd_save.Parameters.AddWithValue("@P4", textDetails.Text);
            cmd_save.Parameters.AddWithValue("@P5", textWrittenBy.Text);
            cmd_save.Parameters.AddWithValue("@P6", textReceivingBy.Text);
            cmd_save.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Not bilgisi başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NoteList();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                textID.Text = dr["NOTID"].ToString();
                textDate.Text = dr["TARİH"].ToString();
                textTime.Text = dr["SAAT"].ToString();
                textTitle.Text = dr["BAŞLIK"].ToString();
                textDetails.Text = dr["DETAYLAR"].ToString();
                textWrittenBy.Text = dr["NOTU YAZAN"].ToString();
                textReceivingBy.Text = dr["NOT KİME"].ToString();
            }
        }
        private void Clear()
        {

            textID.Text = "";
            textDate.Text = "";
            textTime.Text = "";
            textTitle.Text = "";
            textDetails.Text = "";
            textWrittenBy.Text = "";
            textReceivingBy.Text = "";
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Not bilgisi silinecek emin misiniz!", "Bilgi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd_delete = new SqlCommand("Delete From Table_Note where NOTID=@P1", sql_conn.Connention());
                cmd_delete.Parameters.AddWithValue("@P1", textID.Text);
                cmd_delete.ExecuteNonQuery();
                sql_conn.Connention().Close();
                MessageBox.Show("Silme İşlemi başarıyla tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NoteList();

            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NoteList();
            }
        }

        private void Button_Update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd_update = new SqlCommand("Update Table_Note set TARİH=@P1,SAAT=@P2,BAŞLIK=@P3,DETAYLAR=@P4,[NOTU YAZAN]=@P5,[NOT KİME]=@P6 WHERE NOTID=@P7",sql_conn.Connention());
            cmd_update.Parameters.AddWithValue("@P1", textDate.Text);
            cmd_update.Parameters.AddWithValue("@P2", textTime.Text);
            cmd_update.Parameters.AddWithValue("@P3", textTitle.Text);
            cmd_update.Parameters.AddWithValue("@P4", textDetails.Text);
            cmd_update.Parameters.AddWithValue("@P5", textWrittenBy.Text);
            cmd_update.Parameters.AddWithValue("@P6", textReceivingBy.Text);
            cmd_update.Parameters.AddWithValue("@P7", textID.Text);
            cmd_update.ExecuteNonQuery();
            sql_conn.Connention().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NoteList();
        }

       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            NoteDetails details = new NoteDetails();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                details.text = dr["DETAYLAR"].ToString();
            }
            details.Show();
        }
    }
}
