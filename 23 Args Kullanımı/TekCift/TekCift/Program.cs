using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekCift
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayiStr = "";

            Console.WriteLine("girilen arguman sayısı:{0}",args.Length);

            if (args.Length > 0)
            {
                sayiStr = args[0];
            }
            else 
            {
                Console.Write("Konsola bir sayı giriniz : ");
                sayiStr = Console.ReadLine();

            }


           
            int sayiInt = Convert.ToInt32(sayiStr);

            if (sayiInt % 2 == 0)
            {
                Console.WriteLine($"Girdiğiniz sayı ({sayiInt}) çiftdir");
            }
            else 
            {
                Console.WriteLine($"Girdiğiniz sayı ({sayiInt}) tekdir");
            }

            Console.WriteLine("çıkmak için herhangi bir tuşa basınız!.");
            Console.ReadKey();
        }
    }
}
