using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Klavyeden girilen 2 sayıdan, küçük olanından başlayıp büyük olanına kadar çarpım tablosunu ekrana yazdıran programı c#.net ile kodlayınız..
            int i, k, say1, say2, basla=0,carpim, bitis=0;
            Console.WriteLine("1.Sayıyı Girin:");
            say1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Girin:");
            say2 = Convert.ToInt16(Console.ReadLine());
            carpim = 0;
            if (say1 < say2) // Hata burada
            {
                basla = say1;
                bitis = say2;
            }
            else 
            {
                basla = say2;
                bitis = say1;
            }
            
            for (i = basla; i <= bitis; i++)
            {
                Console.WriteLine("-{0} ve Katları-",i);
                for (k = 1; k <= 10; k++)
                {

                    carpim = i * k;
                    Console.WriteLine("{0} x {1} = {2}",i,k,carpim);
                    
                }
                Console.ReadKey();
            }*/

            /*int i, k, say1, say2, toplam = 0, basla, bitis ,carpim=0;

            Console.WriteLine("1.Sayıyı Girin:");
            say1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Girin:");
            say2 = Convert.ToInt16(Console.ReadLine());

            if (say1 < say2)
            {
                basla = say1;
                bitis = say2;
            }
            else
            {
                basla = say2;
                bitis = say1;
            }

            for (i = basla; i <= bitis; i++)
            {
                Console.WriteLine("-{0} ve Katları");
                for (k=1;k<=10;k++)
                {
                    carpim = i * k;
                    Console.WriteLine("{0} * {1} = {2}", i, k, carpim);
                }
            }

            Console.ReadKey();*/

            int i, k, say1, say2, basla = 0, bitis = 0, carpim = 0;

            Console.WriteLine("1.Sayıyı Girin:");
            say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Girin:");
            say2 = Convert.ToInt32(Console.ReadLine());

            if (say1 < say2)
            {
                basla = say1;
                bitis = say2;
            }
            else
            {
                basla = say2;
                bitis = say1;
            }

            for (i = basla; i <= bitis; i++)
            {
                Console.WriteLine("{0} ve Katları");
                for (k = 1; k <= 10; i++)
                {
                    carpim = i * k;
                    Console.WriteLine("{0} * {1} = {2}",i,k,carpim);
                }
            }
            Console.ReadKey();

        }
    }
}
