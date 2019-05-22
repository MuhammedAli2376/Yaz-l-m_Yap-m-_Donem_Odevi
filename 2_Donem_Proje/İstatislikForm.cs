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
    public partial class İstatislikForm : Form
    {
        public İstatislikForm()
        {
            InitializeComponent();
        }

        private void İstatislikForm_Load(object sender, EventArgs e)
        {
            Aylar[] aylar = new Aylar[12];

            Aylar ay = new Aylar();
            for (int i=0;i<Kelimeler.Dizi.Length;i++)
            {
              
                if (Kelimeler.Dizi[i].Seviye==3)
                {
                    if (Kelimeler.Dizi[i].Tekrar.Month == 1)
                        ay.Ocak++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 2)
                        ay.Subat++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 3)
                        ay.Mart++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 4)
                        ay.Nisan++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 5)
                        ay.Mayıs++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 6)
                        ay.Haziran++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 7)
                        ay.Temmuz++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 8)
                        ay.Agustos++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 9)
                        ay.Eylul++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 10)
                        ay.Ekim++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 11)
                        ay.Kasim++;

                    if (Kelimeler.Dizi[i].Tekrar.Month == 12)
                        ay.Aralik++;
                }
            }
            this.chart1.Titles.Add("Öğrenilen Kelimler");
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Ocak", ay.Ocak);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Şubat", ay.Subat);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Mart", ay.Mart);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Nisan", ay.Nisan);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Mayıs", ay.Mayıs);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Haziran", ay.Haziran);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Temmuz", ay.Temmuz);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Ağustos", ay.Agustos);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Eylül", ay.Eylul);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Ekim", ay.Ekim);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Kasım", ay.Kasim);
            this.chart1.Series["Öğrenilen Kelimeler"].Points.AddXY("Aralık", ay.Aralik);
            
        }
    }
}
