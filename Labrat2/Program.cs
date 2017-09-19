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

            //TestaaKiuas(); 
            //TestaaPesukone(); 
            //TestaaTelevisio();
            //TestaaVehicle();
            TestaaCD();
        }
        
        static void TestaaKiuas()
        {
            Kiuas kiuas = new Kiuas(); // luodaan uusi kiuas-olio

            kiuas.OnkoPaalla = true; // Laitetaan kiuas päälle
            kiuas.Lampotila = 100; // Laitetaan saunan lämpötila 100 asteeseen
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
        static void TestaaTelevisio()
        {
            Televisio televisio = new Televisio(); // Luodaan uusi olio

            televisio.OnkoPaalla = true; // Televisio päälle
            televisio.Kanava = 7;
            televisio.Aanenvoimakkuus = 20;  

            Console.WriteLine("Onko televisio päällä? = " + televisio.OnkoPaalla);
            Console.WriteLine("Katsot kanavaa: " + televisio.Kanava);
            Console.WriteLine("Valitse äänenvoimakkuus 1-50: " );
            televisio.Aanenvoimakkuus = int.Parse(Console.ReadLine());

            Console.WriteLine("\nÄänenvoimakkuus on: " + televisio.Aanenvoimakkuus);
        }
        static void TestaaVehicle()
        {
            Vehicle vehicle = new Vehicle("Lada", 80, 4); // konstruktorin ansioista voi suoraan määritellä arvot
            Vehicle vehicle2 = new Vehicle("Volvo", 120, 4);
            Vehicle vehicle3 = new Vehicle("Saab", 100, 4);

                vehicle.PrintData();
                vehicle.ToString();

                Console.WriteLine();
                vehicle2.PrintData();
                vehicle2.ToString();

                Console.WriteLine();
                vehicle3.PrintData();
                vehicle3.ToString();
                Console.WriteLine();
        }
        static void TestaaCD()
        {
            // olioiden luonti
            CD cd = new CD();
            CD cd1 = new CD("Weak Fantasy", "05:23");
            CD cd2 = new CD("Elan", "06:29");
            CD cd3 = new CD("Yours Is an Empty Hope", "04:45");
            CD cd4 = new CD("Our Decades in the Sun", "05:34");
            CD cd5 = new CD("My Walden", "06:29");
            CD cd6 = new CD("Endless Forms Most Beautiful", "06:03");

            // Tulostetaan ominaisuuksien merkkijono
            cd.TulostaOminaisuudet(); 
            cd.ToString();

            // Tulostetaan lyhennetty kappalelista
            cd1.TulostaKappaleet();
            cd2.TulostaKappaleet();
            cd3.TulostaKappaleet();
            cd4.TulostaKappaleet();
            cd5.TulostaKappaleet();
            cd6.TulostaKappaleet();
        }
    }
}
