using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab04
    {
        public static void Exercise4()
        {
            int age = 0;

            Console.WriteLine("Syötä ikäsi: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            if (age >= 18 && age < 65)
            {
                Console.WriteLine("Aikuinen");
            }
            if (age > 65) 
            {
                Console.WriteLine("Seniori");
            }

        }
    }
}
