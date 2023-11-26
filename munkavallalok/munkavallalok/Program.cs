using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munkavallalok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            munkavallalo mv = new munkavallalo("Kovács Béla", 2, 10);
            int sz = mv.KivehetoSzabi();
            Console.WriteLine("Kivehető szabadnapok száma: "+sz);

            Console.ReadKey();
        }
    }
}
