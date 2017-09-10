using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab14
    {
        public static void Exercise14()
        {
            //int[] grades = new int[];
            int numbers = 0;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            
            Console.WriteLine("Anna arvosanat 0-5. Luku 10 lopettaa arvosanojen syöttämisen.");

                do
                {
                Console.WriteLine("Anna arvosana: ");
                numbers = int.Parse(Console.ReadLine());
                    if (numbers == 0)
                    {
                        counter++;
                    }
                    if (numbers == 1)
                    {
                        counter1++;
                    }
                    if (numbers == 2)
                    {
                        counter2++;
                    }
                    if (numbers == 3)
                    {
                        counter3++;
                    }
                    if (numbers == 4)
                    {
                        counter4++;
                    }
                    if (numbers == 5)
                    {
                        counter5++;
                    }

            } while (numbers != 10); // suoritetaan kunnes käyttäjä syöttää luvun 10

            
            Console.Write("Arvosanoja 5: ");
                for(int i = 0; i < counter5; i++)
                {
                    Console.Write("*");
                }
            Console.Write("\nArvosanoja 4: ");
                for (int i = 0; i < counter4; i++)
                {
                    Console.Write("*");
                }
            Console.Write("\nArvosanoja 3: ");
                for (int i = 0; i < counter3; i++)
                {
                    Console.Write("*");
                }
            Console.Write("\nArvosanoja 2: ");
                for (int i = 0; i < counter2; i++)
                {
                    Console.Write("*");
                }
            Console.Write("\nArvosanoja 1: ");
                for (int i = 0; i < counter1; i++)
                {
                    Console.Write("*");
                }
            Console.Write("\nArvosanoja 0: ");
                for (int i = 0; i < counter; i++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
        }
    }
}
