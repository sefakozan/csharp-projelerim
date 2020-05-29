using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme3
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }
        /// <summary>
        /// Program başlatıldığı yer, Mainde Çağrılır
        /// </summary>
        static void StartProgram()
        {
            string[] ogrenciAdSoyad = new string[10];
            int[] ogrenciNot = new int[10];
            // sinifta kaç kişi oldugunu söyleyen değişken(sira)
            int sira = 0;

            while (true)
            {
                int islemNO = OgrenciMenuYaz();

                if (islemNO == 4)
                    break;

                switch (islemNO)
                {
                    case 1:
                        OgrenciKayit(ogrenciAdSoyad, ogrenciNot, sira);
                        sira++;
                        break;
                    case 2:
                        SinifListesi(ogrenciAdSoyad, ogrenciNot, sira);
                        sira++;
                        break;
                    case 3:
                        double ortalama = SinifBasarisi(ogrenciNot, sira);
                        Console.WriteLine($"Sinif Başarısı = {ortalama}");
                        sira++;
                        break;
                }
            }
            Console.WriteLine("Program Sonlandı.");
            Console.ReadKey();
        }

        /// <summary>
        /// Öğrenci İşlem Menüsünü Yazdıracak ve İşlem Numarasını Döndürecek
        /// </summary>
        /// <returns>İşlem numarası örneğin 1</returns>
        static int OgrenciMenuYaz()
        {
            int islemNo = 0;

            Console.WriteLine(new String('-', 30));
            Console.WriteLine("\tÖğrenci İşlemleri");
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("1. Öğrenci Kayıt");
            Console.WriteLine("2. Sınıf Listesi ve Not Listesi");
            Console.WriteLine("3. Sınıf Başarısı");
            Console.WriteLine("4. Exit");

            Console.WriteLine(new String('-', 30));

            do
            {
                Console.Write("İşlem Numarasını Giriniz: ");
                islemNo = Convert.ToInt32(Console.ReadLine());

            } while (islemNo < 1 || islemNo > 4);

            return islemNo;
        }

        /// <summary>
        /// Yeni kayıt olmak isteten öğrenciyi bir diziye(sınıfa) aktaracak
        /// </summary>
        /// <param name="ogrenci">öğrenci bilgileri ad-soyad ogrenci dizisine atayacak</param>
        /// <param name="ogrenciNot">öğrenci notunu not dizinie atayacak</param>
        static void OgrenciKayit(string[] ogrenciAdSoyad, int[] ogrenciNot, int sira)
        {
            Console.Write("\nÖğrenci Adını Giriniz: ");
            string ogrAd = Console.ReadLine();

            Console.Write("Öğrenci Soyadını Giriniz: ");
            string ogrSoyAd = Console.ReadLine();

            Console.Write("Öğrenci Yıl Sonu Notunu Giriniz: ");
            int ogrNot = Convert.ToInt32(Console.ReadLine());

            for (int i = sira; i <= sira; i++)
            {
                ogrenciAdSoyad[i] = ogrAd + " " + ogrSoyAd;
                ogrenciNot[i] = ogrNot;
            }

            Console.WriteLine("Öğrenci Kayıt İşleminiz Başarıyla Gerçekleşmiştir.");
        }

        static void SinifListesi(string[] ogrenciAdSoyad, int[] ogrenciNot, int sira)
        {
            Console.WriteLine();
            Console.WriteLine("{0,30}", "Sınıf Listesi \n");
            Console.WriteLine("{0,10} {1,20}", "Ad-SoyAd", "Not");
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < sira; i++)
            {
                string ogrnAdSoyad = ogrenciAdSoyad[i];
                int ogrnNot = ogrenciNot[i];

                Console.WriteLine("{0,0} {1,20}", $"{i + 1:D2}. {ogrnAdSoyad}", ogrnNot);
            }
        }

        /// <summary>
        /// ogrnNot dizisindeki notları alarak notları toplayıp ortalamasını bulacak
        /// </summary>
        /// <param name="ogrnNot">öğrenci notları</param>
        /// <param name="sira">sınıfta kaç kişi olduğunu söyleyen değişken</param>
        /// <returns></returns>
        static double SinifBasarisi(int[] ogrnNot, int sira)
        {
            double top = 0;

            for (int i = 0; i < 10; i++)
                top = top + ogrnNot[i];

            double ort = top / sira;

            return ort;
        }
    }
}
