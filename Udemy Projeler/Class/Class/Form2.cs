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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba car2 = new Araba();
            car2.renk = "Siyah";
            car2.hiz = 200;
            car2.motor = 1160.20;
            car2.fiyat = 200000;
            car2.durum = 'i';

            label1.Text = car2.renk;
            label2.Text = car2.hiz.ToString();
            label3.Text = car2.motor.ToString();
            label4.Text = car2.fiyat.ToString();
            label5.Text = car2.durum.ToString();
            pictureBox1.BackColor = Color.Chocolate;
        }
    }
}
