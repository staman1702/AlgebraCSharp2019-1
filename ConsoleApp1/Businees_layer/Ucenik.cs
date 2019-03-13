using System;



namespace Businees_layer
{
    public class Ucenik : Osoba, IUcenik
    {              
        //private string ime = "";
        //public string prezime = "";
        //public DateTime datumNastanka; 
        public int ocjenaMatematika = 0;
        public int ocjenaEngleski = 0;
        public int ocjenaBiologija = 0;
        private Ispit prijavljeniIspit;
        //public string Ime  
        //{
        //    get => ime;
        //    set => ime = ToUpper.FirstCharToUpper(value); 
        //}



        //defaultni radi samo kod direktnog poziva npr:
        // Ucenik u99 = new Ucenik()
        public Ucenik() 
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Ucenik:Ucenik()");
        }

        public Ucenik(string v) : base() //base znaci da proslijedi na baznu klasu (osoba). preskocila defaultni konstrkt ucenika
        {
            this.Ime = v;
        }

        
        public Ucenik(string v, string prez) : this (v)
        {           
            //this.Ime = v; 
            this.prezime = prez;

        }

        public void PrijaviIspit(Ispit ispit)
        {
            this.prijavljeniIspit = ispit;
            Console.WriteLine("Uspješno ste prijavili: " + this.prijavljeniIspit.Naziv);
        }

        public double Prosjek()
        {
            double prosjek = 0;

            prosjek = (double) (ocjenaMatematika + ocjenaEngleski + ocjenaBiologija) / 3;

            return prosjek;
        }

        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek().ToString("#.##");
        }
    }
}