  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Noppa
    {
        public int Numero { get; set; }
        private int kerrat;
        private int[] laskuri = new int[6];
        private double ka;

        public void HeitaNoppaa ()
        {
            Console.WriteLine("Kuinka monta kertaa haluat heittää noppaa?");
            kerrat = int.Parse(Console.ReadLine());
        }

        public void TeeRandomNumero()
        {
            Random rnd = new Random();
            for (int i = 0; i < kerrat; i++)
            {
                Numero = rnd.Next(1, 7);
                ka += Numero; // kasvatetaan keskiarvon laskua varten ka-muuttujaa

                switch (Numero)
                {
                    case 1: laskuri[0]++; break;
                    case 2: laskuri[1]++; break;
                    case 3: laskuri[2]++; break;
                    case 4: laskuri[3]++; break;
                    case 5: laskuri[4]++; break;
                    case 6: laskuri[5]++; break;
                }
            }
        }
        public override string ToString()
        {
            Console.WriteLine("Heitettyjen lukujen keskiarvo on: " + (ka /= kerrat));

            for (int i = 0; i < laskuri.Length; i++)
            {
                Console.WriteLine("Numero "+ (i + 1) + " esiintyy: " + laskuri[i] + " kertaa.");
            }
            return "";
        }
    }
    public class TestaaNoppa
    {
        public static void Testaa()
        {
            try
            {
                Noppa noppa = new Noppa();

                noppa.HeitaNoppaa();
                noppa.TeeRandomNumero();
                Console.WriteLine(noppa.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
