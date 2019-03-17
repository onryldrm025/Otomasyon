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
    public partial class GiderGrafik : Form
    {
        public GiderGrafik()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void GiderGrafik_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.AddDays(-7).ToString();


            SqlCommand komutg2 = new SqlCommand("select Gidertarih,sum(Gider) From Gider where Gidertarih<@p1 and Gidertarih>=@p2 Group by Gidertarih", bgl.baglanti());
            komutg2.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            komutg2.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart1.Series["Gider"].Points.AddXY(dr2[0], dr2[1]);

            }


            dateTimePicker2.Visible = false;
            dateTimePicker1.Visible = false;
        }
    }
}
