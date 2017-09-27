using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab04
    {
        public string Nimi { get; set; }
        public string Ammatti { get; set; }
        public double Palkka { get; set; }

        public Lab04 (string nimi, string ammatti, double palkka)
        {
            Nimi = nimi;
            Ammatti = ammatti;
            Palkka = palkka;
        }
        public void TulostaMetodi()
        {
            Console.WriteLine("Työntekijä: ");
            Console.WriteLine("Nimi:" + Nimi);
            Console.WriteLine("Ammatti: " + Ammatti);
            Console.WriteLine("Palkka: " + Palkka);
        }
        public string ToString()
        {
            return Nimi + " " + Ammatti + " " + Palkka + " ";
        }
    }
    public class Pomo
    {
        public string Auto { get; set; }
        public double Bonus { get; set; }

        public Pomo(string nimi, string ammatti, double palkka, string auto, double bonus)
            :base(nimi, ammatti, palkka)
        {
            Auto = auto;
            Bonus = bonus;
        }
        

    }
     class TestaaLuokka
    {
        public static void TestaaToiminta()
        {
            Lab04 tyontekija = new Lab04("Kirsi Kernel", "Opettaja", 1200);

            tyontekija.TulostaMetodi();
            tyontekija.ToString();
        }
    }


       
}
