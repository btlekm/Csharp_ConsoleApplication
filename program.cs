using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 10 sayýyý büyükten küçüðe sýralayan, yapýlacak iþlemi iþlem menüsünden seçtiren,sýralanan sayýlardan iþlem yapýlacak 2 sayýyý kullanýcýnýn seçtiði ve iþlemi yaptýran programýn Algoritmasýný,Akýþ Diyagramýný ve C#.net ile kodlayýnýz.! */
            //Ali AKÇAY
            int gecici;
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++) 
            { 
                Console.Write("Sayý giriniz = "); 
                sayilar[i] = Convert.ToInt16(Console.ReadLine()); 
            } 

            for (int i = 0; i < 10; i++) 
            { 
                for (int j = i+1; j < 10; j++) 
                { 
                    if (sayilar[i]<sayilar[j]) 
                    { 
                        gecici = sayilar[i]; 
                        sayilar[i] = sayilar[j]; 
                        sayilar[j] = gecici; 
                    } 
                } 
            } 

            foreach (int i in sayilar) 
            { 
                Console.WriteLine("{0}",i); 
            }

            Console.WriteLine(" ");
            Console.WriteLine("Lütfen Yukarýdaki Sýralamadan 2 Sayý Seçiniz: ");
            Console.Write("Lütfen 1.Sayýyý Seçiniz:");
            int say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Lütfen 2.Sayýyý Seçiniz:");
            int say2 = Convert.ToInt16(Console.ReadLine());

            int basla = 0, bitis = 0;

            if (say1 > say2)
            {
                basla = say1;
                bitis = say2;
            }
            else
            {
                basla = say2;
                bitis = say1;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Lütfen Ýþlem Menüsünden Bir Ýþlem Seçin:");
            Console.WriteLine("************");
            Console.WriteLine("*1-)Toplama*");
            Console.WriteLine("*2-)Çýkarma*");
            Console.WriteLine("*3-)Çarpma**");
            Console.WriteLine("*4-)Bölme***");
            Console.WriteLine("************");
            Console.Write("Seçim=");
            int secilenislem = Convert.ToInt16(Console.ReadLine());

            if (secilenislem == 1)
            {
                Console.WriteLine("Seçilen Ýþlem = *1-)Toplama* ");
                int islem1 = basla + bitis;
                Console.WriteLine("Seçilen Ýþlemin Sonucu = {0}",islem1);
            }
            else if (secilenislem == 2)
            {
                Console.WriteLine("Seçilen Ýþlem = *2-)Çýkarma* ");
                int islem2 = basla - bitis;
                Console.WriteLine("Seçilen Ýþlemin Sonucu = {0}", islem2);
            }
            else if (secilenislem == 3)
            {
                Console.WriteLine("Seçilen Ýþlem = *3-)Çarpma** ");
                int islem3 = basla * bitis;
                Console.WriteLine("Seçilen Ýþlemin Sonucu = {0}", islem3);
            }
            else if (secilenislem == 4)
            {
                Console.WriteLine("Seçilen Ýþlem = *4-)Bölme*** ");
                int islem4 = basla / bitis;
                Console.WriteLine("Seçilen Ýþlemin Sonucu = {0}", islem4);
            }
            Console.ReadKey(); 
        } 

    } 
}
