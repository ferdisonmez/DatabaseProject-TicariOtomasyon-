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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void personellist()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        public void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbPersonelil.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();

        }
        private void clean()
        {
            TxtPersoneliAd.Text = "";
            TxtPersoneliAd.Text = "";
            TxtPersonelsoyad.Text = "";
            MskPersonelTelefon.Text = "";
            MskPersonelTc.Text = "";
            TxtPersonelMail.Text = "";
            CmbPersonelil.Text = "";
            CmbPersonelilce.Text = "";
            RchPersonelAdres.Text = "";
            TxtPersonelGorev.Text = "";
          
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            personellist();
            sehirlistesi();
            clean();
        }

        private void BtnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into PERSONELLER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersoneliAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskPersonelTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskPersonelTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtPersonelMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbPersonelil.Text);
            komut.Parameters.AddWithValue("@p7", CmbPersonelilce.Text);
            komut.Parameters.AddWithValue("@p8", RchPersonelAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtPersonelGorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellist();
        }

        private void CmbPersonelil_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbPersonelil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbPersonelilce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtPersonelid.Text = dr["ID"].ToString();
                TxtPersoneliAd.Text = dr["AD"].ToString();
                TxtPersonelsoyad.Text = dr["SOYAD"].ToString();
                MskPersonelTelefon.Text = dr["TELEFON"].ToString();
                MskPersonelTc.Text = dr["TC"].ToString();
                TxtPersonelMail.Text = dr["MAIL"].ToString();
                CmbPersonelil.Text = dr["IL"].ToString();
                CmbPersonelilce.Text = dr["ILCE"].ToString();
                RchPersonelAdres.Text = dr["ADRES"].ToString();
                TxtPersonelGorev.Text = dr["GOREV"].ToString();

            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut =new SqlCommand("Delete from PERSONELLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            personellist();
            clean();
        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,GOREV=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPersoneliAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonelsoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskPersonelTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskPersonelTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtPersonelMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbPersonelil.Text);
            komut.Parameters.AddWithValue("@p7", CmbPersonelilce.Text);
            komut.Parameters.AddWithValue("@p8", RchPersonelAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtPersonelGorev.Text);
            komut.Parameters.AddWithValue("@p10", TxtPersonelid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Musteri Sistemi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personellist();
        }
    }
}
