using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTurleri
{
    class Program
    {
        static void Main(string[] args)
        {

            //degişken tanımlama 1
            int sayiTipi01;

            //degişken tanımlam 2
            int sayiTipi02 = 11;

            //degişken tanımlama 3
            int sayiTipi03;
            sayiTipi03 = 22;

            //degişken tanımı 4

            System.Int32 sayiTipiO4 = 111;


            Type veriTipi01 = sayiTipi03.GetType();

            //Console.WriteLine(veriTipi01);
            Console.WriteLine("veriTipi01 degişken tipi = {0}", veriTipi01);
            Dur();


            string str01 = "string yazi tipidir";

            Type veriTipi02 = str01.GetType();
            Console.WriteLine("veriTipi02 degişken tipi = {0}", veriTipi02);
            Dur();


            // veri dünüşümleri
            // int -> string
            // string -> int
            // string -> char

            string strInt01 = "123";

            int sayisi = int.Parse(strInt01);


            sayisi = sayisi + sayisi;
            //sayisi++;

            Console.WriteLine("sayisi = {0}", sayisi);
            Dur();


            string merhabaStr = "Merhaba Dünya";

            


            Console.WriteLine("merhabaStr string degişkeninin uzunlugu={0}",merhabaStr.Length);

            char ilkKarekteri = 'a';
            ilkKarekteri = merhabaStr[0];

            Console.WriteLine("merhabaStr string ilk karakteri={0}", ilkKarekteri);

            char sonKarakter = merhabaStr[12];
            Console.WriteLine("merhabaStr string son karakteri={0}", sonKarakter);


            Console.WriteLine("Dünya replace metodu ile degiştirildi.");
            Console.WriteLine("Önceki hali = {0}", merhabaStr);
            merhabaStr = merhabaStr.Replace("Dünya", "Mars");
            Console.WriteLine("Sonraki hali = {0}", merhabaStr);


            Dur();
        }


        static void Dur ()
        {

            Console.WriteLine("");
            Console.WriteLine("Devam etmek için bir tuşa bas!..");
            Console.ReadKey();
            Console.WriteLine("");

        }


    }
}
