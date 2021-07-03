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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void labelControl21_Click(object sender, EventArgs e)
        {

        }
        public void Temizle()
        {
            CmbGay.Text = " ";
            CmbGyıl.Text = " ";
            TxtGelektrik.Text = " ";
            TxtGsu.Text = " ";
            TxtGdogalgaz.Text = " ";
            TxtGinternet.Text = " ";
            TxtGmaas.Text = " ";
            TxtGextra.Text = " ";
            RchGnotlar.Text = " ";

        }
        public void GiderlerList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from GiderlerFaturaPrint", bgl.baglanti());  ///*******Wiew
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        private void FrmGiderler_Load(object sender, EventArgs e)
        {
            GiderlerList();
            Temizle();
        }

        private void BtnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into GIDERLER (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",CmbGay.Text);
            komut.Parameters.AddWithValue("@p2", CmbGyıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtGelektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtGsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtGdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtGinternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtGmaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtGextra.Text));
            komut.Parameters.AddWithValue("@p9", RchGnotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Gider Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GiderlerList();
            Temizle();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
              //  TxtGid.Text = dr["ID"].ToString();
                CmbGay.Text = dr["AY"].ToString();
                CmbGay.Text = dr["YIL"].ToString();
                TxtGelektrik.Text = dr["ELEKTRIK"].ToString();
                TxtGsu.Text = dr["SU"].ToString();
                TxtGdogalgaz.Text = dr["DOGALGAZ"].ToString();
                TxtGinternet.Text = dr["INTERNET"].ToString();
              //  TxtGmaas.Text = dr["MAASLAR"].ToString();
               // TxtGextra.Text = dr["EKSTRA"].ToString();
              //  RchGnotlar.Text = dr["NOTLAR"].ToString();


            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from GIDERLER where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtGid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            GiderlerList();
            MessageBox.Show("Gider Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Temizle();
        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbGay.Text);
            komut.Parameters.AddWithValue("@p2", CmbGyıl.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(TxtGelektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(TxtGsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(TxtGdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtGinternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtGmaas.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(TxtGextra.Text));
            komut.Parameters.AddWithValue("@p9", RchGnotlar.Text);
            komut.Parameters.AddWithValue("@p10", TxtGid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Gider Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GiderlerList();
            Temizle();
        }
    }
}
