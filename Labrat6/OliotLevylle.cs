using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    [Serializable]
    public class OliotLevylle
    {
        public string Nimi { get; set; }
        public string Kanava { get; set; }
        public string Aika { get; set; }
        public string Info { get; set; }

        public OliotLevylle () { }
        public OliotLevylle(string nimi, string kanava, string aika, string info)
        {
            Nimi = nimi;
            Kanava = kanava;
            Aika = aika;
            Info = info;
        }
    }
    public class TestaaOliot {

        public static void Testaa()
        {
            try
            {
                List<OliotLevylle> tv = new List<OliotLevylle>();

                tv.Add(new OliotLevylle("Paras ohjelma", "Yle 1", "19.00-22.00", "Ohjelma on paras plaaplaa."));
                tv.Add(new OliotLevylle("Paras ohjelma 2", "Yle 2", "10.00-12.00", "Ohjelma on tosi hyvä plaaplaa."));
                tv.Add(new OliotLevylle("Paras ohjelma 3", "MTV3", "15.45-16.20", " Plalalaplaplaalaaplaa."));
                tv.Add(new OliotLevylle("Paras sarja", "Nelonen", "13.00-13.15", "Tosi hyvä sarja."));

                //luodaan tiedosto olioille
                Stream tvKanavat = new FileStream("TvKanavat.bin", FileMode.Create, FileAccess.Write, FileShare.None);

                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(tvKanavat, tv); //kirjoitetaan lista levylle
                tvKanavat.Close();

                Stream avaaStream = new FileStream("TvKanavat.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<OliotLevylle> lueKanavat = (List<OliotLevylle>)formatter.Deserialize(avaaStream);

                avaaStream.Close();

                foreach (OliotLevylle x in lueKanavat)
                {
                    Console.WriteLine("Ohjelman nimi: " + x.Nimi + "\nKanava: " + x.Kanava + "\nKesto: " + x.Aika + "\nInfo: " + x.Info);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

