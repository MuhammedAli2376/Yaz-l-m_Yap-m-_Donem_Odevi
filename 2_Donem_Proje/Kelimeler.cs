using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _2_Donem_Proje
{
   public class Kelimeler
    {
        int Sayac = 0;
        public static  Kelime[] Dizi = new Kelime[0];
        public void Ekle(Kelime kok,string ingilizce, string turkce, string cumle,string Soru,DateTime tekrar,int seviye,int id)
        {
            if (seviye != 3)
            {
                if (kok.Tekrar < tekrar)
                {
                    if (kok.Sag == null)
                    {
                        kok.Sag = new Kelime();
                        kok.Sag.Ingilizce = ingilizce;
                        kok.Sag.Turkce = turkce;
                        kok.Sag.OrnekCumle = cumle;
                        kok.Sag.Soru = Soru;
                        kok.Sag.Tekrar = tekrar;
                        kok.Sag.Seviye = seviye;
                        kok.Sag.ID = id;

                        return;
                    }
                    Ekle(kok.Sag, ingilizce, turkce, cumle, Soru, tekrar, seviye, id);
                }
                else
                {
                    if (kok.Sol == null)
                    {
                        kok.Sol = new Kelime();
                        kok.Sol.Ingilizce = ingilizce;
                        kok.Sol.Turkce = turkce;
                        kok.Sol.OrnekCumle = cumle;
                        kok.Sol.Soru = Soru;
                        kok.Sol.Tekrar = tekrar;
                        kok.Sol.ID = id;
                        return;
                    }
                    Ekle(kok.Sol, ingilizce, turkce, cumle, Soru, tekrar, seviye, id);
                }
            }
        }
        public void InOrderInt(Kelime dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.Sol);
            Ziyaret(dugum);
            InOrderInt(dugum.Sag);
        }
        private void Ziyaret(Kelime dugum)
        {
            Array.Resize(ref Dizi, Dizi.Length + 1);
            Dizi[Sayac] = dugum;
            Sayac++;
        }
    }
}
