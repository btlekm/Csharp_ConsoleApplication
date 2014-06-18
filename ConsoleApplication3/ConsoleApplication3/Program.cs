using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 4 sayının ortalamasını hesaplayan, girilen ilk 2 sayıyı çarpan, girilen son 2 sayıyı toplayan programı C#.NET ile kodlayın.!
            string say1,say2,say3,say4;
            const int bol4 = 4;
            Console.Write("1.Sayıyı Gİrin: ");
            say1 = Console.ReadLine();
            Console.Write("2.Sayıyı Girin: ");
            say2 = Console.ReadLine();
            Console.Write("3.Sayıyı Girin: ");
            say3 = Console.ReadLine();
            Console.Write("4.Sayıyı Girin: ");
            say4 = Console.ReadLine();
            Console.WriteLine("{0} + {1} + {2} + {3} / {4} = {5}", say1, say2, say3, say4, bol4, ((Convert.ToInt16(say1) + Convert.ToInt16(say2) + Convert.ToInt16(say3) + Convert.ToInt16(say4)) / (bol4)));
            Console.WriteLine("{0} * {1} = {2}",say1,say2, (Convert.ToInt16(say1) * Convert.ToInt16(say2)));
            Console.WriteLine("{0} + {1} = {2}",say3,say4, (Convert.ToInt16(say3) + Convert.ToInt16(say4)));

            Console.ReadKey();
        }
    }
}
