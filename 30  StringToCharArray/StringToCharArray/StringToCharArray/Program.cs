using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Konsola bir şey giriniz : ");
            string girdigiString = Console.ReadLine();


            //foreach (var item in girdigiString)
            //{
            //    Console.WriteLine(item);
            //}


            //https://www.includehelp.com/dot-net/convert-string-to-character-array-in-c-sharp.aspx

            char[] karakter = girdigiString.ToCharArray();


            for (int i = 0; i < girdigiString.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }

            Console.ReadKey();
        }
    }
}
