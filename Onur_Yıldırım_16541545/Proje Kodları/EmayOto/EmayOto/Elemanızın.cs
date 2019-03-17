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
    public partial class Elemanızın : Form
    {
        public Elemanızın()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
          

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Seçilen Kişi İzimn listeleme
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilen = cmbElemalar.Text;
            secilen = "'"+secilen+"'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Verilenizin Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }
     




        private void Elemanızın_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emayDataDataSet20.Verilenavans' table. You can move, or remove it, as needed.
            this.verilenavansTableAdapter4.Fill(this.emayDataDataSet20.Verilenavans);
            // TODO: This line of code loads data into the 'emayDataDataSet19.Verilenizin' table. You can move, or remove it, as needed.
            this.verilenizinTableAdapter3.Fill(this.emayDataDataSet19.Verilenizin);
            // TODO: This line of code loads data into the 'emayDataDataSet18.Verilenavans' table. You can move, or remove it, as needed.
            this.verilenavansTableAdapter3.Fill(this.emayDataDataSet18.Verilenavans);
            // TODO: This line of code loads data into the 'emayDataDataSet11.Verilenavans' table. You can move, or remove it, as needed.
            this.verilenavansTableAdapter2.Fill(this.emayDataDataSet11.Verilenavans);
            // TODO: This line of code loads data into the 'emayDataDataSet10.Verilenavans' table. You can move, or remove it, as needed.
            this.verilenavansTableAdapter1.Fill(this.emayDataDataSet10.Verilenavans);

            // TODO: This line of code loads data into the 'emayDataDataSet8.Verilenizin' table. You can move, or remove it, as needed.
            this.verilenizinTableAdapter2.Fill(this.emayDataDataSet8.Verilenizin);

            // Boxlara Verileri Alma
            txtaıd.Enabled = false;
            txtid.Enabled = false;
            SqlCommand komut = new SqlCommand("Select Adsoyad From Personeller ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbElemalar.Items.Add(dr[0]);
                cmbEleman2.Items.Add(dr[0]);
            }


            bgl.baglanti().Close();

           
            
            dtizin.MinDate = DateTime.Now;




        }
        // İzin Ekleme
        private void btnIzın_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into Verilenizin (Adsoyad,Verilenİzin,Gerekcesi)values(@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbElemalar.Text);
            komut.Parameters.AddWithValue("@p2", dtizin.Text.ToString());
            komut.Parameters.AddWithValue("@p3", rtxtGerek.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            string secilen = cmbElemalar.Text;
            secilen = "'" + secilen + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Verilenizin Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();


        }
        // Avans Ekleme
        private void btnAvans_Click(object sender, EventArgs e)
        {
            
           

            SqlCommand komut = new SqlCommand("insert into VerilenAvans (AdSoyad,VerilenAvans,VerilenTarih)values(@p1,@p2,@p3)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbEleman2.Text);
            komut.Parameters.AddWithValue("@p2", mskAvans.Text);
            komut.Parameters.AddWithValue("@p3", dtavans.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            string secilen = cmbEleman2.Text;

            SqlCommand komut2 = new SqlCommand("insert into Gider (Gider,Gidertarih,Nedeni)values(@p1,@p2,@p3)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", mskAvans.Text);
            komut2.Parameters.AddWithValue("@p2", dtavans.Text.ToString());
            komut2.Parameters.AddWithValue("@p3", "Avans");

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();


            secilen = "'" + secilen + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From VerilenAvans Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            bgl.baglanti().Close();


        }
        // Secilen Eleman Avans Gösterme
        private void cmbEleman2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cmbEleman2.Text;
            secilen = "'" + secilen + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From VerilenAvans Where Adsoyad=" + secilen, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dtavans_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtElemanad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txttarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            rcgerek.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Update Verilenizin set Adsoyad=@p1,Verilenİzin=@p2,Gerekcesi=@p3 where Id=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtElemanad.Text);
            komut.Parameters.AddWithValue("@p2", txttarih.Text);
            komut.Parameters.AddWithValue("@p3", rcgerek.Text);
            komut.Parameters.AddWithValue("@p4", txtid.Text);


            komut.ExecuteNonQuery();
            this.verilenizinTableAdapter2.Fill(this.emayDataDataSet8.Verilenizin);
            dataGridView1.DataSource = emayDataDataSet8.Verilenizin;
            MessageBox.Show("Bilgiler Güncellendi");
        }

        private void txtElemanad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtaıd.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtaadsoyad.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            mskavansg.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            txtatarıh.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Verilenavans set Adsoyad=@p1,VerilenAvans=@p2,VerilenTarih=@p3 where Id=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtaadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", mskavansg.Text);
            komut.Parameters.AddWithValue("@p3", txtatarıh.Text);
            komut.Parameters.AddWithValue("@p4", txtaıd.Text);


            komut.ExecuteNonQuery();
           
            dataGridView2.DataSource = emayDataDataSet20.Verilenavans;
            this.verilenavansTableAdapter4.Fill(this.emayDataDataSet20.Verilenavans);
            MessageBox.Show("Bilgiler Güncellendi");

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
