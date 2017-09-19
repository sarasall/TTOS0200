using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat2
{
    class Televisio
    {
        public bool OnkoPaalla { get; set; }
        public int Kanava { get; set; }
        public int aani;
        public int Aanenvoimakkuus
        {
            get { return aani; }
            set
            {
                aani = value;
                if (aani < 0 || aani > 50)
                {
                    aani = 0;
                    Console.WriteLine("Ääni pois käytöstä"); // Jos äänentaso ei ole väliltä 1-50 -> äänetön
                }
            }
        }
   }   
}
