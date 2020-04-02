using System;

namespace DrinkMACHINE
{
    // PascalCase yazılır
    // https://medium.com/better-programming/string-case-styles-camel-pascal-snake-and-kebab-case-981407998841
    class DrinkingMachine
    {
        // sabitlerin degeri program boyunca degişmez
        // SNAKE_CASE yazilir.
        const int SU_FIYATI = 5;
        const int CAY_FIYATI = 10;
        const int KAHVE_FIYATI = 15;
        const int KOLA_FIYATI = 25;

        // Main'in icine kod yazılmaz. 1 satır kod olur genelde.
        // Bir fonksiyonda en fazla 40 satır kod olur.
        // Degişken adları en fazla 3 kelimeden oluşur. 2 kelime kullanmak genelde en iyisidir.
        // iç içe 2 den fazla if kullanılmaz.
        // az degişken kullanmak önemlidir, degişken çöplüğü kötüdür.
        // degişen şey deişkendir.
        // iyi yazılmış kodda en az kod kadar yorum olur.
        // while(true) sonsuz döngüler kod yazarken genelde kullanılmaz.
        // break ve continue kullanmak kötüdür genelde kullanmamak iyidir. 
        // iç içe döngüler tehlikelidir. Genelde 1 döngüde iş yapılır.
        // programı anlamsal kısımlara yani fonksiyonlara yani metodlara ayırabilmek çok önemlidir.
        // kodu yazmadan önce foksiyonları yazabiliyor ve sadece fonksiyonların icin doldurunca program çalışıyorsa bu iş tamam demektir.
        // döngü sayısı belli ise for döngüsüdür, belli değil ise genelde while döngüsüdür.
        static void Main()
        {

            //int paraUstu = ParaAl(30);

            StartDrinkingMachine();
        }

