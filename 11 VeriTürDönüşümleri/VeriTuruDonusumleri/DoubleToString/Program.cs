using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("06 Veri Tür Dönüşümleri");

            double x = 10.5;
            string a = Convert.ToString(x);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
