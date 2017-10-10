using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat4
{
    public class Lab01 // Renkaat
    {
        public string Merkki { get; set; }
        public string Tyyppi { get; set; }
        public string Koko { get; set; }

        public Lab01 () { } 

        public Lab01(string merkki, string tyyppi, string koko)
        {
            Merkki = merkki;
            Tyyppi = tyyppi;
            Koko = koko;
        }
        public override string ToString()
        {
            return "\nMerkki: " + Merkki + " Tyyppi: " + Tyyppi + " Koko: " + Koko;
        }
    }
    public class Kulkuneuvo
    {
        public List <Lab01> Renkaat {get;} // Koostetaan lista object-luokasta

        public string Nimi { get; set; }
        public string Malli { get; set; }
        private int RengasLaskuri = 0; // Laskuri lähtee nollasta

        public Kulkuneuvo(string nimi, string malli) {
            Nimi = nimi;
            Malli = malli;
            Renkaat = new List<Lab01>();
        }

        public void LisaaRengas(Lab01 rengas)
        {
            Renkaat.Add(rengas);
            RengasLaskuri++;
            Console.WriteLine("Lisätty {0} rengas nro {1} kulkuneuvoon: {2} ", rengas.Merkki, RengasLaskuri, Nimi);
        }

        public override string ToString()
        {
            string tuloste = "\nKulkuneuvo: " + Nimi + " Malli: " + Malli + " \nRenkaat: ";

            foreach (Lab01 rengas in Renkaat) // loopataan lista läpi
            {
                tuloste += rengas.ToString();
            }
            return tuloste;
        }

    }
    public class TestaaKulkuneuvot
    {
        public static void TestaaToimivuus()
        {
            Kulkuneuvo auto = new Kulkuneuvo("Porsche", "85256");
            Console.WriteLine("Luotu uusi kulkuneuvo: {0} ", auto.ToString());

            Lab01 rengas = new Lab01("Nokia", "Hakkapeliitta", "205R16"); // luodaan rengas-olio
            auto.LisaaRengas(rengas); // Lisätään neljä rengasta
            auto.LisaaRengas(rengas);
            auto.LisaaRengas(rengas);
            auto.LisaaRengas(rengas);
            Console.WriteLine(auto.ToString());

            Kulkuneuvo motskari = new Kulkuneuvo("Ducati", "Diavel");
            Console.WriteLine("\nLuotu uusi kulkuneuvo: {0} ", motskari.ToString());

            rengas.Merkki = "MIC";
            rengas.Koko = "160R17";
            rengas.Merkki = "Pilot";
            motskari.LisaaRengas(rengas); // Lisätään kaksi rengasta
            motskari.LisaaRengas(rengas);
            Console.WriteLine(motskari.ToString());
    
        }
    }
}