using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra2._5
{
    public class Opiskelija
    {
        public string OpiskelijaID { get; set; }
        public string EtuNimi { get; set; }
        public string SukuNimi { get; set; }
        public string RyhmaTunnus { get; set; }
        public bool LasnaOleva { get; set; }

        //konstruktori
        public Opiskelija (string id, string etunimi, string sukunimi, string ryhma, bool lasna){
            OpiskelijaID = id;
            EtuNimi = etunimi;
            SukuNimi = sukunimi;
            RyhmaTunnus = ryhma;
            LasnaOleva = lasna;
        } 
        public void TulostaOppilaat()
        {
            Console.WriteLine("Opiskelijatunnus: " + OpiskelijaID);
            Console.WriteLine("Etunimi: " + EtuNimi);
            Console.WriteLine("Sukunimi: " + SukuNimi);
            Console.WriteLine("Ryhmätunnus: " + RyhmaTunnus);
            Console.WriteLine("Ilmoittautunut läsnäolevaksi: " + LasnaOleva);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija[] opiskelija = new Opiskelija[5]; // Luodaan taulukko

            // Luodaan oliot taulukkoon ja tallennetaan opiskelijoiden tiedot siihen 
            opiskelija[0] = new Opiskelija("X8256", "Pentti","Peltola", "TTV123A", true);
            opiskelija[1] = new Opiskelija("K2525", "Salla", "Pallonen", "TTV212C", false);
            opiskelija[2] = new Opiskelija("L2588", "Olli", "Oivaltaja", "TTV363", true);
            opiskelija[3] = new Opiskelija("O6969", "Kalle", "Koodari", "TTV1233E", false);
            opiskelija[4] = new Opiskelija("F2369", "Sirpa", "Savela", "TTV3696", true);

            Console.WriteLine("Opiskelijoiden tiedot: "); 
            
            for (int i = 0; i < opiskelija.Length; i++) 
            {
                opiskelija[i].TulostaOppilaat(); //tulostetaan taulukon sisältö kutsumalla tulostusmetodia 
                Console.WriteLine();
            }
        }
    }
}
