using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab12
    {
        public static void Exercise12 ()
        {
            int[] numbers = new int[5]; 

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Anna luku {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numbers); // ensin nousevaan järjestykseen, jotta voi muuttaa laskevaan
            Array.Reverse(numbers); 

            for (int i = 0; i < numbers.Length; i++) {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
