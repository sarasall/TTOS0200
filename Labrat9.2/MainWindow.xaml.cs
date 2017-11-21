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
using JAMK.IT;

namespace Labrat9._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Pelaaja> pelaajat;

        public MainWindow()
        {
            pelaajat = Joukkue.HaePelaajat();
            InitializeComponent();    
        }
        private void bHaePelaajat_Click(object sender, RoutedEventArgs e)
        {
            dgPelaajat.ItemsSource = pelaajat;
        }
    }
}
