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
            /*      
    *
   * *
  * * *
 * * * *
* * * * *

       */
            Console.Write("Konsola Piramit Kat Sayısı Giriniz : ");
            string katString = Console.ReadLine();
            int kat = Convert.ToInt32(katString);

            for (int i = 0; i < kat; i++)
            {
                Console.WriteLine("*");

                for (int j = i; j < kat; j++)
                {
                    Console.Write("*");
                }
                
            }



            Console.ReadKey();
        }
    }
}
