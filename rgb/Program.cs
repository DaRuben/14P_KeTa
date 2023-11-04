using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace rgb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pixelek = Beolvas("kep.txt");
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(pixelek[i] + " ");
            }

            Console.Write("Kérem adja meg a sor számát: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg az oszlop számát: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());

            var eredmeny = pixelek.Skip(sor - 1).Select(x => pixelek[oszlop - 1]);
            Console.WriteLine("A keresett szám: " + eredmeny);

            Console.ReadKey();
        }
        /*
        static int[] Beker(int a, int b)
        {
                Console.Write("Kérem adja meg a sor számát: ");
                int sor = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kérem adja meg az oszlop számát: ");
                int oszlop = Convert.ToInt32(Console.ReadLine());

                int[] bekert = pixelek[rowNumber - 1].Split(' ').Select(int.Parse).ToArray();

                int szam = bekert[columnNumber - 1];
                Console.WriteLine($"A keresett szám: "+szam);
            }

        }*/

        static int[] Beolvas(string path)
        {
            return File.ReadAllText(path).Select(x => Convert.ToInt32(x)).ToArray();
        }
    }
}
