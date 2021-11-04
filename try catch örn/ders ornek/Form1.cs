using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 0, sayi2 = 0, sayi3 = 0, sayi4 = 0, top = 0;
            try
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi3 = Convert.ToInt32(textBox3.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("hata");

            }
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi4 = Convert.ToInt32(textBox4.Text);
            top = sayi1 + sayi2 + sayi3 + sayi4;
            label5.Text = top.ToString();



        }
    }
}
