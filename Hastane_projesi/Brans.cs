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
    public partial class Brans : Form
    {
        public Brans()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();
        private void Brans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Brans_tbl",bgl.baglanti());
            da.Fill(dt);
            dataGridViewBrans.DataSource = dt;

        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Brans_tbl (Ad) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textboxBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridViewBrans.SelectedCells[0].RowIndex;
            textboxBransId.Text = dataGridViewBrans.Rows[seçilen].Cells[0].Value.ToString();
            textboxBransAd.Text= dataGridViewBrans.Rows[seçilen].Cells[1].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete Brans_tbl where Ad=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textboxBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Brans_tbl set Ad=@b1 where Id=@b2", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", textboxBransAd.Text);
            komut.Parameters.AddWithValue("@b2", textboxBransId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
