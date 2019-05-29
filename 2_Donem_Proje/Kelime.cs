using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Donem_Proje
{
   public class Kelime
    {
        public Kelime Sag;
        public Kelime Sol;
        public int ID;
        public string Ingilizce { get; set; }
        public string Turkce { get; set; }
        public string OrnekCumle { get; set; }
        public string Soru { get; set; }
        public int Turu { get; set; }
        public int Seviye { get; set; }
        public DateTime Tekrar { get; set; }
        public Kelime()
        {
            Sag = null;
            Sol = null;
        }
    }
}
