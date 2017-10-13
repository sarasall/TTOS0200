using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CD
    {
        #region PROPERTIES
        public string Artisti { get; set; }
        public string LevynNimi { get; set; }
        public string KappaleenNimi { get; set; }
        #endregion

        #region CONSTRUCTORS
        public CD() { }

        public CD(string artisti, string levynnimi)
        {
            Artisti = artisti;
            LevynNimi = levynnimi;
        }
        public CD(string kappale)
        {
            KappaleenNimi = kappale;
        }
        #endregion

        #region METHODS
        public void TulostaTiedot()
        {
            Console.WriteLine("- Esittäjä: " + Artisti);
            Console.WriteLine("- Levyn nimi: " + LevynNimi);
        }
        public string ToString()
        {
            return " " + Artisti + " " + LevynNimi;
        }
        public string TulostaKappaleet(string kappaleet)
        {
            kappaleet = "   -" + KappaleenNimi;
            return kappaleet;
        }
        #endregion
    }
    public class TestaaCD
    {
        public static void Testaa()
        {
            List<CD> kappalelista = new List<CD>(); // Luodaan lista kappaleita varten

            CD nightwish = new CD("Nightwish", "Endless Forms Most Beautiful"); // uusi cd-olio

            kappalelista.Add(new CD("Shudder Before the Beautiful 6:29")); // Lisätään kappaleet listaan
            kappalelista.Add(new CD("Weak Fantasy 5:23"));
            kappalelista.Add(new CD("Elan 4:45"));
            kappalelista.Add(new CD("Yours Is an Empty Hope 5:34"));
            kappalelista.Add(new CD("Our Decades in the Sun 6:37"));
            kappalelista.Add(new CD("My Walden 4:38"));
            kappalelista.Add(new CD("Endless Forms Most Beautiful 5:07"));
            kappalelista.Add(new CD("Edema Ruh 5:15"));
            kappalelista.Add(new CD("Alpenglow 4:45"));
            kappalelista.Add(new CD("The Eyes of Sharbat Gula 6:03"));
            kappalelista.Add(new CD("The Greatest Show on Earth 24:00"));

            // Tulostetaan tiedot
            Console.WriteLine("CD:n tiedot:");
            nightwish.ToString();
            nightwish.TulostaTiedot();

            Console.WriteLine("- Kappaleet:");

            foreach (var x in kappalelista) // loopataan kappalelista läpi 
            {
                Console.WriteLine(x.TulostaKappaleet(""));
            }
        }
    }
}
