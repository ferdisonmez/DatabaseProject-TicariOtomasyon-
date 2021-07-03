namespace TicariOtomasyon
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAD = new DevExpress.XtraEditors.TextEdit();
            this.TxtKullaniciSifre = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullanıcıAd:";
            // 
            // TxtKullaniciAD
            // 
            this.TxtKullaniciAD.Location = new System.Drawing.Point(220, 167);
            this.TxtKullaniciAD.Name = "TxtKullaniciAD";
            this.TxtKullaniciAD.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.TxtKullaniciAD.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAD.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKullaniciAD.Properties.Appearance.Options.UseFont = true;
            this.TxtKullaniciAD.Size = new System.Drawing.Size(122, 28);
            this.TxtKullaniciAD.TabIndex = 1;
            // 
            // TxtKullaniciSifre
            // 
            this.TxtKullaniciSifre.Location = new System.Drawing.Point(220, 225);
            this.TxtKullaniciSifre.Name = "TxtKullaniciSifre";
            this.TxtKullaniciSifre.Properties.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.TxtKullaniciSifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciSifre.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKullaniciSifre.Properties.Appearance.Options.UseFont = true;
            this.TxtKullaniciSifre.Properties.UseSystemPasswordChar = true;
            this.TxtKullaniciSifre.Size = new System.Drawing.Size(122, 28);
            this.TxtKullaniciSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(122, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnGirisYap.Location = new System.Drawing.Point(220, 290);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(122, 32);
            this.BtnGirisYap.TabIndex = 4;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(172, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ticari Otomasyon Sistemi ";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtKullaniciSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAD);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAD;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.Label label3;
    }
}