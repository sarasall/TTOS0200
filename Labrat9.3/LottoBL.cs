using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Lotto
    {
        public int LoppuNro { get; set; }
        public int RandNro { get; set; }
        public int YhtNroita { get; set; }
        Random rnd = new Random();

        public Lotto() { }

        public Lotto (int loppunro, int yht)
        {
            LoppuNro = loppunro;
            YhtNroita = yht;
        }
    
        public List<int> TeeLottoNrot()
        {
            List<int> numerot = new List<int>();

            for (int i = 0; i < YhtNroita; i++)
            {
                RandNro = rnd.Next(1, LoppuNro + 1);
                numerot.Add(RandNro);
            }
            return numerot;
        }
    }

}
