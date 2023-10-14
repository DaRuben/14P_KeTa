using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace rendezesek_wpf
{
    /// <summary>
    /// Interaction logic for EgyszeruCseresRendezes.xaml
    /// </summary>
    public partial class EgyszeruCseresRendezes : Window
    {
        List<int> randomSzamok, rendezettSzamok;
        static Random R;

        public EgyszeruCseresRendezes()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int db = Int32.Parse(t1.Text);
            R = new Random();
            int szam;
            randomSzamok = new List<int>();
            for (int i = 0; i < db; i++)
            {
                szam = R.Next(101);
                lb1.Items.Add(szam);
                randomSzamok.Add(szam);
            }
        }

        private void egyszeru_Click(object sender, RoutedEventArgs e)
        {
            EgyszeruCseresRendezes egyszeru = new EgyszeruCseresRendezes();
            egyszeru.Show();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            int[] randomSzamokTomb = randomSzamok.ToArray();
            int[] egyszeru = Egyszeru_Cseres(randomSzamokTomb);
            rendezettSzamok = new List<int>();

            int szam = 0;
            for (int i = 0; i < egyszeru.Length; i++)
            {
                szam = egyszeru[i];
                lb2.Items.Add(szam);
                rendezettSzamok.Add(szam);
            }
        }

        private void buborek_Click(object sender, RoutedEventArgs e)
        {
            BuborekRendezes buborek = new BuborekRendezes();
            buborek.Show();
        }

        private void minMax_Click(object sender, RoutedEventArgs e)
        {
            MinMaxRendezes minMax = new MinMaxRendezes();
            minMax.Show();
        }

        private void shell_Click(object sender, RoutedEventArgs e)
        {
            ShellBeszuroRendezes shell = new ShellBeszuroRendezes();
            shell.Show();
        }

        public int[] Egyszeru_Cseres(int[] A_tomb)
        {
            int csere = 0;
            for (int i = 0; i < A_tomb.Length - 1; i++)
            {
                for (int j = i + 1; j < A_tomb.Length; j++)
                {
                    if (A_tomb[i] > A_tomb[j])
                    {
                        csere = A_tomb[i];
                        A_tomb[i] = A_tomb[j];
                        A_tomb[j] = csere;
                    }
                }
            }
            return A_tomb;
        }

        public int[] Buborek(int[] A_tomb)
        {
            int csere = 0;
            for (int i = A_tomb.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (A_tomb[j] > A_tomb[j + 1])
                    {
                        csere = A_tomb[j];
                        A_tomb[j] = A_tomb[j + 1];
                        A_tomb[j + 1] = csere;
                    }
                }
            }
            return A_tomb;
        }

        public int[] MinMax(int[] A_tomb)
        {
            int csere = 0, akt_index = 0;
            for (int i = 0; i < A_tomb.Length - 1; i++)
            {
                akt_index = i;
                for (int j = i + 1; j < A_tomb.Length; j++)
                {
                    if (A_tomb[akt_index] > A_tomb[j]) akt_index = j;
                }
                csere = A_tomb[i];
                A_tomb[i] = A_tomb[akt_index];
                A_tomb[akt_index] = csere;
            }
            return A_tomb;
        }


        public int[] Shell(int[] A_tomb)
        {
            int csere = 0, tavolsag = A_tomb.Length / 3, j = 0;
            while (tavolsag > 0)
            {
                for (int i = 0; i < A_tomb.Length; i++)
                {
                    j = i;
                    csere = A_tomb[i];
                    while (j >= tavolsag && A_tomb[j - tavolsag] > csere)
                    {
                        A_tomb[j] = A_tomb[j - tavolsag];
                        j = j - tavolsag;
                    }
                    A_tomb[j] = csere;
                }
                if (tavolsag / 2 != 0) tavolsag = tavolsag / 2;
                else if (tavolsag == 1) tavolsag = 0;
                else tavolsag = 1;
            }
            return A_tomb;
        }

        private void b1_MouseEnter(object sender, MouseEventArgs e)
        {

        }



    }
}
