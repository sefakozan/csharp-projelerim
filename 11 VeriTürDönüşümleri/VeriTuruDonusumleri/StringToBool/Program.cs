using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToBool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03 Veri Tür Dönüşümleri");

            string str = "true";
            bool dogru = true;
            dogru = Convert.ToBoolean(str);
            Console.WriteLine(dogru);
            Console.ReadKey();
        }
    }
}
