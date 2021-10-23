
namespace ApartmanKayıtUygulaması
{
    partial class FrmAnaform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaform));
            this.btnDaireler = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorçlar = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayıt = new DevExpress.XtraEditors.SimpleButton();
            this.btnFotoğraf = new DevExpress.XtraEditors.SimpleButton();
            this.btnHakkımızda = new DevExpress.XtraEditors.SimpleButton();
            this.btnÇıkış = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnDaireler
            // 
            this.btnDaireler.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnDaireler.Appearance.Options.UseFont = true;
            this.btnDaireler.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDaireler.ImageOptions.SvgImage")));
            this.btnDaireler.Location = new System.Drawing.Point(129, 103);
            this.btnDaireler.Name = "btnDaireler";
            this.btnDaireler.Size = new System.Drawing.Size(162, 47);
            this.btnDaireler.TabIndex = 0;
            this.btnDaireler.Text = "Daireler";
            this.btnDaireler.Click += new System.EventHandler(this.btnDaireler_Click);
            // 
            // btnBorçlar
            // 
            this.btnBorçlar.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnBorçlar.Appearance.Options.UseFont = true;
            this.btnBorçlar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVeriler.ImageOptions.SvgImage")));
            this.btnBorçlar.Location = new System.Drawing.Point(399, 103);
            this.btnBorçlar.Name = "btnBorçlar";
            this.btnBorçlar.Size = new System.Drawing.Size(162, 47);
            this.btnBorçlar.TabIndex = 1;
            this.btnBorçlar.Text = "Borçlar";
            this.btnBorçlar.Click += new System.EventHandler(this.btnBorçlar_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnKayıt.Appearance.Options.UseFont = true;
            this.btnKayıt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKayıt.ImageOptions.SvgImage")));
            this.btnKayıt.Location = new System.Drawing.Point(129, 202);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(162, 47);
            this.btnKayıt.TabIndex = 2;
            this.btnKayıt.Text = "Kayıt İşlemleri";
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnFotoğraf
            // 
            this.btnFotoğraf.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnFotoğraf.Appearance.Options.UseFont = true;
            this.btnFotoğraf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFotoğraf.ImageOptions.SvgImage")));
            this.btnFotoğraf.Location = new System.Drawing.Point(399, 202);
            this.btnFotoğraf.Name = "btnFotoğraf";
            this.btnFotoğraf.Size = new System.Drawing.Size(162, 47);
            this.btnFotoğraf.TabIndex = 3;
            this.btnFotoğraf.Text = "Fotoğraflar";
            this.btnFotoğraf.Click += new System.EventHandler(this.btnFotoğraf_Click);
            // 
            // btnHakkımızda
            // 
            this.btnHakkımızda.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnHakkımızda.Appearance.Options.UseFont = true;
            this.btnHakkımızda.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHakkımızda.ImageOptions.SvgImage")));
            this.btnHakkımızda.Location = new System.Drawing.Point(129, 288);
            this.btnHakkımızda.Name = "btnHakkımızda";
            this.btnHakkımızda.Size = new System.Drawing.Size(162, 47);
            this.btnHakkımızda.TabIndex = 4;
            this.btnHakkımızda.Text = "Hakkımızda";
            this.btnHakkımızda.Click += new System.EventHandler(this.btnHakkımızda_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnÇıkış.Appearance.Options.UseFont = true;
            this.btnÇıkış.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnÇıkış.ImageOptions.SvgImage")));
            this.btnÇıkış.Location = new System.Drawing.Point(399, 288);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(162, 47);
            this.btnÇıkış.TabIndex = 5;
            this.btnÇıkış.Text = "Çıkış";
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // FrmAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(741, 466);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnHakkımızda);
            this.Controls.Add(this.btnFotoğraf);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.btnBorçlar);
            this.Controls.Add(this.btnDaireler);
            this.Name = "FrmAnaform";
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDaireler;
        private DevExpress.XtraEditors.SimpleButton btnBorçlar;
        private DevExpress.XtraEditors.SimpleButton btnKayıt;
        private DevExpress.XtraEditors.SimpleButton btnFotoğraf;
        private DevExpress.XtraEditors.SimpleButton btnHakkımızda;
        private DevExpress.XtraEditors.SimpleButton btnÇıkış;
    }
}