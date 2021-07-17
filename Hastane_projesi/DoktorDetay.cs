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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();
        public string Tc;
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = Tc;

            //Doktor ad ve soyad
            SqlCommand komut = new SqlCommand("Select Ad, Soyad From Doktor_tbl where Tc=@d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", labelTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                labelAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Randevu_tbl where Doktor='" + labelAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridViewRandevu.DataSource = dt;
        }

        private void buttonDüzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDüzenle fr = new DoktorBilgiDüzenle();
            fr.TCNO = labelTc.Text;
            fr.Show();
        }

        private void buttonDuyuru_Click(object sender, EventArgs e)
        {
            Duyurular fd = new Duyurular();
            fd.Show();
        }

        private void buttonCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridViewRandevu.SelectedCells[0].RowIndex;
            richTextBoxSikayet.Text = dataGridViewRandevu.Rows[seçilen].Cells[7].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinizden emin misiniz?", "Onay Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FormGiris fg = new FormGiris();
                fg.Show();
                this.Hide();
            }
        }
    }
}
