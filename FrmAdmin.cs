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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Admin where KullanıcıAd=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAD.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaModul fr = new FrmAnaModul();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Yada Şifre","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
