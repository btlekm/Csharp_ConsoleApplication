using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
	class Program
	{
		static void Main(string[] args)
		{ 
		/*1 ile 100 aras�nda �retilen bir say�y� 5 tahminde bulma oyununun algoritmas�n� ve while d�ng�s� kullanarak C#.net kodlar�n� yaz�n�z.
		Program; Oyun bittikten sonra klavyeden girilecek say� ile oyunda tutulan say� aral���ndaki �ift say�lar�n toplam�n� hesaplay�p sonucu yazd�racak.
		Tahmin oyununda yap�lan tahmine g�re a�a�� ya da yukar� �eklinde kullan�c�ya ipucu verilecek.*/
		//
		int say1=0,say2=0,hak=5,toplam=0,basla=0,bitis=0,k=0,r=0;
		Random rnd = new Random();
		int bot = rnd.Next(1,100);
		while (hak > 0)
		{
			Console.Write("Bir Say� Giriniz:");
			say1 = Convert.ToInt16(Console.ReadLine());
			hak = hak - 1;
			if (bot == say1)
			{
				Console.WriteLine("Tebrikler do�ru say�y� tahmin ettiniz..");
				//break;
			}
			else
			{
				if (say1 > bot)
				{
					Console.WriteLine("A�a��.!");
				}
				else
				{
					Console.WriteLine("Yukar�.!");
				}
			}
			Console.WriteLine("Kalan tahmin hakk�n�z: {0}",hak);
		}
		if (hak == 0)
		{
			Console.WriteLine("Kalan Tahmin Hakk�n�z: {0}",hak);
			Console.WriteLine("Say�n�z={0} Olacakt�..",bot);
		}
		//Devam.Ediyoruz..
		Console.WriteLine("L�tfen klavyeden yeni bir say� giriniz:");
		say2 = Convert.ToInt16(Console.ReadLine());
		
		if (say2 < bot)
		{
			basla = say2;
			bitis = bot;
			
		}
		else if (bot < say2)
		{
			basla = bot;
			bitis = say2;
		}
		
		//Tek �fadeleri Toplama Sorunu ��z�m�..
		for (r=1;r<=9999;r=r+2)
		{
			if (basla == r)
			{
				basla = basla - 1;
			}
			else if (bitis == r)
			{
				bitis = bitis - 1;
			}
			else
			{
				k=basla;
				while (k<=bitis)
				{
					k = k + 2;
					toplam = toplam + k;
				}
				Console.WriteLine("Toplam= {0}",toplam);
			}
		}
		//Programda Bir �ok Hata Olabilir �nemli Olan Hatalar� K�sa Zaman ��erisinde D�zeltmektir.! :)
		Console.ReadKey();
		} 

	} 
}
