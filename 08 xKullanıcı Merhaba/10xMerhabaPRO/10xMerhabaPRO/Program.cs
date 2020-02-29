using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10xMerhabaPRO
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Konsola 'Merhaba' Yazısını Kaç Defa Yazdırılacağını Yazınız --> ");
            string girilenStr = Console.ReadLine();
            sayi = Convert.ToInt32(girilenStr);

            for (int i = 0; i < sayi; i=i+1)
            {
                int merahabaSayisi = i + 1;
                Console.WriteLine("> Merhaba {0}", merahabaSayisi);
            }

            Console.ReadKey();
        }

    }
}
