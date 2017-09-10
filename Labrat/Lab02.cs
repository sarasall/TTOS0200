using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public static void Exercise2()
        {
            int points = 0;

            Console.WriteLine("Anna pistemäärä: ");
            points = int.Parse(Console.ReadLine());

            if (points >= 0 && points <= 2)
            {
                Console.WriteLine("Koulunumero on 0.");
            }
            if (points >= 2 && points <= 3)
            {
                Console.WriteLine("Koulunumero on 1.");
            }
            if (points >= 4 && points <= 5)
            {
                Console.WriteLine("Koulunumero on 2.");
            }
            if (points >= 6 && points <= 7)
            {
                Console.WriteLine("Koulunumero on 3.");
            }
            if (points >= 8 && points <= 9)
            {
                Console.WriteLine("Koulunumero on 4.");
            }
            if (points >= 10 && points <= 12)
            {
                Console.WriteLine("Koulunumero on 5.");
            }
            if (points < 0 || points > 12)
            {
                Console.WriteLine("Väärä pistemäärä.");
            }
        }
    }
}
