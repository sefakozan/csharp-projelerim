using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("08 Veri Tür Dönüşümleri");

            char[] harfdizisi = new char[5];
            harfdizisi[0] = 'a';
            harfdizisi[1] = 'b';
            harfdizisi[2] = 'c';
            harfdizisi[3] = 'd';
            harfdizisi[4] = 'e';

            string metin = new string(harfdizisi);
            Console.WriteLine(metin);
            Console.ReadKey();

        }
    }
}
