using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab06
    {
        public static void Exercise6()
        {
            int km = 0;

            Console.WriteLine("Anna matka: ");
            km = int.Parse(Console.ReadLine());

            double litre = (km * 7.02) / 100;
            double cost = 1.595 * litre;

            Console.WriteLine("Bensaa kuluu " + litre + " litraa, kustannus {0:F} euroa.", cost); // {0:F} F:n avulla näytetään vain 2 desimaalia luvussa
        }
    }
}
