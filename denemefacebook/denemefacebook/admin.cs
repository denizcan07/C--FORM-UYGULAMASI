using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemefacebook
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyekontrol frm4 = new uyekontrol();
            this.Hide();
            frm4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            admin frm11 = new admin();
            this.Hide();
            frm11.Close();
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
