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
using JAMK.IT; // Lisätään nimiavaruus, että autot-listaa voidaan käyttää

namespace VKO46Autotalli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Auto> autot; // Muuttuja on käytettävissä kaikissa tämän luokan metodeissa ja tapahtumankäsittelijöissä
        private const string polku = @"d:\\K8500\Kuvat\";
        public MainWindow()
        {
            // Tänne koodi, mikä suoritetaan ikkunen avauksen luonnissa
            InitializeComponent();
            NaytaKuva("autotalli.png");
            // Pyydetään BL-kerrokselta autot ja näytetään ne käyttäjälle
            autot = Autotalli.HaeAutot(); //kutsutaan staattisen Autotalli-luokan staattista metodia
            // Vaihtoehto 1 käsin koodaamalla
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
           
            // Vaihtoehto 2: Kysytään LiNG:lla datasta eri automerkit
            var result = autot.Select(m => m.Merkki).Distinct();
            cmbAutot.ItemsSource = result;
        }

        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            NaytaKuva("autotalli.png");
            dgAutot.ItemsSource = autot;
        }
        private void NaytaKuva (string url) // Parametrina kuva, mistä url lähetetään
        {
            try
            {
                if (string.IsNullOrEmpty(url))
                {
                    url = "puuttuu.png";
                }
                url = polku + url; // Lisätään kuvatiedostojen vakiopolku
                                   // Kuvan näyttäminen
                BitmapImage pic = new BitmapImage(); // Luodaan olio
                pic.BeginInit(); //Alustetaan
                pic.UriSource = new Uri(url); // Muutetaan url resurssiosoitteeksi
                pic.EndInit(); // Lopetetaan lataaminen
                imgAuto.Stretch = Stretch.Fill; // Täyttää koko kuvan 
                imgAuto.Source = pic; // Asetetaan pic sourceksi
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Huom, olemme itse populoineet DataGridin Auto-olioilla, joten kukin DataGridin jäsen/alkio on itseasiassa Auto-olio
            object obj = dgAutot.SelectedItem; // Viittaa valittuun olioon object-luokasta
            if (obj != null)
            {
                Auto valittu = (Auto)obj; // Castaaminen, muutetaan luokka toiseen tyyppiin 
                NaytaKuva(valittu.URL);
            }
        }

        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            //Näkyviin pelkästään Audi-merkkiset autot
            var result = autot.Where(m => m.Merkki.Contains("Audi")); //var on muuttuva muuttujatyyppi 
            dgAutot.ItemsSource = result;
        }

        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Suodatetaan DataGridiin näkyviin vai valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(m => m.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
            NaytaKuva("autotalli.png");
        }
    }
}
