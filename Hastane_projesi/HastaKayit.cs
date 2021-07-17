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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();

        private void buttonKayıt_Click(object sender, EventArgs e)
        {
            if (textBoxAd.Text==string.Empty || textBoxSoyad.Text == "" || textBoxTc.Text == "" ||textBoxTel.Text==""||textBoxSifre.Text==""||comboBoxCinsiyet.Text=="")
            {
                textBoxAd.BackColor = Color.LightCyan;
                textBoxTc.BackColor = Color.LightPink;
                textBoxSifre.BackColor = Color.LightYellow;
                MessageBox.Show("Herhangi bir alanları boş geçemezsiniz", "Boş Alan Hatası");
            }
            else{

            if (textBoxSifre.Text == textBoxSifTek.Text) { 
            SqlCommand komut = new SqlCommand("insert into Hasta_Tbl(Ad,Soyad,Tc,Tel,Sifre,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@p3", textBoxTc.Text);
            komut.Parameters.AddWithValue("@p4", textBoxTel.Text);
            komut.Parameters.AddWithValue("@p5", textBoxSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: "+textBoxSifre.Text," Bilgi ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifre Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }

        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            FormGiris fg = new FormGiris();
            fg.Show();
            this.Hide();
        }
    }
}
