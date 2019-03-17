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
    public partial class Gider : Form
    {
        public Gider()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void guncelle()
        {
            DataTable dt = new DataTable();
            string secilen = dateTimePicker1.Text.ToString();
            secilen = "'" + secilen + "'";
            SqlDataAdapter da = new SqlDataAdapter("Select * From Gider Where Gidertarih=" + secilen, bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;



            bgl.baglanti().Close();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Gider (Gider,Gidertarih,Nedeni) values (@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msktutar.Text);
            komut.Parameters.AddWithValue("@p2",dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@p3",rcneden.Text);
            komut.ExecuteNonQuery();
            guncelle();
            bgl.baglanti().Close();
        }

        private void Gider_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            // TODO: This line of code loads data into the 'emayDataDataSet16.Gider' table. You can move, or remove it, as needed.
            this.giderTableAdapter.Fill(this.emayDataDataSet16.Gider);
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guncelle();
           
        }
    }
}
