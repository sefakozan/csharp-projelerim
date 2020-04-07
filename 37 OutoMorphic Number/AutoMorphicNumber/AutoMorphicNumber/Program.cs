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
            int girilenSayi = KullanicidanSayiAl();

            if (girilenSayi <= 0)
            {
                Console.WriteLine("Gecerli bir dogal sayi giriniz!..");
            }

            for (int i = 0; i <= girilenSayi; i++)
            {
                int kare = KareAl(i);

                bool OtoMorfik = IsAutoMorphic(i , kare);
          
                if (OtoMorfik)
                {
                    Console.WriteLine($"{i} sayisi automorphic'tir.");
                }
            }
        }
        static int KullanicidanSayiAl()
        {
            int num = -1;

            Console.Write("dogal sayi giriniz:");
            string girilenSayiStr = Console.ReadLine();

            try
            {
                return Convert.ToInt32(girilenSayiStr);
                
            }
            catch
            {
                return num;
            }
        }

        static int KareAl(int sayi)
        {
            int kare;
            kare = sayi * sayi;
            return kare;
        }
        static bool IsAutoMorphic(int sayi, int kare)
        {           
            string sayiStr = Convert.ToString(sayi);
            string kareStr = Convert.ToString(kare);
           
            return kareStr.EndsWith(sayiStr); ;
        }
    }
}
