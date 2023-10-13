using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodol
{
    internal class kodolas
    {
        string nyiltSzoveg, nyiltSzovegMegad,  kulcs, ujSzoveg;

        public kodolas(string K)
        {
            nyiltSzovegMegad = K;
        }
        public string szovegAtalakit(string szoveg)
        {
            for (int i = 0; i < szoveg.Length; i++)
            {
                switch (szoveg[i])
                {
                    case ' ': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case ',': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case '.': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case '?': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case '!': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case ';': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case ':': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case '-': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case '_': szoveg = szoveg.Replace(szoveg[i].ToString(), ""); break;
                    case 'á': szoveg = szoveg.Replace(szoveg[i].ToString(), "a"); break;
                    case 'é': szoveg = szoveg.Replace(szoveg[i].ToString(), "e"); break;
                    case 'í': szoveg = szoveg.Replace(szoveg[i].ToString(), "i"); break;
                    case 'ó': szoveg = szoveg.Replace(szoveg[i].ToString(), "o"); break;
                    case 'ö': szoveg = szoveg.Replace(szoveg[i].ToString(), "o"); break;
                    case 'ő': szoveg = szoveg.Replace(szoveg[i].ToString(), "o"); break;
                    case 'ú': szoveg = szoveg.Replace(szoveg[i].ToString(), "u"); break;
                    case 'ü': szoveg = szoveg.Replace(szoveg[i].ToString(), "u"); break;
                    case 'ű': szoveg = szoveg.Replace(szoveg[i].ToString(), "u"); break;
                }
            }
            ujSzoveg = szoveg.ToUpper();

            return ujSzoveg;
        }
      /*  public string kulcsszoHosszabit(string nysz, string kszo)
        {
            int hossz = nysz.Length;

        }*/

        

    }
}
