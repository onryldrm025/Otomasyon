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
    public partial class PersonelEkran : Form
    {
        public PersonelEkran()
        {
            InitializeComponent();
        }
        public string idm;
        sqlbaglantısı bgl = new sqlbaglantısı();
        public void dtguncel()
        {
            // İşlem
            DataTable dt3 = new DataTable();
            SqlCommand komut = new SqlCommand("Select * from YapılanIslemler where Adsoyad=@p1 and Islemtarihi=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbbadım.Text);
            komut.Parameters.AddWithValue("@p2", dateTimePicker1.Text);
            SqlDataAdapter da0 = new SqlDataAdapter();
            da0.SelectCommand = komut;
            
            da0.Fill(dt3);
            dataGridView2.DataSource = dt3;
            bgl.baglanti().Close();
            //////////////
            //randevu
            DataTable dt1 = new DataTable();
            string secilen = dateTimePicker1.Text.ToString();
            secilen = "'" + secilen + "'";
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Randevular Where Tarıh=" + secilen, bgl.baglanti());

            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();


            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Randevular Where Ontarıh=" + secilen, bgl.baglanti());
            da2.Fill(dt1);
            dataGridView1.DataSource = dt1;
            bgl.baglanti().Close();
            ///////////
        }

        private void PersonelEkran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emayDataDataSet17.YapılanIslemler' table. You can move, or remove it, as needed.
            this.yapılanIslemlerTableAdapter2.Fill(this.emayDataDataSet17.YapılanIslemler);
            dateTimePicker1.Text = DateTime.Today.ToString();

            // TODO: This line of code loads data into the 'emayDataDataSet12.Randevular' table. You can move, or remove it, as needed.
            this.randevularTableAdapter.Fill(this.emayDataDataSet12.Randevular);
            lbbadım.Text = idm;
            txtıd.Enabled = false;

            SqlCommand komut = new SqlCommand("Select Adsoyad from Personeller where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", idm);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                lbbadım.Text = dr[0].ToString();

            }

            bgl.baglanti().Close();

            dtguncel();
          




        }
        public void tumran()
        {
            dataGridView1.DataSource = emayDataDataSet12.Randevular;
        }
        private void lbbadım_Click(object sender, EventArgs e)
        {

        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into YapılanIslemler (Adsoyad,Yapılanıslem,Islemtarihi,tutar) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lbbadım.Text);
            komut.Parameters.AddWithValue("@p2",txtıslem.Text);
            komut.Parameters.AddWithValue("@p3",dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p4",msktutar.Text);
            komut.ExecuteNonQuery();
            dtguncel();
            bgl.baglanti().Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtguncel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            tumran();
        }

        private void Fryeni_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Fyeni_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.randevularTableAdapter.Fill(this.emayDataDataSet12.Randevular);
            dataGridView1.DataSource = emayDataDataSet12.Randevular;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandevuGuncel yrangun = new RandevuGuncel();
            yrangun.FormClosed += Yrangun_FormClosed;
            yrangun.ShowDialog();
            
        }

        private void Yrangun_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            this.randevularTableAdapter.Fill(this.emayDataDataSet12.Randevular);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Avansveizinlerim yfavans = new Avansveizinlerim();
            yfavans.idm = this.idm;
            yfavans.ShowDialog();
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtıd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtyapıs.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            txttarih.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            msktutarg.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update YapılanIslemler set Yapılanıslem=@p2,Islemtarihi=@p3,tutar=@p4 where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtyapıs.Text);
            komut.Parameters.AddWithValue("@p3", txttarih.Text);
            komut.Parameters.AddWithValue("@p4", msktutarg.Text);
            komut.Parameters.AddWithValue("@p1", txtıd.Text);
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellenme Başarılı");
            dtguncel();
            bgl.baglanti().Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from YapılanIslemler where Id=@p1", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p1", txtıd.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı");
            dtguncel();
           

        }
    }
}
