using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class TestaaTallennus1
    {
        public static void Testaa()
        {
            try
            {
                //
                //KÄYTTÄKÄÄ AINA TRY-CATCHIA!
                string nimi;
                string filupath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //hakemistopolku
                string filu = filupath + @"\testi.txt"; // tiedoston polku-muuttuja
                // Kirjoitetaan käyttäjän antamat rivit tiedostoon
                // Luodaan StreamWriter-tyyppinen olio, johon kirjoitetaan 
                StreamWriter sw = new StreamWriter(filu); // lisää testi.txt-nimisen tiedoston kansioon K8500-kansioon
                do
                {
                    Console.Write("Anna nimi (enter lopettaa):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                        sw.WriteLine(nimi);
                } while (nimi.Length != 0);
                sw.Close(); // Suljetaan streamwriter
                            // Avataan tiedosto uudelleen ja luetaan sen sisältö ja tulostetaan konsolissa
                if (File.Exists(filu)) // tarkistaa onko tiedosto olemassa
                {
                    string teksti = File.ReadAllText(filu);
                    Console.WriteLine("\ntesti.txt-tiedoston sisältö: ");
                    Console.WriteLine(teksti);
                }

            }
            catch (FileNotFoundException ex) // esimerkki, yleensä pärjää exceptionille
            {
                Console.WriteLine("Tiedostoa ei löydy");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }
}
