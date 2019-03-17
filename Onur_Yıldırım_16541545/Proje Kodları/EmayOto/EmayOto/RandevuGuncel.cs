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

namespace EmayOto
{
    public partial class RandevuGuncel : Form
    {
        public RandevuGuncel()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RandevuGuncel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emayDataDataSet5.Randevular' table. You can move, or remove it, as needed.
            this.randevularTableAdapter.Fill(this.emayDataDataSet5.Randevular);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
           
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdsoyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskTel.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbxsalon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cbxnitelik.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            msktarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            mskontarih.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            cbxmissay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void btnGuncel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Randevular set Adsoyad=@p1,Telefon=@p2,Salon=@p3,Nıtelık=@p4,Tarıh=@p5,Ontarıh=@p6,Mıssay=@p7 where Id=@p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@p2", mskTel.Text);
            komut.Parameters.AddWithValue("@p3", cbxsalon.Text);
            komut.Parameters.AddWithValue("@p4", cbxnitelik.Text);
            komut.Parameters.AddWithValue("@p5", msktarih.Text);
            komut.Parameters.AddWithValue("@p6", mskontarih.Text);
            komut.Parameters.AddWithValue("@p7", cbxmissay.Text);
            komut.Parameters.AddWithValue("@p8", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi");
            bgl.baglanti().Close();
            this.randevularTableAdapter.Fill(this.emayDataDataSet5.Randevular);
            dataGridView1.DataSource = emayDataDataSet5.Randevular;

        }

        private void mskTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnara_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string secilen = txtara.Text;
            secilen = "'" + secilen + "'";
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(dt.Rows.Count==0)
            {
                MessageBox.Show("Bulunamadı \n Sadece Ad Soyada göre arama yapınız!!");
                dataGridView1.DataSource = emayDataDataSet5.Randevular;
            }
            bgl.baglanti().Close();

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Randevular where Id=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            this.randevularTableAdapter.Fill(this.emayDataDataSet5.Randevular);
            dataGridView1.DataSource = emayDataDataSet5.Randevular;
            bgl.baglanti().Close();

        }
    }
}
