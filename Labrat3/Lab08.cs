using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab08
    {
            public string Tuote { get; set; }
            public string Tarkoitus { get; set; }

            public Lab08(string tuote,  string tarkoitus)
            {
                Tuote = tuote;
                Tarkoitus = tarkoitus;
            }
            public void TulostaTiedot()
            {
                Console.WriteLine("Tuote on: " + Tuote);
                Console.WriteLine("Tuottetta käytetään: " + Tarkoitus);

            }
            public override string ToString()
            {
                return " " + Tuote + " " + Tarkoitus;
            }

        }
        public class Kodinkoneet : Lab08
        {
            public string Malli { get; set; }
            public bool TakuuVoimassa { get; set; }

            public Kodinkoneet(string tuote, string tarkoitus, string malli, bool takuu)
                : base(tuote, tarkoitus)
            {
                Malli = malli;
                TakuuVoimassa = takuu; 
            }
            public new void TulostaTiedot()
            {
                Console.WriteLine("\nTuote on: " + Tuote);
                Console.WriteLine("Tuottetta käytetään: " + Tarkoitus);
                Console.WriteLine("Malli: " + Malli);
                Console.WriteLine("Takuuta on jäljellä? : " + TakuuVoimassa);
            }
            public override string ToString()
            {
                return " " + Malli + " " + TakuuVoimassa;
            }

        }
        public class Elektroniikka : Kodinkoneet
        {
            public string Ostettu { get; set; }

            public Elektroniikka (string tuote, string tarkoitus, string malli, bool takuu, string ostettu)
                : base(tuote, tarkoitus, malli, takuu)
            {
                Ostettu = ostettu;
            }
            public new void TulostaTiedot()
            {
                Console.WriteLine("\nTuote on: " + Tuote);
                Console.WriteLine("Tuottetta käytetään: " + Tarkoitus);
                Console.WriteLine("Malli: " + Malli);
                Console.WriteLine("Takuuta on jäljellä? : " + TakuuVoimassa);
                Console.WriteLine("Ostopäivämäärä: " + Ostettu);
            }
            public override string ToString()
            {
                return " " + Ostettu;
            }
        }
        class TestaaLaitteita
        {
            public static void TestaaToiminta()
            {
                Kodinkoneet kodinkoneet = new Kodinkoneet("Liesi", "Kokkaus", "Upo", true);
                kodinkoneet.TulostaTiedot();
                kodinkoneet.ToString();

                kodinkoneet.Tuote = "Jääkaappi";
                kodinkoneet.Tarkoitus = "Ruoansäilytys";
                kodinkoneet.TulostaTiedot();
                kodinkoneet.ToString();

                Elektroniikka elektroniikka = new Elektroniikka("Tabletti", "Viihde", "Samsung", false, "01.01.2000");
                elektroniikka.TulostaTiedot();
                elektroniikka.ToString();
            }
        }
    }
