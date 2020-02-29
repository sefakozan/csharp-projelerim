using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Konsola bir sayı giriniz : ");
                string metin = Console.ReadLine();
                int girilenSayi = Convert.ToInt32(metin);

                
                for (int i = girilenSayi - 1 ; i >= 2; i--)
                {
                    if (girilenSayi % i == 0)
                    {
                        Console.WriteLine("Girilen Sayı Asal Sayı Değildir.");
                        break;
                    }

                    if (i == 2)
                    {
                        Console.WriteLine("Girilen Sayı Asal Sayıdır.");
                    }
                   
                }
   
                

            }
        }
    }
}
