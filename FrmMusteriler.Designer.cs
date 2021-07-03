using System;

namespace TicariOtomasyon
{
    partial class FrmMusteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriler));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.CmbMusterilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.BtnMusteriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMusteriSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMusteriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtMusteriVergi = new DevExpress.XtraEditors.TextEdit();
            this.RchMusteriAdres = new System.Windows.Forms.RichTextBox();
            this.CmbMusteril = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TxtMusteriMail = new DevExpress.XtraEditors.TextEdit();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.MskMusteriTc = new System.Windows.Forms.MaskedTextBox();
            this.TxtMusterisoyad = new DevExpress.XtraEditors.TextEdit();
            this.TxtMusteriAd = new DevExpress.XtraEditors.TextEdit();
            this.TxtMusterid = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMusterilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriVergi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMusteril.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusterisoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusterid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(0, 2);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(851, 681);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView3_FocusedRowChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.CmbMusterilce);
            this.groupControl2.Controls.Add(this.BtnMusteriGuncelle);
            this.groupControl2.Controls.Add(this.BtnMusteriSil);
            this.groupControl2.Controls.Add(this.BtnMusteriKaydet);
            this.groupControl2.Controls.Add(this.TxtMusteriVergi);
            this.groupControl2.Controls.Add(this.RchMusteriAdres);
            this.groupControl2.Controls.Add(this.CmbMusteril);
            this.groupControl2.Controls.Add(this.TxtMusteriMail);
            this.groupControl2.Controls.Add(this.MskTelefon);
            this.groupControl2.Controls.Add(this.labelControl21);
            this.groupControl2.Controls.Add(this.labelControl20);
            this.groupControl2.Controls.Add(this.labelControl18);
            this.groupControl2.Controls.Add(this.labelControl17);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl12);
            this.groupControl2.Controls.Add(this.MskMusteriTc);
            this.groupControl2.Controls.Add(this.TxtMusterisoyad);
            this.groupControl2.Controls.Add(this.TxtMusteriAd);
            this.groupControl2.Controls.Add(this.TxtMusterid);
            this.groupControl2.Location = new System.Drawing.Point(857, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(430, 680);
            this.groupControl2.TabIndex = 1;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(77, 345);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(25, 16);
            this.labelControl19.TabIndex = 46;
            this.labelControl19.Text = "Ilce:";
            // 
            // CmbMusterilce
            // 
            this.CmbMusterilce.Location = new System.Drawing.Point(155, 342);
            this.CmbMusterilce.Name = "CmbMusterilce";
            this.CmbMusterilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbMusterilce.Size = new System.Drawing.Size(222, 22);
            this.CmbMusterilce.TabIndex = 45;
            // 
            // BtnMusteriGuncelle
            // 
            this.BtnMusteriGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriGuncelle.ImageOptions.Image")));
            this.BtnMusteriGuncelle.Location = new System.Drawing.Point(155, 583);
            this.BtnMusteriGuncelle.Name = "BtnMusteriGuncelle";
            this.BtnMusteriGuncelle.Size = new System.Drawing.Size(222, 34);
            this.BtnMusteriGuncelle.TabIndex = 44;
            this.BtnMusteriGuncelle.Text = "Güncelle";
            this.BtnMusteriGuncelle.Click += new System.EventHandler(this.BtnMusteriGuncelle_Click);
            // 
            // BtnMusteriSil
            // 
            this.BtnMusteriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriSil.ImageOptions.Image")));
            this.BtnMusteriSil.Location = new System.Drawing.Point(155, 543);
            this.BtnMusteriSil.Name = "BtnMusteriSil";
            this.BtnMusteriSil.Size = new System.Drawing.Size(222, 34);
            this.BtnMusteriSil.TabIndex = 43;
            this.BtnMusteriSil.Text = "Sil";
            this.BtnMusteriSil.Click += new System.EventHandler(this.BtnMusteriSil_Click);
            // 
            // BtnMusteriKaydet
            // 
            this.BtnMusteriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriKaydet.ImageOptions.Image")));
            this.BtnMusteriKaydet.Location = new System.Drawing.Point(155, 503);
            this.BtnMusteriKaydet.Name = "BtnMusteriKaydet";
            this.BtnMusteriKaydet.Size = new System.Drawing.Size(222, 34);
            this.BtnMusteriKaydet.TabIndex = 42;
            this.BtnMusteriKaydet.Text = "Kaydet";
            this.BtnMusteriKaydet.Click += new System.EventHandler(this.BtnMusteriKaydet_Click);
            // 
            // TxtMusteriVergi
            // 
            this.TxtMusteriVergi.Location = new System.Drawing.Point(155, 469);
            this.TxtMusteriVergi.Name = "TxtMusteriVergi";
            this.TxtMusteriVergi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriVergi.Properties.Appearance.Options.UseFont = true;
            this.TxtMusteriVergi.Size = new System.Drawing.Size(222, 28);
            this.TxtMusteriVergi.TabIndex = 41;
            // 
            // RchMusteriAdres
            // 
            this.RchMusteriAdres.Location = new System.Drawing.Point(155, 389);
            this.RchMusteriAdres.Name = "RchMusteriAdres";
            this.RchMusteriAdres.Size = new System.Drawing.Size(222, 65);
            this.RchMusteriAdres.TabIndex = 18;
            this.RchMusteriAdres.Text = "";
            // 
            // CmbMusteril
            // 
            this.CmbMusteril.Location = new System.Drawing.Point(155, 294);
            this.CmbMusteril.Name = "CmbMusteril";
            this.CmbMusteril.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbMusteril.Size = new System.Drawing.Size(222, 22);
            this.CmbMusteril.TabIndex = 39;
            this.CmbMusteril.SelectedIndexChanged += new System.EventHandler(this.CmbMusteril_SelectedIndexChanged);
            // 
            // TxtMusteriMail
            // 
            this.TxtMusteriMail.Location = new System.Drawing.Point(155, 245);
            this.TxtMusteriMail.Name = "TxtMusteriMail";
            this.TxtMusteriMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMusteriMail.Size = new System.Drawing.Size(222, 28);
            this.TxtMusteriMail.TabIndex = 38;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(155, 151);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(222, 23);
            this.MskTelefon.TabIndex = 37;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(49, 481);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(74, 16);
            this.labelControl21.TabIndex = 36;
            this.labelControl21.Text = "VergiDairesi:";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(68, 410);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(38, 16);
            this.labelControl20.TabIndex = 35;
            this.labelControl20.Text = "Adres:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(87, 300);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(12, 16);
            this.labelControl18.TabIndex = 33;
            this.labelControl18.Text = "Il:";
            this.labelControl18.Click += new System.EventHandler(this.labelControl18_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(83, 253);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(23, 16);
            this.labelControl17.TabIndex = 32;
            this.labelControl17.Text = "Maıl";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(86, 204);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(14, 16);
            this.labelControl16.TabIndex = 31;
            this.labelControl16.Text = "Tc";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(63, 158);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(43, 16);
            this.labelControl15.TabIndex = 30;
            this.labelControl15.Text = "Telefon";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(67, 108);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(35, 16);
            this.labelControl14.TabIndex = 29;
            this.labelControl14.Text = "Soyad";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(87, 55);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(15, 16);
            this.labelControl13.TabIndex = 28;
            this.labelControl13.Text = "Ad";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(86, 21);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(12, 16);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "ID";
            // 
            // MskMusteriTc
            // 
            this.MskMusteriTc.Location = new System.Drawing.Point(155, 197);
            this.MskMusteriTc.Mask = "00000000000";
            this.MskMusteriTc.Name = "MskMusteriTc";
            this.MskMusteriTc.Size = new System.Drawing.Size(222, 23);
            this.MskMusteriTc.TabIndex = 26;
            this.MskMusteriTc.ValidatingType = typeof(int);
            // 
            // TxtMusterisoyad
            // 
            this.TxtMusterisoyad.Location = new System.Drawing.Point(155, 100);
            this.TxtMusterisoyad.Name = "TxtMusterisoyad";
            this.TxtMusterisoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusterisoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtMusterisoyad.Size = new System.Drawing.Size(222, 28);
            this.TxtMusterisoyad.TabIndex = 22;
            // 
            // TxtMusteriAd
            // 
            this.TxtMusteriAd.Location = new System.Drawing.Point(155, 52);
            this.TxtMusteriAd.Name = "TxtMusteriAd";
            this.TxtMusteriAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusteriAd.Properties.Appearance.Options.UseFont = true;
            this.TxtMusteriAd.Size = new System.Drawing.Size(222, 28);
            this.TxtMusteriAd.TabIndex = 10;
            // 
            // TxtMusterid
            // 
            this.TxtMusterid.Location = new System.Drawing.Point(155, 18);
            this.TxtMusterid.Name = "TxtMusterid";
            this.TxtMusterid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMusterid.Properties.Appearance.Options.UseFont = true;
            this.TxtMusterid.Size = new System.Drawing.Size(222, 28);
            this.TxtMusterid.TabIndex = 9;
            // 
            // FrmMusteriler
            // 
            this.ClientSize = new System.Drawing.Size(1316, 694);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl2);
            this.Name = "FrmMusteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.FrmMusteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMusterilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriVergi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbMusteril.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusterisoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusteriAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMusterid.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void labelControl18_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.MaskedTextBox MskTelefon1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox RchAdres;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtVergi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Txtid;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.MaskedTextBox MskTelefon2;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbilce;
        private DevExpress.XtraEditors.ComboBoxEdit Cmbil;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit TxtMusteriAd;
        private DevExpress.XtraEditors.TextEdit TxtMusterid;
        private System.Windows.Forms.MaskedTextBox MskMusteriTc;
        private DevExpress.XtraEditors.TextEdit TxtMusterisoyad;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.ComboBoxEdit CmbMusteril;
        private DevExpress.XtraEditors.TextEdit TxtMusteriMail;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private DevExpress.XtraEditors.TextEdit TxtMusteriVergi;
        private System.Windows.Forms.RichTextBox RchMusteriAdres;
        private DevExpress.XtraEditors.SimpleButton BtnMusteriGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnMusteriSil;
        private DevExpress.XtraEditors.SimpleButton BtnMusteriKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.ComboBoxEdit CmbMusterilce;
    }
}