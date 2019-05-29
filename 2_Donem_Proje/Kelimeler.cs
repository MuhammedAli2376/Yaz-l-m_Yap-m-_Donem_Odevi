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
        int sayac2 = 0;
        public static  Kelime[] Dizi = new Kelime[0];
        public static Kelime[] Dizi2 = new Kelime[0];
        public void Ekle(Kelime kok,string ingilizce, string turkce,int Turu, string cumle,string Soru,DateTime tekrar,int seviye,int id)
        {
            if (kok.Tekrar < tekrar)
            {
                if (kok.Sag == null)
                {
                    kok.Sag = new Kelime();
                    kok.Sag.Ingilizce = ingilizce;
                    kok.Sag.Turkce = turkce;
                    kok.Sag.Turu = Turu;
                    kok.Sag.OrnekCumle = cumle;
                    kok.Sag.Soru = Soru;
                    kok.Sag.Tekrar = tekrar;
                    kok.Sag.Seviye = seviye;
                    kok.Sag.ID = id;

                    return;
                }
                Ekle(kok.Sag, ingilizce, turkce,Turu, cumle, Soru, tekrar, seviye, id);
            }
            else
            {
                if (kok.Sol == null)
                {
                    kok.Sol = new Kelime();
                    kok.Sol.Ingilizce = ingilizce;
                    kok.Sol.Turkce = turkce;
                    kok.Sol.Turu = Turu;
                    kok.Sol.OrnekCumle = cumle;
                    kok.Sol.Soru = Soru;
                    kok.Sol.Tekrar = tekrar;
                    kok.Sol.Seviye = seviye;
                    kok.Sol.ID = id;
                    return;
                }
                Ekle(kok.Sol, ingilizce, turkce,Turu, cumle, Soru, tekrar, seviye, id);
            }
        }
        public void Tamamlanmis(Kelime dugum)
        {
            if (dugum == null)
                return;
            Tamamlanmis(dugum.Sol);
            Tamamlanmis_Ziyaret(dugum);
            Tamamlanmis(dugum.Sag);
        }
        private void Tamamlanmis_Ziyaret(Kelime dugum)
        {
            if (dugum.Seviye == 3)
            {
                Array.Resize(ref Dizi2, Dizi2.Length + 1);
                Dizi2[sayac2] = dugum;
                sayac2++;
            }
        }
        public void Tamamlanmamis(Kelime dugum)
        {
            if (dugum == null)
                return;
            Tamamlanmamis(dugum.Sol);
            Tamamlanmamis_Ziyaret(dugum);
            Tamamlanmamis(dugum.Sag);
        }
        private void Tamamlanmamis_Ziyaret(Kelime dugum)
        {
            if (dugum.Seviye != 3)
            {
                Array.Resize(ref Dizi, Dizi.Length + 1);
                Dizi[Sayac] = dugum;
                Sayac++;
            }
        }
      


    }
}
