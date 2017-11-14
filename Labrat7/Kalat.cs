using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kala
    {
        public string Laji { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }
        public string PaikanNimi { get; set; }
        public string Paikka { get; set; }

        public Kala (string laji, double pituus, double paino, string nimi, string paikka)
        {
            Laji = laji;
            Pituus = pituus;
            Paino = paino;
            PaikanNimi = nimi;
            Paikka = paikka;
        }
        public override string ToString()
        {
            return "Laji: " + Laji + " " + Pituus + " " + Paino + " kg." + "\nPaikka: " + PaikanNimi + " \nSijainti: " + Paikka;
        }
    }
    public class Kalastaja
    {
        public string Nimi { get; set; }
        public string PuhNum { get; set; }
        public List<Kala> kalalista { get; set; }

        public Kalastaja (string nimi, string puhnum)
        {
            Nimi = nimi;
            PuhNum = puhnum;
            kalalista = new List<Kala>();
        }
        public override string ToString()
        {
            return "Kalastaja: " + Nimi + " Puh: " + PuhNum;
        }
    }

    public class TestaaKalat
    {
        public static void Testaa()
        {
            try
            {
                Kalastaja kalastajaKirsi = new Kalastaja("Kirsi Kernel", "020-5555555");
                Console.WriteLine("Uusi kalastaja lisätty rekisteriin: ");
                Console.WriteLine(kalastajaKirsi.ToString());

                Console.WriteLine("\nKalastaja: {0} sai uuden kalan", kalastajaKirsi.Nimi);
                kalastajaKirsi.kalalista.Add(new Kala("Ahven", 190, 5.0, "Jyväsjärvi", "Jyväskylä"));
                Console.WriteLine(kalastajaKirsi.kalalista[0].ToString());

                Console.WriteLine("\nKalastaja: {0} sai uuden kalan", kalastajaKirsi.Nimi);
                kalastajaKirsi.kalalista.Add(new Kala("Särki", 90, 2.5, "Oulujoki", "Oulu"));
                Console.WriteLine(kalastajaKirsi.kalalista[1].ToString());

                Console.WriteLine("\nKaikki kalat rekisterissä:");
                foreach (Kala kala in kalastajaKirsi.kalalista)
                {
                    Console.WriteLine(kala.ToString());
                }

                kalastajaKirsi.kalalista.Sort((x, y) => y.Paino.CompareTo(x.Paino)); // Sortataan painavemmasta kevyempään kalaan

                Console.WriteLine("\nJärjestetyt kalat rekisterissä:");
                foreach (Kala kala in kalastajaKirsi.kalalista)
                {
                    Console.WriteLine(kala.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
