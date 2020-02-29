using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04 Veri Tür Dönüşümleri");

            string metin;
            Console.Write("Konsola tek karakterli bir şey yazınız? ");
            metin = Console.ReadLine();
            char karakter = Convert.ToChar(metin);
            Console.WriteLine("Girdiğiniz tek karakter : {0}",karakter);






            int i = 123;

            string s1 = i.ToString();

            string s2 = Convert.ToString(i);

            string s3 = string.Format("{0}", i);// anlamadım.

            string s4 = $"{i}";

            string s5 = "" + i;

            string s6 = string.Empty + i;

            string s7 = new StringBuilder().Append(i).ToString();


            Console.WriteLine($"{s1} {s2} {s3} {s4} {s5} {s6} {s7}");


            Console.ReadKey();



        }
    }
}
