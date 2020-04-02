using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersYazdırma
{
    class Program
    {
        static void Main(string[] args)
        {
            KareHesaplama();
            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
        }
        static int KareHesaplama()
        {
            int kare, sayi; ;
            Console.Write("- Konsola bir sayı giriniz : ");
            string sayiStr = Console.ReadLine();
            sayi = Convert.ToInt32(sayiStr);

            // sayiyi kendisi ile çarpıp karesini buldum.
            kare = sayi * sayi;
            Console.WriteLine("- Girdiğiniz sayının karesi : {0}", kare);

            string[] harfler = new string[kare];
            return kare;

        }
    }
}
