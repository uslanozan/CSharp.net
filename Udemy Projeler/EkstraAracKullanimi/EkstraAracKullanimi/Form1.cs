using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraAracKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;


        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Gray;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Ozan Uslan 17cm tarafından yapıldı. ","bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information); // Çıkan mesajın içeriğini değiştirir.
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void madMaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");  //Navigate yönlendir anlamında kullanılır.
            label1.Text = "Mad Max";                                              //Hata veriyor sebebini bulamadım script hatası
        }

        private void görevimizTehlikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=Ohws8y572KE");
            label1.Text = "Görevimiz Tehlike";
        }

        private void feetApartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=XtgCqMZofqM");
            label1.Text = "5 Feet Apart";
        }

        private void laLaLandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=0pdqf4P9MB8");
            label1.Text = "La La Land";
        }

        private void dabbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CkZ_zRohbp8");
            label1.Text = "Dabbe";
        }

        private void testereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=1pP2Wwl8gBc");
            label1.Text = "Testere";
        }

        private void marslıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=zb3dm_72j6I");
            label1.Text = "Marslı";
        }

        private void ınceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=YoHD9XEInc0");
            label1.Text = "Inception";
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Series["Kitap"].Points.AddXY("Akdeniz", 5);  //Points koordinat demek
            chart1.Series["Kitap"].Points.AddXY("Ege", 9);
            chart1.Series["Kitap"].Points.AddXY("İç Anadolu", 2);
            chart1.Series["Kitap"].Points.AddXY("Marmara", 4);
        }
    }
}
