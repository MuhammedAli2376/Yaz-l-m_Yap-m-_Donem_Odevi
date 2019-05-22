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
    public partial class Test_Form : Form
    {
        public Test_Form()
        {
            InitializeComponent();
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            fonc();
        }
        
        void fonc()
        {
            Random rastgele = new Random();

            int sayac = 0;

            foreach (Control gez in Controls)
            {
                int sayac2 = 0;
                int salla = rastgele.Next(0, 4);
                foreach (Control gez2 in gez.Controls)
                {
                    if (Kelimeler.Dizi[sayac].Tekrar < DateTime.Now)
                    {
                        if (gez2 is Label)
                            gez2.Text = Kelimeler.Dizi[sayac].Soru;
                        else
                        {
                            if (salla == sayac2)
                                gez2.Text = Kelimeler.Dizi[sayac].Turkce;
                            else
                                gez2.Text = Kelimeler.Dizi[rastgele.Next(0, Kelimeler.Dizi.Length - 1)].Turkce;
                            sayac2++;

                        }
                    }
                        
                }
                if (gez is GroupBox)
                    sayac++;
            }
        }
        KelimeORM korm = new KelimeORM();
        private void button1_Click(object sender, EventArgs e)
        {
            int say = 0;
            int sayac = 0;
            foreach (Control k1 in Controls)
            {
                foreach(Control k2 in k1.Controls)
                {
                    if(k2 is RadioButton)
                    {
                        if (((RadioButton)k2).Checked)
                        {
                            if (((RadioButton)k2).Text == Kelimeler.Dizi[sayac].Turkce)
                            {
                                if (Kelimeler.Dizi[sayac].Tekrar < DateTime.Now)
                                {
                                    if (Kelimeler.Dizi[sayac].Seviye == 0) { Kelimeler.Dizi[sayac].Tekrar = DateTime.Now.AddHours(1); Kelimeler.Dizi[sayac].Seviye = +1; }
                                    else if (Kelimeler.Dizi[sayac].Seviye == 1) { Kelimeler.Dizi[sayac].Tekrar = DateTime.Now.AddDays(7); Kelimeler.Dizi[sayac].Seviye += 1; }
                                    else if (Kelimeler.Dizi[sayac].Seviye == 2) { Kelimeler.Dizi[sayac].Tekrar = DateTime.Now.AddMonths(1); Kelimeler.Dizi[sayac].Seviye += 1; }
                                    if (korm.Guncelle<Kelime>(Kelimeler.Dizi[sayac], Kelimeler.Dizi[sayac].ID))
                                        say++;
                                }
                            }
                        }
                    }
                }
                if (k1 is GroupBox)
                    sayac++;
            }
            MessageBox.Show(string.Format("{0} tane doğru çevapladınız", say));
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
