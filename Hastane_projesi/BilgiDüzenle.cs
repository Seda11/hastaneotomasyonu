using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_projesi
{
    public partial class BilgiDüzenle : Form
    {
        public BilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        sqlBagla bgl = new sqlBagla();
        private void buttonKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Hasta_Tbl set Ad=@p1,Soyad=@p2,Sifre=@p4 where TC=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textboxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", textBoxTc.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Güncelle");
        }
        private void BilgiDüzenle_Load(object sender, EventArgs e)
        {
            textBoxTc.Text = TCno;

            SqlCommand komut = new SqlCommand("Select * from Hasta_Tbl where Tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textboxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                textBoxTc.Text = dr[4].ToString();
                textBoxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
