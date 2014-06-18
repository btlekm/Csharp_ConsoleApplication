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
            /*Klavyeden girilen 10 say�y� b�y�kten k����e s�ralayan, yap�lacak i�lemi i�lem men�s�nden se�tiren,s�ralanan say�lardan i�lem yap�lacak 2 say�y� kullan�c�n�n se�ti�i ve i�lemi yapt�ran program�n Algoritmas�n�,Ak�� Diyagram�n� ve C#.net ile kodlay�n�z.! */
            //Ali AK�AY
            int gecici;
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++) 
            { 
                Console.Write("Say� giriniz = "); 
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
            Console.WriteLine("L�tfen Yukar�daki S�ralamadan 2 Say� Se�iniz: ");
            Console.Write("L�tfen 1.Say�y� Se�iniz:");
            int say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("L�tfen 2.Say�y� Se�iniz:");
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
            Console.WriteLine("L�tfen ��lem Men�s�nden Bir ��lem Se�in:");
            Console.WriteLine("************");
            Console.WriteLine("*1-)Toplama*");
            Console.WriteLine("*2-)��karma*");
            Console.WriteLine("*3-)�arpma**");
            Console.WriteLine("*4-)B�lme***");
            Console.WriteLine("************");
            Console.Write("Se�im=");
            int secilenislem = Convert.ToInt16(Console.ReadLine());

            if (secilenislem == 1)
            {
                Console.WriteLine("Se�ilen ��lem = *1-)Toplama* ");
                int islem1 = basla + bitis;
                Console.WriteLine("Se�ilen ��lemin Sonucu = {0}",islem1);
            }
            else if (secilenislem == 2)
            {
                Console.WriteLine("Se�ilen ��lem = *2-)��karma* ");
                int islem2 = basla - bitis;
                Console.WriteLine("Se�ilen ��lemin Sonucu = {0}", islem2);
            }
            else if (secilenislem == 3)
            {
                Console.WriteLine("Se�ilen ��lem = *3-)�arpma** ");
                int islem3 = basla * bitis;
                Console.WriteLine("Se�ilen ��lemin Sonucu = {0}", islem3);
            }
            else if (secilenislem == 4)
            {
                Console.WriteLine("Se�ilen ��lem = *4-)B�lme*** ");
                int islem4 = basla / bitis;
                Console.WriteLine("Se�ilen ��lemin Sonucu = {0}", islem4);
            }
            Console.ReadKey(); 
        } 

    } 
}
