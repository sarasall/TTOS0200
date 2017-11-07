using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public abstract class Kuvio
    {
        public string Nimi { get; set; }

        public abstract double Ala();

        public abstract double Ymparysmitta();       
    }
    public class Ympyra : Kuvio
    {
        public double Sade { get; set; }
        private double pii = 3.41;

        public override double Ala()
        {
            return pii * Sade * Sade;
        }
        public override double Ymparysmitta()
        {
            return 2 * pii * Sade;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + " Säde: " + Sade + " Pinta-ala: " + Ala() + " Ympärysmitta: " + Ymparysmitta();
        }
    }
    public class Kolmio : Kuvio
    {
        public double Korkeus { get; set; }
        public double Kanta { get; set; }

        public override double Ala()
        {
            return Kanta * Korkeus;
        }
        public override double Ymparysmitta()
        {
            return (Kanta * Korkeus) * 2;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + " Korkeus: " + Korkeus + " Kanta: " + Kanta + " Pinta-ala: " + Ala() + " Ympärysmitta: " + Ymparysmitta();
        }
    }
    public class Kuviot
    {
        public List<Kuvio> kuviolista { get; }

        public Kuviot ()
        {
            kuviolista = new List<Kuvio>();
        }
        public void LisaaKuvio(Kuvio kuvio)
        {
            kuviolista.Add(kuvio);
        }
        public override string ToString()
        {
            foreach(Kuvio x in kuviolista)
            {
                Console.WriteLine(x.ToString());
            }
            return "";
        }
    }
    public class TestaaKuviot
    {
        public static void Testaa()
        {
            try
            {
                Ympyra ympyra1 = new Ympyra();
                ympyra1.Nimi = "Ympyrä";
                ympyra1.Sade = 3.6;

                Ympyra ympyra2 = new Ympyra();
                ympyra2.Nimi = "Ympyrä";
                ympyra2.Sade = 5.5;

                Kolmio kolmio1 = new Kolmio();
                kolmio1.Nimi = "Kolmio";
                kolmio1.Korkeus = 6.0;
                kolmio1.Kanta = 3.0;

                Kolmio kolmio2 = new Kolmio();
                kolmio2.Nimi = "Kolmio";
                kolmio2.Korkeus = 6.0;
                kolmio2.Kanta = 3.0;

                Kuviot kuviot = new Kuviot();

                kuviot.LisaaKuvio(ympyra1);
                kuviot.LisaaKuvio(ympyra2);
                kuviot.LisaaKuvio(kolmio1);
                kuviot.LisaaKuvio(kolmio2);
                Console.WriteLine(kuviot.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
