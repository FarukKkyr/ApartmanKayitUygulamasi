using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanKayıtUygulaması
{
    public partial class FrmAnaform : Form
    {
        public FrmAnaform()
        {
            InitializeComponent();
        }

        private void btnDaireler_Click(object sender, EventArgs e)
        {
            FrmDaireler daireler = new FrmDaireler();
            daireler.Show();
            this.Hide();
        }

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            FrmKayıt kayit = new FrmKayıt();
            kayit.Show();
            this.Hide();
        }

        private void btnFotoğraf_Click(object sender, EventArgs e)
        {
            FrmFotoğraflar foto = new FrmFotoğraflar();
            foto.Show();
            this.Hide();
        }

        private void btnBorçlar_Click(object sender, EventArgs e)
        {
            FrmBorçlar borc = new FrmBorçlar();
            borc.Show();
            this.Hide();
        }

        private void btnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10.05.2021 de bu Programı DevExpress Kullanarak Yaptım.");
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
