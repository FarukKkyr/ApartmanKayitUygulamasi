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
    public partial class FrmBorçlar : Form
    {
        public FrmBorçlar()
        {
            InitializeComponent();
        }
        SqlConnection bağlan = new SqlConnection(@"Data Source=DESKTOP-9SGQANB;Initial Catalog=apartman;Integrated Security=True");
        
        private void verilerigoster()
        {
            lstBorç.Items.Clear();
            bağlan.Open();
            SqlCommand komut = new SqlCommand("Select *from kisibilgi", bağlan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();                
                ekle.SubItems.Add(oku["Soyad"].ToString());               
                ekle.SubItems.Add(oku["Borçlar"].ToString());
                lstBorç.Items.Add(ekle);
            }
            bağlan.Close();

        }
        private void FrmBorçlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
    }
}
