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
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        sqlbaglantısı bgl = new sqlbaglantısı();
       
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(comPoz.SelectedItem.ToString()=="Yönetici")
            {
                
                SqlCommand komut = new SqlCommand("select * From Yonetenler Where Id=@ıd and Sıfre=@sıfre", bgl.baglanti());
                komut.Parameters.AddWithValue("@ıd", txtıd.Text);
                komut.Parameters.AddWithValue("@sıfre", txtsıfre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("Giriş Basarılı");
                    YoneticiEkran yfr = new YoneticiEkran();
                    yfr.Show();
                    this.Hide();
                    yfr.FormClosed += yfr_FormClosed;
                   



                }
                
                else
                {
                    MessageBox.Show("İd Veya Şifre Yanlış Lütfen Tekrar Deneyiniz");
                }
                bgl.baglanti().Close();
                
                

           

            }
            if (comPoz.SelectedItem.ToString() == "Personel")
            {
                SqlCommand komut = new SqlCommand("select * From Personeller Where Id=@ıd and Sıfre=@sıfre", bgl.baglanti());
                komut.Parameters.AddWithValue("@ıd", txtıd.Text);
                komut.Parameters.AddWithValue("@sıfre", txtsıfre.Text);
                SqlDataReader dr = komut.ExecuteReader();
              
                if (dr.Read())
                {
                    
                    MessageBox.Show("Giriş Basarılı");
                    PersonelEkran frper = new PersonelEkran();
                    frper.idm = txtıd.Text.ToString();
                    frper.Show();
                    this.Hide();
                    
                    frper.FormClosed += Frper_FormClosed;
                    

                }
                else
                {
                    MessageBox.Show("İd Veya Şifre Yanlış Lütfen Tekrar Deneyiniz");
                }
                bgl.baglanti().Close();



            }
            
        }

        private void Frper_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void yfr_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void GirisEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
