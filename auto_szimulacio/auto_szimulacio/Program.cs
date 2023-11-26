using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_szimulacio
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<autok> autokLista = new List<autok>();
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("Kérem adja meg a(z) "+ i +". autó nevét: ");
                string nev = Console.ReadLine();
                Console.WriteLine("Kérem adja meg a(z) "+ i +". sofőrnél lévő pénzmennyiséget: ");
                int penz= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem adja meg mekkora a(z) "+ i +". autó benzintankja: ");
                int tank = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kérem adja meg mekkora a(z) "+ i +". autó fogyasztasa: ");
                double fogyasztas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kérem adja meg mennyi benzin van a(z) "+ i +". autóban: ");
                double tankbanBenzin = Convert.ToDouble(Console.ReadLine());

                autok a = new autok(nev, penz, tank, fogyasztas, tankbanBenzin);
                autokLista.Add(a);
            }

            Console.WriteLine("Kérem adja meg a benzinkúton lévő benzin mennyiségét: ");
            int benzinMenny = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adja meg mennyi a benzin ára (literenként): ");
            int benzinAr = Convert.ToInt32(Console.ReadLine());

            benzinkut bk = new benzinkut(benzinMenny, benzinAr, 0);

            Random r = new Random();
            int tav =  r.Next(300);



            for (int i = 0; i < 10; i++)
            {
                if (autokLista[0].KellETankolni(tav, bk.BenzinAr, bk.BenzinMenny))
                {
                    Console.WriteLine("Autó: " + autokLista[0].Nev + " nem állt meg");
                }
                else
                {
                    Console.WriteLine("Autó: " + autokLista[0].Nev + " megállt");
                    break;
                }
            }

           


            Console.ReadKey();
        }
    }
}
