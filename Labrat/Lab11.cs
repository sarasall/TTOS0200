using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab11
    {
        public static void Exercise11()
        {

            Console.Write("Anna rivien määrä: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++) // kerrosten määrä
            {
                for (int j = 1; j <= i ; j++) // kasvatetaan tähtien määrää rivi kerrallaan
                {
                    Console.Write("*");
                }
                Console.Write("\n"); // Lisätään rivivaihto kun yksi kerros suoritettu
            }
        }
    }
}
