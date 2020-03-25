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

            Console.WriteLine("Birinci sayı : {0}  İkinci sayı : {1}",birinciSayı,ikinciSayı);



            //
            //tempVariable = Tempoaray Variable(Geçici Değişken)

            int tempVariable = birinciSayı;
            birinciSayı = ikinciSayı;
            ikinciSayı = tempVariable;



            Console.WriteLine("İki sayı değiştrildi.");
            Console.WriteLine("Birinci sayı : {0}  İkinci sayı : {1}",birinciSayı,ikinciSayı);

            Console.ReadKey();

            
        }
    }
}
