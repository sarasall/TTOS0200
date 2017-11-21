using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Joukkue
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            //Maalivahdit
            pelaajat.Add(new Pelaaja { Etunimi = "Eetu", Sukunimi = "Laurikainen", Katisyys = "Vasen", Numero = 41 });
            pelaajat.Add(new Pelaaja { Etunimi = "Juho", Sukunimi = "Olkinuora", Katisyys = "Vasen", Numero = 45 });
            //Puolustajat
            pelaajat.Add(new Pelaaja { Etunimi = "Anttoni", Sukunimi = "Honka", Katisyys = "Oikea", Numero = 3 });
            pelaajat.Add(new Pelaaja { Etunimi = "Juuso", Sukunimi = "Vainio", Katisyys = "Oikea", Numero = 5 });
            pelaajat.Add(new Pelaaja { Etunimi = "Mikko", Sukunimi = "Kalteva0", Katisyys = "Vasen", Numero = 7 });
            pelaajat.Add(new Pelaaja { Etunimi = "Jaakko", Sukunimi = "Jokinen", Katisyys = "Vasen", Numero = 16 });
            pelaajat.Add(new Pelaaja { Etunimi = "Alex", Sukunimi = "Lindroos", Katisyys = "Vasen", Numero = 34 });
            pelaajat.Add(new Pelaaja { Etunimi = "Roni", Sukunimi = "Allen", Katisyys = "Vasen", Numero = 36 });
            pelaajat.Add(new Pelaaja { Etunimi = "Ossi", Sukunimi = "Ikonen", Katisyys = "Vasen", Numero = 37 });
            pelaajat.Add(new Pelaaja { Etunimi = "Nolan", Sukunimi = "Yonkman", Katisyys = "Oikea", Numero = 43 });
            pelaajat.Add(new Pelaaja { Etunimi = "Mikko", Sukunimi = "Mäenpää", Katisyys = "Vasen", Numero = 47 });
            pelaajat.Add(new Pelaaja { Etunimi = "Joona", Sukunimi = "Erving", Katisyys = "Vasen", Numero = 53 });
            pelaajat.Add(new Pelaaja { Etunimi = "Olli", Sukunimi = "Aitola", Katisyys = "Vasen", Numero = 60 });
            pelaajat.Add(new Pelaaja { Etunimi = "Tuomas", Sukunimi = "Salmela", Katisyys = "Vasen", Numero = 61 });
            pelaajat.Add(new Pelaaja { Etunimi = "Mikko", Sukunimi = "Kuukka", Katisyys = "Vasen", Numero = 91 });
            //Hyökkääjät
            pelaajat.Add(new Pelaaja { Etunimi = "Joonas", Sukunimi = "Nättinen", Katisyys = "Oikea", Numero = 9 });
            pelaajat.Add(new Pelaaja { Etunimi = "Samuli", Sukunimi = "Ratinen", Katisyys = "Vasen", Numero = 11 });
            pelaajat.Add(new Pelaaja { Etunimi = "Jani", Sukunimi = "Tuppurainen", Katisyys = "Vasen", Numero = 12 });
            pelaajat.Add(new Pelaaja { Etunimi = "Antti", Sukunimi = "Suomela", Katisyys = "Vasen", Numero = 14 });
            pelaajat.Add(new Pelaaja { Etunimi = "Juha-Pekka", Sukunimi = "Hytönen", Katisyys = "Vasen", Numero = 15 });
            pelaajat.Add(new Pelaaja { Etunimi = "Juuso", Sukunimi = "Puustinen", Katisyys = "Oikea", Numero = 17 });
            pelaajat.Add(new Pelaaja { Etunimi = "Valtteri", Sukunimi = "Hotakainen", Katisyys = "Vasen", Numero = 21 });
            pelaajat.Add(new Pelaaja { Etunimi = "Ossi", Sukunimi = "Louhivaara", Katisyys = "Oikea", Numero = 23 });
            pelaajat.Add(new Pelaaja { Etunimi = "Jarkko", Sukunimi = "Immonen", Katisyys = "Oikea", Numero = 26 });
            pelaajat.Add(new Pelaaja { Etunimi = "Riku", Sukunimi = "Tiainen", Katisyys = "Vasen", Numero = 27 });
            pelaajat.Add(new Pelaaja { Etunimi = "Miika", Sukunimi = "Lahti", Katisyys = "Vasen", Numero = 28 });
            pelaajat.Add(new Pelaaja { Etunimi = "Joel", Sukunimi = "Sund", Katisyys = "Oikea", Numero = 29 });
            pelaajat.Add(new Pelaaja { Etunimi = "Arttu", Sukunimi = "Likola", Katisyys = "Vasen", Numero = 31 });
            pelaajat.Add(new Pelaaja { Etunimi = "Jerry", Sukunimi = "Turkulainen", Katisyys = "Oikea", Numero = 32 });
            pelaajat.Add(new Pelaaja { Etunimi = "Micke", Sukunimi = "Saari", Katisyys = "Vasen", Numero = 40 });
            pelaajat.Add(new Pelaaja { Etunimi = "Janne", Sukunimi = "Kolehmainen", Katisyys = "Vasen", Numero = 55 });
            pelaajat.Add(new Pelaaja { Etunimi = "Henri", Sukunimi = "Kanninen", Katisyys = "Vasen", Numero = 71 });
            pelaajat.Add(new Pelaaja { Etunimi = "Robert", Sukunimi = "Rooba", Katisyys = "Vasen", Numero = 88 });

            return pelaajat;
        }
    }
        public class Pelaaja
        {
            public string Etunimi { get; set; }
            public string Sukunimi { get; set; }
            public string Katisyys { get; set; }
            public int Numero { get; set; }

            public Pelaaja() { }

            public Pelaaja(string etunimi, string sukunimi, string katisyys, int nro)
            {
                Etunimi = etunimi;
                Sukunimi = sukunimi;
                Katisyys = katisyys;
                Numero = nro;
            }
            public override string ToString()
            {
                return "Nimi: " + Etunimi + " " + Sukunimi + " | Kätisyys: " + Katisyys + " | Pelaajanumero: #" + Numero;
            }
        }
}

