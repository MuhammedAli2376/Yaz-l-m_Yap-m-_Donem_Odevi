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
        void AyGore()
        {
            chart1.Series.Clear();
            Aylar ay = new Aylar();

            for (int i = 0; i < Kelimeler.Dizi2.Length; i++)
            {
                
                    if (Kelimeler.Dizi2[i].Tekrar.Month == 1)
                        ay.Ocak++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 2)
                        ay.Subat++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 3)
                        ay.Mart++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 4)
                        ay.Nisan++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 5)
                        ay.Mayıs++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 6)
                        ay.Haziran++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 7)
                        ay.Temmuz++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 8)
                        ay.Agustos++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 9)
                        ay.Eylul++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 10)
                        ay.Ekim++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 11)
                        ay.Kasim++;

                    else if (Kelimeler.Dizi2[i].Tekrar.Month == 12)
                        ay.Aralik++;
                
            }
            
            chart1.Series.Add("Ay");
            chart1.Series["Ay"].Points.AddXY("Ocak", ay.Ocak);
            chart1.Series["Ay"].Points.AddXY("Şubat", ay.Subat);
            chart1.Series["Ay"].Points.AddXY("Mart", ay.Mart);
            chart1.Series["Ay"].Points.AddXY("Nisan", ay.Nisan);
            chart1.Series["Ay"].Points.AddXY("Mayıs", ay.Mayıs);
            chart1.Series["Ay"].Points.AddXY("Haziran", ay.Haziran);
            chart1.Series["Ay"].Points.AddXY("Temmuz", ay.Temmuz);
            chart1.Series["Ay"].Points.AddXY("Ağustos", ay.Agustos);
            chart1.Series["Ay"].Points.AddXY("Eylül", ay.Eylul);
            chart1.Series["Ay"].Points.AddXY("Ekim", ay.Ekim);
            chart1.Series["Ay"].Points.AddXY("11", ay.Kasim);
            chart1.Series["Ay"].Points.AddXY("Aralık", ay.Aralik);
        }
        private void İstatislikForm_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("Öğrenilen Kelime istatisliği");
            AyGore();
        }

        private void ayaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyGore();
        }

        private void yılaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Yıl");
            int s = 0, s2 = 0, s3 = 0;
            for (int i = 0; i < Kelimeler.Dizi2.Length; i++)
            {
                if (Kelimeler.Dizi2[i].Tekrar.Year == 2019)
                    s++;
                else if (Kelimeler.Dizi2[i].Tekrar.Year == 2018)
                    s2++;
                else if (Kelimeler.Dizi2[i].Tekrar.Year == 2017)
                    s3++;
            }
            chart1.Series["Yıl"].Points.AddXY("2017",s3 );
            chart1.Series["Yıl"].Points.AddXY("2018", s2);
            chart1.Series["Yıl"].Points.AddXY("2019", s);
        }

        private void haftayaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Series.Add("Hafta");
            int p = 0, s = 0, c = 0, p1 = 0, c1 = 0, c2 = 0, p2 = 0;
            for (int i = 0; i < Kelimeler.Dizi2.Length; i++)
            {
                if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Monday")
                    p++;
               else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Tuesday")
                    s++;
               else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Wednesday")
                    c++;
                else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Thursday")
                    p1++;
                else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Friday")
                    c1++;
                else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Saturday")
                    c2++;
                else if (Kelimeler.Dizi2[i].Tekrar.DayOfWeek.ToString() == "Sunday")
                    p2++;
            }
            chart1.Series["Hafta"].Points.AddXY("Pazartesi",p);
            chart1.Series["Hafta"].Points.AddXY("Salı", s);
            chart1.Series["Hafta"].Points.AddXY("Çarşamba",c);
            chart1.Series["Hafta"].Points.AddXY("Perşembe",p1);
            chart1.Series["Hafta"].Points.AddXY("Cuma", c1);
            chart1.Series["Hafta"].Points.AddXY("Cumartesi",c2);
            chart1.Series["Hafta"].Points.AddXY("Pazar", p2);
        }
    }
}
