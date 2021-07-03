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
    public partial class Faturalar : Form
    {
        public Faturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FATURABILGI", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource= dt;
        }
        private void Temizle()
        {
            TxtSeri.Text = "";
            TxtSiraNo.Text = "";
            MskFaturaTarih.Text = "";
            MskFaturaSaat.Text = "";
            TxtFaturaVergi.Text = "";
            TxtFaturaAlici.Text = "";
            TxtTeslimEden.Text = "";
            TxtTeslimAlan.Text = "";

        }
        private void Faturalar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void BtnFaturaKaydet_Click(object sender, EventArgs e)
        {
            if(TxtFaturaDID.Text=="") ///Fatura Bilgileri Kaydedilir
            {
                SqlCommand komut = new SqlCommand("insert into FATURABILGI (SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
                komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
                komut.Parameters.AddWithValue("@p3", MskFaturaTarih.Text);
                komut.Parameters.AddWithValue("@p4", MskFaturaSaat.Text);
                komut.Parameters.AddWithValue("@p5", TxtFaturaVergi.Text);
                komut.Parameters.AddWithValue("@p6", TxtFaturaAlici.Text);
                komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Listele();
            }
            if (TxtFaturaDID.Text != "")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(TxtDetayFiyat.Text);
                miktar = Convert.ToDouble(TxtUrunMiktar.Text);
                tutar = miktar * fiyat;
                TxtUrunTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into FATURADETAY (URUNADI,MIKTAR,FIYAT,TUTAR,FATURAID) VALUES (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1",TxtUrunAd.Text);
                komut2.Parameters.AddWithValue("@p2", TxtUrunMiktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse( TxtDetayFiyat.Text));
                komut2.Parameters.AddWithValue("@p4",decimal.Parse(TxtUrunTutar.Text));
                komut2.Parameters.AddWithValue("@p5", TxtFaturaid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand komut3 = new SqlCommand("insert into FIRMAHAREKETLER (URUNID,ADET,PERSONEL,FIRMA,FIYAT,TOPLAM,FATURAID,TARIH) VALUES (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8)",bgl.baglanti());
                komut3.Parameters.AddWithValue("@h1", TxtUrunID.Text);
                komut3.Parameters.AddWithValue("@h2", TxtUrunMiktar.Text);
                komut3.Parameters.AddWithValue("@h3", TxtPersonel.Text);
                komut3.Parameters.AddWithValue("@h4", TxtFirma.Text);
                komut3.Parameters.AddWithValue("@h5",decimal.Parse(TxtDetayFiyat.Text));
                komut3.Parameters.AddWithValue("@h6",decimal.Parse( TxtUrunTutar.Text));
                komut3.Parameters.AddWithValue("@h7", TxtFaturaid.Text);
                komut3.Parameters.AddWithValue("@h8", MskFaturaTarih.Text);
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Listele();
            }

        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtFaturaid.Text = dr["FATURABILGID"].ToString();
                TxtSeri.Text = dr["SERI"].ToString();
                TxtSiraNo.Text = dr["SIRANO"].ToString();
                MskFaturaTarih.Text = dr["TARIH"].ToString();
                MskFaturaSaat.Text = dr["SAAT"].ToString();
                TxtFaturaVergi.Text = dr["VERGIDAIRE"].ToString();
                TxtFaturaAlici.Text = dr["ALICI"].ToString();
                TxtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                TxtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            }///İf

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnFaturaSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from FATURABILGI where FATURABILGID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtFaturaid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnFaturaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtSeri.Text);
            komut.Parameters.AddWithValue("@p2", TxtSiraNo.Text);
            komut.Parameters.AddWithValue("@p3", MskFaturaTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskFaturaSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtFaturaVergi.Text);
            komut.Parameters.AddWithValue("@p6", TxtFaturaAlici.Text);
            komut.Parameters.AddWithValue("@p7", TxtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", TxtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", TxtFaturaid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunler fr = new FrmFaturaUrunler();
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                fr.id = dr["FATURABILGID"].ToString();
            }
            fr.Show();

        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select Urunad,Satısfıyat from URUNLER where ID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtUrunID.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtUrunAd.Text = dr[0].ToString();
                TxtDetayFiyat.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
