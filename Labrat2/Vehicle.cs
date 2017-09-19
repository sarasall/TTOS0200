using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat2
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        //konstruktori

        public Vehicle(string name, int speed, int tyres)
        {
            Name = name;
            Speed = speed;
            Tyres = tyres;
        }
        public void PrintData()
        {
            Console.WriteLine("Vehicle: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }
        public string ToString()
        {
            string vehicleString = Name + " " + Speed + " " + Tyres + " wheels"; 

            return vehicleString; 
        }
    }

}
