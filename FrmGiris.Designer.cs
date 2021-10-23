
namespace ApartmanKayıtUygulaması
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanıcı = new DevExpress.XtraEditors.TextEdit();
            this.txtŞifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGiris.ImageOptions.SvgImage")));
            this.btnGiris.Location = new System.Drawing.Point(208, 181);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(138, 56);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(68, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(123, 135);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre:";
            // 
            // txtKullanıcı
            // 
            this.txtKullanıcı.Location = new System.Drawing.Point(182, 89);
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtKullanıcı.Properties.Appearance.Options.UseFont = true;
            this.txtKullanıcı.Size = new System.Drawing.Size(179, 26);
            this.txtKullanıcı.TabIndex = 3;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(182, 132);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtŞifre.Properties.Appearance.Options.UseFont = true;
            this.txtŞifre.Size = new System.Drawing.Size(179, 26);
            this.txtŞifre.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(93, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(276, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "DevExpress Apartman Kayıt Uygulaması";
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(508, 284);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtKullanıcı);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGiris);
            this.Name = "FrmGiris";
            this.Text = "GİRİS SAYFASI";
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullanıcı;
        private DevExpress.XtraEditors.TextEdit txtŞifre;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

