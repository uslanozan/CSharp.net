using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;

            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;

            label5.Text=btnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lblDogru.Text=dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text=yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            lblSoruNo.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ozanın en sevdiği yemek nedir?";
                btnA.Text = "İskender";
                btnB.Text = "Mantı";
                btnC.Text = "Döner";
                btnD.Text = "Yaprak Sarma";
                label4.Text = "Mantı";
            }
            if(soruNo == 2)
            {
                richTextBox1.Text = "Ozanın burcu nedir?";
                btnA.Text = "Boğa";
                btnB.Text = "Akrep";
                btnC.Text = "İkizler";
                btnD.Text = "Koç";
                label4.Text = "Koç";
            }
            if(soruNo==3)
            {
                richTextBox1.Text = "Ozanın ney fetişi vardır?";
                btnA.Text = "Ayak";
                btnB.Text = "El";
                btnC.Text = "Bacak";
                btnD.Text = "Threesome";
                label4.Text = "Bacak";
                btnSonraki.Text = "Sonuçlar";
            }
            if(soruNo == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru:"+dogru+"\n"+"Yanlış:"+yanlis);
            }

        }
    }
}