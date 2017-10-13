using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    class Lab06
    {
        public bool OnkoPaalla { get; set; }

        public double taajuudet;
        public double Taajuus {
            get { return taajuudet; }
            set {

                taajuudet = value;

                if (taajuudet < 2000.0 || taajuudet > 26000.0)
                {
                    taajuudet = 0;
                }
            }
        }

        public int aani;
        public int Aanenvoimakkuus
        {
            get { return aani; }
            set
            {
                aani = value;
                if (aani < 1 || aani > 9)
                {
                    aani = 0;
                }
            }
        }
        // konstruktori
        public Lab06 (bool paalla, double taajuus, int voimakkuus)
        {
            OnkoPaalla = paalla;
            Taajuus = taajuus;
            Aanenvoimakkuus = voimakkuus;
        }
        public override string ToString()
        {
            return " " + Taajuus + " " + Aanenvoimakkuus;
        }
    }

    class TestaaRadio {

        public static void TestaaToimivuus()
        {
            Lab06 radio = new Lab06(true, 5000, 9);

            if (radio.OnkoPaalla == true)
            {
                Console.WriteLine("Radio on päällä. ");
            }

            radio.OnkoPaalla = false; // sammutetaan radio 

            if (radio.OnkoPaalla == false)
            {
                radio.Taajuus = 0;
                radio.Aanenvoimakkuus = 0;
                Console.WriteLine("Radio on kiinni. Äänenvoimakkuus: {0} ja taajuus: {1}.", radio.Aanenvoimakkuus, radio.Taajuus); // Jos radio on kiinni, kaikki nollille
            }

            if (radio.Taajuus >= 2000.0 && radio.Taajuus <= 26000.0)
            {
                Console.WriteLine("Taajuus säädetty: " + radio.Aanenvoimakkuus);
            }

            radio.Taajuus = 3000000;

            if(radio.Taajuus == 0)
            {
                Console.WriteLine("Virheelinen taajuus");
            }

            radio.Aanenvoimakkuus = 11;
            
            if(radio.Aanenvoimakkuus == 0)
            {
                Console.WriteLine("Ääni pois käytöstä"); 
            }

            radio.Aanenvoimakkuus = 3;

            if(radio.Aanenvoimakkuus > 0 && radio.Aanenvoimakkuus < 10)
            {
                Console.WriteLine("Äänenvoimakkuus säädetty: " + radio.Aanenvoimakkuus);
            }           
        }
    }
}
