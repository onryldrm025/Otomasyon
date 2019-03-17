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
    public partial class Gelir : Form
    {
        public Gelir()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void Gelir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emayDataDataSet15.YapılanIslemler' table. You can move, or remove it, as needed.
            this.yapılanIslemlerTableAdapter.Fill(this.emayDataDataSet15.YapılanIslemler);
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.Text = DateTime.Today.AddDays(-1).ToString();
            dateTimePicker2.MaxDate = DateTime.Today.AddDays(-1);
            //Bugun Gelir Sadec

            SqlCommand komut = new SqlCommand("Select * from YapılanIslemler where Islemtarihi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            bgl.baglanti().Close();
            dataGridView1.DataSource = dt;
            //
            SqlCommand komut2 = new SqlCommand("Select sum(tutar) from YapılanIslemler where Islemtarihi=@p1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                label4.Text =  "Kazancınız:" + dr[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btngetir_Click(object sender, EventArgs e)
        {
           
            SqlCommand komut = new SqlCommand("Select * from YapılanIslemler where Islemtarihi<=@p1 and Islemtarihi>=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            komut.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select sum(tutar) from YapılanIslemler where Islemtarihi<=@p1 and Islemtarihi>=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            komut2.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());
            SqlDataReader dr = komut2.ExecuteReader();
            while(dr.Read())
            {
                label4.Text = dateTimePicker2.Text.ToString()+"'den\n"+dateTimePicker1.Text.ToString()+" kadar olan kazancınız:"+dr[0].ToString()+"TL";
            }
            bgl.baglanti().Close();

        }
    }
}
