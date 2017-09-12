using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab17
    {
        public static void Exercise17()
        {
            int[] firstArray = new int [] { 10, 20, 30, 40, 50 };
            int[] secondArray = new int[] { 5, 15, 25, 35, 45 };
            int[] thirdArray = firstArray.Concat(secondArray).ToArray(); // Yhdistetään taulukot 1 & 2

            Array.Sort(firstArray);
            Array.Sort(secondArray);
            Array.Sort(thirdArray);

            Console.Write("Luvut taulukossa 1: ");
                
                for (int i = 0; i < firstArray.Length; i++)
                {
                    Console.Write(firstArray[i] + " ");
                } 

            Console.Write("\nLuvut taulukossa 2: ");

                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write(secondArray[i]+ " ");
                }

            Console.Write("\nLuvut taulukossa 3: ");
            
                for (int i = 0; i < thirdArray.Length; i++)
                {
                    Console.Write(thirdArray[i] + " ");
                }
            Console.WriteLine();
        }
    }
}
