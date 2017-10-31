using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class TestaaTallennus2
    {
        public static void Testaa()
        {     
            string tiedostopolku = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
            string filu = tiedostopolku + @"\nimet.txt";

            try
            {
                if (File.Exists(filu))
                {
                    int rivit = File.ReadAllLines(filu).Count(); // Laskee rivien määrän
                    Console.WriteLine("Tiedoston rivejä: " + rivit + " kpl.");

                    int eriNimet = File.ReadAllLines(filu).Distinct().Count();
                    Console.WriteLine("Tiedostossa erilaisia nimiä: " + eriNimet + " kpl.");

                    Dictionary<string, int> samatNimet = new Dictionary<string, int>(); // samanlaisten nimien tarkistusta varten dictionary

                    foreach(string x in File.ReadAllLines(filu))
                    {
                        if (samatNimet.ContainsKey(x)) // jos löytyy jo dictionarysta -> kasvatetaan arvoa yhdellä
                        {
                            samatNimet[x] = samatNimet[x]+1; 
                        }
                        else
                        {
                            samatNimet.Add(x, 1); // Lisätään dictionaryyn
                        }
                    }

                    foreach(var nimet in samatNimet) // tulostetaan nimet ja niiden lkm
                    {
                        Console.WriteLine("Nimiä: " + nimet.Key + " " + nimet.Value + " kpl.");
                    }

                    Console.WriteLine("\nSortattu nimilista: ");
                    var sortatutNimet = samatNimet.OrderBy(x => x.Key); // sorttaus & tulostus

                    foreach(var nimet in sortatutNimet)
                    {
                        Console.WriteLine("Nimiä: " + nimet.Key + " " + nimet.Value + " kpl.");
                    }             
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
