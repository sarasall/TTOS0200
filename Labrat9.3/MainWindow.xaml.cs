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

namespace Labrat9._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> numerot;     

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bValitseRivit_Click(object sender, RoutedEventArgs e)
        {
            int rivit = int.Parse(txtbRivienLkm.Text); 
            string value = cmbValinta.SelectedValue.ToString();
            string tulos = "";
            

            for (int i = 0; i < rivit; i++)
            {
                if (value == "Lotto")
                {
                    Lotto lotto = new Lotto(40, 7);
                    tulos += (numerot.ToString() + "\n");
                }
                else if (value == "VikingLotto")
                {
                    Lotto vikinglotto = new Lotto(48, 6);
                    tulos += (numerot.ToString() + "\n");
                }
                else if (value == "EuroJackpot")
                {
                    Lotto eurojackpot = new Lotto(50, 5);
                    tulos += (numerot.ToString() + "\n");
                } 
            }
            txtbNaytaNrot.Text = tulos;
        }

        private void bTyhjenna_Click(object sender, RoutedEventArgs e)
        {
            txtbNaytaNrot.Text = "";
        }
    }
}
