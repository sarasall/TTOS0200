using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Kortti
    {
        public string Maa { get; set; }
        public int KortinNro { get; set; }

        public Kortti () { }

        public Kortti (string maa, int korttinro) {
            Maa = maa;
            KortinNro = korttinro;
        }

        public override string ToString ()
        {        
            return ". kortti on: " + Maa + " " + KortinNro + " "; 
        }
    }
    public class Pakka
    {
        public List<Kortti> korttipakka { get; }
        
        int laskuri = 0;

        public Pakka()
        {
            korttipakka = new List<Kortti>();
        }

        public void LisaaKortteja()
        {
            for (int i = 0; i < 13; i ++)
            {                
                korttipakka.Add(new Kortti { Maa = "Hertta", KortinNro = i + 1 });
            }
            for (int i = 0; i < 13; i++)
            {
                korttipakka.Add(new Kortti { Maa = "Pata", KortinNro = i + 1 });
            }
            for (int i = 0; i < 13; i++)
            {
                korttipakka.Add(new Kortti { Maa = "Ruutu", KortinNro = i + 1 });
            }
            for (int i = 0; i < 13; i++)
            {
                korttipakka.Add(new Kortti { Maa = "Risti", KortinNro = i + 1 });
            }          
        }
        public override string ToString()
        {
            foreach (Kortti x in korttipakka) // loopataan lista läpi
            {
                laskuri++;
                Console.WriteLine(" " + laskuri + x.ToString());
            }
            return  "";
        }
        public void SekoitaPakka ()
        {
            laskuri = 0; //nollataan laskuri tulostusta varten
            Random randompakka = new Random();

            int yhtKortteja = korttipakka.Count-1;
            
            while(yhtKortteja > 0)
            {
                var index = randompakka.Next(yhtKortteja+1); //  arvotaan randomnro 1-52 indexiksi
                var tmp = korttipakka[index]; // Lisätään arvottu muuttuja väliaikaiseen muuttujaans
                // swapataan korttien paikkoja
                korttipakka[index] = korttipakka[yhtKortteja];
                korttipakka[yhtKortteja] = tmp;
                yhtKortteja--;
            }           
        }
    }
    public class TestaaKortit
    {
        public static void Testaa()
        {
            Pakka uusipakka = new Pakka();
            uusipakka.LisaaKortteja(); 
            Console.WriteLine("Korttipakka järjestyksessä: ");
            uusipakka.ToString();
            
            Console.WriteLine("Sekoitettu korttipakka: ");
            uusipakka.SekoitaPakka();
            uusipakka.ToString();
        }
    }
}
