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
    public partial class kayit : Form
    {
      
        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=dctbook;Integrated Security=True;");
        
        public kayit()
        {
            InitializeComponent();
        }
       
       

        private void kayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dctbookDataSet7.kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kayitTableAdapter.Fill(this.dctbookDataSet7.kayit);
            comboBox1.Items.Add("1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Robot olmadığınızı kanıtlayın. :)","Hata!");
            }

            if (comboBox1.Text == "1")
            {
                if (kullaniciadi.Text == "" || Ad.Text == "" || Soyad.Text == "" || Sifre.Text == "" || Telefon.Text == "" || email.Text == "" || resim.Text == "")
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız.", "Hata!");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("ekle", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@kullaniciadi", kullaniciadi.Text);
                    komut.Parameters.AddWithValue("@Ad", Ad.Text);
                    komut.Parameters.AddWithValue("@Soyad", Soyad.Text);
                    komut.Parameters.AddWithValue("@Sifre", Sifre.Text);
                    komut.Parameters.AddWithValue("@Telefon", Telefon.Text);
                    komut.Parameters.AddWithValue("@email", email.Text);
                    komut.Parameters.AddWithValue("@resim", resim.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kaydolma işlemi Başarılı.");
                    kayit frm2 = new kayit();
                    this.Hide();
                    frm2.Close();
                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.Show();
                }
            }

          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            pictureBox1.ImageLocation = dialog.FileName;
            resim.Text = dialog.FileName; 

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            kayit frm2 = new kayit();
            this.Hide();
            frm2.Close();
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
