using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat4
{
    public class Lab02 // Jääkaapin tuotteet
    {
        public string Nimi { get; set; }
        public int Maara { get; set; }

        public Lab02 () { }
        public Lab02 (string nimi, int maara)
        {
            Nimi = nimi;
            Maara = maara;
        }

    }
    public class Jaakaappi // Jääkaappi
    {
        public List<Lab02> Tavarat { get; } // Koostetaan tavara-lista

        public bool OnkoPaalla { get; set; }
        public string Merkki { get; set; }
        public double asteet;
        public double Lampotila { get { return asteet; }
            set {
                asteet = value;

                if (asteet < 2 || asteet > 6)
                {
                    asteet = 1;
                    Console.WriteLine("Lämpötila virheellinen.");
                }
            }
        }
        public int tuoteLaskuri = 0;

        public Jaakaappi () { }

        public Jaakaappi (bool paalla, string merkki, double lampotila) {
            OnkoPaalla = paalla;
            Merkki = merkki;
            Lampotila = lampotila;
            Tavarat = new List<Lab02>();
        }

        public void LisaaTavara (Lab02 tavara)
        {
            Tavarat.Add(tavara);
            tuoteLaskuri += tavara.Maara;
            Console.WriteLine("\nLisätty {0} jääkaappiin. Määrä yhteensä: {1}", tavara.Nimi, tavara.Maara);
        }

        public override string ToString()
        {
            string tuloste = "Jääkaapin merkki: " + Merkki + " Lämpötila: " + Lampotila + " astetta.";
                foreach (Lab02 tavara in Tavarat)
            {
                tuloste += tavara.ToString();
            }
            return tuloste;
        }

    }
    public class TestaaToiminta
    {
        public static void TestaaJaakaappi ()
        {
            Jaakaappi jaakaappi = new Jaakaappi(true, "Rosenlew", 3);
            Console.WriteLine("\nLuotu uusi jääkaappi-olio: " + jaakaappi.ToString());

            if (jaakaappi.OnkoPaalla == true)
            {
                Console.WriteLine("Jääkaappi on päällä. Tavaroita voi lisätä.");

                // Lisätään tavaroita
                Lab02 tavara = new Lab02("Maito", 1);
                jaakaappi.LisaaTavara(tavara);

                jaakaappi.LisaaTavara(new Lab02("Juusto", 2));
                jaakaappi.LisaaTavara(new Lab02("Kurkku", 1));

                Console.WriteLine("\nTavaroita yhteensä jääkaapissa: " + jaakaappi.tuoteLaskuri + " kappaletta.");
            }

            jaakaappi.OnkoPaalla = false; // Testataan toimintaa

            if (jaakaappi.OnkoPaalla == false)
            {
                Console.WriteLine("Jääkaappi pois päältä. ");
                jaakaappi.Lampotila = 1; // jos pois päältä, lämpötila 1 ja virheilmoitus
            }

            jaakaappi.Lampotila = -4; // herjaa virheellistä lämpötilaa 
       
        }
    }
}
