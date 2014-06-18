using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kenar uzunlukları klavyeden girilen bir dikdörtgenin alanını hesaplayan programı C#.NET ile kodlayın.!
            string akenari, bkenari;
            Console.Write("Dikdörtgenin Kısa Kenar Uzunluğunu Girin:");
            akenari = Console.ReadLine();
            Console.Write("Dikdörtgenin Uzun Kenar Uzunluğunu Girin:");
            bkenari = Console.ReadLine();
            Console.WriteLine("Dikdörtgenin alanı: {0} ", (Convert.ToInt16(akenari) * Convert.ToInt16(bkenari)));

            Console.ReadKey();
        }
    }
}
