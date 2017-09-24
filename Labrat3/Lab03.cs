using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat3
{
    public class Lab03
    {
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volume = value;
                }
                if (value > 100 ) 
                {
                    volume = 100;
                    Console.WriteLine("Ääni säädetty maksimiin");
                }
                if (value < 0 )
                {
                    volume = 0;
                    Console.WriteLine("Ääni pois käytöstä");
                }

  
            }
        }
    }
    public class TestaaVahvistin
    {

        public static void TestaaToiminta()
        {
            string syote;      

            Lab03 vahvistin = new Lab03(); // Luodaan olio

            while(true)
            {
                Console.WriteLine("Äänenvoimakkuus on tasolla: " + vahvistin.Volume);
                Console.WriteLine("Valitse vahvistimen äänenvoimakkuus väliltä 0-100. \nLopetus syöttämällä x ");
                syote = Console.ReadLine();
                
                    if (syote == "x")
                    {
                        Console.WriteLine("Valitsit lopetuksen. ");
                        break;
                    }
                    else
                    {
                        vahvistin.Volume = int.Parse(syote); // syote stringistä intiksi 
                    }
            }   
        }
    }
}

