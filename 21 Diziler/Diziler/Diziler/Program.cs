using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {

        static void Main(string[] args)
        {
            //string[] sira = new string[7] { "1", "2", "3", "4", "5", "6", "7" };

            //string[] gunler = new string[7];
            //gunler[0] = "Pazartesi";
            //gunler[1] = "Salı";
            //gunler[2] = "Çarşamba";
            //gunler[3] = "Perşembe";
            //gunler[4] = "Cuma";
            //gunler[5] = "Cumartesi";
            //gunler[6] = "Pazar";
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[0], gunler[0]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[1], gunler[1]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[2], gunler[2]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[3], gunler[3]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[4], gunler[4]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[5], gunler[5]);
            //Console.WriteLine("Haftanın {0}. günü : {1}", sira[6], gunler[6]);

            //Console.ReadKey();



            string[] sehiler = new string[5] { "Ankara", "K.Maraş", "Erzurum", "izmir", "Adana" };

            foreach (string sehirIsmi in sehiler)
            {
                Console.WriteLine(sehirIsmi);
            }
            Console.ReadKey();
        }
    }
}
