using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace szinozon2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kiir();
            Console.ReadLine();
        }
        static void kiir()
        {
            string felirat1 = "színek megadása - m";
            string felirat2 = "színözön játék indítása - j";
            string felirat3 = "kilépés - k";
            string felirat4 = "----------------------------";
            Console.WriteLine(felirat1);
            Console.WriteLine(felirat2);
            Console.WriteLine(felirat3);
            Console.WriteLine(felirat4);

            string bekert = Console.ReadLine();
            switch (bekert)
            {
                case "m": szinekTxt(); break;
                case "j": jatekIndit(); break;
                case "k": Environment.Exit(0); break;
            }
        }

        static void szinekTxt()
        {
            string felirat1 = "Válasszon 6 darab színt: Magenta\nCyan\nRed\nBlue\nYellow\nGreen\nBlack\nWhite";
            string felirat2 = "Írja be a választott színt, angolul, nagy kezdőbetűvel";
            Console.WriteLine(felirat1);
            Console.WriteLine(felirat2);

            List<string> szinek = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                string beSzin = Console.ReadLine();
                if (!szinek.Contains(beSzin))
                {
                    if (beSzin == "Black")
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        if (Enum.TryParse(beSzin, out ConsoleColor sz))
                        {
                            Console.ForegroundColor = sz;
                        }
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(felirat2);
                    szinek.Add(beSzin);
                }
                else
                {
                    Console.WriteLine("Ezt a színt már megadta!");
                }
            }
            if(szinek.Count == 6)
            {
                string szinekOsszefuzve = "";
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                foreach (var sz in szinek)
                {
                    szinekOsszefuzve += sz + " ";
                }

                StreamWriter sw = new StreamWriter("../../../../szinek.txt");
                sw.WriteLine(szinekOsszefuzve);
                sw.Close();
                Console.WriteLine("Fájlba írás megtörtént");
                kiir();
            }
        }
        static void jatekIndit()
        {
            string utvonal = @"..\..\..\..\..\szinozon\szinozon\bin\Debug\szinozon.exe";
            System.Diagnostics.Process.Start(utvonal);
            kiir();
        }

    }
}
