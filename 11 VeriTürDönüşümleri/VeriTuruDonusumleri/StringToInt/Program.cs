using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01 Veri Tür Dönüşümleri");


            int sayi;
            int sayi2;
            int toplam;


            Console.Write("Konsola birinci sayıyı giriniz? ");
            string sayiStr = Console.ReadLine();
            sayi = Convert.ToInt32(sayiStr);

            Console.Write("Konsola ikinci sayıyı giriniz? ");
            string sayi2Str = Console.ReadLine();
            sayi2 = Convert.ToInt32(sayi2Str);

            toplam = sayi + sayi2;

            Console.Write("İki sayını toplamı : {0}",toplam);
            Console.ReadKey();
        }
    }
}
