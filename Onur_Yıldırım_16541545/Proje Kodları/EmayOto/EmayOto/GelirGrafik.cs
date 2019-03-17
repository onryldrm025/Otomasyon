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
    public partial class GelirGrafik : Form
    {
        public GelirGrafik()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void GelirGrafik_Load(object sender, EventArgs e)
        {

            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.AddDays(-7).ToString();
            SqlCommand komutg2 = new SqlCommand("select Islemtarihi,sum(tutar) From YapılanIslemler where Islemtarihi<@p1 and Islemtarihi>=@p2 Group by Islemtarihi", bgl.baglanti());
            komutg2.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            komutg2.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Gelir"].Points.AddXY(dr2[0], dr2[1]);

            }


            dateTimePicker2.Visible = false;
            dateTimePicker1.Visible = false;



        }
    }
}
