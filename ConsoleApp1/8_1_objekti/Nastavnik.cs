using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_objekti
{
    internal class Nastavnik
    {

        private string ime = "Antonije Marcus";
        private int oib;

        public int Oib //tajan
        {
           
            set => oib = value; //write only, upisemo ga ali ga nikada ne isprintamo u gl program (...set)
        }

        public int PartOib { get => int.Parse(oib.ToString().Substring(0,4)); }

        public string Ime
        {
            get => ime; //samo ispis. tj read only (...get)
        }

        public static string Opis()
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama";
            //static znaci da je vezano  i ne komunicira sa ostatkom klase

        }
        /// <summary>
        /// ovo dohvaca koeficijent za izracun place
        /// </summary>
        /// <returns>float</returns>
        public static float Koeficijent()
        {
            return 1.5f;
        }
        
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj oib je: " + this.PartOib.ToString() +"#####.";
        }
    }
}
