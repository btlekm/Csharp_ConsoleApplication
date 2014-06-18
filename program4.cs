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
		/*1 ile 100 arasýnda üretilen bir sayýyý 5 tahminde bulma oyununun algoritmasýný ve while döngüsü kullanarak C#.net kodlarýný yazýnýz.
		Program; Oyun bittikten sonra klavyeden girilecek sayý ile oyunda tutulan sayý aralýðýndaki çift sayýlarýn toplamýný hesaplayýp sonucu yazdýracak.
		Tahmin oyununda yapýlan tahmine göre aþaðý ya da yukarý þeklinde kullanýcýya ipucu verilecek.*/
		//
		int say1=0,say2=0,hak=5,toplam=0,basla=0,bitis=0,k=0,r=0;
		Random rnd = new Random();
		int bot = rnd.Next(1,100);
		while (hak > 0)
		{
			Console.Write("Bir Sayý Giriniz:");
			say1 = Convert.ToInt16(Console.ReadLine());
			hak = hak - 1;
			if (bot == say1)
			{
				Console.WriteLine("Tebrikler doðru sayýyý tahmin ettiniz..");
				//break;
			}
			else
			{
				if (say1 > bot)
				{
					Console.WriteLine("Aþaðý.!");
				}
				else
				{
					Console.WriteLine("Yukarý.!");
				}
			}
			Console.WriteLine("Kalan tahmin hakkýnýz: {0}",hak);
		}
		if (hak == 0)
		{
			Console.WriteLine("Kalan Tahmin Hakkýnýz: {0}",hak);
			Console.WriteLine("Sayýnýz={0} Olacaktý..",bot);
		}
		//Devam.Ediyoruz..
		Console.WriteLine("Lütfen klavyeden yeni bir sayý giriniz:");
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
		
		//Tek Ýfadeleri Toplama Sorunu Çözümü..
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
		//Programda Bir Çok Hata Olabilir Önemli Olan Hatalarý Kýsa Zaman Ýçerisinde Düzeltmektir.! :)
		Console.ReadKey();
		} 

	} 
}
