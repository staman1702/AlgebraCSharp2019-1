using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_objekti
{
    internal class Nastavnik
    {

        public string ime = "Antonije Marcus";
        private int oib;


        public static string Opis()
        {
            return "Nastavnik je osoba koja predaje u obrazovnim ustanovama";
            //static znaci da je vezano  i ne komunicira sa ostatkom klase

        }

        public static float Koeficijent()
        {
            return 1.5f;
        }

    }
}
