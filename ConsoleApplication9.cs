using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int say1, i,toplam=0;
            Console.Write("Lütfen çift bir sayı giriniz..");
            say1 = Convert.ToInt16(Console.ReadLine());
            if (say1 <= 0)
            {
                Console.Write("Lütfen çift bir sayı giriniz..");
                say1 = Convert.ToInt16(Console.ReadLine());

                for (i = 0; i <= say1; i = i + 2)
                {
                    toplam = toplam + i;
                    Console.WriteLine(i);
                }
            }
            else if (say1 > 0)
            {
            for (i=0;i<=say1;i = i + 2)
                {
                toplam = toplam + i;
                Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
