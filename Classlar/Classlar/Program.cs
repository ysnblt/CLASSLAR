using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int kapiSayisi = 4;
            string arabaModeli = "Renault";
            string arabaRengi = "Kırmızı";
            Araba araba1 = new Araba(4 , "Renault" , "Kırmızı");
            Console.WriteLine("Kapı sayısı :"  + araba1.kapiSayisi);
            Console.WriteLine("Araba modeli :" + araba1.arabaModel);
            Console.WriteLine("Araba rengi :" + araba1.arabaRengi);
           
            Console.ReadLine();
        }
    }
}
