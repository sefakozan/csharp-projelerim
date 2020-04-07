using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMorphicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            char keyChar;
            do
            {
                StartAutoMorphic();
                Console.WriteLine("çıkmak için 'q' devam etmek için herhangi bir tuşa basınız!..");
                keyChar = Console.ReadKey().KeyChar;

            } while (keyChar != 'q' && keyChar != 'Q');

        }
        static void StartAutoMorphic()
        {
            long girilenSayi = KullanicidanSayiAl();

            if (girilenSayi <= 0)
            {
                Console.WriteLine("Gecerli bir dogal sayi giriniz!..");
            }

            for (int i = 0; i <= girilenSayi; i++)
            {
                long kare = KareAl(i);

                bool OtoMorfik = IsAutoMorphic(i , kare);
          
                if (OtoMorfik)
                {
                    Console.WriteLine($"{i} sayisi automorphic'tir.");
                }
            }
        }
        static long KullanicidanSayiAl()
        {
            int num = -1;

            Console.Write("dogal sayi giriniz:");
            string girilenSayiStr = Console.ReadLine();

            try
            {
                return Convert.ToInt64(girilenSayiStr);
                
            }
            catch
            {
                return num;
            }
        }

        static long KareAl(long sayi)
        {
            long kare;
            kare = sayi * sayi;
            return kare;
        }
        static bool IsAutoMorphic(long sayi, long kare)
        {           
            string sayiStr = Convert.ToString(sayi);
            string kareStr = Convert.ToString(kare);
           
            return kareStr.EndsWith(sayiStr); ;
        }
    }
}
