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

                // üç degişken tanıplayıp, 0 atayacaz
                // 0'la initialize edecez
                int sayi1 = 0;
                int sayi2 = 0;
                int toplam = 0;

                // birinci sayıyı kullanıcıdan oku
                Console.Write("\tHosgeldiniz\n\n");
                Console.Write(">>> Konsola birinci sayiyi yaziniz!.. yada exit\n");
                Console.Write(">");

                string sayi1Str = Console.ReadLine();

                if (sayi1Str == "exit")
                {
                    break;
                }

                sayi1 = Convert.ToInt32(sayi1Str);

                // ikinci sayıyı kullanıcıdan oku
                Console.WriteLine("\n>>> Konsola ikinci sayiyi yaziniz!..yada exit");
                Console.Write(">");

                string sayi2Str = Console.ReadLine();


                if (sayi2Str == "exit")
                {
                    break;
                }


                sayi2 = Convert.ToInt32(sayi1Str);

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
