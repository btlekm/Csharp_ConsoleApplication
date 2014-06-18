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
            string say1,say2,say3;
            const int bol3 = 3;
            Console.Write("1.Sayıyı Girin: ");
            say1 = Console.ReadLine();
            Console.Write("2.Sayıyı Girin: ");
            say2 = Console.ReadLine();
            Console.Write("3.Sayıyı Girin: ");
            say3 = Console.ReadLine();
            Console.WriteLine("{0} + {1} + {2} / {3} = {4}",say1,say2,say3,bol3, ((Convert.ToInt16(say1) + Convert.ToInt16(say2) + Convert.ToInt16(say3)) / (bol3)));

            Console.ReadKey();
        }
    }
}
