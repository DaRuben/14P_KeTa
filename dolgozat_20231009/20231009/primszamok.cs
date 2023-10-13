using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace _20231009
{
    internal class primszamok
    {

        public primszamok()
        {
            adatbazis DB = new adatbazis("server=localhost;database=primszamok;user=root;password=;");

            if (DB.SzamLekerdezes("SELECT COUNT(*) FROM primszam;") == "0")
            {
                List<int> szamok = elsoFutas();
                foreach (int sz in szamok)
                {
                    DB.DdlDml("INSERT INTO primszam VALUES (" + sz + ")");
                }
            }
        }

        public List<int> elsoFutas()
        {
            List<int> primszamok100ig = new List<int>();
            for (int i = 2; i < 100; i++)
            {
                bool primszamE = true;
                double gyok = Math.Round(Math.Sqrt(i));
                for (int j = 2; j <= gyok; j++)
                {
                    if (i % j == 0)
                    {
                        primszamE = false;
                        break;
                    }
                }
                if (primszamE)
                {
                    primszamok100ig.Add(i);
                }
            }
            return primszamok100ig;
        }

        public string primSzamMegallapit(double bekertSzam)
        {
            double gyok = Math.Round(Math.Sqrt(bekertSzam));
            bool primszamE = false;

            for (int i = 2; i <= gyok; i++)
            {
                if (bekertSzam < 2 || bekertSzam % i == 0)
                {
                    primszamE = true;
                }
            }

            if (primszamE)
            {
                return "Nem prímszám";
            }
            else
            {
                return "Prímszám";
            }

        }

        public List<int> bekertSzamigMegallapit(double bekertSzam)
        {
            List<int> bekertSzamig = new List<int>();

            for (int i = 2; i <= bekertSzam; i++)
            {
                bool primszamE = true;
                double gyok = Math.Round(Math.Sqrt(i));
                for (int j = 2; j <= gyok; j++)
                {
                    if (i % j == 0)
                    {
                        primszamE = false;
                        break;
                    }
                }
                if (primszamE)
                {
                    bekertSzamig.Add(i);
                }
            }
            return bekertSzamig;
        }
    }
}
