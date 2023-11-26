using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_szimulacio
{
    
    internal class autok
    {
        string nev;
        int penz, benzintank;
        double fogyasztas, tankbanBenzin;
        public string Nev { get => nev; set => nev = value; }
        public int Penz { get => penz; set => penz = value; }
        public int Benzintank { get => benzintank; set => benzintank = value; }
        public double Fogyasztas { get => fogyasztas; set => fogyasztas = value; }
        public double TankbanBenzin { get => tankbanBenzin; set => tankbanBenzin = value; }

        public autok(string nev, int penz, int benzintank, double fogyasztas, double tankbanBenzin)
        {
            this.nev = nev;
            this.penz = penz;
            this.benzintank = benzintank;
            this.fogyasztas = fogyasztas;
            this.tankbanBenzin = tankbanBenzin;
        }
        public bool KellETankolni(int tav, int ar, int menny)
        {
            double fogyOssz = fogyasztas * tav;
            double tankolMenny = 0;
            double fizet = 0;

            if (fogyOssz < tankbanBenzin)
            {
                tankolMenny = tankbanBenzin - fogyOssz;
                fizet = ar * tankolMenny;
            }
            if (penz > 0 && tankbanBenzin > 0 && tankbanBenzin > fogyOssz && fizet < penz && tankolMenny < menny)
            {
                return true;
            }
            else
            {
                return false;
            }

            

        }
    }
}
