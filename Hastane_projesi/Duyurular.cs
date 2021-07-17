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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }

        sqlBagla bgl = new sqlBagla();
        private void Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Duyuru_tbl",bgl.baglanti());
            da.Fill(dt);
            dataGridViewDuyuru.DataSource = dt;
        }
    }
}
