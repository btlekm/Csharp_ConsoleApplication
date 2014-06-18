using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir derse ait 2 yazılı 2 sözlü botu klavyeden girilecektir.Dersin adı klavyeden girilecektir.Not ortalamasını hesaplayan, puanın
             5'lik not sistemindeki karşılığını bulan sonucu ekrana dersin adıyla birlikte yazdıran programı C#.NET ile kodlayın.!0*/
            string dersadi,yaznot1,yaznot2,soznot1,soznot2;
            int bol4 = 4;
            Console.Write("Dersin adını girin: ");
            dersadi = Console.ReadLine();
            Console.Write("1.Yazılı notunu girin: ");
            yaznot1 = Console.ReadLine();
            Console.Write("2.Yazılı notunu girin: ");
            yaznot2 = Console.ReadLine();
            Console.Write("1.Sözlü notunu girin: ");
            soznot1 = Console.ReadLine();
            Console.Write("2.Sözlü notunu girin: ");
            soznot2 = Console.ReadLine();
            Console.WriteLine("{0} dersi ortalamanız {1}'dır, karne notunuz...",dersadi, ((Convert.ToInt16(yaznot1) + Convert.ToInt16(yaznot2) + Convert.ToInt16(soznot1) + Convert.ToInt16(soznot2)) / (bol4)));

            Console.ReadKey();
        }
    }
}
