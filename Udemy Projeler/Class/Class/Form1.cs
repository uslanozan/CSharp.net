using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba car1=new Araba();
            car1.renk = "Kırmızı";
            car1.hiz = 220;
            car1.motor = 1245.56;
            car1.fiyat = 300000;
            car1.durum = 's'; //s = sıfır   i = ikinci el
            car1.YIL = -2016;
            car1.MARKASI = "mazda";
            car1.plaka = "48 OZN 130";
            car1.sahip = "Ozan";
            car1.muayeneTarih = 2023;


            label1.Text= car1.renk;
            label2.Text=car1.hiz.ToString();
            label3.Text=car1.motor.ToString();
            label4.Text =car1.fiyat.ToString();
            label5.Text=car1.durum.ToString();
            label6.Text=car1.YIL.ToString();
            label7.Text = car1.MARKASI;
            label8.Text = car1.plaka;
            label9.Text=car1.sahip;
            label10.Text=car1.muayeneTarih.ToString();

            pictureBox1.BackColor= Color.Aquamarine;

        }
    }
}
