using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munkavallalok
{
    internal class munkavallalo
    {
        private string nev;
        private int fizKat, evesSzabi, eddigKivettSzabi;
        private int[] t = {1,2,3,4,5};

        public string Nev { get => nev; set => nev = value; }
        public int FizKat { get => fizKat; set => fizKat = value; }
        public int EddigKivettSzabi { get => eddigKivettSzabi; set => eddigKivettSzabi = value; }


        public munkavallalo(string nev, int fizKat, int eddigKivettSzabi)
        {
            this.nev = nev;
            this.fizKat = fizKat;
            this.eddigKivettSzabi = eddigKivettSzabi;
        }
        public munkavallalo(string nev, int fizKat, int evesSzabi, int eddigKivettSzabi)
        {
            this.nev = nev;
            this.fizKat = fizKat;
            this.evesSzabi = evesSzabi;
            this.eddigKivettSzabi = eddigKivettSzabi;
        }


        public int KivehetoSzabi()
        {
            int maradt = 0;
            if (evesSzabi > 0)
            {
                maradt = evesSzabi - eddigKivettSzabi;
                return maradt;
            }
            else
            {
                evesSzabi = 30;
                maradt = evesSzabi - eddigKivettSzabi;
                return maradt;
            }
        }

    }
}
