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

namespace ApartmanKayıtUygulaması
{
    public partial class FrmKayıt : Form
    {
        public FrmKayıt()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection(@"Data Source=DESKTOP-9SGQANB;Initial Catalog=apartman;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select *from kisibilgi", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borçlar"].ToString());
                listView1.Items.Add(ekle);
            }
            bağlan.Close();

        }
        private void FrmKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand komut = new SqlCommand("insert into kisibilgi(Ad,Soyad,Daire,Telefon,Mail,Borçlar) values('" + txtAd.Text.ToString() + "', '" + txtSoyad.Text.ToString() + "' , '" + txtDaire.Text.ToString() + "' , '" + txtTelefon.Text.ToString() + "', '" + txtMail.Text.ToString() + "' , '" + txtBorçlar.Text.ToString() + "') ", bağlan);
            komut.ExecuteNonQuery();
            bağlan.Close();
            verilerigoster();
        }
        int id = 0;
        private void btnSil_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Delete from kisibilgi where id=("+id+")", bağlan);
            komut.ExecuteNonQuery();
            bağlan.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtDaire.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtBorçlar.Text = listView1.SelectedItems[0].SubItems[6].Text;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            txtDaire.Text = " ";
            txtTelefon.Text = " ";
            txtMail.Text = " ";
            txtBorçlar.Text = " ";

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            bağlan.Open();
            SqlCommand komut = new SqlCommand("update kisibilgi set Ad='" + txtAd.Text.ToString()+ "', Soyad='"+txtSoyad.Text.ToString()+ "', Daire='" + txtDaire.Text.ToString() + "' , Telefon='"+ txtTelefon.Text.ToString() +"' , Mail='" + txtMail.Text.ToString() + "' , Borçlar='"+txtBorçlar.Text.ToString()+ "' where id="+id+" ", bağlan);
            komut.ExecuteNonQuery();
            bağlan.Close();
            verilerigoster();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select *from kisibilgi where Ad like '%" + txtAra.Text+"%' ", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Daire"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["Borçlar"].ToString());
                listView1.Items.Add(ekle);
            }
            bağlan.Close();
        }
    }
}
// Data Source=DESKTOP-9SGQANB;Initial Catalog=apartman;Integrated Security=True