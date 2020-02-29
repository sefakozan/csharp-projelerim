using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Press ENTER to start...");
            Console.ReadKey();

            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = Environment.CurrentDirectory + "\\muslum.wav";
            sp.PlayLooping();

            for (int sayi = 0; sayi <= int.MaxValue; sayi++)
            {
                //Console.CursorLeft = 0;
                //Console.CursorTop = 0;
                Console.CursorVisible = false;

                

                if (sayi % 2 == 0)
                {
                    Console.Write("gfjfgsdfs");
                }
                else if (sayi % 3 == 0)
                {
                    Console.Write("rturtasf0");
                }
                else if (sayi % 5 == 0)
                {
                    Console.Write("fgghkhjkgff1");
                }
                else if (sayi % 11 == 0)
                {
                    Console.Write("dfhsdgsdhs0");
                }
                else if (sayi %  61 == 0)
                {
                    Console.Write("sdgasdqtrs");
                }
                else if (sayi % 63 == 0)
                {
                    Console.Write("ıluışıoiıoşkle");
                }
                else if (sayi % 67 == 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" sefa ");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (sayi % 71 == 0)
                {
                    Console.Write("afgdfgsdfasdasf");
                }
                else
                {
                    Console.Write(" ");
                }


            }
            Console.ReadKey();

        }
    }
}
