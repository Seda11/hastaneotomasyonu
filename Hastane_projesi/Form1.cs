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
    public partial class FormGiris : Form
    {
        sqlBagla bgl = new sqlBagla();
        public FormGiris()
        {
            InitializeComponent();
        }


        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Doktor_tbl where Tc=@p1 and Sifre=@p2", bgl.baglanti());
            SqlCommand komut1 = new SqlCommand("Select * From Sekreter_tbl where Tc=@p1 and Sifre=@p2 ", bgl.baglanti());
            SqlCommand komut2 = new SqlCommand("select *from Hasta_Tbl where Tc=@p1 and Sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxTc.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            komut1.Parameters.AddWithValue("@p1", textBoxTc.Text);
            komut1.Parameters.AddWithValue("@p2", textBoxSifre.Text);
            komut2.Parameters.AddWithValue("@p1", textBoxTc.Text);
            komut2.Parameters.AddWithValue("@p2", textBoxSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            SqlDataReader sr = komut1.ExecuteReader();
            SqlDataReader hr = komut2.ExecuteReader();
            if (dr.Read())
            {
                DoktorDetay fr = new DoktorDetay();
                fr.Tc = textBoxTc.Text;
                fr.Show();
                this.Hide();
            }

            else if (sr.Read())
            {
                SekreterDetay sd = new SekreterDetay();
                sd.TCnumara = textBoxTc.Text;
                sd.Show();
                this.Hide();
            }
            else if (hr.Read())
            {
                HastaDetay fd = new HastaDetay();
                fd.tca = textBoxTc.Text;
                fd.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void linkLabelUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit fr = new HastaKayit();
            fr.Show();
        }

        private void linkLabelSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sf = new SifremiUnuttum();
            sf.Show();
        }
    }
}
