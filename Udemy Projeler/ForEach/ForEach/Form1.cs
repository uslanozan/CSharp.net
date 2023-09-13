using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sinavlar = {70,65,85,100,90};
            foreach (int degisken in sinavlar)
            {
                listBox1.Items.Add(degisken);
                toplam = toplam + degisken;
            }
            label1.Text=toplam.ToString();

            int ortalama = toplam / sinavlar.Length;
            label2.Text=ortalama.ToString();
        }
    }
}
