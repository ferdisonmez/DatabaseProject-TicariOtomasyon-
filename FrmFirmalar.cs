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
    public partial class FrmFirmalar : Form
    {
        public FrmFirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from FIRMALAR", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl17_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }
        private void clean()
        {
            TxtFirmaid.Text = "";
            TxtFirmaAd.Text = "";
            TxtFirmaYad.Text = "";
            TxtFirmaYgorev.Text = "";
            MskYtc.Text = "";
            TxtFirmaSektor.Text = "";
            MskFirmaTelefon.Text = "";
            TxtFirmaMail.Text = "";
            MskFirmaFax.Text = "";
            CmbFirmail.Text = "";
            CmbFirmailce.Text = "";
            TxtFirmaVergi.Text = "";
            RchFirmaAdres.Text = "";
            TxtKod1.Text = "";
            TxtKod2.Text = "";
            TxtKod3.Text = "";
            TxtFirmaAd.Focus();
        }
        public void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbFirmail.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();

        }
        private void cariaciklama()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from KODLAR", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                RchKod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

        }

        private void FrmFirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            clean();
            sehirlistesi();
            cariaciklama();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtFirmaid.Text = dr["ID"].ToString();
                TxtFirmaAd.Text = dr["AD"].ToString();
                TxtFirmaYgorev.Text = dr["YETKILISTATU"].ToString();
                TxtFirmaYad.Text = dr["YETKILIADSOYAD"].ToString();
                MskYtc.Text = dr["YETKILITC"].ToString();
                TxtFirmaSektor.Text = dr["SEKTOR"].ToString();
                MskFirmaTelefon.Text = dr["TELEFON"].ToString();
                TxtFirmaMail.Text = dr["MAIL"].ToString();
                MskFirmaFax.Text = dr["FAX"].ToString();
                CmbFirmail.Text = dr["IL"].ToString();
                CmbFirmailce.Text = dr["ILCE"].ToString();
                TxtFirmaVergi.Text = dr["VERGIDAIRE"].ToString();
                RchFirmaAdres.Text = dr["ADRES"].ToString();
                TxtKod1.Text = dr["OZELKOD1"].ToString();
                TxtKod2.Text = dr["OZELKOD2"].ToString();
                TxtKod3.Text = dr["OZELKOD3"].ToString();
            }
        }

        private void BtnFirmaKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into FIRMALAR (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES,OZELKOD1,OZELKOD2,OZELKOD3) values (@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16)", bgl.baglanti());
      
            komut.Parameters.AddWithValue("@p2", TxtFirmaAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtFirmaYgorev.Text);
            komut.Parameters.AddWithValue("@p4", TxtFirmaYad.Text);
            komut.Parameters.AddWithValue("@p5", MskYtc.Text);
            komut.Parameters.AddWithValue("@p6", TxtFirmaSektor.Text);
            komut.Parameters.AddWithValue("@p7", MskFirmaTelefon.Text);
            komut.Parameters.AddWithValue("@p8", TxtFirmaMail.Text);
            komut.Parameters.AddWithValue("@p9", MskFirmaFax.Text);
            komut.Parameters.AddWithValue("@p10", CmbFirmail.Text);
            komut.Parameters.AddWithValue("@p11", CmbFirmailce.Text);
            komut.Parameters.AddWithValue("@p12", TxtFirmaVergi.Text);
            komut.Parameters.AddWithValue("@p13", RchFirmaAdres.Text);
            komut.Parameters.AddWithValue("@p14", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p16", TxtKod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            firmalistesi();
            clean();
        }
    

        private void CmbFirmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbFirmail.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbFirmailce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void BtnFirmaSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from FIRMALAR where ID=@p1",bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",TxtFirmaid.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistesi();
            MessageBox.Show("Firma Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            clean();
        }

        private void BtnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON=@p6,MAIL=@p7,FAX=@p8,IL=@p9,ILCE=@p10,VERGIDAIRE=@p11,ADRES=@p12,OZELKOD1=@p13,OZELKOD2=@p14,OZELKOD3=@p15 where ID=@p16",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtFirmaAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtFirmaYgorev.Text);
            komut.Parameters.AddWithValue("@p3", TxtFirmaYad.Text);
            komut.Parameters.AddWithValue("@p4", MskYtc.Text);
            komut.Parameters.AddWithValue("@p5", TxtFirmaSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskFirmaTelefon.Text);
            komut.Parameters.AddWithValue("@p7", TxtFirmaMail.Text);
            komut.Parameters.AddWithValue("@p8", MskFirmaFax.Text);
            komut.Parameters.AddWithValue("@p9", CmbFirmail.Text);
            komut.Parameters.AddWithValue("@p10", CmbFirmailce.Text);
            komut.Parameters.AddWithValue("@p11", TxtFirmaVergi.Text);
            komut.Parameters.AddWithValue("@p12", RchFirmaAdres.Text);
            komut.Parameters.AddWithValue("@p13", TxtKod1.Text);
            komut.Parameters.AddWithValue("@p14", TxtKod2.Text);
            komut.Parameters.AddWithValue("@p15", TxtKod3.Text);
            komut.Parameters.AddWithValue("@p16", TxtFirmaid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalistesi();
            clean();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}