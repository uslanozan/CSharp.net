using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bufe_Satis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, kola,toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            kola = Convert.ToInt16(TxtKola.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            
            toplam = misir * 4 + kola * 2 + su * 1 + bilet * 8;
            LblToplam.Text = toplam.ToString() + " TL";
            
            kasatutar = kasatutar + toplam;
            LblKasaToplam.Text = kasatutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kasatutar = 0;
            LblKasaToplam.Text = kasatutar.ToString() + " Tl";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = "";
            TxtKola.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            TxtMisir.Focus(); // İmleci oraya odaklamak için
        }
    }
}
