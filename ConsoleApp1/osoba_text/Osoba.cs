using System;

namespace osoba_text
{
    class Osoba
    {

        
        
        public DateTime datumNastanka;

        private string ime = "";
        public string Ime
        {
            get { return ime; }
            set { ime = ToUpper.FirstCharToUpper(value); }
        }

        private string prezime = "";
        public string Prezime
        {
            get { return prezime; }
            set { prezime = ToUpper.FirstCharToUpper(value); }
        }

        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Osoba:Osoba()");

        }
        
        public Osoba(string v1, string v2) 
        {
            this.Ime = v1;
            this.Prezime = v2;
        }

        public string Inicijal(string ime)
        {
            string inicijal = ime.Substring(0, 1);
            return inicijal + "." ;
        }


        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " " + this.Prezime + " i inicijali su mi: " + Inicijal(this.Ime) + Inicijal(this.Prezime).ToString();
        }
    }
}