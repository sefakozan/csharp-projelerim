using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMACHINE
{
    class Program
    {
        static void Ana(string[] args)
        {
            // ilk yazılan kod bu. Bu kodda bir çok hata yapılmıştır. 
            // Bu hatalar DrinkingMachine.cs yazılan yeni kodda düzeltildi.
            // Burdaki Main fonksiyonun adı 'Ana' olarak değiştirildi.

            Console.Title = "Para Tuzağı (Drink Machine)";
            PrintGreeting();
            Console.ReadKey();

            PrintMenu();

            Console.WriteLine("- Please Enter Your Choice[Water(1), Tea(2), Coffee(3), Cola(4), Exit(5)]");

            Console.Write(" Beverage Number : ");
            string girilenIcecekIsmiSTR = Console.ReadLine();
            int girilenIcecekIsmiINT = Convert.ToInt32(girilenIcecekIsmiSTR);
            Console.WriteLine();

            if (girilenIcecekIsmiINT >= 1 && girilenIcecekIsmiINT <= 5)
            {


                int SuParası = 5;
                int CayParası = 10;
                int KahveParası = 15;
                int KolaParası = 25;


                switch (girilenIcecekIsmiINT)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("- Water 5 TL");
                            Console.WriteLine("You Need Pay The Price: (5TL, 10TL, 15TL, 25TL, 50TL)");

                            Console.Write(" Console : ");
                            string SuSTR = Console.ReadLine();
                            int KullanıcıGirdigiSuParası = Convert.ToInt32(SuSTR);
                            Console.WriteLine();

                            if (KullanıcıGirdigiSuParası == 5 || KullanıcıGirdigiSuParası == 10 || KullanıcıGirdigiSuParası == 15 || KullanıcıGirdigiSuParası == 25 || KullanıcıGirdigiSuParası == 50)
                            {
                                if (KullanıcıGirdigiSuParası == 5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Water is Being Delivered.");
                                    Console.WriteLine("- You Will Take 0TL Back");
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else if (KullanıcıGirdigiSuParası > 5)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Water is Being Delivered.");
                                    Console.WriteLine("- You Will Take {0}TL Back", KullanıcıGirdigiSuParası - SuParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- You Need To Pay {0}TL More", SuParası - KullanıcıGirdigiSuParası);
                                    Console.WriteLine("Geçerli bir değer girmediğiniz için makine yenilendi..Lütfen tekrar deneyiniz.\n");
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir para aralığı giriniz!..");
                                Console.WriteLine();
                                continue;
                            }
                        }
                        break;

                    case 2:
                        while (true)
                        {
                            Console.WriteLine("- TEA 10 TL");
                            Console.WriteLine("You Need Pay The Price: (5TL, 10TL, 15TL, 25TL, 50TL)");

                            Console.Write(" Console : ");

                            string CaySTR = Console.ReadLine();
                            int KullanıcıGirdigiCayParası = Convert.ToInt32(CaySTR);
                            Console.WriteLine();

                            if (KullanıcıGirdigiCayParası == 5 || KullanıcıGirdigiCayParası == 10 || KullanıcıGirdigiCayParası == 15 || KullanıcıGirdigiCayParası == 25 || KullanıcıGirdigiCayParası == 50)
                            {
                                if (KullanıcıGirdigiCayParası == 10)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Tea is Being Delivered.");
                                    Console.WriteLine("- You Will Take 0TL Back");
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else if (KullanıcıGirdigiCayParası > 10)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Tea is Being Delivered.");
                                    Console.WriteLine("- You Will Take {0}TL Back", KullanıcıGirdigiCayParası - CayParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- You Need To Pay {0}TL More", CayParası - KullanıcıGirdigiCayParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();

                                    while (true)
                                    {
                                        Console.Write(" Console : ");
                                        string CayKalanParaStr = Console.ReadLine();
                                        int CayKullanıcınınGirmesiGerekenKalanPara = Convert.ToInt32(CayKalanParaStr);
                                        Console.WriteLine();

                                        if (CayKullanıcınınGirmesiGerekenKalanPara + KullanıcıGirdigiCayParası  - CayParası == 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("- Thank You For Using The Drink Machine.");
                                            Console.WriteLine("- Your Tea is Being Delivered.");
                                            Console.WriteLine("- You Will Take 0TL Back");
                                            Console.WriteLine("- Press a button to continue...");
                                            Console.WriteLine();
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir para aralığı giriniz!..");
                                Console.WriteLine();
                                continue;
                            }
                        }
                        break;

                    case 3:
                        while (true)
                        {
                            Console.WriteLine("- COFFEE 15 TL");
                            Console.WriteLine("You Need Pay The Price: (5TL, 10TL, 15TL, 25TL, 50TL)");

                            Console.Write(" Console : ");



                            string KavheSTR = Console.ReadLine();
                            int KullanıcıGirdigiKahveParası = Convert.ToInt32(KavheSTR);
                            Console.WriteLine();

                            if (KullanıcıGirdigiKahveParası == 5 || KullanıcıGirdigiKahveParası == 10 || KullanıcıGirdigiKahveParası == 15 || KullanıcıGirdigiKahveParası == 25 || KullanıcıGirdigiKahveParası == 50)
                            {
                                if (KullanıcıGirdigiKahveParası == 15)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Coffee is Being Delivered.");
                                    Console.WriteLine("- You Will Take 0TL Back");
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else if (KullanıcıGirdigiKahveParası > 15)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Coffee is Being Delivered.");
                                    Console.WriteLine("- You Will Take {0}TL Back", KullanıcıGirdigiKahveParası - KahveParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- You Need To Pay {0}TL More", KahveParası - KullanıcıGirdigiKahveParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();

                                    while (true)
                                    {
                                        Console.Write(" Console : ");
                                        string KahveKalanParaStr = Console.ReadLine();
                                        int KahveKullanıcınınGirmesiGerekenKalanPara = Convert.ToInt32(KahveKalanParaStr);
                                        Console.WriteLine();

                                        //if (KahveKullanıcınınGirmesiGerekenKalanPara + KullanıcıGirdigiKahveParası == 15)
                                        //{
                                        //    Console.WriteLine();
                                        //    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                        //    Console.WriteLine("- Your Coffee is Being Delivered.");
                                        //    Console.WriteLine("- You Will Take 0TL Back");
                                        //    Console.WriteLine("- Press a button to continue...");
                                        //    Console.WriteLine();
                                        //    Console.ReadKey();
                                        //    break;
                                        //}
                                        if(KahveKullanıcınınGirmesiGerekenKalanPara + KullanıcıGirdigiKahveParası >= 15)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("- Thank You For Using The Drink Machine.");
                                            Console.WriteLine("- Your Coffee is Being Delivered.");
                                            Console.WriteLine("- You Will Take {0}TL Back", KullanıcıGirdigiKahveParası + KahveKullanıcınınGirmesiGerekenKalanPara - KahveParası);
                                            Console.WriteLine("- Press a button to continue...");
                                            Console.WriteLine();
                                            Console.ReadKey();
                                            break;
                                        }
                                        else if (KahveKullanıcınınGirmesiGerekenKalanPara + KullanıcıGirdigiKahveParası < 15)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("- You Need To Pay {0}TL More", KahveParası - KahveKullanıcınınGirmesiGerekenKalanPara - KullanıcıGirdigiKahveParası);
                                            Console.WriteLine("- Press a button to continue...");
                                            Console.WriteLine();
                                            Console.ReadKey();
                                        }
                                    }

                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir para aralığı giriniz!..");
                                Console.WriteLine();
                                continue;
                            }
                        }
                        break;

                    case 4:
                        while (true)
                        {
                            Console.WriteLine("- COLA 25 TL");
                            Console.WriteLine();
                            Console.WriteLine("You Need Pay The Price: (5TL, 10TL, 15TL, 25TL, 50TL)");

                            Console.Write(" Console : ");

                            string KolaSTR = Console.ReadLine();
                            int KullanıcıGirdigiKolaParası = Convert.ToInt32(KolaSTR);

                            if (KullanıcıGirdigiKolaParası == 5 || KullanıcıGirdigiKolaParası == 10 || KullanıcıGirdigiKolaParası == 15 || KullanıcıGirdigiKolaParası == 25 || KullanıcıGirdigiKolaParası == 50)
                            {
                                if (KullanıcıGirdigiKolaParası == 25)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Cola is Being Delivered.");
                                    Console.WriteLine("- You Will Take 0TL Back");
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else if (KullanıcıGirdigiKolaParası > 25)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- Thank You For Using The Drink Machine.");
                                    Console.WriteLine("- Your Cola is Being Delivered.");
                                    Console.WriteLine("- You Will Take {0}TL Back", KullanıcıGirdigiKolaParası - KolaParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("- You Need To Pay {0}TL More", KolaParası - KullanıcıGirdigiKolaParası);
                                    Console.WriteLine("- Press a button to continue...");
                                    Console.WriteLine();
                                    Console.ReadKey();

                                    while (true)
                                    {
                                        Console.Write(" Console : ");
                                        string CayKalanParaStr = Console.ReadLine();
                                        int KolaKullanıcınınGirmesiGerekenKalanPara = Convert.ToInt32(CayKalanParaStr);
                                        Console.WriteLine();

                                        if (KolaParası - KolaKullanıcınınGirmesiGerekenKalanPara + KullanıcıGirdigiKolaParası == 0)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("- Thank You For Using The Drink Machine.");
                                            Console.WriteLine("- Your Tea is Being Delivered.");
                                            Console.WriteLine("- You Will Take 0TL Back");
                                            Console.WriteLine("- Press a button to continue...");
                                            Console.WriteLine();
                                            Console.ReadKey();
                                            break;
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lütfen geçerli bir para aralığı giriniz!..");
                                Console.WriteLine();
                                continue;
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Makine Kapanmıştır!..\n");
                        break;

                    default:
                        // Buraya hiç bir koşulda girmez
                        Console.WriteLine("Geçerli bir değer girmediğiniz için makine kapandı...Lütfen daha sonra tekrar deneyiniz.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir değer girmediğiniz için makine kapandı...Lütfen daha sonra tekrar deneyiniz.\n");
            }


            PrintEndMessage();

            // end program
            Console.ReadKey();
        }

        static void PrintGreeting()
        {
            Console.WriteLine(".................#...#...#.........____....................................#...#...#.................");
            Console.WriteLine(".................##.###.##.........|___|..*../..||.//.|----..\\..//.........##.###.##.................");
            Console.WriteLine(".................#########.........|.\\....|.---.|//...|--.....\\//..........#########.................");
            Console.WriteLine(".................#########.........|..\\...|.../.|.\\...|----...//...........#########.................");
            Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("||||||||||||||||||||||||| WELCOME TO THE DRINK MACHINE.HAVE A GOOD APETITE! |||||||||||||||||||||||||");
            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            Console.WriteLine("- Press a button to continue...");

        }
        static void PrintMenu()
        {
            Console.Write("\t\t\t\t     -------------------\n");
            Console.WriteLine("\t\t\t\t\tBeverage Menus ");
            Console.Write("\t\t\t\t     -------------------\n");
            Console.WriteLine("\t\t\t\t      1. WATER - 5TL");
            Console.WriteLine("\t\t\t\t      2. TEA - 10TL");
            Console.WriteLine("\t\t\t\t      3. COFFEE - 15TL");
            Console.WriteLine("\t\t\t\t      4. COLA - 25TL");
            Console.WriteLine("\t\t\t\t      5. EXIT");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void PrintEndMessage()
        {
            Console.WriteLine(".................#...#...#.........____....................................#...#...#.................");
            Console.WriteLine(".................##.###.##.........|___|..*../..||.//.|----..\\..//.........##.###.##.................");
            Console.WriteLine(".................#########.........|.\\....|.---.|//...|--.....\\//..........#########.................");
            Console.WriteLine(".................#########.........|..\\...|.../.|.\\...|----...//...........#########.................");
        }

    }
}
