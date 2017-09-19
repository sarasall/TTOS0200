using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat2
{
    class Program
    {
        static void Main(string[] args)
        {

            //TestaaKiuas(); // Testataan kiukaan toimintaa testaus-metodilla
            TestaaPesukone(); // Testataan pesukone
        }
        
        static void TestaaKiuas()
        {
            Kiuas kiuas = new Kiuas(); // luodaan uusi kiuas-olio

            kiuas.OnkoPaalla = true; // Laitetaan kiuas päälle
            kiuas.Lampotila = 100; // Laitetaan saunan lämpötila 80 asteeseen
            kiuas.Kosteus = 70; // Kosteustaso 70 

            Console.WriteLine("Onko kiuas päällä? = " + kiuas.OnkoPaalla);
            Console.WriteLine("Lampotila: " + kiuas.Lampotila + " celsiusta.");
            Console.WriteLine("Kosteustaso: " + kiuas.Kosteus);

            kiuas.OnkoPaalla = false; // Kiuas pois päältä
            kiuas.Lampotila = 200; 
            kiuas.Kosteus = 150; 

            Console.WriteLine("\nOnko kiuas päällä? = " + kiuas.OnkoPaalla);
            Console.WriteLine("Lampotila: " + kiuas.Lampotila + " celsiusta.");
            Console.WriteLine("Kosteustaso: " + kiuas.Kosteus);
        }
         static void TestaaPesukone()
        {
            Pesukone pesukone = new Pesukone(); // luodaan olio
            string valinta = "";

            do {

                Console.WriteLine("\nIlmoita pesuohjelman lämpötila: ");
                pesukone.Lampotila = int.Parse(Console.ReadLine());

                Console.WriteLine("Ilmoita kierrosluvut: ");
                pesukone.Kierrokset = int.Parse(Console.ReadLine());

                Console.WriteLine("Käynnistetäänkö pesukone? Valitse k/e. "); 
                valinta = Console.ReadLine();

                if (valinta == "k")
                {
                    pesukone.OnkoPaalla = true;
                    Console.WriteLine("\nPesukone päällä. ");
                }
                if (valinta == "e")
                {
                    pesukone.OnkoPaalla = false; 
                    Console.WriteLine("\nPesukone pois päältä. ");
                }
            } while (valinta != "k");

            Console.WriteLine("\nPesuohjelman tiedot: ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Lampotila: " + pesukone.Lampotila + " celsiusta.");
            Console.WriteLine("Kierrosten määrä: " + pesukone.Kierrokset);

            // Testataan konstruktoreita

            Console.WriteLine("Pesuohjelman 1. nimi: " + pesukone.Ohjelma); // tulostetaan oletus, eli peruspesu

            pesukone.Ohjelma = "Kirjopesu ";
            Console.WriteLine("Pesuohjelman 2. nimi: " + pesukone.Ohjelma);
            pesukone.Ohjelma = "Siliävät vaatteet";
            Console.WriteLine("Pesuohjelman 3. nimi: " + pesukone.Ohjelma);

            Console.WriteLine("Tarkistus onko vedentulo päällä: " + pesukone.VesiPaalla); // Oletuksena määritelty kiinni, testataan
        }
    }
}
