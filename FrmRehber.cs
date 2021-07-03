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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }
        private void ShowRehberM()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
            
        }
        private void ShowRehberF()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;

        }
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            ShowRehberM();
            ShowRehberF();
        }

        private void gridView3_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                frm.mail = dr["MAIL"].ToString();

            }
            frm.Show();
        }
    }
}
