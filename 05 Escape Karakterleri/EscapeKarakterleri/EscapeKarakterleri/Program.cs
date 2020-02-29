using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeKarakterleri
{
    class Program
    {
        static void Main(string[] args)
        {
             // \n alt satıra geçer.
            Console.Write("Hello\n");
            Console.Write("World");
            Console.ReadKey();

            // \a uyarı sesi verir.
            Console.Write("Hello \a");
            Console.Write("World");
            Console.ReadKey();

            // \t bir tablık boşluk bırakır.
            Console.Write("\tHello");
            Console.Write("\tWorld");
            Console.ReadKey();

            // \" cift tırnak koyar.
            Console.Write("Hello \"");
            Console.Write("World\"");
            Console.ReadKey();

            // \' tek tırnak koyar.
            Console.Write("Hello \'");
            Console.Write("World\'");
            Console.ReadKey();

            // \b önceki karakteri siler.
            Console.Write("Hello\b");
            Console.Write("World");
            Console.ReadKey();

            // \r satır başı yapar.
            Console.Write("\rHello");
            Console.WriteLine("World");
            Console.ReadKey();


        }
    }
}
