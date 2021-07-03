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
    public partial class Bankalar : Form
    {
        public Bankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Execute BankaBilgisi", bgl.baglanti());  ///Procedure İçerisinde Joinler
            da.Fill(dt);
            gridControl2.DataSource=dt;

        }
        public void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from FIRMALAR",bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void Temizle()
        {
            TxtBankaAd.Text = "";
            TxtBankaSube.Text = "";
            CmbBankail.Text = "";
            CmbBankailce.Text = "";
            MskIBAN.Text = "";
            HesapNoB.Text = "";
            TxtYetkiliName.Text = "";
            MskBankaTlfn.Text = "";
            MskTarih.Text = "";
            TxtHesapTuru.Text = "";
         //   TxtFirma.Text = "";
        }
        public void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBankail.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();

        }

        private void Bankalar_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
            sehirlistesi();
            FirmaListesi();
        }

        private void BtnBankaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into BANKALAR (BANKADI,SUBE,IL,ILCE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtBankaSube.Text);
            komut.Parameters.AddWithValue("@p3", CmbBankail.Text);
            komut.Parameters.AddWithValue("@p4", CmbBankailce.Text);
            komut.Parameters.AddWithValue("@p5", MskIBAN.Text);
            komut.Parameters.AddWithValue("@p6", HesapNoB.Text);
            komut.Parameters.AddWithValue("@p7", TxtYetkiliName.Text);
            komut.Parameters.AddWithValue("@p8", MskBankaTlfn.Text);
            komut.Parameters.AddWithValue("@p9", MskTarih.Text);
            komut.Parameters.AddWithValue("@p10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@p11",lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            Listele();
            bgl.baglanti();
            MessageBox.Show("Banka Sisteme Kaydedildi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Temizle();
        }

        private void CmbBankail_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBankail.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBankailce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtBankaid.Text = dr["ID"].ToString();
                TxtBankaAd.Text = dr["BANKADI"].ToString();
                TxtBankaSube.Text = dr["SUBE"].ToString();
                CmbBankail.Text = dr["IL"].ToString();
                CmbBankailce.Text = dr["ILCE"].ToString();
                MskIBAN.Text = dr["IBAN"].ToString();
                HesapNoB.Text = dr["HESAPNO"].ToString();
                TxtYetkiliName.Text = dr["YETKILI"].ToString();
                MskBankaTlfn.Text = dr["TELEFON"].ToString();
                MskTarih.Text = dr["TARIH"].ToString();
                TxtHesapTuru.Text = dr["HESAPTURU"].ToString();

            }
        }

        private void BtnBankaSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from BANKALAR where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBankaid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void BtnBankaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update BANKALAR set BANKADI=@P1,SUBE=@P2,IL=@P3,ILCE=@P4,IBAN=@P5,HESAPNO=@P6,YETKILI=@P7,TELEFON=@P8,TARIH=@P9,HESAPTURU=@P10,FIRMAID=@P11 WHERE ID=@P12", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtBankaAd.Text);
            komut.Parameters.AddWithValue("@P2", TxtBankaSube.Text);
            komut.Parameters.AddWithValue("@P3", CmbBankail.Text);
            komut.Parameters.AddWithValue("@P4", CmbBankailce.Text);
            komut.Parameters.AddWithValue("@P5", MskIBAN.Text);
            komut.Parameters.AddWithValue("@P6", HesapNoB.Text);
            komut.Parameters.AddWithValue("@P7", TxtYetkiliName.Text);
            komut.Parameters.AddWithValue("@P8", MskBankaTlfn.Text);
            komut.Parameters.AddWithValue("@P9", MskTarih.Text);
            komut.Parameters.AddWithValue("@P10", TxtHesapTuru.Text);
            komut.Parameters.AddWithValue("@P11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@P12", TxtBankaid.Text);
            komut.ExecuteNonQuery();
            Listele();
            bgl.baglanti();
            MessageBox.Show("Banka Sistemi Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Temizle();
        }
    }
}
