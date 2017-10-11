using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class miniAsio
    {

    }
    public class Opiskelija
    {
        #region PROPERTIES
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string AsioID { get; set; }
        public string Ryhma { get; set; }

        #endregion

        #region CONSTRUCTORS
        public Opiskelija() { }
        public Opiskelija(string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
        }
        public Opiskelija(string etunimi, string sukunimi, string asioid)
            : this(etunimi, sukunimi) // kutsuu ylempää konstruktoria
        {
            AsioID = asioid;
        }
        public Opiskelija(string etunimi, string sukunimi, string asioid, string ryhma)
        : this(etunimi, sukunimi, asioid) // kutsuu ylempää konstruktoria
        {
            Ryhma = ryhma;
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Etunimi, Sukunimi, AsioID, Ryhma);
        }
        #endregion
    }
    public class TestaaMiniASIO
    {
        public static void Testaa()
        {
            // luodaan List-tyyppinen lista oppilaista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            
            // Testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");

            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Pena", "Penttinen", "K3500"));
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanne", Sukunimi = "Valkeala", AsioID = "K2888" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Janne", Sukunimi = "Jormanen", AsioID = "E2939", Ryhma = "TTV12S1" });

            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle";
            kalle.Sukunimi = "Kokkonen";
            kalle.AsioID = "K666";
            kalle.Ryhma = "TTV11V1";
            opiskelijat.Add(kalle);

            // Yhden opiskelijan tietojen tulostus, Countin avulla saa tietoon listan pituuden
            Console.WriteLine("Anna numero väliltä 1 - {0}", opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());

            if (i-1 < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa.", opiskelijat.Count);

            // Kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat: ");

            foreach(var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }

            // Kaikkien opiskelijoiden tiedot aakkosjärjestyksessä sukunimen mukaan
            // Sortataan oliot Sukunimi-ominaisuuden mukaiseen järjestykseen

            opiskelijat.Sort((x,y) => x.Sukunimi.CompareTo(y.Sukunimi));

            Console.WriteLine("MiniASIOn kaikki opiskelijat sortattuna: ");

            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }

            // uuden opiskelijan lisääminen huom, tehdään tarkistus ettei Asio id ole jo käytössä
            Console.WriteLine("Anna uuden opiskelijan AsioID");
            string asioid = Console.ReadLine();

            // tutkitaan onko listassa
            bool lippu = false; // apumuuttuja
            foreach(Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID) // tarkistetaan yksi kerrallaan ja verrataan annettua ja listassa olevaa ID:tä
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä.", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan ryhmä");
                string ryhma = Console.ReadLine();
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
            }
            Console.WriteLine("\nMiniASIOn kaikki opiskelijat ({0} kpl): ", opiskelijat.Count);

            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
