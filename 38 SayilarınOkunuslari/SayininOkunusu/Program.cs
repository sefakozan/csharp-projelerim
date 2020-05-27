using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayininOkunusu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\n0 ile 999 arasında sayi giriniz: ");
                string sayiStr = Console.ReadLine();

                sayiStr = sayiStr.ToLower();

                if (sayiStr == "exit")
                    break;

                int sayi = Convert.ToInt32(sayiStr);

                if (sayi > 999 || sayi < 0 )
                {
                    Console.WriteLine("hatalı sayi!!!");
                    continue;
                }

                SayiYazilisi(sayi);
            }
            Console.WriteLine("Program sonlandı.");
            Console.ReadKey();
        }
        static void SayiYazilisi(int sayi)
        {
            YuzlerBasamagiYazdir(sayi);
            OnlarBasamagiYazdir(sayi);
            BirlerBasamagiYazdir(sayi);
            
            if (sayi == 0)
            {
                Console.WriteLine("sıfır");
            }

        }
        static void YuzlerBasamagiYazdir(int sayi)
        {
            switch (sayi / 100)
            {
                case 9:
                    Console.Write("dokuzyüz ");
                    break;
                case 8:
                    Console.Write("sekizyüz ");
                    break;
                case 7:
                    Console.Write("yediyüz ");
                    break;
                case 6:
                    Console.Write("altıyüz ");
                    break;
                case 5:
                    Console.Write("beşyüz ");
                    break;
                case 4:
                    Console.Write("dörtyüz ");
                    break;
                case 3:
                    Console.Write("üçyüz ");
                    break;
                case 2:
                    Console.Write("ikiyüz ");
                    break;
                case 1:
                    Console.Write("yüz ");
                    break;
            }
        }
        static void OnlarBasamagiYazdir(int sayi)
        {
            switch ((sayi % 100) / 10)
            {
                case 9:
                    Console.Write("doksan ");
                    break;
                case 8:
                    Console.Write("seksen ");
                    break;
                case 7:
                    Console.Write("yetmiş ");
                    break;
                case 6:
                    Console.Write("altmış ");
                    break;
                case 5:
                    Console.Write("elli ");
                    break;
                case 4:
                    Console.Write("kırk ");
                    break;
                case 3:
                    Console.Write("otuz ");
                    break;
                case 2:
                    Console.Write("yirmi ");
                    break;
                case 1:
                    Console.Write("on ");
                    break;
            }
        }
        static void BirlerBasamagiYazdir(int sayi)
        {
            switch ((sayi % 100) % 10)
            {
                case 9:
                    Console.Write("dokuz ");
                    break;
                case 8:
                    Console.Write("sekiz ");
                    break;
                case 7:
                    Console.Write("yedi ");
                    break;
                case 6:
                    Console.Write("altı ");
                    break;
                case 5:
                    Console.Write("beş ");
                    break;
                case 4:
                    Console.Write("dört ");
                    break;
                case 3:
                    Console.Write("üç ");
                    break;
                case 2:
                    Console.Write("iki ");
                    break;
                case 1:
                    Console.Write("bir ");
                    break;
            }
        }
    }
}
