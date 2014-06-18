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
			/*Sayý tahmin oyununda rastgele üretilen sayýyý 2. Denemede bulduran programý yazýnýz.ilk denemeden sonra kullanýcýya tutulan sayý ile girdiði sayý arasýndaki farký söyleyip kullanýcýnýn 2.Denemede tutulan sayýyý bulmasýný saðlayan program. */
			/*Algoritma*/
			//1-)Baþla
			//2-)Rastgele bir sayý üret ve bunu bir deðiþkende tut
			//3-)Kullanýcýdan tahminde bulunmasýný iste
			//4-)Kullanýcýnýn sayýyý 2.Denemede bulmasý için kullanýcýyý yönlendireceðiz bunun için if kullanarak tahmin edilen sayý ile programýn ürettiði sayýyý karþýlaþtýr
			//5-)Kullanýcýnýn sayýyý 2.Denemede hatalý girmesi durumunda olayý döngü kullanarak sonsuza kadar devam ettir(Bu ek fonksiyon)
			//6-)Sonuçlarýn doðru olmasý durumunda ekrana "Tebrikler Doðru Tahminde Bulundunuz.." yaz..
			//7-)Bitir
			int sayi=0,islem=0,dogru1=0,dogru2=0;
			Random rnd = new Random();
			int bot = rnd.Next(1,100);
			Console.Write("Bir Tahminde Bulununuz:");
			sayi = Convert.ToInt16(Console.ReadLine());
			if (bot > sayi)
			{
				islem=bot-sayi;
				Console.WriteLine("Lütfen Bir Tahminde Bulunduðunuz Sayýyý {0} arttýrýnýz..",islem);
				Console.Write("Lütfen Arttýrdýðýnýz Sayýyý Giriniz:");
				dogru1 = Convert.ToInt16(Console.ReadLine());
				
				
				if (dogru1 == bot)
				{
					Console.WriteLine("Tebrikler Doðru Tahminde Bulundunuz..");
				}
				else
				{
					Console.WriteLine("Lütfen Bir Tahminde Bulunduðunuz Sayýyý {0} arttýrýnýz..",islem);
					Console.Write("Lütfen Arttýrdýðýnýz Sayýyý Giriniz:");
					dogru1 = Convert.ToInt16(Console.ReadLine());
					//break;
				}
				
			}
			else
			{
				islem=sayi-bot;
				Console.WriteLine("Lütfen Bir Tahminde Bulunduðunuz Sayýyý {0} azaltýnýz..",islem);
				Console.Write("Lütfen Azaltýðýnýz Sayýyý Giriniz:");
				dogru2 = Convert.ToInt16(Console.ReadLine());
				
				
				if (dogru2 == bot)
				{
					Console.WriteLine("Tebrikler Doðru Tahminde Bulundunuz..");
				}
				else
				{
					Console.WriteLine("Lütfen Bir Tahminde Bulunduðunuz Sayýyý {0} azaltýnýz..",islem);
					Console.Write("Lütfen Azaltýðýnýz Sayýyý Giriniz:");
					dogru2 = Convert.ToInt16(Console.ReadLine());
					//break;
				}
				
			}
	Console.ReadKey();
	
		} 
	} 
}
