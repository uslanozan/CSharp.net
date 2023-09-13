using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        void renklendir() //private ya da public yazılmazsa private kabul edilir
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.LightGoldenrodYellow;
            textBox3.BackColor = Color.DarkViolet;
            textBox4.BackColor = Color.Aquamarine;
            textBox1.Text = "Merhaba";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }
    }
}
