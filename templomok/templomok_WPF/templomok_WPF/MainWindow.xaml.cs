using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace templomok_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szamlalo = 0;
        string[] kep_nevek = new string[] { "Belapatfalva.jpg", "Jak.jpg", "Kaposszentjakab.jpg", "Lebeny.jpg", "Lonya.jpg", "Ocsa.jpg", "Pannonhalma.jpg", "Szeged.jpg", "Tarnaszentmaria.jpg", "Turje.jpg" };

        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void vissza_Click(object sender, RoutedEventArgs e)
        {
            
        }
        

        
        private void elore_Click(object sender, RoutedEventArgs e)
        {
            szamlalo++;
            if (szamlalo < 10) { megjelenit(); }
           
        }
        public void megjelenit()
        {
            for (int i = 0; i < kep_nevek.Length; i++)
            {
                templom_kep.Source = (new ImageSourceConverter()).ConvertFromString("kepek/" + kep_nevek[i]) as ImageSource;
            }

            StreamReader sr = new StreamReader("mt9k.txt");
            string sz = sr.ReadToEnd().Replace(Environment.NewLine, " ");
            string[] leirasok = sz.Split(';');

            for (int i = 0; i < sz.Length; i++)
            {
                if (i == szamlalo)
                {
                    leiras.Content = leirasok[2] + ", " + leirasok[0] + ", " + leirasok[1] + ".";
                }
            }
        }
    }
}
