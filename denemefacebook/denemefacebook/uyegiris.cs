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
    public partial class uyegiris : Form
    {
        
        public Form1 frm1;
       /* SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
       */

        public uyegiris()
        {
            InitializeComponent();
            
            label2.Text = Form1.ad;
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void uyegiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uyegiris frm12 = new uyegiris();
            this.Hide();
            frm12.Close();
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
