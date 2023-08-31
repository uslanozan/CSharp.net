using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text+" Tarih:"+dateTimePicker1.Text+" Saat:"
                +maskedTextBox1.Text+" Yolcu Bilgileri - Ad:"+textBox1.Text+ " TC:"+maskedTextBox2.Text+" Telefon:"+maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı yapıldı");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih:" + dateTimePicker1.Text + " Saat:"
                + maskedTextBox1.Text + " Yolcu Bilgileri - Ad:" + textBox1.Text + " TC:" + maskedTextBox2.Text + " Telefon:" + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String gecicideger=comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = gecicideger;
        }
    }
}
