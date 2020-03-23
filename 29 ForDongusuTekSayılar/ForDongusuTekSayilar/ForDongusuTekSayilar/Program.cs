using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuTekSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Konsola Bir Sayı Giriniz : ");
            string girilenStr = Console.ReadLine();
            int girilenSayi = Convert.ToInt32(girilenStr);

            for (int i = 0; i <= girilenSayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
