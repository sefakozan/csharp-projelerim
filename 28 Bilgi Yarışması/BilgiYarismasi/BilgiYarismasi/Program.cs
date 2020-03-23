using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Kim Trilyoner Olmak İster";
                Console.WriteLine("                                                                                     -------------------------------------");
                Console.WriteLine("------------------------------------------------------------------                   | 10-  1.000.000 TL                  |");
                Console.WriteLine("\tKim Trilyoner Olmak İstere Hoşgeldiniz...                |                   | 9-     550.000 TL                  |");
                Console.WriteLine("------------------------------------------------------------------                   | 8-     300.000 TL   3.Baraj sorusu |");
                Console.WriteLine("Yarışmamızın Kuralları;                                          |                   | 7-     125.000 TL                  |");
                Console.WriteLine("- Her cevabtan sonra ENTER tuşuna basmayı unutmayınız!..         |                   | 6-      70.000 TL                  |");
                Console.WriteLine("- Hiçbir joker hakkınız yoktur!..                                |                   | 5-      30.000 TL   2.Baraj sorusu |");
                Console.WriteLine("- 3 Yanlış yapma hakkınız vardır. 3 Yanlıştan sonra elenirsiniz  |                   | 4-       7.500 TL                  |");
                Console.WriteLine("- Yarışmadan ayrılmak istiyorsanız cevabınıza 'Exit' yazınız!..  |                   | 3-       3.000 TL                  |");
                Console.WriteLine("------------------------------------------------------------------                   | 2-       1.000 TL - 1.Baraj sorusu |");
                Console.WriteLine("                                                                                     | 1-         500 TL                  |");
                Console.WriteLine("                                                                                     --------------------------------------");

                Console.Write("> Adınız : ");
                string ad = Console.ReadLine();
                Console.Write("> Soyadınız : ");
                string soyad = Console.ReadLine();

                Console.WriteLine("-------------------------------------------------------------------");

                int dogru, yanlıs, para;
                dogru = 0;
                yanlıs = 0;
                para = 0;


                Console.WriteLine("Soru 1:");
                Console.WriteLine("Hangisi, bebeklere sıkça söylenenlerden biri değildir?");
                Console.WriteLine(" A: Attaya gidelim \n B: Attum \n C: Bıcı bıcı yapalım \n D: Empati Kur");
                Console.Write("Cevabınız : ");
                string c1 = Console.ReadLine();
                if (c1 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c1 == "D" || c1 == "d")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 500 TL kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 500;
                    Console.ReadKey();

                }
                else
                {
                    yanlıs = yanlıs + 1;
                    Console.WriteLine("Soruyu yanlış cevapladınız, Maalesef Yarışmadan Elendiniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : 0 TL'dir");
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);
                    Console.WriteLine("Sorunun Doğru Cevabı D şıkkıdır");
                    break;
                }
                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 2:");
                Console.WriteLine("Elinde karton bir bardakla, 'Şunu içmeden güne başlayamıyorum'");
                Console.WriteLine("diyen biri muhtemelen ne içiyordur?");
                Console.WriteLine(" A: Lohusa şerbeti \n B: Kahve \n C: Kış sütü \n D: Öksürük şurubu");
                Console.Write("Cevabınız : ");
                string c2 = Console.ReadLine();
                if (c2 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);
                    Console.WriteLine("Yarışma sonlandı... Çıkmak için herhangi bir tuşa basınız!..");
                    break;
                }

                if (c2 == "B" || c2 == "b")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 1.000 TL daha kazanarak 1.Baraj sorusunu geçtiniz...");
                    Console.WriteLine("Devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 1000;
                    Console.ReadKey();

                }
                else
                {
                    yanlıs = yanlıs + 1;
                    Console.WriteLine("Soruyu yanlış cevapladınız, Maalesef Yarışmadan Elendiniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : 0 TL'dir");
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);
                    Console.WriteLine("Sorunun Doğru Cevabı B şıkkıdır");

                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 3:");
                Console.WriteLine("'Uzun sürmek' ve 'sürüp gitmek' anlamlarına");
                Console.WriteLine("gelen ifade hangileridir?");
                Console.WriteLine(" A: Hırla Gitmek \n B: Gırla Gitmek \n C: Zırla Gitmek \n D: Tırla Gitmek");
                Console.Write("Cevabınız : ");
                string c3 = Console.ReadLine();
                if (c3 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c3 == "B" || c3 == "b")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 3.000 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 3000;
                    Console.ReadKey();

                }
                else
                {
                    yanlıs = yanlıs + 1;
                    Console.WriteLine("Soruyu yanlış cevapladınız, Maalesef Yarışmadan Elendiniz...");
                    if (para >= 1000)
                    {
                        para = 1000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı B şıkkıdır");
                        break;
                    }
                    break;

                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 4:");
                Console.WriteLine("Gece gökyüzünü izleyen biri için Kutup Yıldızı'nın");
                Console.WriteLine("diğer yıldızlara göre farkı hangisidir?");
                Console.WriteLine(" A: Daha hızlı haraket etmesi \n B: Sürekli yer değiştirmesi  \n C: Aynı yerde durması \n D: En parlak yıldız olması");
                Console.Write("Cevabınız : ");
                string c4 = Console.ReadLine();
                if (c4 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c4 == "C" || c4 == "c")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 7.500 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 7500;
                    Console.ReadKey();

                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if(para >= 1000)
                    {
                        para = 1000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı C şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 5:");
                Console.WriteLine("İsveç, Norveç ve Danimarka'da");
                Console.WriteLine("yaşayan halkların genel adı nedir?");
                Console.WriteLine(" A: Galyalı \n B: İberyalı  \n C: Britanyalı \n D: İskandinavyalı");
                Console.Write("Cevabınız : ");
                string c5 = Console.ReadLine();
                if (c5 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c5 == "D" || c5 == "d")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 30.000 TL daha kazanarak 2.Baraj sorusunu geçtiniz... ");
                    Console.WriteLine("Devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 30000;
                    Console.ReadKey();
                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if (para >= 1000)
                    {
                        para = 1000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı D şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 6:");
                Console.WriteLine("1.Dünya Savaşı sırasında cephedeki yaralıların hastaneye taşınmasının zor olmasından");
                Console.WriteLine("dolayı, içinde röntgen cihazı olan araçlar tasarlayıp hizmete sunan kişi kimdir?");
                Console.WriteLine(" A: Thomas Edison \n B: Wilhelm Röntgen  \n C: Nikola Tesla \n D: Marie Curie");
                Console.Write("Cevabınız : ");
                string c6 = Console.ReadLine();
                if (c6 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c6 == "D" || c6 == "d")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 70.000 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 70000;
                    Console.ReadKey();


                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if (para >= 30000)
                    {
                        para = 30000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı B şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 7:");
                Console.WriteLine("Dede Korkut'un Türk Destanları'nın özgün kopyaları");
                Console.WriteLine("hangi iki kentte bulunmaktadır?");
                Console.WriteLine(" A: Lizbon-Roma \n B: Dresten-Vatikan  \n C: Londra-Budapeşte \n D: Paris-Varşova");
                Console.Write("Cevabınız : ");
                string c7 = Console.ReadLine();
                if (c7 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c7 == "B" || c7 == "b")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 125.000 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 125000;
                    Console.ReadKey();


                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if (para >= 30000)
                    {
                        para = 30000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı B şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 8:");
                Console.WriteLine("Her 100 yılda 7 cm yere yaklaşan Pisa Kulesi");
                Console.WriteLine("hangi yöne doğru eğilmektedir?");
                Console.WriteLine(" A: Batı \n B: Kuzey  \n C: Güney \n D: Doğu");
                Console.Write("Cevabınız : ");
                string c8 = Console.ReadLine();
                if (c8 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c8 == "C" || c8 == "c")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 300.000 TL daha kazanarak 3.Baraj sorusunu geçtiniz... ");
                    Console.WriteLine("Devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 300000;
                    Console.ReadKey();


                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if (para >= 30000)
                    {
                        para = 30000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı C şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("Soru 9:");
                Console.WriteLine("Ülkemizde 'Devlet Sanatçısı' unvanını");
                Console.WriteLine("alan ilk isim kimdir?");
                Console.WriteLine(" A: Cüneyt Gökçer \n B: Ahmet Adnan Saygun \n C: Yıldız Kenter \n D: Cemal Reşit Bey");
                Console.Write("Cevabınız : ");
                string c9 = Console.ReadLine();
                if (c9 == "Exit" || c1 == "exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c9 == "B" || c9 == "b")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 550.000 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 550000;
                    Console.ReadKey();


                }
                else
                {
                    yanlıs = yanlıs + 1;
                    if (para >= 300000)
                    {
                        para = 300000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı B şıkkıdır");
                        break;
                    }
                    break;
                }

                Console.WriteLine("-------------------------------------------------------------------");

                Console.WriteLine("!!!! 1 Milyonluk Soru !!!!!:");
                Console.WriteLine("Atatürk'ün çok sevdiği");
                Console.WriteLine("atı ve köpeğinin ismi nedir?");
                Console.WriteLine(" A: Anadolu ve Çakır \n B: Yiğit ve Kont \n C: Devrim ve Çakır \n D: Sakarya ve Foks");
                Console.Write("Cevabınız : ");
                string c10 = Console.ReadLine();
                if (c10 == "Exit")
                {
                    Console.WriteLine("Yarışmadan Ayrılmak İstediniz...");
                    Console.WriteLine("Adınız : {0}", ad);
                    Console.WriteLine("Soyadınız : {0}", soyad);
                    Console.WriteLine("Kazandığınız Para : {0}", para);
                    Console.WriteLine("Doğru Sayınız : {0}", dogru);

                    break;
                }

                if (c10 == "D" || c10 == "d")
                {
                    dogru = dogru + 1;
                    Console.WriteLine();
                    Console.WriteLine("Doğru cevap!!! Bizden 1.000.000 TL daha kazandınız devam etmek için Enter'a basınız");
                    Console.WriteLine("Şuana kadar paranız {0} ve doğru sayınız {1}",para,dogru);
                    Console.WriteLine("Eğer ayrılmak istiyorsanız 'Exit' Yazınız");
                    para = 100000;
                    Console.ReadKey();


                }
                else
                {
                    yanlıs = yanlıs + 1;
                    Console.WriteLine("Soruyu yanlış cevapladınız, Maalesef Yarışmadan Elendiniz...");
                    {
                        para = 300000;
                        Console.WriteLine("Adınız : {0}", ad);
                        Console.WriteLine("Soyadınız : {0}", soyad);
                        Console.WriteLine("Kazandığınız Para : {0}", para);
                        Console.WriteLine("Doğru Sayınız : {0}", dogru);
                        Console.WriteLine("Sorunun Doğru Cevabı D şıkkıdır");
                        break;
                    }
                }

                Console.WriteLine("-------------------------------------------------------------------");


            }
            Console.WriteLine("Yarışma sonlandı... Çıkmak için herhangi bir tuşa basınız!..");
            Console.ReadKey();
        }
    }
}
