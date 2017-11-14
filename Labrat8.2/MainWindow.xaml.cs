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

namespace Labrat8._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtSumma_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double osto, myynti;
                bool syote = double.TryParse(txtSumma.Text, out osto);

                if (syote == true)
                {
                    if (combobValinta.SelectedItem == usValinta)
                    {
                        myynti = osto * 0.8997;
                        txtbTulos.Text = myynti.ToString("0.00") + " euroa";
                    }
                    else if (combobValinta.SelectedItem == eurValinta)
                    {
                        myynti = osto / 0.8997;
                        txtbTulos.Text = myynti.ToString("0.00") + " dollaria";
                    }
                }
                else
                {
                    txtError.Text = "Virheellinen syöte!";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
