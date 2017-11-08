using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Lasku
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        public int Määrä { get; set; }

        public Lasku(string nimi, double hinta, int maara) {
            Nimi = nimi;
            Hinta = hinta;
            Määrä = maara;
        }
        public double KokonaisHinta()
        {
            return Hinta * Määrä;
        }
        public override string ToString()
        {
            return "Nimi: " + Nimi + " Hinta: " + Hinta + "e " + Määrä + "kpl " + "Yhteensä: " + KokonaisHinta() + "e";
        }
    }
    public class LaskuLista
    {
        public string Asiakas { get; set; }
        public List<Lasku> laskulista { get; set;}

        public LaskuLista()
        {
            laskulista = new List<Lasku>();
        }
        public void LisaaTuotteita(Lasku lista)
        {
            laskulista.Add(lista);
        }
        public double LaskeTotal()
        {
            return laskulista.Sum(x => x.KokonaisHinta());
        }
        public override string ToString()
        {          
            foreach (Lasku l in laskulista)
            {
                Console.WriteLine(l.ToString());
            }
            return "";
        }
    }
    public class TestaaLasku
    {
        public static void Testaa()
        {
            try
            {
                Lasku lasku1 = new Lasku("Maito", 0.89, 2);
                Lasku lasku2 = new Lasku("Kalja", 5.25, 1);
                Lasku lasku3 = new Lasku("Voi  ", 2.00, 2);

                LaskuLista oikeaLasku = new LaskuLista();
                oikeaLasku.Asiakas = "Kirsi Kernel";

                Console.WriteLine("Asiakkaan " + oikeaLasku.Asiakas + " lasku: ");
                Console.WriteLine("=========================================");
                oikeaLasku.LisaaTuotteita(lasku1);
                oikeaLasku.LisaaTuotteita(lasku2);
                oikeaLasku.LisaaTuotteita(lasku3);
                Console.WriteLine(oikeaLasku.ToString());
                Console.WriteLine("==========================================");
                Console.WriteLine("Total: " + oikeaLasku.LaskeTotal() + " euroa\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
