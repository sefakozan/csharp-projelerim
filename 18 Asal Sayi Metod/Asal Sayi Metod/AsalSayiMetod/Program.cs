using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiTers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir Sayı Giriniz : ");
            string satir = Console.ReadLine();
            int sayi = Convert.ToInt32(satir);
            bool isAsal = AsalSayi.AsalSayiMi(sayi);


            if (isAsal)
            {
                Console.WriteLine("Asal");
            }
            else 
            {
                Console.WriteLine("Asal Degil");
            }

            AsalSayi.ProgramBitti();

        }

    }
}

