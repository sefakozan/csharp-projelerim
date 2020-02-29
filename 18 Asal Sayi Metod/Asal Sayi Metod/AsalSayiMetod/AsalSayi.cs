using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiTers
{
    class AsalSayi
    {


        public static bool AsalSayiMi(long sayi)
        {
            bool isAsal = true;

            if (sayi <= 1)
            {
                isAsal = false;
            }
            else if (sayi == 2)
            {
                isAsal = true;
            }
            else
            {

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        isAsal = false;
                        break;
                    }
                }

            }

            return isAsal;

        }

        public static void ProgramBitti() 
        {
            Console.WriteLine("Program bitti!.. Çıkmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }



    }
}
