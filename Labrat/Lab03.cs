using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab03
    {
        public static void Exercise3()
        {
            int number1, number2, number3 = 0;

            Console.WriteLine("Syötä luku 1: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä luku 2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä luku 3: ");
            number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3;
            int average = sum / 3;

            Console.WriteLine("Lukujen summa on: " + sum);
            Console.WriteLine("Lukujen keskiarvo on: " + average);

        }
    }
}
