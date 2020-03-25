using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Taş Kağıt Makas Oyunu";

            Oyun();

            Console.WriteLine("Oyun Sonlandı. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();

        }
        static void Oyun()
        {
            Random random = new Random();

            while (true)
            {
               
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("\tTaş Kağıt Makas Oyununa Hoşgeldiniz...");
                Console.WriteLine("----------------------------------------------------------------\n");
                Console.WriteLine("Konsola T(Taş), K(Kağıt) ve M(Makas)'tan Birini Yazınız.");
                Console.Write("> ");

                string satir = Console.ReadLine();
                string kullanicininTahmini = satir.ToLower();

                if (kullanicininTahmini == "exit")
                {
                    break;
                }


                
                int rndNumber = random.Next(0, 3);
                string bilgisarTahmini = string.Empty;

                switch (rndNumber)
                {
                    case 0:
                        bilgisarTahmini = "t";
                        break;
                    case 1:
                        bilgisarTahmini = "k";
                        break;
                    case 2:
                        bilgisarTahmini = "m";
                        break;
                }



                // bilgisayarın tuttuğu numaralara göre eşyalar
                if (bilgisarTahmini == "t")
                {
                  
                    Console.WriteLine("Aklımdan Taş tuttum.");

                    switch (kullanicininTahmini)
                    {
                        case "t":
                            Console.WriteLine("Durum Berabere");
                            break;
                        case "k":
                            Console.WriteLine("Kağıt Taşı Sarar... Kullanıcı Kazandı!!!");
                            break;
                        case "m":
                            Console.WriteLine("Taş Makası Kırar... Bilgisayar Kazandı!!!");
                            break;
                    }

                }
                else if (bilgisarTahmini == "k")
                {
                   
                    Console.WriteLine("Aklımdan Kağıt tuttum.");

                    switch (kullanicininTahmini)
                    {
                        case "t":
                            Console.WriteLine("Kağıt Taşı Sarar... Bilgisayar Kazandı!!!");
                            break;
                        case "k":
                            Console.WriteLine("Durum Berabere");
                            break;
                        case "m":
                            Console.WriteLine("Makas Kağıtı Keser... Kullanıcı Kazandı!!!");
                            break;
                    }

                }
                else if (bilgisarTahmini == "m")
                {
                
                    Console.WriteLine("Aklımdan Makas tuttum.");

                    switch (kullanicininTahmini)
                    {
                        case "t":
                            Console.WriteLine("Taş Makası Kırar... Kullanıcı Kazandı!!!");
                            break;
                        case "k":
                            Console.WriteLine("Makas Kağıtı Keser... Bilgisayar Kazandı!!!");
                            break;
                        case "m":
                            Console.WriteLine("Durum Berabere");
                            
                            break;
                    }
                }
            }
    
        }
    }
}
