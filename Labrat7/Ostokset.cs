using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Ostokset
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }

        public Ostokset(string nimi, double hinta) {
            Nimi = nimi;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return "- tuote: " + Nimi + " " + Hinta + "e.";
        }
    }
    public class TestaaOstokset
    {
        public static void Testaa()
        {
            try
            {
                List<Ostokset> ostoskarry = new List<Ostokset>();

                ostoskarry.Add(new Ostokset("Maito", 1.3));
                ostoskarry.Add(new Ostokset("Kalja", 0.99));
                ostoskarry.Add(new Ostokset("Voi", 3.3));
                ostoskarry.Add(new Ostokset("Juusto", 4.99));

                Console.WriteLine("Ostoskärryn koko sisältö: ");
                foreach (Ostokset ostos in ostoskarry)
                {
                    Console.WriteLine(ostos.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
