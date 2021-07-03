namespace TicariOtomasyon
{
    partial class FrmNotlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.BtnNotGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNotSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNotKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.RchNotDetay = new System.Windows.Forms.RichTextBox();
            this.TxtNotOlusturan = new DevExpress.XtraEditors.TextEdit();
            this.MskNotTarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.TxtNotid = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BtnNotTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.MskNotSaat = new System.Windows.Forms.MaskedTextBox();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtHitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotOlusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNotGuncelle
            // 
            this.BtnNotGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotGuncelle.ImageOptions.Image")));
            this.BtnNotGuncelle.Location = new System.Drawing.Point(155, 511);
            this.BtnNotGuncelle.Name = "BtnNotGuncelle";
            this.BtnNotGuncelle.Size = new System.Drawing.Size(222, 34);
            this.BtnNotGuncelle.TabIndex = 44;
            this.BtnNotGuncelle.Text = "Güncelle";
            this.BtnNotGuncelle.Click += new System.EventHandler(this.BtnNotGuncelle_Click);
            // 
            // BtnNotSil
            // 
            this.BtnNotSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotSil.ImageOptions.Image")));
            this.BtnNotSil.Location = new System.Drawing.Point(155, 471);
            this.BtnNotSil.Name = "BtnNotSil";
            this.BtnNotSil.Size = new System.Drawing.Size(222, 34);
            this.BtnNotSil.TabIndex = 43;
            this.BtnNotSil.Text = "Sil";
            this.BtnNotSil.Click += new System.EventHandler(this.BtnNotSil_Click);
            // 
            // BtnNotKaydet
            // 
            this.BtnNotKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotKaydet.ImageOptions.Image")));
            this.BtnNotKaydet.Location = new System.Drawing.Point(155, 431);
            this.BtnNotKaydet.Name = "BtnNotKaydet";
            this.BtnNotKaydet.Size = new System.Drawing.Size(222, 34);
            this.BtnNotKaydet.TabIndex = 42;
            this.BtnNotKaydet.Text = "Kaydet";
            this.BtnNotKaydet.Click += new System.EventHandler(this.BtnNotKaydet_Click);
            // 
            // RchNotDetay
            // 
            this.RchNotDetay.Location = new System.Drawing.Point(155, 292);
            this.RchNotDetay.Name = "RchNotDetay";
            this.RchNotDetay.Size = new System.Drawing.Size(222, 108);
            this.RchNotDetay.TabIndex = 18;
            this.RchNotDetay.Text = "";
            // 
            // TxtNotOlusturan
            // 
            this.TxtNotOlusturan.Location = new System.Drawing.Point(155, 195);
            this.TxtNotOlusturan.Name = "TxtNotOlusturan";
            this.TxtNotOlusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotOlusturan.Properties.Appearance.Options.UseFont = true;
            this.TxtNotOlusturan.Size = new System.Drawing.Size(222, 28);
            this.TxtNotOlusturan.TabIndex = 38;
            // 
            // MskNotTarih
            // 
            this.MskNotTarih.Location = new System.Drawing.Point(155, 55);
            this.MskNotTarih.Mask = "00/00/0000";
            this.MskNotTarih.Name = "MskNotTarih";
            this.MskNotTarih.Size = new System.Drawing.Size(222, 23);
            this.MskNotTarih.TabIndex = 37;
            this.MskNotTarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(87, 207);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(55, 16);
            this.labelControl17.TabIndex = 32;
            this.labelControl17.Text = "Oluşturan";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(87, 292);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(32, 16);
            this.labelControl16.TabIndex = 31;
            this.labelControl16.Text = "Detay";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(86, 154);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(33, 16);
            this.labelControl15.TabIndex = 30;
            this.labelControl15.Text = "Başlık";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(87, 103);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(26, 16);
            this.labelControl14.TabIndex = 29;
            this.labelControl14.Text = "Saat";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(87, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(30, 16);
            this.labelControl13.TabIndex = 28;
            this.labelControl13.Text = "Tarih";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(86, 21);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(31, 16);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "NotID";
            // 
            // TxtNotBaslik
            // 
            this.TxtNotBaslik.Location = new System.Drawing.Point(155, 146);
            this.TxtNotBaslik.Name = "TxtNotBaslik";
            this.TxtNotBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotBaslik.Properties.Appearance.Options.UseFont = true;
            this.TxtNotBaslik.Size = new System.Drawing.Size(222, 28);
            this.TxtNotBaslik.TabIndex = 10;
            // 
            // TxtNotid
            // 
            this.TxtNotid.Location = new System.Drawing.Point(155, 18);
            this.TxtNotid.Name = "TxtNotid";
            this.TxtNotid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNotid.Properties.Appearance.Options.UseFont = true;
            this.TxtNotid.Size = new System.Drawing.Size(222, 28);
            this.TxtNotid.TabIndex = 9;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.TxtHitap);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.BtnNotTemizle);
            this.groupControl2.Controls.Add(this.MskNotSaat);
            this.groupControl2.Controls.Add(this.BtnNotGuncelle);
            this.groupControl2.Controls.Add(this.BtnNotSil);
            this.groupControl2.Controls.Add(this.BtnNotKaydet);
            this.groupControl2.Controls.Add(this.RchNotDetay);
            this.groupControl2.Controls.Add(this.TxtNotOlusturan);
            this.groupControl2.Controls.Add(this.MskNotTarih);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.TxtNotBaslik);
            this.groupControl2.Controls.Add(this.TxtNotid);
            this.groupControl2.Location = new System.Drawing.Point(872, 7);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(430, 680);
            this.groupControl2.TabIndex = 3;
            // 
            // BtnNotTemizle
            // 
            this.BtnNotTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotTemizle.ImageOptions.Image")));
            this.BtnNotTemizle.Location = new System.Drawing.Point(155, 551);
            this.BtnNotTemizle.Name = "BtnNotTemizle";
            this.BtnNotTemizle.Size = new System.Drawing.Size(222, 34);
            this.BtnNotTemizle.TabIndex = 46;
            this.BtnNotTemizle.Text = "Temizle";
            this.BtnNotTemizle.Click += new System.EventHandler(this.BtnNotTemizle_Click);
            // 
            // MskNotSaat
            // 
            this.MskNotSaat.Location = new System.Drawing.Point(155, 96);
            this.MskNotSaat.Mask = "90:00";
            this.MskNotSaat.Name = "MskNotSaat";
            this.MskNotSaat.Size = new System.Drawing.Size(222, 23);
            this.MskNotSaat.TabIndex = 45;
            this.MskNotSaat.ValidatingType = typeof(System.DateTime);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(15, 7);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(851, 681);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // TxtHitap
            // 
            this.TxtHitap.Location = new System.Drawing.Point(155, 238);
            this.TxtHitap.Name = "TxtHitap";
            this.TxtHitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtHitap.Properties.Appearance.Options.UseFont = true;
            this.TxtHitap.Size = new System.Drawing.Size(222, 28);
            this.TxtHitap.TabIndex = 48;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(87, 250);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 16);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Hitap";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 694);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl2);
            this.Name = "FrmNotlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotOlusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNotid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtHitap.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton BtnNotGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnNotSil;
        private DevExpress.XtraEditors.SimpleButton BtnNotKaydet;
        private System.Windows.Forms.RichTextBox RchNotDetay;
        private DevExpress.XtraEditors.TextEdit TxtNotOlusturan;
        private System.Windows.Forms.MaskedTextBox MskNotTarih;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit TxtNotBaslik;
        private DevExpress.XtraEditors.TextEdit TxtNotid;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton BtnNotTemizle;
        private System.Windows.Forms.MaskedTextBox MskNotSaat;
        private DevExpress.XtraEditors.TextEdit TxtHitap;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}