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
            /*Klavyeden kullanıcı tarafından girilen 3 sayıyı büyükten küçüğe sıralayan programı C#.net ile kodlayınız..*/
            Console.Write("1.Sayıyı Giriniz.");
            int say1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz.");
            int say2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3.Sayıyı Giriniz.");
            int say3 = Convert.ToInt16(Console.ReadLine());

            if ((say1 > say2) && (say2 > say3))
            {
                Console.WriteLine("{0} > {1} > {2}",say1,say2,say3);
            }
            else if ((say1 > say3) && (say3 > say2))
            { 
                Console.WriteLine("{0} > {1} > {2}",say1,say3,say2);
            }
            else if ((say2 > say1) && (say1 > say3))
            {
                Console.WriteLine("{0} > {1} > {2}",say2,say1,say3);
            }
            else if ((say2 > say3) && (say3 > say1))
            {
                Console.WriteLine("{0} > {1} > {2}",say2,say3,say1);
            }
            else if ((say3 > say2) && (say2 > say1))
            {
                Console.WriteLine("{0} > {1} > {2}",say3,say2,say1);
            }
            else if ((say3 > say1) && (say1 > say2))
            {
                Console.WriteLine("{0} > {1} > {2}",say3,say1,say2);
            }
             
                /*Esitlik İhtimali..*/

            else if ((say1 == say2) && (say2 == say3))
            {
                Console.WriteLine("{0} = {1} = {2}", say1, say2, say3);
            }
            else if ((say1 == say3) && (say3 == say2))
            {
                Console.WriteLine("{0} = {1} = {2}", say1, say3, say2);
            }
            else if ((say2 == say1) && (say1 == say3))
            {
                Console.WriteLine("{0} = {1} = {2}", say2, say1, say3);
            }
            else if ((say2 == say3) && (say3 == say1))
            {
                Console.WriteLine("{0} = {1} = {2}", say2, say3, say1);
            }
            else if ((say3 == say2) && (say2 == say1))
            {
                Console.WriteLine("{0} = {1} = {2}", say3, say2, say1);
            }
            else if ((say3 == say1) && (say1 == say2))
            {
                Console.WriteLine("{0} = {1} = {2}",say3,say1,say2);
            }




            Console.ReadKey();
        }
    }
}
