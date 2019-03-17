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
    public partial class YoneticiEkran : Form
    {
        public YoneticiEkran()
        {
            InitializeComponent();
        }
        public void guncelle()
        {
            this.randevularTableAdapter1.Fill(this.emayDataDataSet4.Randevular);
          



            // bugun randevu
            SqlCommand komut = new SqlCommand("Select Count(Tarıh) From Randevular where Tarıh=@p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbbrandevu.Text = dr[0].ToString();
            }
            dr.Close();
            bgl.baglanti().Close();
            
            
           
            // bugun on gorusme
            SqlCommand komut1 = new SqlCommand("Select Count(Ontarıh) From Randevular where Ontarıh=@p1 ", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbbongorus.Text = dr1[0].ToString();
            }
            dr1.Close();
            bgl.baglanti().Close();

            // bugun mıssayısı
            SqlCommand komut2 = new SqlCommand("Select sum(Mıssay) From Randevular where Tarıh=@p1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbbmıssay.Text = dr2[0].ToString();
            }
            dr2.Close();
            bgl.baglanti().Close();

            // bugun avans
            SqlCommand komut3 = new SqlCommand("Select sum(VerilenAvans) From Verilenavans where VerilenTarih=@p1 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while(dr3.Read())
            {
                lbbavans.Text = dr3[0].ToString();
            }
            dr3.Close();
            bgl.baglanti().Close();

            // izinli eleman 
            SqlCommand komut4 = new SqlCommand("Select (Adsoyad) From Verilenizin where Verilenİzin=@p1 ", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbbeleman.Text = dr4[0].ToString();
            }
            dr4.Close();
            bgl.baglanti().Close();

            // Gelir

            SqlCommand komut5 = new SqlCommand("Select sum(tutar) From YapılanIslemler where Islemtarihi=@p1 ", bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbbgelir.Text = "+"+dr5[0].ToString();
            }
            dr5.Close();
            bgl.baglanti().Close();

            // gider

            SqlCommand komut6 = new SqlCommand("Select sum(Gider) From Gider where Gidertarih=@p1 ", bgl.baglanti());
            komut6.Parameters.AddWithValue("@p1", dateTimePicker1.Text);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lbbgider.Text = "-"+dr6[0].ToString();
            }
            dr6.Close();
            bgl.baglanti().Close();



        }
        public void dtguncel()


        {
            DataTable dt = new DataTable();
            string secilen = dateTimePicker1.Text.ToString();
            secilen = "'" + secilen + "'";
            SqlDataAdapter da = new SqlDataAdapter("Select * From Randevular Where Tarıh=" + secilen, bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Randevular Where Ontarıh=" + secilen, bgl.baglanti());
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yenirandevu yeniran = new Yenirandevu();
            yeniran.FormClosed += Yeniran_FormClosed;
            yeniran.ShowDialog();
            
            
            
           
            
        }

        private void Yeniran_FormClosed(object sender, FormClosedEventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            dataGridView1.DataSource = emayDataDataSet4.Randevular;
            guncelle();
            this.randevularTableAdapter1.Fill(this.emayDataDataSet4.Randevular);

        }

        private void YoneticiEkran_Load(object sender, EventArgs e)
        {
            
            this.randevularTableAdapter1.Fill(this.emayDataDataSet4.Randevular);
            guncelle();



        }

        private void BtnRanguncel_Click(object sender, EventArgs e)
        {
            RandevuGuncel yrangun = new RandevuGuncel();
            yrangun.FormClosed += Yrangun_FormClosed;
            yrangun.ShowDialog();

        }

        private void Yrangun_FormClosed(object sender, FormClosedEventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            dataGridView1.DataSource = emayDataDataSet4.Randevular;
            this.randevularTableAdapter1.Fill(this.emayDataDataSet4.Randevular);
            guncelle();
        }

        private void btnElemanEkle_Click(object sender, EventArgs e)
        {
            ElemanEkle Yelmanfr = new ElemanEkle();
            Yelmanfr.Show();
            

        }

        private void ElemanIzın_Click(object sender, EventArgs e)
        {
            Elemanızın frelemanızın = new Elemanızın();
            frelemanızın.FormClosed += Frelemanızın_FormClosed;
            frelemanızın.ShowDialog();
              
        }

        private void Frelemanızın_FormClosed(object sender, FormClosedEventArgs e)
        {
            guncelle();

           
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        private void BtnGelır_Click(object sender, EventArgs e)
        {
            Gelir ftge = new Gelir();
            ftge.ShowDialog();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guncelle();
            dtguncel();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btntumrand_Click(object sender, EventArgs e)
        {

            dateTimePicker1.Text = DateTime.Today.ToString();
            dataGridView1.DataSource = emayDataDataSet4.Randevular;
            this.randevularTableAdapter1.Fill(this.emayDataDataSet4.Randevular);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Btngrafık_Click(object sender, EventArgs e)
        {
            grafikler gfr = new grafikler();
            gfr.ShowDialog();
        }

        private void BtnGider_Click_1(object sender, EventArgs e)
        {
            Gider frgider = new Gider();
            frgider.FormClosed += Frgider_FormClosed;
            frgider.ShowDialog();
        }

        private void Frgider_FormClosed(object sender, FormClosedEventArgs e)
        {
            guncelle();
        }

        private void lbbgelir_Click(object sender, EventArgs e)
        {

        }

        private void BtnGelirGra_Click(object sender, EventArgs e)
        {
            GelirGrafik yfrg = new GelirGrafik();
            yfrg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiderGrafik yfgg = new GiderGrafik();
            yfgg.ShowDialog(); 
        }
    }
}
