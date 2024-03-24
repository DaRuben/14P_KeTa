using Microsoft.SqlServer.Server;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace linq_biv
{
	internal struct adatok
	{
		public string Kod { get; set; }
		public string Nev { get; set; }
		public double elmelet_1 { get; set; }
		public double gyakorlat_1 { get; set; }
		public double elmelet_2 { get; set; }
		public double gyakorlat_2 { get; set; }
		public double elso_fordulo { get { return elmelet_1 + gyakorlat_1; } }
		public double masodik_fordulo { get { return elmelet_2 + gyakorlat_2; } }
		public double osszes { get { return elso_fordulo + masodik_fordulo; } }
	};
	internal class Program
	{
		static void Main(string[] args)
		{
			var KapottAnyag = Beolvas();
			var E15 = Elso15(KapottAnyag);
			for (int i = 0; i < E15.Length; i++)
			{
				Console.WriteLine((i + 1).ToString().PadLeft(2) + ". helyezett: " + E15[i].Nev);
			}

			var DoubleTulajdosagok = KapottAnyag[0].GetType().GetProperties().Where(t => t.PropertyType == typeof(double));
			Console.WriteLine("\nÁtlagok");
			foreach (var tulajdonsag in DoubleTulajdosagok)
			{
				Console.WriteLine(tulajdonsag.Name.PadLeft(15) + " " + Atlag(KapottAnyag, tulajdonsag.Name));
			}

			Console.WriteLine("\nMaximumokat elérő:");
			foreach (var tulajdonsag in DoubleTulajdosagok.Take(4))
			{
				Console.WriteLine();
				var AktMax = Maximumok(KapottAnyag, tulajdonsag.Name);
				foreach (var versenyzo in AktMax)
				{
					Console.WriteLine(tulajdonsag.Name.PadLeft(15) + " " + versenyzo.Nev + " " + tulajdonsag.GetValue(versenyzo));
				}
			}

			Console.ReadKey();
		}
		static adatok[] Maximumok(adatok[] versenyzok, string Tulajdonsag)
		{
			var MaxErtek = versenyzok.Max(m => (double)m.GetType().GetProperty(Tulajdonsag).GetValue(m));
			return versenyzok.Where(m => (double)m.GetType().GetProperty(Tulajdonsag).GetValue(m) == MaxErtek).ToArray();
		}
		static double Atlag(adatok[] versenyzok, string Tulajdonsag)
		{
			return versenyzok.Average(x => (double)x.GetType().GetProperty(Tulajdonsag).GetValue(x));
		}
		static adatok[] Elso15(adatok[] versenyzok)
		{
			return (versenyzok.OrderByDescending(v => v.osszes)).Take(15).ToArray();
		}
		static adatok[] Beolvas()
		{
			var seged = File.ReadAllLines("biv_2022-23-8.txt", Encoding.UTF8);
			adatok[] Feldolgozott = new adatok[seged.Length - 10];
			for (int i = 0; i < Feldolgozott.Length; i++)
			{
				var Egysor = seged[i + 1].Trim().Split('\t');
				try
				{
					Feldolgozott[i] = new adatok
					{
						Kod = Egysor[0],
						Nev = Egysor[1],
						elmelet_1 = double.Parse(Egysor[2]),
						gyakorlat_1 = double.Parse(Egysor[3]),
						elmelet_2 = double.Parse(Egysor[4]),
						gyakorlat_2 = double.Parse(Egysor[5]),
					};
				}
				catch (Exception EX) { Console.WriteLine(EX.Message); }
			}
			return Feldolgozott;
		}
	}
}
