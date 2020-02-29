using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumAsalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong toplamAsalSayiSayisi = 0;
            
            for (ulong j = 2; j < ulong.MaxValue; j++)
            {
                for (ulong i = 2; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        //Console.WriteLine("Girilen Sayı Asal Değildir.");
                        break;
                    }
                    if (i == j - 1)
                    {
                        //Console.WriteLine("Girilen Sayı Asaldır.");
                        Console.WriteLine(j);
                        toplamAsalSayiSayisi++;
                        break;
                    }

                }
            }



           
            Console.WriteLine("Bulunan toplam asal sayi sayısı = {0}", toplamAsalSayiSayisi);
            Console.WriteLine("Program bitti çıkmak için hehangi bir tuşa basınız.");
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
