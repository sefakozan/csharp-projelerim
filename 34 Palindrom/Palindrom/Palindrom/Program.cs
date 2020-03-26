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


            Console.Write("Kelime giriniz : ");
            string girilenStr = Console.ReadLine();

            char[] harfler = girilenStr.ToCharArray();
            // int bölme işlem yapıldığında 5'i 2 ye bölersek sonuç 2 çıkar.
            int döngüSayısı = harfler.Length / 2;

            bool polindromFlag = true;

            // Döngü içinde flag kullanmak lazım
            // Flag değişkenleri genelde bool olur
            for (int i = 0; i < döngüSayısı; i++)
            {
                //Console.WriteLine(harfler[i]);

                if (harfler[i] != harfler[harfler.Length -1 -i])
                {
                    //Console.WriteLine("Polindrom değil");
                    polindromFlag = false;
                    break;
                }

            }
            if (polindromFlag == false)
            {
                Console.WriteLine("Polindrom değildir");
            }
            else
            {
                Console.WriteLine("Polindromdur");
            }



            // polindrom mu değil mi diye buraya yazılacak
            Console.ReadKey();
        }
    }
}
