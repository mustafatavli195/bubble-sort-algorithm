using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSortAlgorithm
{
	internal class Program
	{
		static Random rnd = new Random();
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("						Mustafa Tavlı");
				uygulamayıCalistir();


				#region tryAgain
				Console.WriteLine("Tekrar denemek ister misiniz? (E/H)");
				string cevap = Console.ReadLine().ToUpper();
				if (cevap == "H")
					Environment.Exit(0);
				else if (cevap == "E")
					Console.Clear();
				else
					Console.WriteLine("Geçersiz seçim yaptınız (E/H).");
				#endregion
			}
		}

		private static void uygulamayıCalistir()
		{
			Console.WriteLine("Kaç elemanlı bir dizi oluşturmak istiyorsunuz ? ");
			int deger = Convert.ToInt16(Console.ReadLine());

			int[] dizi = new int[deger];

			for (int i = 0; i < dizi.Length; i++)
			{
				dizi[i] = rnd.Next(100);
			}


			#region Print Section
			Console.WriteLine("Oluşturulan Rastgele Dizi : \n");
			Yazdir(dizi);


			Console.WriteLine("\nBubble Sort Uygulanıyor...... \n");
			bubbleSort(dizi);


			Console.WriteLine("Sonuç : ");
			Yazdir(dizi);
			#endregion
		}

		private static void bubbleSort(int[] dizi)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			int n = dizi.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n - 1; j++)
				{
					if (dizi[j] > dizi[j + 1])
					{
						int temp = dizi[j];
						dizi[j] = dizi[j + 1];
						dizi[j + 1] = temp;
						Console.WriteLine(dizi[j] + " ile " + dizi[j + 1] + " yer değiştirdi.");
						Yazdir(dizi);
						Console.WriteLine();
					}
				}
			}
			stopwatch.Stop();
			TimeSpan gecenZaman = stopwatch.Elapsed;
			Console.WriteLine("\nÇalışma Süresi : " + gecenZaman.TotalSeconds + " saniye");
		}
		private static void Yazdir(int[] dizi)
		{
			foreach (int i in dizi)
			{
				Console.Write(i + ", ");
			}
			Console.WriteLine();
		}
	}
}
