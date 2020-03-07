using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc;

            if (args.Length == 3)
            {
                
                Console.WriteLine("Girdiğiniz Argümanlar Sırasıyla : {0} {1} {2}",args[0], args[1], args[2]);


                int sayi1 = Convert.ToInt32(args[0]);
                int sayi2 = Convert.ToInt32(args[1]);
                int sayi3 = Convert.ToInt32(args[2]);

                sonuc = sayi1 * sayi2 * sayi3;
                Console.WriteLine("Girdiğiniz Argümanların Çarpımı : {0}",sonuc);

            }

            if (args.Length > 3)
            {
                Console.WriteLine("Girdiğiniz Argümanlar Üçten Fazladır");
                Console.WriteLine("Argümanları Yanlış Girdiğiniz için Program Sonlandı!");
                Console.ReadKey();
            }

            if (args.Length < 3)
            {
                Console.WriteLine("Girdiğiniz Argümanlar Üçten Azdır");
                Console.WriteLine("Argümanları Yanlış Girdiğiniz için Program Sonlandı!");
                Console.ReadKey();
            }

        }
    }
}
