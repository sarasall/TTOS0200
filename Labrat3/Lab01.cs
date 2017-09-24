using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Labrat3
{
    public class Lab01
    {
        public static bool OnkoLuku(string syote)
        {
            double luku;      
            bool tulos;

            Console.WriteLine("\nSyötä merkkijono: ");
            syote = Console.ReadLine();

            char viimeinen = syote.Last(); //otetaan viimeinen merkki merkkijonosta

                if (syote.Contains('.')) // jos merkkijono sisältää pisteen, arvo on false
                {
                    tulos = false;
                }
                else if (syote.IndexOf(',') != syote.LastIndexOf(',')) // arvo false, jos merkkijonossa useampi kuin 1 pilkku
                {
                    tulos = false;
                }
                else if (syote.Last().ToString().Contains(',')) // arvo false, jos viimeinen merkki pilkku, muutetaan myös char -> sring
                {
                    tulos = false;
                }
                else
                {
                    tulos = Double.TryParse(syote, out luku); // tarkistetaan onko merkkijono luku
                } 
                return tulos;
        }

        public static bool OnkoPvm(string syote)
        {
            string[] sallitutMuodot = {"dd.mm.yyyy", "d.m.yyyy", "dd.mm.yy", "d.m.yy"};
            DateTime pvm;

            Console.WriteLine("\nSyötä päivämäärä: ");
            syote = Console.ReadLine();

            // tarkistetaan, että syöte on sallitussa muodossa, esim jos pilkku -> ei hyväksytä
            bool tulos = DateTime.TryParseExact(syote, sallitutMuodot, DateTimeFormatInfo.InvariantInfo, System.Globalization.DateTimeStyles.None, out pvm); 

                if (tulos == true)
                {              
                    int[] intTaulukko = syote.Split('.').Select(x => int.Parse(x)).ToArray(); /* tehdään int-taulukko, string katkaistaan aina pisteen kohdalta
                        ja vertaillaan, että päivät ja kuukaudet ovat sallituissa lukemissa */
                
                        if (intTaulukko[0] < 1 || intTaulukko[0] > 31) // pvm tarkistus 
                        {
                            tulos = false;
                        }  
                        else if (intTaulukko[1] < 1 || intTaulukko[1] > 12) // kk tarkistus
                        {
                            tulos = false;
                        }
                        else if (intTaulukko[1] == 2 && intTaulukko[0] > 29) // helmikuun tarkistus
                        {
                            tulos = false;
                        }
                        else
                        {
                            tulos = true;
                        }
                }
                else
                {
                    tulos = false;
                }

            return tulos; 
    }
}
    public class TestiPeti
    {
        public static void TestaaMetodit()
        {
            bool testilause;

            for (int i = 0; i < 5; i++)
            {
                testilause = Lab01.OnkoLuku("");
                Console.WriteLine("Merkkijono on luku = {0}", testilause);
            }

            for (int i = 0; i < 5; i++)
            {
                testilause = Lab01.OnkoPvm("");
                Console.WriteLine("Päivämäärä on oikeassa muodosssa = {0}", testilause);
            }

        }
    }
}
