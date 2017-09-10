using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Olio-ohjelmoinnin viikkotehtävät 
//Sara Sallinen
namespace Labrat
{
    class Lab01
    {
        public static void Exercise1()
        {
            int number = 0;

            Console.WriteLine("Anna luku: ");
            number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Console.WriteLine("Annoit luvun yksi.");
            }
            if (number == 2)
            {
                Console.WriteLine("Annoit luvun kaksi. ");
            }
            if (number == 3)
            {
                Console.WriteLine("Annoit luvun kolme.");
            }
            if (number < 1 || number > 3)
            {
                Console.WriteLine("Joku muu luku");
            }
        }
    }
}
