using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02 Veri Tür Dönüşümleri");

            string metin;
            double sayi;

            Console.Write("Konsola bir sayı giriniz? ");
            metin = Console.ReadLine();
            sayi = Convert.ToDouble(metin);

            sayi = sayi / 2;
            Console.Write("{0}'ın Yarısı : {1}",metin,sayi);
            Console.ReadKey();
        }
    }
}
