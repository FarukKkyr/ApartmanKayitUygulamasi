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
    public partial class FrmDaireler : Form
    {
        public FrmDaireler()
        {
            InitializeComponent();
        }

        private void renkler()
        {
            btnDaire1.BackColor = Color.Gray;
            btnDaire2.BackColor = Color.Gray;
            btnDaire3.BackColor = Color.Gray;
            btnDaire4.BackColor = Color.Gray;
            btnDaire5.BackColor = Color.Gray;
            btnDaire6.BackColor = Color.Gray;
            btnDaire7.BackColor = Color.Gray;
            btnDaire8.BackColor = Color.Gray;
        }
        private void btnDaire1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDaireler_Load(object sender, EventArgs e)
        {
            renkler();


        }

        private void btnDaire1_Click_1(object sender, EventArgs e)
        {
            renkler();
            btnDaire1.BackColor = Color.Red;
        }

        private void btnDaire2_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire2.BackColor = Color.Red;
        }

        private void btnDaire3_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire3.BackColor = Color.Red;
        }

        private void btnDaire4_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire4.BackColor = Color.Red;
        }

        private void btnDaire5_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire5.BackColor = Color.Red;
        }

        private void btnDaire6_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire6.BackColor = Color.Red;
        }

        private void btnDaire7_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire7.BackColor = Color.Red;
        }

        private void btnDaire8_Click(object sender, EventArgs e)
        {
            renkler();
            btnDaire8.BackColor = Color.Red;
        }
    }
}
