using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab10
    {
        public static void Exercise10()
        {
            int[] numberArray = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] % 2 == 0)
                {
                    Console.WriteLine("HEP");
                }
                else
                    Console.WriteLine(numberArray[i]);
            }
        }
    }
}
