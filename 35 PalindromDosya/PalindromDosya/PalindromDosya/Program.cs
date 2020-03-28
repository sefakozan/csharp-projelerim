using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PalindromDosya
{
    class Program
    {
        static void Main(string[] args)
        {

            Directory.CreateDirectory("C:\\Palindromm");
            string DosyaYolu = @"C:\Palindromm\PalindromMetin.txt";

            string okunanSatirlar = File.ReadAllText(DosyaYolu);
            string[] kelimeler = okunanSatirlar.Split(' ', '#', '\n', '\r');

            int PolindromOlanlar = 0;

            for (int i = 0; i < kelimeler.Length; i++)
            {
                if (kelimeler[i].Length == 0)
                {
                    continue;
                }

                bool PolindromKontrol = IsPolidrom(kelimeler[i]);

                if (PolindromKontrol == false)
                {
                }
                else
                {
                    Console.WriteLine(kelimeler[i]);
                    PolindromOlanlar++;
                }

            }
            Console.WriteLine("Toplam palindrom sayisi: {0}", PolindromOlanlar);
            Console.WriteLine("Program bitti. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();

        }
        static bool IsPolidrom(string str)
        {
            bool polindromFlag = true;

            char[] harfler = str.ToCharArray();

            int döngüSayısı = harfler.Length / 2;
            for (int i = 0; i < döngüSayısı; i++)
            {

                if (harfler[i] != harfler[harfler.Length - 1 - i])
                {
                    polindromFlag = false;
                    break;
                }

            }

            return polindromFlag;

        }
    }

}
