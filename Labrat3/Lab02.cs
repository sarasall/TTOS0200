using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab02
    {
        private int kerros = 1; // aloitetaan kerroksesta 1
        public int Kerros
        {
            get { return kerros; }
            set
            {
                if (value >= 1 && value <= 5) // kerrokset 1-5
                {
                    kerros = value; 
                }
            }
        }
    }

    public class TestaaHissi
    {

        public static void TestaaToiminta()
        {
            int kerros;
            Lab02 hissi= new Lab02(); // Luodaan olio
            Console.WriteLine("Olet nyt kerroksessa: " + hissi.Kerros); // Lähdetään kerroksesta 1

            do
            {            
                Console.WriteLine("Valitse kerros 1-5 (voit lopettaa valitsemalla 0): ");
                kerros = int.Parse(Console.ReadLine());

                Console.WriteLine("Olet nyt kerroksessa: " + kerros);

                if (kerros > 5)
                {
                    Console.WriteLine("Liian suuri kerros. ");
                }
                if (kerros < 0)
                {
                    Console.WriteLine("Liian pieni kerros. ");

                }

            } while (kerros != 0);

            Console.WriteLine("Valitsit lopetuksen. Kiitos käynnistä. ");
        }
    }
}
