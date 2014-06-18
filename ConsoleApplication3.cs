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

            {

                int[] sayilar = new int[10];

                int gecici;

                for (int i = 0; i < 1; i++)
                {
                    Console.Write("Sayı giriniz = ");
                    sayilar[i] = int.Parse(Console.ReadLine());
                }


                for (int i = 0; i < 1; i++)
                {
                    for (int j = i + 1; j < 1; j++)
                    {
                        if (sayilar[j] > sayilar[i])
                        {
                            gecici = sayilar[i];
                            sayilar[i] = sayilar[j];
                            sayilar[j] = gecici;
                        }
                    }
                }

                foreach (int i in sayilar)
                {

                    Console.WriteLine("{0}", i);

                }
            } 


            Console.ReadKey();
        }
    }
}
