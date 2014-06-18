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
            int i ,say1, say2, toplam = 0;
            Console.Write("1.Sayıyı Giriniz.:");
            say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz.:");
            say2 = Convert.ToInt16(Console.ReadLine());

            //Değer atama işlemini yapamadığım için çözüm olarak
            //
            int islem1 = say1 + 1;
            int islem2 = say2 - 1;

            for (i = islem1; i <= islem2;i++)
            {
                //toplam = toplam + i;
                Console.WriteLine(i);
            }

            //Console.WriteLine("Toplam={0}",toplam);

            Console.ReadKey();
        }
    }
}
