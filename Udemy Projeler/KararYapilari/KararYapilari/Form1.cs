using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KararYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, proje, ort;
            string durum;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            proje = Convert.ToDouble(textBox3.Text);

            ort=(s1+s2+ proje)/3;

            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            textBox4.Text = ort.ToString("0.00") + " / " + durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kitap fiyatı 8tl
            int kitapsayisi;
            double toplam=0;
            kitapsayisi = Convert.ToInt16(textBox5.Text);
            if(kitapsayisi >=0 && kitapsayisi <= 20)
            {
                toplam = (kitapsayisi * 8) - (kitapsayisi * 8 * 0.20);
           
            }
            
            if(kitapsayisi>=21 && kitapsayisi <= 40)
            {
                toplam = (kitapsayisi * 8) - (kitapsayisi * 8 * 0.40);
            }
            
            if(kitapsayisi >= 41)
            {
                toplam = (kitapsayisi * 8) - (kitapsayisi * 8 * 0.50);
            }
            FiyatTutar.Text = toplam + " TL ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ay=Convert.ToInt16(textBox6.Text); //Textbox string olduğu için convert ettik
            switch(ay)
            {
                case 1: label10.Text = "Ocak";break;
                case 2: label10.Text = "Şubat"; break;
                case 3: label10.Text = "Mart"; break;
                case 4: label10.Text = "Nisan"; break;
                case 5: label10.Text = "Mayıs"; break;
                case 6: label10.Text = "Haziran"; break;
                case 7: label10.Text = "Temmuz"; break;
                case 8: label10.Text = "Ağustos"; break;
                case 9: label10.Text = "Eylül"; break;
                case 10: label10.Text = "Ekim"; break;
                case 11: label10.Text = "Kasım"; break;
                case 12: label10.Text = "Aralık"; break;
                default:label10.Text = "Hatalı Ay"; break; // Case içinde olmayan bir durum için kullanılır

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mevsim = textBox7.Text; // Textboxtan string aldığımız için convert yapmaya gerek yok
            switch (mevsim)
            {
                case "yaz":label11.Text = "Haziran Temmuz Ağustos"; break;
                case "sonbahar":label11.Text = "Mart Nisan Mayıs"; break;
                case "kış":label11.Text = "Aralık Ocak Şubat"; break;
                case "ilkbahar":label11.Text = "Mart Nisan Mayıs"; break;
                default: label11.Text = "Hatalı Mevsim"; break;
            }
        }
    }
}
