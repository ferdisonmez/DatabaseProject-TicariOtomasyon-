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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void NotListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from NOTLAR",bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void Temizle()
        {
            TxtNotid.Text = "";
            MskNotTarih.Text = "";
            MskNotSaat.Text = "";
            TxtNotBaslik.Text = "";
            RchNotDetay.Text = "";
            TxtNotOlusturan.Text = "";
            TxtHitap.Text = "";
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            NotListele();
            Temizle();
        }

        private void BtnNotKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into NOTLAR (NOTTARIH,NOTSAAT,NOTBASLIK,NOTDETAY,NOTOLUSTURAN,NOTHITAP) VALUES (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", MskNotTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskNotSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtNotBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchNotDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtNotOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            NotListele();
            MessageBox.Show("Not Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                TxtNotid.Text = dr["NOTID"].ToString();
                MskNotTarih.Text = dr["NOTTARIH"].ToString();
                MskNotSaat.Text = dr["NOTSAAT"].ToString();
                TxtNotBaslik.Text = dr["NOTBASLIK"].ToString();
                RchNotDetay.Text = dr["NOTDETAY"].ToString();
                TxtNotOlusturan.Text = dr["NOTOLUSTURAN"].ToString();
                TxtHitap.Text = dr["NOTHITAP"].ToString();

            }
        }

        private void BtnNotTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnNotSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from NOTLAR where NOTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtNotid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            NotListele();
        }

        private void BtnNotGuncelle_Click(object sender, EventArgs e)
        { 
            SqlCommand komut = new SqlCommand("Update NOTLAR set NOTTARIH=@P1,NOTSAAT=@P2,NOTBASLIK=@P3,NOTDETAY=@P4,NOTOLUSTURAN=@P5,NOTHITAP=@P6 where NOTID=@p7", bgl.baglanti());

            komut.Parameters.AddWithValue("@P1", MskNotTarih.Text);
            komut.Parameters.AddWithValue("@P2", MskNotSaat.Text);
            komut.Parameters.AddWithValue("@P3", TxtNotBaslik.Text);
            komut.Parameters.AddWithValue("@P4", RchNotDetay.Text);
            komut.Parameters.AddWithValue("@P5", TxtNotOlusturan.Text);
            komut.Parameters.AddWithValue("@P6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@P7", TxtNotid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            NotListele();
            MessageBox.Show("Not Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
