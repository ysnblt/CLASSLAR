using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;
        public void motorCalıstır()
        {
            Console.WriteLine("Motor çalışıyor");
        }


        public Araba(int _kapiSayisi , string _arabaModeli , string _arabaRengi )
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModeli;
            arabaRengi = _arabaRengi;

        }

        public void kapilariKilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor");
        }
    }
}