        static void StartDrinkingMachine()
        {

            PrintGreeting();

            // genelde degişkenler fonksiyon başında yada fonk başına yakın yerlerde tanımlaır.
            int kullaniciTercihi = Menu();
            int paraUstu = 0;
            string alinanUrun = "";



            switch (kullaniciTercihi)
            {
                // genelde case'lerin icinde 3-5 satır kod olur.
                case 1:
                    alinanUrun = "Water";
                    Console.WriteLine($"- {alinanUrun} {SU_FIYATI} TL");
                    paraUstu = ParaAl(SU_FIYATI);
                    // geri verilecek para yazılacak vs..
                    break;
                case 2:
                    alinanUrun = "Tea";
                    Console.WriteLine($"- {alinanUrun} {CAY_FIYATI} TL");
                    paraUstu = ParaAl(CAY_FIYATI);
                    // geri verilecek para yazılacak vs..

                    break;
                case 3:
                    alinanUrun = "Coffee";
                    Console.WriteLine($"- {alinanUrun} {KAHVE_FIYATI} TL");
                    paraUstu = ParaAl(KAHVE_FIYATI);
                    // geri verilecek para yazılacak vs..
                    break;
                case 4:
                    alinanUrun = "Cola";
                    Console.WriteLine($"- {alinanUrun} {KOLA_FIYATI} TL");
                    paraUstu = ParaAl(KOLA_FIYATI);
                    // geri verilecek para yazılacak vs..
                    break;
                case 5:
                    // programdan bir iş yapmadan çıkacak
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("- Thank You For Using The Drink Machine.");
            Console.WriteLine($"- Your {alinanUrun} is Being Delivered.");
            Console.WriteLine($"- You Will Take {paraUstu} TL Back");
            Console.WriteLine("- Press a button to continue...");
            Console.WriteLine();
            Console.ReadKey();
            PrintEndMessage();
            Console.ReadKey();

        }

        /// <summary>
        /// Karşılama mesajını yazacak.
        /// </summary>
        static void PrintGreeting()
        {
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||| WELCOME TO THE DRINK MACHINE.HAVE A GOOD APETITE! |||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("- Press a button to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Menüyü ekrana yazacak ve kullanıcıdan bir tercih alacak.
        /// </summary>
        /// <returns>
        /// kullanıcı tercihi
        /// sadece 1,2,3,4,5 olabilir 
        /// gecersiz deger girerse döngüden geçerli bir deger alana kadar dönecek.
        /// </returns>
        static int Menu()
        {
            // kullanici tercihi 1,2,3,4,5 olabilir.
            int kullaniciTercihi;

            Console.Write("\t\t\t\t     -------------------\n");
            Console.WriteLine("\t\t\t\t\tBeverage Menus ");
            Console.Write("\t\t\t\t     -------------------\n");
            Console.WriteLine("\t\t\t\t      1. WATER - 5TL");
            Console.WriteLine("\t\t\t\t      2. TEA - 10TL");
            Console.WriteLine("\t\t\t\t      3. COFFEE - 15TL");
            Console.WriteLine("\t\t\t\t      4. COLA - 25TL");
            Console.WriteLine("\t\t\t\t      5. EXIT");
            Console.WriteLine();
            Console.WriteLine();

            // menü döngüleri do-while olur
            do
            {
                Console.WriteLine("- Please Enter Your Choice[Water(1), Tea(2), Coffee(3), Cola(4), Exit(5)]");
                Console.Write(" Beverage Number : ");


                // camelCase yazılır 
                string kullaniciTercihiStr = Console.ReadLine();

                try
                {
                    kullaniciTercihi = Convert.ToInt32(kullaniciTercihiStr);
                    Console.WriteLine();
                }
                catch
                {
                    kullaniciTercihi = -1;
                }

                if (kullaniciTercihi < 1 || kullaniciTercihi > 5)
                {
                    Console.WriteLine("Geçerli bir değer giriniz...\n");
                }

            } while (kullaniciTercihi < 1 || kullaniciTercihi > 5);

            return kullaniciTercihi;
        }

        /// <summary>
        /// kullanıcıdan para alınacak
        /// kullanıcı eksik veremez fakat fazla verebilir.
        /// foksiyon para üstünü döner.
        /// </summary>
        /// <param name="alinacakPara"> mesala kahve icin 15 TL alınacak</param>
        /// <returns> para üstü, mesela kullanıcı kahve icin 20 TL verebilir para üstü 5 TL olur.</returns>
        static int ParaAl(int alinacakPara)
        {
            // para üstü = alinanpara - alinacakpara
            // kalanpara = alinacakpara - alınanpara
            int paraUstu = 0;
            int toplamAlinanPara = 0;

            do
            {
                Console.WriteLine("You Need Pay The Price: (5TL, 10TL, 15TL, 25TL, 50TL)");

                Console.Write(" Console : ");
                string alinanParaStr = Console.ReadLine();
                int alinanPara = Convert.ToInt32(alinanParaStr);
                Console.WriteLine();
                // eğer alinanpara 5,10,15,25 ve 50 ise döngü çalışacak
                // değilse geçerli bir para birimi girene kadar para istiyecek
                if (alinanPara == 5 || alinanPara == 10 || alinanPara == 15 || alinanPara == 25 || alinanPara == 50)
                {
                    // Alınan para kabul edildi.
                    toplamAlinanPara = toplamAlinanPara + alinanPara;

                    if (toplamAlinanPara >= alinacakPara)
                    {
                        paraUstu = toplamAlinanPara - alinacakPara;
                    }
                    else
                    {
                        Console.WriteLine("- You Need To Pay {0}TL More", alinacakPara - toplamAlinanPara);
                        Console.WriteLine("- Devam Etmek icin Bir Tusa Basiniz...");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Geçerli bir para birimi giriniz!..");
                }
            } while (toplamAlinanPara < alinacakPara);


            return paraUstu;
        }

        static void PrintEndMessage()
        {
            Console.WriteLine(".................#...#...#.........____....................................#...#...#.................");
            Console.WriteLine(".................##.###.##.........|___|..*../..||.//.|----..\\..//.........##.###.##.................");
            Console.WriteLine(".................#########.........|.\\....|.---.|//...|--.....\\//..........#########.................");
            Console.WriteLine(".................#########.........|..\\...|.../.|.\\...|----...//...........#########.................\n");
            Console.WriteLine("Program sonlandı, kapatmak için herhengi bir tuşa basınız.");
            Console.ReadKey();
        }


    }
}
