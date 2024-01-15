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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace palindrom_hf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hossz;
        string szam_string;

        public MainWindow()
        {
            InitializeComponent();
        }

        public bool PalindromEldont(int n)
        {
            szam_string = n.ToString();
            hossz = szam_string.Length;
            for (int i = 0; i < hossz / 2; i++)
            {
                if (szam_string[i] != szam_string[hossz - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            string be = n_bevitel.Text;
            if (int.TryParse(be, out int n))
            {
                if (n > 0 && n <= 10000)
                {
                    for (int i = 1; i < n; i++)
                    {
                        if (PalindromEldont(i))
                        {
                            LB1.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("0 és 10000 közötti számot adjon meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Nem számot adott meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void B1_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
