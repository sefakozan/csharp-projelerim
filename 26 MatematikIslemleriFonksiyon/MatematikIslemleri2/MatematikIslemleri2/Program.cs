using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Aritmetik İşlemler Menüsüne Hoşgeldiniz...\n");
                Console.WriteLine("-----------| Menü |-----------\n");
                Console.WriteLine("1- Aritmetik Dört İşlem");
                Console.WriteLine("2- Üs Alma");
                Console.WriteLine("3- Kök Alma");
                Console.WriteLine("4- Karenin Alan ve Çevre Hesabı");
                Console.WriteLine("5- Dikdörtgende Alan ve Çevre Hesabı");
                Console.WriteLine("6- Eşkenar Üçgende Çevre Hesabı\n");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Not : Çıkmak İçin 'Exit' Yazınız.\n");



                Console.Write("> İşlem Yapmak İstediğiniz Alanı Giriniz : ");

                string girilenString = Console.ReadLine();
                if (girilenString == "Exit" || girilenString == "exit")
                {
                    break;
                }
                int AlanSayisi = Convert.ToInt16(girilenString);
                

                if (AlanSayisi == 1)
                {
                    AritmetikDortIslem();
                }
                else if(AlanSayisi == 2)
                {
                    UsAlma();
                }
                else if(AlanSayisi == 3)
                {
                    KokAlma();
                }
                else if(AlanSayisi == 4)
                {
                    KareAlanveCevre();
                }
                else if(AlanSayisi == 5)
                {
                    DikdortgenAlanveCevre();
                }
                else if (AlanSayisi == 6)
                {
                    EskenarCevre();
                }
                else
                {
                    Console.WriteLine("!!! Lütfen Konsola 1 ile 6 Arasında Bir Değer Girini !!!\n");

                }
            }
            Console.WriteLine("Program Sonlanmıştır. Çıkmak İçin Bir Tuşa Basınız!..");
            Console.ReadKey();
        }
        static void AritmetikDortIslem()
        {
            int sayi1, sayi2, toplam, fark, carpma, bolme;
            Console.Write("Konsola Birinci Sayıyı Giriniz : ");
            string sayi1String = Console.ReadLine();
            sayi1 = Convert.ToInt16(sayi1String);

            Console.Write("Konsola İkinci Sayıyı Giriniz : ");
            string sayi2String = Console.ReadLine();
            sayi2 = Convert.ToInt16(sayi2String);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolme = sayi1 / sayi2;

            Console.WriteLine(">> Toplam = {0}", toplam);
            Console.WriteLine(">> Farkı = {0}", fark);
            Console.WriteLine(">> Çarpımı = {0}", carpma);
            Console.WriteLine(">> Bölümü = {0}", bolme);


        }
        static void UsAlma()
        {

            double sayi, us, sonuc;
            Console.Write("Konsola Bir Sayı Giriniz : ");
            string sayiString = Console.ReadLine();
            sayi = Convert.ToDouble(sayiString);

            Console.Write("Konsola Sayını Üssünü Giriniz : ");
            string usString = Console.ReadLine();
            us = Convert.ToDouble(usString);

            sonuc = Math.Pow(sayi, us);
            Console.WriteLine("Sonuc : {0}", sonuc);

        }
        static void KokAlma()
        {

            double sayiKoK, Koksonuc;
            Console.Write("Konsola Bir Sayı Giriniz : ");
            string sayiKokString = Console.ReadLine();
            sayiKoK = Convert.ToDouble(sayiKokString);

            Koksonuc = Math.Sqrt(sayiKoK);
            Console.WriteLine("Sonuc : {0}", Koksonuc);

        }
        static void KareAlanveCevre()
        {

            int sayiKare, AlanKare, CevreKare;
            Console.Write("Konsola Karenin Bir Kenarını Giriniz : ");
            string kareString = Console.ReadLine();
            sayiKare = Convert.ToInt32(kareString);

            AlanKare = sayiKare * sayiKare;
            CevreKare = sayiKare * 4;
            Console.WriteLine("Karenin Alanı = {0}", AlanKare);
            Console.WriteLine("Karenin Çevresi = {0}", CevreKare);

        }
        static void DikdortgenAlanveCevre()
        {

            int kısakenar, uzunkenar, dikAlan, dikCevre;
            Console.WriteLine();

            Console.Write("Konsola Dikdörgenin Kısa Kenarını Giriniz : ");
            string kısakenarString = Console.ReadLine();
            kısakenar = Convert.ToInt32(kısakenarString);

            Console.Write("Konsola Dikdörgenin Uzun Kenarını Giriniz : ");
            string uzunkenarString = Console.ReadLine();
            uzunkenar = Convert.ToInt32(uzunkenarString);

            dikAlan = kısakenar * uzunkenar;
            dikCevre = kısakenar * 2 + uzunkenar * 2;

            Console.WriteLine("Dikdörtgenin Alanı = {0}", dikAlan);
            Console.WriteLine("Dikdörtgenin Çevresi = {0}", dikCevre);

        }
        static void EskenarCevre()
        {

            int ucgenkenar, ucgenCevre;
            Console.Write("Konsola Üçgenin Bir Kenarını Giriniz : ");
            string ucgenString = Console.ReadLine();
            ucgenkenar = Convert.ToInt32(ucgenString);

            ucgenCevre = ucgenkenar * 3;
            Console.WriteLine("Üçgenin Çevresi : {0}", ucgenCevre);

        }
    }

}
