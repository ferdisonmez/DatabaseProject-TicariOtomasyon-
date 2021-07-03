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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from MUSTERILER",bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        public void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("Select SEHIR from ILLER",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbMusteril.Properties.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();

        }


 
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
        }

        private void CmbMusteril_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select ILCE from ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbMusteril.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbMusterilce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void BtnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into MUSTERILER (AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMusteriAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtMusterisoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskMusteriTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMusteriMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbMusteril.Text);
            komut.Parameters.AddWithValue("@p7", CmbMusterilce.Text);
            komut.Parameters.AddWithValue("@p8", RchMusteriAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtMusteriVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteri Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr!=null)
            {
                TxtMusterid.Text = dr["ID"].ToString();
                TxtMusteriAd.Text = dr["AD"].ToString();
                TxtMusterisoyad.Text = dr["SOYAD"].ToString();
                MskTelefon.Text = dr["TELEFON"].ToString();
                MskMusteriTc.Text = dr["TC"].ToString();
                TxtMusteriMail.Text = dr["MAIL"].ToString();
                CmbMusteril.Text = dr["IL"].ToString();
                CmbMusterilce.Text = dr["ILCE"].ToString();
                RchMusteriAdres.Text = dr["ADRES"].ToString();
                TxtMusteriVergi.Text = dr["VERGIDAIRE"].ToString();

                
            }
        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from MUSTERILER where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMusterid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteri Sistemden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            listele();
        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,ADRES=@p8,VERGIDAIRE=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMusteriAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtMusterisoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", MskMusteriTc.Text);
            komut.Parameters.AddWithValue("@p5", TxtMusteriMail.Text);
            komut.Parameters.AddWithValue("@p6", CmbMusteril.Text);
            komut.Parameters.AddWithValue("@p7", CmbMusterilce.Text);
            komut.Parameters.AddWithValue("@p8", RchMusteriAdres.Text);
            komut.Parameters.AddWithValue("@p9", TxtMusteriVergi.Text);
            komut.Parameters.AddWithValue("@p10", TxtMusterid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müsteri Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();

        }
    }
}
