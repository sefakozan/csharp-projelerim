using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiTers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz : ");
            string satir = Console.ReadLine();
            int sayi = Convert.ToInt32(satir);
            bool isAsal = true;

            if (sayi <= 1)
            {
                isAsal = false;
            }
            else if (sayi == 2)
            {
                isAsal = true;
            }
            else 
            {

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        isAsal = false;
                        break;
                    }
                }

            }

            if (isAsal)
            {
                Console.WriteLine("Asal");
            }
            else 
            {
                Console.WriteLine("Asal Degil");
            }

            Console.ReadKey();
      

        }
    }
}

