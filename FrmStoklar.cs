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

namespace TicariOtomasyon
{
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmStoklar_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select Urunad,sum(Adet) As 'Miktar' from URUNLER group by Urunad",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            ///Grafik için
            SqlCommand komut = new SqlCommand("Select Urunad,sum(Adet) As 'Miktar' from URUNLER group by Urunad", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]),int.Parse(dr[1].ToString()));
            }
            bgl.baglanti().Close();
        }
    }
}
