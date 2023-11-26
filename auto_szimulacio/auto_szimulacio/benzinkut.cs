using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_szimulacio
{
    internal class benzinkut
    {
        int benzinAr, benzinMenny, kassza;
        
        public int BenzinAr { get => benzinAr; set => benzinAr = value; }
        public int BenzinMenny { get => benzinMenny; set => benzinMenny = value; }
        public int Kassza { get => kassza; set => kassza = value; }
        public benzinkut(int benzinAr, int benzinMenny, int kassza)
        {
            this.benzinAr = benzinAr;
            this.benzinMenny = benzinMenny;
            this.kassza = kassza;
        }

        
    }
}
