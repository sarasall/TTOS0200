using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab16
    {
        public static void Exercise16()
        {
            int askNumber = 0;
            int roundCalc = 0;

            Random random = new Random();
            int randNumber = random.Next(100); // luvut 1-100 väliltä

            do
            {
                Console.WriteLine("Arvaa luku väliltä 1-100: ");
                askNumber = int.Parse(Console.ReadLine());

                if(askNumber < randNumber)
                {
                    Console.WriteLine("Luku on suurempi.");
                }
                else if (askNumber > randNumber)
                {
                    Console.WriteLine("Luku on pienempi.");
                }
                roundCalc++;
                
            } while (randNumber != askNumber);

            Console.WriteLine("Hienoa, arvasit luvun " + roundCalc + ". kerralla.");
        }
    }
}
