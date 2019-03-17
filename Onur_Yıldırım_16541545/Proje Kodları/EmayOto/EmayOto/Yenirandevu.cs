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
    public partial class Yenirandevu : Form
    {
        public Yenirandevu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        sqlbaglantısı bgl = new sqlbaglantısı();


        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAdsoyad.Text.Length==0)
            {
                MessageBox.Show("İlgili Alanlar Boş Kalamaz!!");
               
            }
          
            else
            { 


            SqlCommand komut = new SqlCommand("insert into Randevular (Adsoyad,Telefon,Salon,Nıtelık,Tarıh,Ontarıh,Mıssay)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAdsoyad.Text);
            komut.Parameters.AddWithValue("@p2", mskTel.Text);
            komut.Parameters.AddWithValue("@p3", cbxsalon.Text);
            komut.Parameters.AddWithValue("@p4", cbxnitelik.Text);
            komut.Parameters.AddWithValue("@p5", dttarıh.Text);
            komut.Parameters.AddWithValue("@p6", dttontarıh.Text);
            komut.Parameters.AddWithValue("@p7", cbxmissay.Text);

            komut.ExecuteNonQuery();
            
            bgl.baglanti().Close();
            this.Close();
            }

        }

        private void Yenirandevu_Load(object sender, EventArgs e)
        {

        }

        private void Yenirandevu_Load_1(object sender, EventArgs e)
        {
            
           dttarıh.MinDate = DateTime.Today.AddDays(+1);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dttarıh_ValueChanged(object sender, EventArgs e)
        {
           dttontarıh.MaxDate = Convert.ToDateTime(dttarıh.Text).AddDays(-1);

           dttontarıh.MinDate = DateTime.Today;
            
        }
    }
}
