using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 3 sayının ortalamasını hesaplayan programı C#.NET ile kodlayın.!
            int say1,say2,say3,bolum;
            const int bol3 = 3;
            Console.WriteLine("1.Sayıyı Girin: ");
            say1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Girin: ");
            say2 = int.Parse(Console.ReadLine());
            Console.Write("3.Sayıyı Girin: ");
            say3 = int.Parse(Console.ReadLine());
            bolum=(say1+say2+say3)/bol3;
            Console.WriteLine("{0} + {1} + {2} / {3} = {4}",say1,say2,say3,bol3, bolum );

            Console.ReadKey();
        }
    }
}
