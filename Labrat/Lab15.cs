using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab15
    {
        public static void Exercise15()
        {
            Console.Write("Anna rivien määrä: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows + (rows - 1);
                for (int i = 1; i <= rows - 2; i++) // kerrosten määrä, vähennetään 2 kerrosta jalalle
                {
                    for (int k = 1; k < rows - i; k++) //tähtien paikka 
                    {
                    Console.Write(" ");
                }
                        for (int j = 1; j <= i; j++) // kasvatetaan tähtien määrää rivi kerrallaan
                        {
                            Console.Write("*");
                            Console.Write(" "); //"keskitetään" välilyönnillä tähdet
                    }
                    Console.WriteLine();
                }
            // kuusenjalka
 
           for(int i = 0; i < 2; i++) 
           {
               for (int j = 0; j < (cols / 2 - 1); j++) {
                Console.Write(" "); // keskitetään jalka
                }

               for (int k = 0; k < 1; k++)
               {
                    Console.Write("*");
                    
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
