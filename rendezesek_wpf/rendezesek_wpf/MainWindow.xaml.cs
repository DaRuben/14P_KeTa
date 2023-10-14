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

namespace rendezesek_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] A_tomb;
        List<int> randomSzamok, rendezettSzamok;
        static Random R;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void egyszeru_Click(object sender, RoutedEventArgs e)
        {
            EgyszeruCseresRendezes egysz = new EgyszeruCseresRendezes();
            egysz.Show();
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
        

    }
}
