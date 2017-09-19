using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat2
{
    class CD
    {
        public string Artisti { get; set; }
        public string LevynNimi { get; set; }
        public string KappaleenNimi { get; set; }
        public string KappaleenKesto { get; set; }
        public double Hinta { get; set; }

        public CD() //Oletustiedot
        {
            Artisti = "Nightwish";
            LevynNimi = "Endless Forms Most Beautiful";
            Hinta = 19.90;
         }
        public CD (string kappale, string kesto)
        {
            KappaleenNimi = kappale;
            KappaleenKesto = kesto;     
        }
        public void TulostaOminaisuudet ()
        {
            Console.WriteLine("Esittäjä: " + Artisti);
            Console.WriteLine("Levyn nimi: " + LevynNimi);
            Console.WriteLine("Hinta: " + Hinta + " e");
        }
        public string ToString()
        {
            string cdString = Artisti + " " + LevynNimi + " " + Hinta + "";

            return cdString;
        }
        public void TulostaKappaleet()
        {
            Console.Write("Kappaleen nimi: " + KappaleenNimi);
            Console.WriteLine(" - " + KappaleenKesto);
        }
    }
}
