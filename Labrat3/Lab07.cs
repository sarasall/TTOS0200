using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab07
    {
        public string Tuote { get; set; }
        public int Vuosi { get; set; }

        public Lab07(string tuote, int vuosi)
        {
            Tuote = tuote;
            Vuosi = vuosi;
        }
        public void TulostaTiedot()
        {
            Console.WriteLine("Tuote on: " + Tuote);
            Console.WriteLine("Valmistettu/julkaistu vuonna: " + Vuosi);

        }
        public override string ToString()
        {
            return " " + Tuote + " " + Vuosi;
        }

    }
    public class Kannettava : Lab07
    {
        public string Malli { get; set; }
        public int AkkuaJaljella { get; set; }

        public Kannettava (string tuote, int vuosi, string malli, int akku)
            :base(tuote, vuosi)
        {
            Malli = malli;
            AkkuaJaljella = akku;
        }
        public new void TulostaTiedot()
        {
            Console.WriteLine("Tuote on: " + Tuote);
            Console.WriteLine("Valmistettu/julkaistu vuonna: " + Vuosi);
            Console.WriteLine("Malli: " + Malli);
            Console.WriteLine("Akkua on jäljellä: " + AkkuaJaljella + " %");
        }
        public override string ToString()
        {
            return " " + Malli + " " + AkkuaJaljella;
        }

    }
    public class Puhelin : Kannettava
    {
        public string Ostettu { get; set; }

        public Puhelin(string tuote, int vuosi, string malli, int akku, string ostettu)
            :base(tuote, vuosi, malli, akku)
        {
            Ostettu = ostettu;
        }
        public new void TulostaTiedot()
        {
            Console.WriteLine("\nTuote on: " + Tuote);
            Console.WriteLine("Valmistettu/julkaistu vuonna: " + Vuosi);
            Console.WriteLine("Malli: " + Malli); 
            Console.WriteLine("Akkua on jäljellä: " + AkkuaJaljella + " %");
            Console.WriteLine("Ostopäivämäärä: " + Ostettu);
        }
        public override string ToString()
        {
            return " " + Ostettu;
        }
    }
    class TestaaLuokkia {
        public static void TestaaToiminta()
        {
            Lab07 testi = new Lab07("Kirja", 2004);
            testi.TulostaTiedot();
            testi.ToString();

            Kannettava kannettava = new Kannettava("Kannettava", 2013, "Lenovo 29338", 80);
            kannettava.TulostaTiedot();
            kannettava.ToString();

            Puhelin puhelin = new Puhelin("Puhelin", 2015, "Honor 7", 66, "12.05.2016");
            puhelin.TulostaTiedot();
            puhelin.ToString();
        }
    }
}
