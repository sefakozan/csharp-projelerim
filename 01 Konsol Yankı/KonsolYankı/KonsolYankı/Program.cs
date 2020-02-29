using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolYankı
{
    class Program
    {
        static void Main(string[] args)
        {
            //string girilenSatir;
            Console.WriteLine("Konsole herhangi bir şey yazınız.");
            Console.Write(">");
            string girilenSatir = Console.ReadLine();

            //Console.WriteLine(">Yazılan:" + girilenSatir);
            //Console.WriteLine(">Yazılan: {0}", girilenSatir);
            //Console.WriteLine("Konsola " + girilenSatir + " girdiniz.");
            Console.WriteLine("Konsola {0} girdiniz.", girilenSatir);
            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
    }
}
