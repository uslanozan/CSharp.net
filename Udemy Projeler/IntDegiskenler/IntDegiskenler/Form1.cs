using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntDegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc,sayi;
            sayi=Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi * sayi;
            label2.Text=sonuc.ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, carpim, fark, bölüm;
            sayi1 = Convert.ToInt16(textBox2.Text);
            sayi2 = Convert.ToInt16(textBox3.Text);
            carpim = sayi1 * sayi2;
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            bölüm = sayi1 / sayi2;
            MessageBox.Show("Toplam:" + toplam + "\n" + "Fark:" + fark+"\n"+"Çarpım:"+carpim+"\n"+"Bölüm"+bölüm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox4.Text);
            label5.Text= sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama;
            ad = textBox5.Text;
            soyad=textBox6.Text;
            s1 = Convert.ToInt16(textBox7.Text);
            s2=Convert.ToInt16(textBox8.Text);
            proje= Convert.ToInt16(textBox9.Text);
            ortalama=(s1+s2+proje)/3;
            listBox1.Items.Add(ad+" "+soyad+" Ortalama: "+ortalama);
        }
    }
}
