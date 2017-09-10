using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab07
    {
        public static void Exercise7()
        {
            int year = 0;

            Console.WriteLine("Anna vuosi: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) // vertaillaan jakojäännösten avulla onko vuosi karkausvuosi

            {
                Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
        }
    }
}
