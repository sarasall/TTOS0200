using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab09
    {
        public static void Exercise9()
        {
            int numbers = 0;
            int sum = 0;

            do
            {
                Console.Write("Anna luku: ");
                numbers = int.Parse(Console.ReadLine());
                sum += numbers; 

            } while (numbers != 0); 

            Console.WriteLine("Lukujen summa on: " + sum);
        }
    }
}
