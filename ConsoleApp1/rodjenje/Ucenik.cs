using System;

namespace rodjenje
{
    internal class Ucenik
    {
        private string ime = "";
        private string prezime = "";
        private DateTime datumRodenja;
        private double prosjek;

        public string Ime { get => ime; set => ime = ToUpper.FirstCharToUpper(value); }
        public string Prezime { get => prezime; set => prezime = ToUpper.FirstCharToUpper(value); }
        public DateTime DatumRodenja
        { get => datumRodenja; set => datumRodenja = (value); }
        public double Prosjek { get => prosjek; set => prosjek = value; }

        public Ucenik()
        {
        }

        public Ucenik(string v1, string v2, DateTime d1, double p)
        {
            this.Ime = v1;
            this.Prezime = v2;
            this.DatumRodenja = d1;
            this.Prosjek = p;
        }

        public int Starost
        {
            get
            {
                DateTime sad = DateTime.Now;
                TimeSpan st = sad.Subtract(DatumRodenja);
                return st.Days / 365;
            }
            
        }

        public override string ToString()
        {
            return "Pozdrav. Ja sam " + this.Ime + " " + this.Prezime + " rođen sam "
                + this.DatumRodenja.ToString("dd. MMMM yyyy")
                + ". \nMoj prosjek je " + this.Prosjek + " i star sam " + this.Starost + 
                " godina.\n".ToString();
        }

    }
}