using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_1_dog_primjer
{
    public class Osoba
    {
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);

        public event NaPromjenuImenaDelegat NaPromjenuImena;


        private string ime;

        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImena !=null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }

        
    }
}
