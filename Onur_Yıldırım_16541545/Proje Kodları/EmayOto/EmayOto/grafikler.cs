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
    public partial class grafikler : Form
    {
        public grafikler()
        {
            InitializeComponent();
        }
        sqlbaglantısı bgl = new sqlbaglantısı();
        private void grafikler_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.AddDays(-7).ToString();
            SqlCommand komutg1 = new SqlCommand("select Tarıh,count(*) From Randevular where Tarıh<@p1 and Tarıh>=@p2 Group by Tarıh", bgl.baglanti());
            komutg1.Parameters.AddWithValue("@p1",dateTimePicker1.Text.ToString());
            komutg1.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while(dr1.Read())
                {
                chart1.Series["Randevular"].Points.AddXY(dr1[0], dr1[1]);

            }


            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.AddDays(-7).ToString();
            SqlCommand komutg2 = new SqlCommand("select Tarıh,sum(Mıssay) From Randevular where Tarıh<@p1 and Tarıh>=@p2 Group by Tarıh", bgl.baglanti());
            komutg2.Parameters.AddWithValue("@p1", dateTimePicker1.Text.ToString());
            komutg2.Parameters.AddWithValue("@p2", dateTimePicker2.Text.ToString());
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Missay"].Points.AddXY(dr2[0], dr2[1]);

            }


            dateTimePicker2.Visible = false;
            dateTimePicker1.Visible = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        
        }
    }
}
