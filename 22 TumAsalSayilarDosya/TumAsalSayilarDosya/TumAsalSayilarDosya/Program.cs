using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TumAsalSayilarDosya
{
    class Program
    {
        public static System.IO.TextWriter Out { get; }

        static void Main(string[] args)
        {
            
            string enSonSayiStr = "1";

            FileInfo fileInfo = new FileInfo("AsalSayi.txt");

            if (fileInfo.Length > 0) 
            {
                string[] satirArr = File.ReadAllLines("AsalSayi.txt");
                enSonSayiStr = satirArr.Last();
            }
            
            ulong enSonSayi = Convert.ToUInt64(enSonSayiStr);

            StreamWriter file = File.AppendText("AsalSayi.txt");

            for (ulong i = enSonSayi +1; i < ulong.MaxValue; i++)
            {
                bool asalMi = IsAsal(i);

                if (asalMi)
                {
                    Console.WriteLine(i);
                    file.WriteLine(i); 
                }

                

                if (Console.KeyAvailable) 
                {
                    //ConsoleKeyInfo keyInfo =  Console.ReadKey();
                    var keyInfo =  Console.ReadKey(); //var çalış notal
                    char girilenChar = keyInfo.KeyChar;
                    if (girilenChar == 'q' || girilenChar == 'Q') 
                    {
                        file.Close();
                        break;
                    }

                }

            }



            Console.WriteLine("prg bitti");
            Console.ReadKey();

        }

        public static bool IsAsal(ulong sayi)
        {
            bool ret = true;

            for (ulong i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    ret = false;
                    break;
                }

            }

            return ret;
        }


    }




}

