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
    public partial class DoktorPanel : Form
    {
        public DoktorPanel()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();

        private void DoktorPanel_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Doktor_tbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridViewDoktor.DataSource = dt1;

            //branşı kombobaxa aktarma
            SqlCommand komut2 = new SqlCommand("Select Ad from Brans_tbl ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Doktor_tbl (Ad, Soyad, Brans, Tc, Sifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@d4", textBoxTc.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridViewDoktor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridViewDoktor.SelectedCells[0].RowIndex;
            textBoxAd.Text = dataGridViewDoktor.Rows[secilen].Cells[1].Value.ToString();
            textBoxSoyad.Text= dataGridViewDoktor.Rows[secilen].Cells[2].Value.ToString();
            comboBoxBrans.Text= dataGridViewDoktor.Rows[secilen].Cells[3].Value.ToString();
            textBoxTc.Text= dataGridViewDoktor.Rows[secilen].Cells[4].Value.ToString();
            textBoxSifre.Text= dataGridViewDoktor.Rows[secilen].Cells[5].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Doktor_tbl where Tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Doktor_tbl set Ad=@d1, Soyad=@d2, Brans=@d3, Sifre=@d5 where Tc=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@d2", textBoxSoyad.Text);
            komut.Parameters.AddWithValue("@d3", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@d4", textBoxTc.Text);
            komut.Parameters.AddWithValue("@d5", textBoxSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
