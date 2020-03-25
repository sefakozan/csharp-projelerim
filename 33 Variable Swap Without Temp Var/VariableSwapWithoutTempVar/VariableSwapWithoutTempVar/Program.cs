using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Konsola Birinci Sayıyı Giriniz : ");
            string birincisayiStr = Console.ReadLine();
            int birinciSayı = Convert.ToInt32(birincisayiStr);

            Console.Write("Konsola İkinci Sayıyı Giriniz : ");
            string ikincisayiStr = Console.ReadLine();
            int ikinciSayı = Convert.ToInt32(ikincisayiStr);

            Console.WriteLine("Birinci sayı : {0}  İkinci sayı : {1}", birinciSayı, ikinciSayı);

            //Variable Swap Without =  Bu iş Mülaktlarda Hep sorulur.
            //Geçiçi bir değişken kullanmadan yani temp variable kullanmadan iki değişkenin değerlerinin değiştirilmesi.
            //bu işlem toplama çıkarma ile ya da çarpma bölme ile ya da bitwise kullanarak bu işlemler  yapılır.

            //a=a+b;//a=30 (10+20)    
            //b = a - b;//b=10 (30-20)    
            //a = a - b;//a=20 (30-10)
            //https://www.javatpoint.com/c-program-to-swap-two-numbers-without-using-third-variable

            birinciSayı = birinciSayı + ikinciSayı;
            ikinciSayı = birinciSayı - ikinciSayı;
            birinciSayı = birinciSayı - ikinciSayı;

            Console.WriteLine("İki sayı değiştrildi.");
            Console.WriteLine("Birinci sayı : {0}  İkinci sayı : {1}", birinciSayı, ikinciSayı);

            Console.ReadKey();
        }
    }
}
