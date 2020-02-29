using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayi gir");
            string satir1 = Console.ReadLine();
            int girilenSayi1 = Convert.ToInt32(satir1);


            Console.WriteLine("2. sayi gir");
            string satir2 = Console.ReadLine();
            int girilenSayi2 = Convert.ToInt32(satir2);

            int ikiSayiToplami = Topla(girilenSayi1, girilenSayi2);

            Console.WriteLine("Toplam = {0}", ikiSayiToplami);
            Console.ReadKey();

        }

        static int Topla(int sayi1, int sayi2) 
        {

            int sonuc = sayi1 + sayi2;
            return sonuc;
        
        }
    }
}
