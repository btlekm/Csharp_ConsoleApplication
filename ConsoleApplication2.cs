using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Öğretmen tarafından belirlenen sorunun çözümü*/
            Console.WriteLine("Programıma hoşgeldiniz.!");
            Console.WriteLine("Sorunlar Listesi");
            Console.WriteLine("1.İnternete bağlanamıyorum.");
            Console.WriteLine("2.Bilgisayarım Sürekli Yeniden başlıyor.");
            Console.WriteLine("3.Bilgisayarımdaki medya dosyalarını çalıştırırken sesleri duyamıyorum.");
            Console.Write("Sorununuzu belirtin.!");
            int secim = Convert.ToInt16(Console.ReadLine());

            switch (secim)
            { 
                case 1:
                    Console.WriteLine("İnternete bağlanamıyorsunuz:");
                    Console.WriteLine("Ağ kablonuzu ethernet kartına bağlayınız.");
                    Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                    string sorun1 = Console.ReadLine();
                    if ((sorun1 == "evet") || (sorun1 == "EVET") || (sorun1 == "Evet"))
                    {
                        Console.WriteLine("İyi Çalışmalar");
                    }
                    else
                    {
                        Console.WriteLine("Modeminizin bağlantılarını doğru yapın.");
                        Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                        string sorun2 = Console.ReadLine();
                        if ((sorun2 == "evet") || (sorun2 == "EVET") || (sorun2 == "Evet"))
                        {
                            Console.WriteLine("İyi Çalışmalar");
                        }
                        else
                        {
                            Console.WriteLine("Modeminizi Resetleyin.!");
                            Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                            string sorun3 = Console.ReadLine();
                            if ((sorun3 == "evet") || (sorun3 == "EVET") || (sorun3 == "Evet"))
                            {
                                Console.WriteLine("İyi Çalışmalar");
                            }
                            else 
                            {
                                Console.WriteLine("Müşteri hizmetlerini arayarak modeminizi kontrol ettiriniz.! =)");
                            }
                        }

                    }

                break;

                case 2:
                    Console.WriteLine("Bilgisayarınız Sürekli Yeniden başlıyor:");
                    Console.WriteLine("Kasanızın reset tuşuna basılı kalıp kalmadığını kontrol ediniz.");
                    Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                    string sorun4 = Console.ReadLine();
                    if ((sorun4 == "evet") || (sorun4 == "EVET") || (sorun4 == "Evet"))
                    {
                        Console.WriteLine("İyi Çalışmalar");
                    }
                    else
                    {
                        Console.WriteLine("Hava kompresörü işlemci fanına hava tutup temizleyiniz.!");
                        Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                        string sorun9 = Console.ReadLine();
                        if ((sorun9 == "evet") || (sorun9 == "EVET") || (sorun9 == "Evet"))
                        {
                            Console.WriteLine("İyi Çalışmalar");
                        }
                        else
                        {
                            Console.WriteLine("İşlemci üzerine termal macun sürün.!");
                            Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                            string sorun5 = Console.ReadLine();
                            if ((sorun5 == "evet") || (sorun5 == "EVET") || (sorun5 == "Evet"))
                            {
                                Console.WriteLine("İyi Çalışmalar");
                            }
                            else
                            {
                                Console.WriteLine("Bilgisayarınızı yetkili servisine götürünüz.!");
                            }
                        }
                    }

                break;

                case 3:
                    Console.WriteLine("Bilgisayarınızda ki medya çalıştırırken medya dosyalarını çalıştırırken sesleri duyamıyorsunuz.!");
                    Console.WriteLine("Ses denetimi yazılımından bilgisayarınızın sesini açın.!");
                    Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                    string sorun6 = Console.ReadLine();
                    if ((sorun6 == "evet") || (sorun6 == "EVET") || (sorun6 == "Evet"))
                    {
                        Console.WriteLine("İyi Çalışmalar");
                    }
                    else 
                    {
                        Console.WriteLine("Hoparlörünüzü fişe takınız,sesini açınız.!");
                        Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                        string sorun7 = Console.ReadLine();
                        if ((sorun7 == "evet") || (sorun7 == "EVET") || (sorun7 == "Evet"))
                        {
                            Console.WriteLine("İyi Çalışmalar");
                        }
                        else
                        {
                            Console.WriteLine("Ses kartı sürücü dosyalarını yeniden yükleyiniz.!");
                            Console.WriteLine("Sorun Çözüldü mü?(Evet/Hayır)");
                            string sorun8 = Console.ReadLine();
                            if ((sorun8 == "evet") || (sorun8 == "EVET") || (sorun8 == "Evet"))
                            {
                                Console.WriteLine("İyi Çalışmalar");
                            }
                            else
                            {
                                Console.WriteLine("Bilgisayarınızı yetkili servisine götürünüz.!");
                            }
                            
                        }
                    }
                break;
            }



            Console.ReadKey();
        }
    }
}
