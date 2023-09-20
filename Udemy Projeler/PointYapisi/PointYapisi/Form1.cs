using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            konum.X = 150;
            konum.Y = 250;
            pictureBox1.Location = konum;
        }

        enum sehirler { x, Adana, Adıyaman, Afyonkarahisar, Ağrı, Amasya, Ankara, Antalya, Artvin, Aydın, Balıkesir, Bilecik, Bingöl, Bitlis, Bolu, Burdur, Bursa, Çanakkale, Çankırı,
            Çorum, Denizli, Diyarbakır, Edirne, Elazığ, Erzincan, Erzurum, Eskişehir, Gaziantep, Giresun, Gümüşhane, Hakkari, Hatay,
            Isparta, Mersin, İstanbul, İzmir, Kars, Kastamonu, Kayseri, Kırklareli, Kırşehir, Kocaeli, Konya, Kütahya, Malatya, Manisa,
            Kahramanmaraş, Mardin, Muğla, Muş, Nevşehir, Niğde, Ordu, Rize, Sakarya, Samsun, Siirt, 
            Sinop, Sivas, Tekirdağ, Tokat, Trabzon, Tunceli, Şanlıurfa, Uşak, Van, Yozgat, Zonguldak, 
            Aksaray, Bayburt, Karaman, Kırıkkale, Batman, Şırnak, Bartın, Ardahan, Iğdır, Yalova, Karabük, Kilis, Osmaniye, Düzce}  // ; koymaya gerek yok

        private void button2_Click(object sender, EventArgs e)
        {
            int plaka=Convert.ToInt16(textBox1.Text);
            sehirler s;
            s = (sehirler)plaka;
            label1.Text=s.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi=Convert.ToDouble(textBox2.Text);

            //label3.Text=Math.Abs(sayi).ToString();  //Abs Mutlak
            //label3.Text = Math.Ceiling(sayi).ToString(); //Ceiling Üste yuvarlama
            //label3.Text = Math.Floor(sayi).ToString(); //Floor Alta yuvarlama
            //label3.Text = Math.Pow(sayi,3).ToString(); //Pow Üst alma, 2. parametre kaçıncı üssü 
            label3.Text=Math.Sqrt(sayi).ToString(); //Sqrt Karekök alma
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn1= new Button();
            Point btn1konum=new Point(457,60);
            btn1.Location= btn1konum;
            btn1.Name = "NewButton";
            btn1.Text = "Yeni Buton";
            btn1.BackColor= Color.Gold;
            btn1.Height= 30; btn1.Width= 108;
            this.Controls.Add(btn1); //Bunu yazmazsak eklemez

            Label lbl1=new Label();
            Point lbl1konum=new Point(457,40);
            lbl1.Location= lbl1konum;
            lbl1.Name = "NewLabel";
            lbl1.Text = "Beeeeeeeeeeeeeeeeeeeeeee";
            lbl1.BackColor= Color.Azure;
            lbl1.AutoSize= true;  // Textin uzunluğuna göre textboxı büyütür.
            this.Controls.Add(lbl1);

            

            for (int i = 1; i <6; i++)
            {
                TextBox txt1 = new TextBox();
                Point txt1konum= new Point(457,(i*30)+100);
                txt1.Location= txt1konum;
                txt1.Name = "NewTextbox" + i;
                txt1.Text=i.ToString();
                this.Controls.Add(txt1);
            }  
        }
    }
}