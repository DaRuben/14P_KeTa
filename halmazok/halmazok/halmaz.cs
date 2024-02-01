using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace halmazok
{
    internal class halmaz
    {
        public halmaz()
        {

        }

        public List<int> Unio(HashSet<int> h1, HashSet<int> h2)
        {
            List<int> unio = new List<int>();
            List<int> h1Lista = new List<int>();
            List<int> h2Lista = new List<int>();

            h1Lista = h1.ToList();
            h2Lista = h2.ToList();
            bool van = false;

            for (int i = 0; i < h1.Count; i++)
            {
                unio.Add(h1Lista[i]);
            }
            for (int i = 0; i < h2.Count; i++)
            {
                for (int j = 0; j < unio.Count; j++)
                {
                    if (h2Lista[i] == unio[j])
                    {
                        van = true;
                    }
                }
                if (!van)
                {
                    unio.Add(h2Lista[i]);
                }
            }
            return unio;
        }

        public List<int> Metszet(HashSet<int> h1, HashSet<int> h2)
        {
            List<int> metszet = new List<int>();
            List<int> h1Lista = new List<int>();
            List<int> h2Lista = new List<int>();

            h1Lista = h1.ToList();
            h2Lista = h2.ToList();
            for (int i = 0; i < h1Lista.Count; i++)
            {
                for (int j = 0; j < h2Lista.Count; j++)
                {
                    if (h1Lista[i] == h2Lista[j])
                    {
                        metszet.Add(h1Lista[i]);
                    }
                }
            }
            return metszet;
        }

    }
}
