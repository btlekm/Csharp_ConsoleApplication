using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sayilar = 10; /*"i" döngü için tanımlı,"sayilar" döngüde girilen sayı değerlerini depolamak için tanımlı(=0 Local Hatası vermemesi için)*/
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Sayıyı Giriniz.:");
                sayilar = Convert.ToInt16(Console.ReadLine());
            }

            
            
            Console.ReadKey();
        }
    }
}
