using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TersYazdırma
{
    class Program
    {
        /// <summary>
        /// Main'in içinde bir satır kod olacak.
        /// </summary>
        static void Main()
        {
            StartTestYazdirma();
        }
        static void StartTestYazdirma()
        {
            int kare = KareHesapla();
            Console.WriteLine("- Girdiğiniz sayının karesi : {0}", kare);
            // sayinin karesini alıp stringe çevirip
            string kareStr = Convert.ToString(kare);

            string tersStr = ReverseString(kareStr);
            Console.WriteLine("- Girdiğiniz sayının karesinin tersi : {0}", tersStr);

            //Array.Reverse(sayilar);

            // program bitti.
            Console.WriteLine();
            Console.WriteLine("Program sonlandı. Çıkmak için herhangi bir tuşa basınız...");
            Console.ReadKey();
        }

        /// <summary>
        /// kullanicidan sayi alir , sayinin karesini alır ve karesini dönderir.
        /// </summary>
        /// <returns>sayinin karesi</returns>
        static int KareHesapla()
        {
            int kare, sayi; ;
            Console.Write("- Konsola bir sayı giriniz : ");
            string sayiStr = Console.ReadLine();
            sayi = Convert.ToInt32(sayiStr);
            // sayiyi kendisi ile çarpıp karesini buldum.
            kare = sayi * sayi;

            return kare;
        }


        /// <summary>
        /// fonksiyon string'i parametre olarak alır ve ters çevirir.
        /// </summary>
        /// <param name="str"> ters cevrilecek string</param>
        /// <returns> ters çevrilmiş string</returns>
        static string ReverseString(string str)
        {
            string reversedStr = string.Empty;

            char[] strArray = str.ToCharArray();
            char[] reverseStrArray = new char[strArray.Length];

            for (int i = 0; i < strArray.Length; i++)
            {
                int sonIndex = strArray.Length - i - 1;
                reverseStrArray[i] = strArray[sonIndex];              
            }

            // 1. yol
            // google: c# char array to string
            reversedStr = new string(reverseStrArray);

            //2. yol 

            //StringBuilder sb = new StringBuilder();
            //sb.Append(reverseStrArray);
            //reversedStr = sb.ToString();

            return reversedStr;
        }



    }
}
