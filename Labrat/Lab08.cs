using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab08
    {
        public static void Exercise8()
        {
            int[] number = new int[3]; // luodaan taulukko numeroita varten

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Anna luku {0}: ", i + 1);
                number[i] = int.Parse(Console.ReadLine());
            }

            if (number[0] > number[1] && number[0] > number[2])
            {
                Console.WriteLine("Suurin luku on " + number[0]);
            }
            if (number[1] > number[0] && number[1] > number[2])
            {
                Console.WriteLine("Suurin luku on " + number[1]);
            }
            if (number[2] > number[1] && number[2] > number[0])
            {
                Console.WriteLine("Suurin luku on " + number[2]);
            }
        }
    }
}
