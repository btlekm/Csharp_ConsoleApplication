using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Öğrencinin adı ve soyadı klavyeden girilecektir.3 yazılı ve 3 sözlü notu aynı şekilde klavyeden girilecektir.Not ortalamasını
            hesaplayıp sonucu ekrana adı,soyadı,ortalaması şeklinde yazdıran programı C#.NET ile kodlayın.!(dersadi eklemesi yaptım.) */
            string yaznot1,yaznot2,yaznot3,soznot1,soznot2,soznot3,adi,soyadi,dersadi;
            const int bol6 = 6;
            Console.Write("Adınızı Girin: ");
            adi = Console.ReadLine();
            Console.Write("Soyadınızı Girin: ");
            soyadi = Console.ReadLine();
            Console.Write("Ders Adını Girin: ");
            dersadi = Console.ReadLine();
            Console.Write("1.Yazılı Notunu Girin: ");
            yaznot1 = Console.ReadLine();
            Console.Write("2.Yazılı Notunu Girin: ");
            yaznot2 = Console.ReadLine();
            Console.Write("3.Yazılı Notunu Girin: ");
            yaznot3 = Console.ReadLine();
            Console.Write("1.Sözlü Notunu Girin: ");
            soznot1 = Console.ReadLine();
            Console.Write("2.Sözlü Notunu Girin: ");
            soznot2 = Console.ReadLine();
            Console.Write("3.Sözlü Notunu Girin: ");
            soznot3 = Console.ReadLine();
            Console.WriteLine("{0} {1},{2} dersi ortalamanız {3} 'dır",adi,soyadi,dersadi,yaznot1,yaznot2,yaznot3,soznot1,soznot2,soznot3,bol6, ((Convert.ToInt16(yaznot1) + Convert.ToInt16(yaznot2) + Convert.ToInt16(yaznot3) + Convert.ToInt16(soznot1) + Convert.ToInt16(soznot2) + Convert.ToInt16(soznot3)) / (bol6)));

            Console.ReadKey();
        }
    }
}
 