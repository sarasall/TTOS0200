using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class LuvutTiedostoihin
    {
        public static void Testaa()
        {
            
           try {
            
                    int kokLuku = 0;
                    double reaaliLuku = 0;
                    string tiedostopolku = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string kokTiedosto = tiedostopolku + @"/int.txt";
                    string reaaliTiedosto = tiedostopolku + @"/double.txt";

                    StreamWriter sw1 = new StreamWriter(kokTiedosto);
                    StreamWriter sw2 = new StreamWriter(reaaliTiedosto);

                while (true)
                {
                    Console.WriteLine("Syötä luku (enter tai muu kuin luku lopettaa) : ");
                    string syote = Console.ReadLine();

                    //testataan syötteen tyyppi 
                    bool tulos = int.TryParse(syote, out kokLuku);
                    bool tulosReeali = double.TryParse(syote, out reaaliLuku);

                    if (tulos == true)
                    {                
                            sw1.WriteLine(syote);
                    }
                    else if (tulosReeali == true)
                    {               
                            sw2.WriteLine(syote);                    
                    }
                    else
                    {
                        break;
                    }

                }
                sw1.Close();
                sw2.Close();

                if (File.Exists(kokTiedosto)) // tarkistaa onko tiedosto olemassa ja tulostetaan sisällöt
                {
                    string teksti = File.ReadAllText(kokTiedosto);
                    Console.WriteLine("\nint.txt-tiedoston sisältö: ");
                    Console.WriteLine(teksti);
                }
                if (File.Exists(reaaliTiedosto)) 
                {
                    string teksti = File.ReadAllText(reaaliTiedosto);
                    Console.WriteLine("\ndouble.txt-tiedoston sisältö: ");
                    Console.WriteLine(teksti);
                }
            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }               
        }
    }
}
