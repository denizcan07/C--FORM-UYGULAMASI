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
namespace denemefacebook
{
    public partial class uyekontrol : Form
    {
        public uyekontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=dctbook;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("silme",baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@id",textBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("göster", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(komut.ExecuteReader());
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyekontrol frm12 = new uyekontrol();
            this.Hide();
            frm12.Close();
            admin frm11 = new admin();
            this.Hide();
            frm11.Show();
        }
    }
}
