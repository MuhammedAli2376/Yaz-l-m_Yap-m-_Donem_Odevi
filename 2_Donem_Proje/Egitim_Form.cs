using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Donem_Proje
{
    public partial class Egitim_Form : Form
    {
        public Egitim_Form()
        {
            InitializeComponent();
        }
        int sayac = 0;
        void Yaz()
        {
           if (Kelimeler.Dizi.Length <= sayac)
                sayac = 0;
            if (sayac < 0)
                sayac = Kelimeler.Dizi.Length-1;
            labelingilizce.Text = Kelimeler.Dizi[sayac].Ingilizce;
            labelturkce.Text = Kelimeler.Dizi[sayac].Turkce;
            labelcumle.Text = Kelimeler.Dizi[sayac].OrnekCumle;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           sayac--;
           Yaz();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           sayac++;
          Yaz();
        }
        
        private void Egitim_Form_Load(object sender, EventArgs e)
        {
            Yaz();
        }
    }
}
