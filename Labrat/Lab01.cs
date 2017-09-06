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
            int luku = 0;

            Console.WriteLine("Anna luku: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi.");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi. ");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme.");
            }
        }
    }
}
