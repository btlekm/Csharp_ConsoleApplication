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
		/*0'dan 10'a kadar olan tek say�lar�n toplam�n� bulan program�n algoritmas�n� ve C#.net kodlar�n� yaz�n�z..*/
		/*Algoritma*/
		//1-)Ba�la
		//2-)int de�i�ken tipinde toplam ad�nda bir de�i�ken tan�mla ve bunu 0'a e�itle..
		//3-)int de�i�ken tipinde i ad�nda bir de�i�ken tan�mla ve bunu 1'e e�itle..(Bu ayn� zamanda d�ng�n�n ba�lang�� de�eri olmu� olacak..)
		//4-)While d�ng�s�n� tan�mla ve ko�ulu belirt..
		//5-)Ko�ul sa�land��� s�rece "i=i+2;" ve "toplam=toplam=0;" i�lemlerini yap..
		//6-)Son olarak d�ng� d���nda kullan�c�ya sonucu yans�t..
		//7-)Bitir
		//1-3-5-7-9 = [25]
		int toplam = 0;
		int i=1;
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
