using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("07 Veri Tür Dönüşümleri");

            bool yanlisBayrak = false;
            bool dogruBayrak = true;

            Console.WriteLine(Convert.ToString(yanlisBayrak));
            Console.WriteLine(Convert.ToString(yanlisBayrak).Equals(Boolean.FalseString));

            Console.WriteLine(Convert.ToString(dogruBayrak));
            Console.WriteLine(Convert.ToString(dogruBayrak).Equals(Boolean.TrueString));
            Console.ReadKey();
        }
    }
}
