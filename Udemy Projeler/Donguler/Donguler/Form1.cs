using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <11; i++)
            {
                listBox1.Items.Add(i); 
            }

            int j=1;
            int toplam = 0;
            while( j <= 5){
                toplam = toplam + j;
                j++;
                listBox2.Items.Add(j);
            }
            MessageBox.Show(toplam.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 11;
            do
            {
                listBox1.Items.Add("Merhaba Muğla");
            }
            while (i <= 10);
        }
    }
}
