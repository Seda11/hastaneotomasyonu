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

namespace Hastane_projesi
{
    public partial class DoktorBilgiDüzenle : Form
    {
        public DoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();
        public string TCNO;
        
        private void DoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            textBoxTc.Text = TCNO;
            SqlCommand komut =new SqlCommand ("Select * From Doktor_tbl where Tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                textboxAd.Text = dr[1].ToString();
                textBoxSoyad.Text = dr[2].ToString();
                comboBoxBrans.Text = dr[3].ToString();
                textBoxSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Doktor_tbl set Ad=@p1,Soyad=@p2,Brans=@p3,Sifre=@p4 where TC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textboxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@p4", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p5", textBoxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi","Doktor Güncelle");

        }
    }
}
