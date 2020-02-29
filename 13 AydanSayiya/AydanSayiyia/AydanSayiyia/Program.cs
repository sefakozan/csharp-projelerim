using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AydanSayiyia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...! Konsoldan çıkmak için 'exit' ya da 'çıkış' yazınız !...'");
            while (true)
            {

                Console.Write("Konsola bir ay adı giriniz : ");
                string ayIsmi = Console.ReadLine();

                if (ayIsmi == "exit" || ayIsmi == "çıkış")
                {
                    break;
                }

                ayIsmi = ayIsmi.ToUpper();
                switch (ayIsmi)
                {
                    case "OCAK":
                    case "OÇAK":
                        Console.WriteLine("> Girdiginiz ocak ayı 1. aydır.");
                        break;                   
                    case "ŞUBAT":
                    case "SUBAT":
                        Console.WriteLine("> Girdiginiz şubat ayı 2. aydır.");
                        break;
                    case "MART":
                        Console.WriteLine("> Girdiginiz mart ayı 3. aydır.");
                        break;
                    case "NİSAN":
                        Console.WriteLine("> Girdiginiz nisan ayı 4. aydır.");
                        break;
                    case "MAYIS":
                        Console.WriteLine("> Girdiginiz mayıs ayı 5. aydır.");
                        break;
                    case "HAZİRAN":
                        Console.WriteLine("> Girdiginiz haziran ayı 6. aydır.");
                        break;
                    case "TEMMUZ":
                        Console.WriteLine("> Girdiginiz temmuz ayı 7. aydır.");
                        break;
                    case "AĞUSTOS":
                    case "AGUSTOS":
                        Console.WriteLine("> Girdiginiz ağustos ayı 8. aydır.");
                        break;
                    case "EYLÜL":
                        Console.WriteLine("> Girdiginiz eylül ayı 9. aydır.");
                        break;
                    case "EKİM":
                        Console.WriteLine("> Girdiginiz ekim ayı 10. aydır.");
                        break;
                    case "KASIM":
                        Console.WriteLine("> Girdiginiz kasım ayı 11. aydır.");
                        break;
                    case "ARALIK":
                        Console.WriteLine("> Girdiginiz aralık ayı 1. aydır.");
                        break;
                    default:
                        Console.WriteLine("Hata : Konsola bir ay adı girilmedi!..");
                        break;
                }

            }
            Console.Write("Program sonlandı, Çıkmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
    }
}

