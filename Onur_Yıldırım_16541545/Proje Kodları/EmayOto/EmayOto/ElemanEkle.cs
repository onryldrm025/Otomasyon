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
    public partial class ElemanEkle : Form
    {
        public ElemanEkle()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtsıfre.Text==txtSıfretek.Text)
            {
                SqlCommand komut = new SqlCommand("insert into Personeller (Id,Sıfre,Adsoyad)values(@p1,@p2,@p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtId.Text);
                komut.Parameters.AddWithValue("@p2", txtsıfre.Text);
                komut.Parameters.AddWithValue("@p3", txtad.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Eleman Eklendi Hayırlı Olsun");
                this.Close();
            }
           else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Tekrar Deneyiniz!");
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
