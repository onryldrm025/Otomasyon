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
    public partial class Avansveizinlerim : Form
    {
        public Avansveizinlerim()
        {
            InitializeComponent();
        }
        public string idm;
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void Avansveizinlerim_Load(object sender, EventArgs e)
        {
            lbbad.Text = idm;
            SqlCommand komut = new SqlCommand("Select Adsoyad from Personeller where Id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", idm);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lbbad.Text = dr[0].ToString();

            }

            bgl.baglanti().Close();
          


            string secilen = lbbad.Text;
            secilen = "'" + secilen + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From VerilenAvans Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


         
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Verilenizin Where Adsoyad=" + secilen, bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
