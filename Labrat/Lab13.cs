using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab13
    {
        public static void Exercise13()
        {
            int[] points = new int[5];
            

            for (int i = 0; i < points.Length; i++)
            {
                Console.Write("Anna pisteet: ");
                points[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(points); // sortataan array, että saadaan luvut järjestykseen

            int sum = points[1] + points[2] + points[3]; // summataan vain pisteet muistipaikoista 1-3

            Console.WriteLine("Kokonaispisteet ovat: " + sum);
        }
    }
}
