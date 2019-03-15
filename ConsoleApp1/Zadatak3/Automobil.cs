using System;


namespace Zadatak3
{
    internal class Automobil
    {
        private string naziv = "";
        public int godiste;
        public double cijena;
        //public double ukupnaCijena;

        public string Naziv
        {
            get => naziv;
            set => naziv = ToUpper.FirstCharToUpper(value);
        }
        public int Godiste
        {
            get => godiste;
            set => godiste = value;
        }
        public double Cijena
        {
            get => cijena;
            set => cijena = value;
        }

        public Automobil()
        { }

        public Automobil(string v1, int i1, double d1)
        {
            this.Naziv = v1;
            this.Godiste = i1;
            this.Cijena = d1;

        }

        public int Starost()
        {
            int tekuca = int.Parse(DateTime.Now.Year.ToString());





            return tekuca - Godiste;

            
            

        }

        public double UkupnaCijena()
        {
          
                if (Cijena <= 70000)
                {
                    return (double)Cijena * 1.3;
                }
                if (Cijena >= 1000000)
                {
                    return (double)Cijena * 1.5;
                }
                else
                {
                    return (double)Cijena * 1.4;
                }

            
        }

        public override string ToString()
        {
            return "Naziv auta: " + this.Naziv + ", godina proizvodnje je " + this.Godiste + ", starost auta je "
                + Starost() + " godina, a ukupna cijena je " + UkupnaCijena().ToString("#.##") + "hrk.".ToString();
        }
    }
}