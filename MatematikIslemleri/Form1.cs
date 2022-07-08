using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikIslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1;
            double sayi2;
            double sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = Math.Pow(sayi1, sayi2);
            label1.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi3;
            double sonuc2;
            sayi3 = Convert.ToInt32(textBox3.Text);
            sonuc2 = Math.Sqrt(sayi3);
            label7.Text = sonuc2.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi4;
            double sayi5;
            double sonuc3;
            sayi4 = Convert.ToInt32(textBox4.Text);
            sayi5 = Convert.ToInt32(textBox5.Text);
            sonuc3 = sayi4 % sayi5;
            label10.Text = sonuc3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi6;
            sayi6 = Convert.ToInt32(textBox6.Text);
            int saat, dakika;
            saat = sayi6 / 60;
            label14.Text = saat.ToString();
            dakika = sayi6 % 60;
            label16.Text = dakika.ToString();
        }
    }
}
