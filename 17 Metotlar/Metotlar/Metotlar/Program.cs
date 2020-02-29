using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {

        static void hiz(int yol, int sure)
        {
            int hiz = yol / sure;
            Console.Write("Aracın ortalama hızı {0} KM/S", hiz);
        }


        static int hizHesapla(int yol, int sure)
        {
            int hiz = yol / sure;
            return hiz;
        }





        static void Main(string[] args)
        {
            int alinan_yol, zaman;
            Console.Write("Gidilen yolu giriniz.......:");
            alinan_yol = Convert.ToInt16(Console.ReadLine());
            Console.Write("Süreyi giriniz.......:");
            zaman = Convert.ToInt16(Console.ReadLine());
           
            
            hiz(alinan_yol, zaman);

            //int hesaplanan = hizHesapla(alinan_yol, zaman);
            //Console.Write("Aracın ortalama hızı {0} KM/S", hesaplanan);

            Console.ReadKey();
        }



    }
}
