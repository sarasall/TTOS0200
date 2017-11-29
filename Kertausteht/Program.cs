using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class AMK
    {
        static void Main(string[] args)
        {
            List<Tutkinto> tutkintoOhjelmat = new List<Tutkinto>();
            Tutkinto ttv = new Tutkinto("Tieto- ja viestintätekniikka");
            tutkintoOhjelmat.Add(ttv);
            Tutkinto ele = new Tutkinto("Elektroniikkatekniikka");
            tutkintoOhjelmat.Add(ele);
            Tutkinto musa = new Tutkinto("Musiikki");
            tutkintoOhjelmat.Add(musa);

            Opettaja ope1 = new Opettaja("Henri Halonen");
            Opettaja ope2 = new Opettaja("Kaisa Kannus");

            Opiskelija op1 = new Opiskelija("Pena Pentikäinen", "K2020", "TTV16S9");
            Opiskelija op2 = new Opiskelija("Kalle Jokinen", "K4993", "TTV15S1");
            Opiskelija op3 = new Opiskelija("Ville Vallaton", "K2884", "TTV14S9");

            Opintojakso olio = new Opintojakso("Olio-ohjelmointi"); // Lisätään oliot opintojakso-listaan metodin avulla
            ttv.LisaaOpintoJakso(olio);
            olio.LisaaOpiskelija(op1); // Lisätään olio-ohjelmointiin Pena ja Kalle
            olio.LisaaOpiskelija(op2);
            olio.LisaaOpettaja(ope1); // ja opettaja

            Opintojakso matematiikka = new Opintojakso("Matematiikka");
            ttv.LisaaOpintoJakso(matematiikka);
            Opintojakso kyber = new Opintojakso("Kyberturvallisuus");
            ttv.LisaaOpintoJakso(kyber);
            kyber.LisaaOpettaja(ope2);

            Console.WriteLine("Tutkinto-ohjelmat: ");
            foreach (var x in tutkintoOhjelmat)
            {
                Console.WriteLine(x);
            }

        }
    }
    public class Tutkinto
    {
        public string Tutkintonimike { get; set; }
        public List<Opintojakso> Opintojaksot { get; set; } // Koostetaan Opintojaksot-olioita tutkinnon sisälle

        public Tutkinto(string tutknimi)
        {
            Tutkintonimike = tutknimi;
            Opintojaksot = new List<Opintojakso>();
        }
        public void LisaaOpintoJakso (Opintojakso opintojakso)
        {
            Opintojaksot.Add(opintojakso);
        }
        public override string ToString()
        {
            string retval = Tutkintonimike + ": \n";

            foreach(var x in Opintojaksot)
            {
                retval += x;
            }
            return retval;
        }
    }
    public class Opintojakso
    {
        public string OpintojNimi { get; set; }
        public List<Opettaja> Opettajat { get; set; } // Koostaa sisälleen Opiskelija-ja Opiskelijat-luokan olioita
        public List<Opiskelija> Opiskelijat { get; set; }

        public Opintojakso (string opintjnimi)
        {
            OpintojNimi = opintjnimi;
            Opettajat = new List<Opettaja>();
            Opiskelijat = new List<Opiskelija>();
        }
        public void LisaaOpettaja (Opettaja opettaja)
        {
            Opettajat.Add(opettaja);
        }
        public void LisaaOpiskelija (Opiskelija opiskelija)
        {
            Opiskelijat.Add(opiskelija);
        }
        public override string ToString()
        {
            string retval = OpintojNimi + ": ";

            retval += "Opettajat: \n" + Opettajat.Count.ToString() + " kpl\n";
            foreach (var x in Opiskelijat)
            {
                retval += x.Nimi;
            }
            retval += "Opiskelijat: \n" + Opiskelijat.Count.ToString() + " kpl\n";
            foreach (var x in Opiskelijat)
            {
                retval += x.Nimi;
            }
            return retval;
        }
    }
    public class Opettaja 
    {
        public string Nimi { get; set; }

        public Opettaja (string nimi)
        {
            Nimi = nimi;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Nimi;
        }
    }
    public class Opiskelija 
    {
        public string Nimi { get; set; }
        public string OpiskelijaNro { get; set; }
        public string Ryhma { get; set; }
        private static int lkm = 0;

        public Opiskelija( string nimi, string opiskelijanro, string ryhma)        
        {
            Nimi = nimi;
            OpiskelijaNro = opiskelijanro;
            Ryhma = ryhma;
            lkm++; // Lasketaan olioiden määrä
        }
        public static int Kasvata()
        {
            return lkm;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Nimi + " " + OpiskelijaNro + " " + Ryhma;
        }
    }
}
