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
			/*Say� tahmin oyununda rastgele �retilen say�y� 2. Denemede bulduran program� yaz�n�z.ilk denemeden sonra kullan�c�ya tutulan say� ile girdi�i say� aras�ndaki fark� s�yleyip kullan�c�n�n 2.Denemede tutulan say�y� bulmas�n� sa�layan program. */
			/*Algoritma*/
			//1-)Ba�la
			//2-)Rastgele bir say� �ret ve bunu bir de�i�kende tut
			//3-)Kullan�c�dan tahminde bulunmas�n� iste
			//4-)Kullan�c�n�n say�y� 2.Denemede bulmas� i�in kullan�c�y� y�nlendirece�iz bunun i�in if kullanarak tahmin edilen say� ile program�n �retti�i say�y� kar��la�t�r
			//5-)Kullan�c�n�n say�y� 2.Denemede hatal� girmesi durumunda olay� d�ng� kullanarak sonsuza kadar devam ettir(Bu ek fonksiyon)
			//6-)Sonu�lar�n do�ru olmas� durumunda ekrana "Tebrikler Do�ru Tahminde Bulundunuz.." yaz..
			//7-)Bitir
			int sayi=0,islem=0,dogru1=0,dogru2=0;
			Random rnd = new Random();
			int bot = rnd.Next(1,100);
			Console.Write("Bir Tahminde Bulununuz:");
			sayi = Convert.ToInt16(Console.ReadLine());
			if (bot > sayi)
			{
				islem=bot-sayi;
				Console.WriteLine("L�tfen Bir Tahminde Bulundu�unuz Say�y� {0} artt�r�n�z..",islem);
				Console.Write("L�tfen Artt�rd���n�z Say�y� Giriniz:");
				dogru1 = Convert.ToInt16(Console.ReadLine());
				
				
				if (dogru1 == bot)
				{
					Console.WriteLine("Tebrikler Do�ru Tahminde Bulundunuz..");
				}
				else
				{
					Console.WriteLine("L�tfen Bir Tahminde Bulundu�unuz Say�y� {0} artt�r�n�z..",islem);
					Console.Write("L�tfen Artt�rd���n�z Say�y� Giriniz:");
					dogru1 = Convert.ToInt16(Console.ReadLine());
					//break;
				}
				
			}
			else
			{
				islem=sayi-bot;
				Console.WriteLine("L�tfen Bir Tahminde Bulundu�unuz Say�y� {0} azalt�n�z..",islem);
				Console.Write("L�tfen Azalt���n�z Say�y� Giriniz:");
				dogru2 = Convert.ToInt16(Console.ReadLine());
				
				
				if (dogru2 == bot)
				{
					Console.WriteLine("Tebrikler Do�ru Tahminde Bulundunuz..");
				}
				else
				{
					Console.WriteLine("L�tfen Bir Tahminde Bulundu�unuz Say�y� {0} azalt�n�z..",islem);
					Console.Write("L�tfen Azalt���n�z Say�y� Giriniz:");
					dogru2 = Convert.ToInt16(Console.ReadLine());
					//break;
				}
				
			}
	Console.ReadKey();
	
		} 
	} 
}
