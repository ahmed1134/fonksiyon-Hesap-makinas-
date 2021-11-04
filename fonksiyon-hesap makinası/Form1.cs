using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fonksiyon_hesap_makinası
{
    public partial class Form1 : Form
    {
        void toplama(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            MessageBox.Show("sayıların Toplamı="+ toplam);
        }
        void çarpma(double sayi1 , double sayi2) 
        {
            double çarpma = sayi1 * sayi2;
            MessageBox.Show("Sayıların çarpımı"+çarpma);
        
        }
        void bölme(double sayi1,double sayi2) 
        {


            double bölme = sayi1 / sayi2;
            MessageBox.Show("Sayıların Bölümü=" + bölme);

        }
        void çılkarma(double sayi1, double sayi2)
        {


            double çıkarma = sayi1 - sayi2;
            MessageBox.Show("Sayıların çıkarılımı=" + çıkarma);

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplama(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            çarpma(Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bölme(Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            çılkarma(Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text));
        }
    }
}
