using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonsuzYanki
{
    class Program
    {
        static void Main(string[] args)
        {

            


            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Konsole herhangi bir şey yazınız!..");
                Console.WriteLine("Çıkmak için exit yazınız!..");
                Console.Write(">");
                string girilenSatir = Console.ReadLine();
                string metin = girilenSatir;
                Console.WriteLine("");
                Console.WriteLine("Konsola {0} girdiniz.", girilenSatir);
                Console.WriteLine("Girilen karakter sayısı: {0}", metin.Length);


                if (girilenSatir == "exit")
                {
                    Console.WriteLine("Burada donguden cikacak!..");
                    break;
                }
                

                
            }
        }


        
    }
            
            




        
    
}

