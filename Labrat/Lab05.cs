using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab05
    {
        public static void Exercise5()
        {
            int seconds = 0;

            Console.WriteLine("Anna sekunit: ");
            seconds = int.Parse(Console.ReadLine());

            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int seconds2 = seconds % 60;

            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa: " + hours + " tuntia " + minutes + " minuuttia " + seconds2 + " sekuntia");
        }
    }
}
