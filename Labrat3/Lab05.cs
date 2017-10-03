using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab05
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int Vuosi { get; set; }
        public string Vari { get; set; }

        public Lab05()
        {
        }
        public Lab05(string nimi, string malli, int vuosi, string vari)
        {
            Nimi = nimi;
            Malli = malli;
            Vuosi = vuosi;
            Vari = vari;
        }

        public void TulostaTiedot()
        {
            //Console.WriteLine("Pyörä info: ");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Malli: " + Malli);
            Console.WriteLine("Vuosimalli: " + Vuosi);
            Console.WriteLine("Väri: " + Vari);
        }

        public override string ToString()
        {
            return " " + Nimi + " " + Malli + " " + Vuosi + " " + Vari;
        }
    }
    public class Pyora : Lab05 // Periytyminen Lab-luokasta
    {
        public bool Vaihteet { get; set; }
        public string VaihdeNimi { get; set; }

        public Pyora(string nimi, string malli, int vuosi, string vari, bool vaihteet, string vaihde)
              : base(nimi, malli, vuosi, vari)
        {
              Vaihteet = vaihteet;
              VaihdeNimi = vaihde;
        }

        public void TulostaTiedot()
        {
                Console.WriteLine("\nPyörän tiedot: ");
                Console.WriteLine("Nimi: " + Nimi);
                Console.WriteLine("Malli: " + Malli);
                Console.WriteLine("Vuosimalli: " + Vuosi);
                Console.WriteLine("Väri: " + Vari);
                Console.WriteLine("Vaihteisto: " + Vaihteet);
                Console.WriteLine("Vaihteiden nimi: " + VaihdeNimi);
         }

         public override string ToString()
         {
            return " " + Vaihteet + " " + VaihdeNimi;
         }      
    }
    public class Vene : Lab05 // Periytyminen Lab-luokasta
    {
        public string Tyyppi { get; set; }
        public int Paikat { get; set; }

        public Vene(string nimi, string malli, int vuosi, string vari, string tyyppi, int paikat)
              : base(nimi, malli, vuosi, vari)
        {
            Tyyppi = tyyppi;
            Paikat = paikat;
        }

        public void TulostaTiedot()
        {
            Console.WriteLine("\nPyörän tiedot: ");
            Console.WriteLine("Nimi: " + Nimi);
            Console.WriteLine("Malli: " + Malli);
            Console.WriteLine("Vuosimalli: " + Vuosi);
            Console.WriteLine("Väri: " + Vari);
            Console.WriteLine("Tyyppi: " + Tyyppi);
            Console.WriteLine("Paikkamäärä: " + Paikat);
        }

        public override string ToString()
        {
            return " " + Tyyppi + " " + Paikat;
        }
    }
    class TestaaTiedot
    {
        public static void TestaaToiminta()
        {
            Lab05 testi = new Lab05("Väline", "Merkki", 1995, "sininen"); // testataan perusluokkaa
            testi.TulostaTiedot();
            testi.ToString();

            Pyora pyora = new Pyora("Pyörä", "Tunturi", 1995, "Sininen", true, "jokuMerkki");
            pyora.TulostaTiedot();
            pyora.ToString();

            pyora.Vaihteet = false;
            pyora.VaihdeNimi = "";

            pyora.TulostaTiedot();
            pyora.ToString();

            Vene vene = new Vene("Titanic", "JokuMalli", 1800, "Valkoinen", "Laiva", 5000);
            vene.TulostaTiedot();
            vene.ToString();

            vene.Nimi = "Vesipeto";
            vene.Vuosi = 1999;
            vene.Tyyppi = "Vene";
            vene.Paikat = 4;

            vene.TulostaTiedot();
            vene.ToString();
        }
    }

}
