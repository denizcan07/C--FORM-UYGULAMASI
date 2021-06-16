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
    public partial class Form1 : Form
    {
        public uyegiris frm10;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            frm10 = new uyegiris();
            InitializeComponent();

        }
        /*SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS02;Initial Catalog=dctbook;Integrated Security=True;");*/
      
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kayit frm2 = new kayit();
            this.Hide();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static string ad, sifre;
        private void button1_Click(object sender, EventArgs e)
        {
         
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                admin frm3 = new admin();
                this.Hide();
                frm3.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı adınız veya Şifreniz Boş bırakılmaz.", "Hata!");
            }

            else
            {
                string sorgu = "SELECT * FROM kayit where kullaniciadi=@kullaniciadi AND Sifre=@Sifre";
                con = new SqlConnection("server=MSI\\SQLEXPRESS02; Initial Catalog=dctbook;Integrated Security=SSPI");
                cmd = new SqlCommand(sorgu, con);
                 cmd.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                cmd.Parameters.AddWithValue("@Sifre", textBox2.Text);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ad = textBox1.Text;
                    sifre = textBox2.Text;
                    uyegiris frm7 = new uyegiris();
                  
                    this.Hide();
                    frm7.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                con.Close();
            }
           
            }
        }
    }
    