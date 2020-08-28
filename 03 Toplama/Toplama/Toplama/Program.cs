using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            string sayi1Str, sayi2Str;

            while (true)
            {
                //int a, b, c;
                //Console.WriteLine("-------Hosgeldiniz-------");
                //Console.WriteLine(" ");
                //Console.WriteLine(">>> Konsola birinci sayiyi yaziniz!..");
                //Console.Write(">");
                //a = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine(">>> Konsola ikinci sayiyi yaziniz!..");
                //Console.Write(">");
                //b = Convert.ToInt32(Console.ReadLine());

                //c = a + b;
                //Console.dWriteLine("Toplam Sayı : " + c);
                //Console.WriteLine(" ");


                Console.Write("\tHosgeldiniz\n\n");
                Console.Write(">>> Konsola birinci sayiyi yaziniz!.. yada exit\n");
                Console.Write(">");

                sayi1Str = Console.ReadLine();

                sayi1Str = sayi1Str.ToLower();
                if (sayi1Str == "exit")
                {
                    break;
                }

                sayi1 = Convert.ToInt32(sayi1Str);

                // ikinci sayıyı kullanıcıdan oku
                Console.WriteLine("\n>>> Konsola ikinci sayiyi yaziniz!..yada exit");
                Console.Write(">");

                sayi2Str = Console.ReadLine();

                sayi2Str = sayi2Str.ToLower();
                if (sayi2Str == "exit")
                {
                    break;
                }

                sayi2 = Convert.ToInt32(sayi2Str);

                // toplamı hesapla yazdır.
                toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam Sayı : " + toplam);
                Console.WriteLine(" ");

            }

            Console.WriteLine("while döngüsünden çıkıldı");
            Console.WriteLine("programdan çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();

        }
    }
}
