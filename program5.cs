using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
	class Program
	{
		static void Main(string[] args)
		{ 
		/*0'dan 10'a kadar olan çift sayýlarýn toplamýný bulan programýn algoritmasýný ve C#.net kodlarýný yazýnýz..*/
		/*Algoritma*/
		//1-)Baþla
		//2-)int deðiþken tipinde toplam adýnda bir deðiþken tanýmla ve bunu 0'a eþitle..
		//3-)int deðiþken tipinde i adýnda bir deðiþken tanýmla ve bunu 0'e eþitle..(Bu ayný zamanda döngünün baþlangýç deðeri olmuþ olacak..)
		//4-)While döngüsünü tanýmla ve koþulu belirt..
		//5-)Koþul saðlandýðý sürece "i=i+2;" ve "toplam=toplam=0;" iþlemlerini yap..
		//6-)Son olarak döngü dýþýnda kullanýcýya sonucu yansýt..
		//7-)Bitir
		//0-2-4-6-8-10 = [30]
		int toplam = 0;
		int i=0;
		while (i<=10)
		{
			//i = i + 2;
			toplam = toplam + i;
			i = i + 2;
		}
		Console.WriteLine("Toplam= {0}",toplam);
		Console.ReadKey();
		} 

	} 
}