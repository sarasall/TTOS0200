using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab18
    {
        public static void Exercise18()
        {
            
            Console.WriteLine("Syötä lause: ");
            string askString = Console.ReadLine();
            string lowerString = askString.ToLower(); // pienennetään kaikki kirjaimet

            char[] strArray = lowerString.ToCharArray(); // muutetaan lause taulukoksi

            Array.Reverse(strArray); 

            string palindString = new string(strArray); // tehdään käännetystä taulukosta uusi merkkijono

                if (lowerString == palindString)
                {
                Console.WriteLine("Lause on palindromi.");
                }
                else
                {
                Console.WriteLine("Lause ei ole palindromi.");
                }
        }
    }
}
