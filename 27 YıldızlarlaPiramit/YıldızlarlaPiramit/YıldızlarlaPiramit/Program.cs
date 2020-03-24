using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YıldızlarlaPiramit
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //kat sayısı  = 5

            //....* 4 bosluk 1 yıldız
            //...*** 3 bosluk 3 yıldız
            //..***** 2 bosluk 5 yıldız
            //.******* 1 bosluk 7 yıldız
            //********* 0 bosluk 9 yıldız


            Console.Write("Konsola Piramitin Kat Sayısını Giriniz : ");
            string girilenString = Console.ReadLine();
            int kat = Convert.ToInt32(girilenString);

            int yıldız = 1;
            int bosluk = kat - 1;
            for (int i = 0; i < kat; i++)
            {
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < yıldız; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                bosluk--;
                yıldız = yıldız + 2;

            }
            Console.ReadKey();
        }
    }
}
