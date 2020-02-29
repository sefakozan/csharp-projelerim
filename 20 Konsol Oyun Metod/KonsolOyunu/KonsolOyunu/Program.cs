using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolOyunu
{
    class Program
    {
        static int KullanicidanSayiAl(int min, int max,int hamleSayisi) 
        {
            int sayi = 0;

            while (true) 
            {
                Console.Write($"\n{min}-{max} arasinda sayi gir({hamleSayisi:D2}):");
                string satirStr = Console.ReadLine();
                //Console.WriteLine("");

                try
                {
                    int satirInt = Convert.ToInt32(satirStr);
                    if (satirInt >= min && satirInt <= max)
                    {
                        sayi = satirInt;
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Gecerli bir aralikta sayi giriniz!...");
                    }
                }
                catch
                {
                    Console.WriteLine("Gecerli bir sayi giriniz!...");
                }
            }

            return sayi;
        }

        static int TahminSirasiKullanicida() 
        {
            int hamleSayisi = 0;

            Random randomsayi = new Random();
            int tutulanSayi = randomsayi.Next(0, 100);

            Console.WriteLine("Sıra Sende, Aklımdan 0-100 arası bir sayı tuttum!..");
            Console.WriteLine("Tahmin et!..");

            while (true) 
            {
                hamleSayisi++;
                int kullaniciTahmini = KullanicidanSayiAl(0,100, hamleSayisi);

                if (tutulanSayi > kullaniciTahmini)
                {
                    Console.WriteLine("Daha büyük bir sayı tuttum!..");
                }
                else if (tutulanSayi < kullaniciTahmini)
                {
                    Console.WriteLine("Daha küçük bir sayı tuttum!..");
                }
                else 
                {
                    Console.WriteLine("Doğru bildin, tuttugum sayı {0} !..", tutulanSayi);
                    break;
                }

            }

            return hamleSayisi;
        }


        static char KullanicidanCevapAl(int hamleSayisi) 
        {
            char cevap = 'x';

            while (true) 
            {
                Console.WriteLine("'küçük|kucuk|k', 'büyük|buyuk|b' yada 'eşit|esit|e' yazınız!..");

                Console.Write($"({hamleSayisi:D2})> ");
                string satir = Console.ReadLine();
                satir = satir.ToLower();

                if (satir == "büyük" || satir == "buyuk" || satir == "b")
                {
                    cevap = 'b';
                    break;
                }
                else if (satir == "küçük" || satir == "kucuk" || satir == "k")
                {
                    cevap = 'k';
                    break;
                }
                else if (satir == "eşit" || satir == "esit" || satir == "e")
                {
                    cevap = 'e';
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli bir deger giriniz!..");
                }

            }

            return cevap;
        }

        static int TahminSirasiBilgisayarda()
        {
            int hamleSayisi = 0;

            Random random = new Random();
            int enKucuk = 0, enBuyuk = 100;

            while (true) 
            {
                hamleSayisi++;
                int bilgisayarTahmini = random.Next(enKucuk, enBuyuk);
                Console.WriteLine("{0:D2}. tuttuğun sayı = {1}", hamleSayisi, bilgisayarTahmini);
                char cevap = KullanicidanCevapAl(hamleSayisi);

                switch (cevap)
                {
                    case 'b':
                        enKucuk = bilgisayarTahmini + 1 ;
                        break;
                    case 'k':
                        enBuyuk = bilgisayarTahmini - 1;
                        break;
                    case 'e':
                        Console.WriteLine("Doğru bildim!..");
                        break;
                }

                if (cevap == 'e') 
                {
                    //while'dan çık
                    break;
                }

            }


            return hamleSayisi;
        }

        static void SonucYaz(int kullaniciTahminSayisi, int bilgisayarTahminSayisi) 
        {
            Console.WriteLine("Senin tahmin sayın = {0}", kullaniciTahminSayisi);
            Console.WriteLine("Benim tahmin sayım = {0}", bilgisayarTahminSayisi);

            if (kullaniciTahminSayisi < bilgisayarTahminSayisi)
            {
                Console.WriteLine("Kullanıcı Kazandı!..");
            }
            else if (bilgisayarTahminSayisi < kullaniciTahminSayisi)
            {
                Console.WriteLine("Bilgisayar Kazandı!..");
            }
            else 
            {
                Console.WriteLine("Berabere Kaldık :(");
            }

        }


        static void OyunaBasla() 
        {

            while (true) 
            {
                Console.Clear();
                // oyun birinci kısım
                // bilgisayar sayi tutatcak kullanıcı tahmin edecek.
                int kullaniciTahminSayisi = TahminSirasiKullanicida();

                //oyun arası 1. yarı bitti
                Console.WriteLine("Dogru cevabı {0} hamlede buldun.", kullaniciTahminSayisi);
                Console.WriteLine("Eger ben daha az hamlede senin tuttugun sayıyı bulursam kazanırım.");
                Console.WriteLine("Şimdi Aklından 0-100 arasından bir sayı tut.");
                Console.WriteLine("Tuttuysan devam etmek için herhangi bir tuşa bas!..");
                Console.ReadKey();


                // oyun ikinci kısım
                // kullanıcı sayi tutatcak bilgisayar tahmin edecek.
                int bilgisayarTahminSayisi = TahminSirasiBilgisayarda();

                SonucYaz(kullaniciTahminSayisi, bilgisayarTahminSayisi);

                Console.WriteLine("Oyun bitti!.. Çıkmak için 'e' tuşuna basınız basınız!..");
                Console.WriteLine("Tekrar etmek için herhangi bir tuşuna basınız basınız!..");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == 'e' || keyInfo.KeyChar == 'E') 
                {
                    break;
                }

            }
        }

        static void Main(string[] args)
        {
            OyunaBasla();
            Console.Clear();
            Console.WriteLine("Program sonlandı!... Kapatmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
    }
}
