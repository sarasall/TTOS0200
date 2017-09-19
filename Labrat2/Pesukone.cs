using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat2
{
    class Pesukone
    {
        public bool OnkoPaalla { get; set; }
        public float Lampotila { get; set; }
        public int Kierrokset { get; set; }
        public string Ohjelma { get; set; }
        public bool VesiPaalla { get; set; }

        // Konstruktroit
        public Pesukone()
        {
            Ohjelma = "Peruspesu"; // Oletuksena peruspesu kaikille instansseille
        }

        public Pesukone(bool vesi) 
        {
            VesiPaalla = false;
        }

    }

}
