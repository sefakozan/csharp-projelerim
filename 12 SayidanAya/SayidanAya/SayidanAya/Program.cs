using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayidanAya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çıkmak için 'exit' yada 'çıkış' yazınız!...");


            while (true)
            {
                Console.Write("\nKonsola 1 ile 12 arasında bir sayı giriniz : ");
                int sayi = 0;

                string metin = Console.ReadLine();

                metin = metin.ToUpper();
                if (metin == "EXİT" || metin == "EXIT" || metin == "ÇIKIŞ")
                {

                    break;
                }


                try
                {
                    sayi = Convert.ToInt32(metin);
                }
                catch
                {
                    Console.WriteLine("Lütfen konsola saçma sapan şey girme!..");
                    continue;
                }



                switch (sayi)
                {
                    case 1:
                        Console.WriteLine("Girdiginiz 1 sayisina karsılık ay ismi : OCAK");
                        break;
                    case 2:
                        Console.WriteLine("Girdiginiz 2 sayisina karsılık ay ismi : ŞUBAT");
                        break;
                    case 3:
                        Console.WriteLine("Girdiginiz 3 sayisina karsılık ay ismi : MART");
                        break;
                    case 4:
                        Console.WriteLine("Girdiginiz 4 sayisina karsılık ay ismi : NİSAN");
                        break;
                    case 5:
                        Console.WriteLine("Girdiginiz 5 sayisina karsılık ay ismi : MAYIS");
                        break;
                    case 6:
                        Console.WriteLine("Girdiginiz 6 sayisina karsılık ay ismi : HAZİRAN");
                        break;
                    case 7:
                        Console.WriteLine("Girdiginiz 7 sayisina karsılık ay ismi : TEMMUZ");
                        break;
                    case 8:
                        Console.WriteLine("Girdiginiz 8 sayisina karsılık ay ismi : AĞUSTOS");
                        break;
                    case 9:
                        Console.WriteLine("Girdiginiz 9 sayisina karsılık ay ismi : EYLÜL");
                        break;
                    case 10:
                        Console.WriteLine("Girdiginiz 10 sayisina karsılık ay ismi : EKİM");
                        break;
                    case 11:
                        Console.WriteLine("Girdiginiz 11 sayisina karsılık ay ismi : KASIM");
                        break;
                    case 12:
                        Console.WriteLine("Girdiginiz 12 sayisina karsılık ay ismi : ARALIK");
                        break;
                    default:
                        Console.WriteLine("Lütfen konsola 1 ile 12 arasında bir sayı giriniz!..");
                        break;
                }
                
            }
            Console.WriteLine("Program sonlandı, programı kapatmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
    }
}
