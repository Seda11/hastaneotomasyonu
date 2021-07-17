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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        public string tca;

        sqlBagla bgl = new sqlBagla();

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tca;
            
            //Ad soyad çekme

            SqlCommand komut = new SqlCommand("Select Ad,Soyad from Hasta_Tbl where Tc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tca);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevu_tbl where Tc="+ tca,bgl.baglanti());
            da.Fill(dt);
            dataGridViewRandevuGecmisi.DataSource = dt;


            //branş seçme

            SqlCommand komut2 = new SqlCommand("Select Ad from Brans_tbl", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select Ad,Soyad from Doktor_tbl where Brans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", comboBoxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                comboBoxDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevu_tbl where Brans='" + comboBoxBrans.Text + "'" + "and Doktor='" + comboBoxDoktor.Text +"' and Durum=0" , bgl.baglanti());
            da.Fill(dt);
            dataGridViewAktifRandevu.DataSource = dt;
        }

        private void linkLabelBDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDüzenle dd = new BilgiDüzenle();
            dd.TCno = labelTc.Text;
            dd.Show();
        }


        private void dataGridViewAktifRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridViewAktifRandevu.SelectedCells[0].RowIndex;
            textBoxId.Text = dataGridViewAktifRandevu.Rows[seçilen].Cells[0].Value.ToString();

        }

        private void buttonRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Randevu_tbl (Tarih,Saat,Brans,Doktor,Durum,Tc,Sikayet) values(@r0,@r1,@r2,@r3,@r4,@r5,@r6)", bgl.baglanti());
            komut.Parameters.AddWithValue("r0", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@r1", textBoxSaat.Text);
            komut.Parameters.AddWithValue("@r2", comboBoxBrans.Text);
            komut.Parameters.AddWithValue("@r3", comboBoxDoktor.Text);
            komut.Parameters.AddWithValue("@r4", "True");
            komut.Parameters.AddWithValue("@r5", tca);
            komut.Parameters.AddWithValue("@r6", value: richTextBoxSikayet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) { 
            
            FormGiris fg = new FormGiris();
            fg.Show();
            this.Hide();
            }
        }
    }
    
}
