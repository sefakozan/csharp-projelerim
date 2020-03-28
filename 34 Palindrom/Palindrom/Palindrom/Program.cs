using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://www.youtube.com/watch?v=-Z5ZQ5s9Wno return

            Console.Write("Kelime giriniz : ");
            string girilenStr = Console.ReadLine();

            

            bool PolindromKontrol = IsPolidrom(girilenStr);

            if (PolindromKontrol == false)
            {
                Console.WriteLine("Polindrom değildir");
            }
            else
            {
                Console.WriteLine("Polindromdur");
            }

            Console.WriteLine("Program sonlanmıştır. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();

        }

        static bool IsPolidrom(string str)
        {
            // Döngü içinde flag kullanmak lazım
            // Flag değişkenleri genelde bool olur
            bool polindromFlag = true;

            char[] harfler = str.ToCharArray();

            // int bölme işlem yapıldığında 5'i 2 ye bölersek sonuç 2 çıkar.
            int döngüSayısı = harfler.Length / 2;
            for (int i = 0; i < döngüSayısı; i++)
            {
                //Console.WriteLine(harfler[i]);

                if (harfler[i] != harfler[harfler.Length - 1 - i])
                {
                    //Console.WriteLine("Polindrom değil");
                    polindromFlag = false;
                    break;
                }

            }
            //polindrom mu değil mi diye buraya yazılacak

            return polindromFlag;

        }

            
     }   

}

