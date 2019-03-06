using System;

namespace _8_1_objekti
{
    internal class Ucenik
    {

        //polja klase!!!
        public string ime = "";
        public string prezime = "";
        public DateTime datumNastanka; //(morali gore dodati using sistem da bi nam system.DateTime radio)
        public int ocjenaMatematika = 0;
        public int ocjenaEngleski = 0;
        public int ocjenaBiologija = 0;



        //konstruktor koji ne cini nista, on jednostavno mora postojati
        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
        }

        public Ucenik(string v)
        {
            this.ime = v;
        }

        //konstruktor: jer je posebna vrsta funkcije koja ima isto ime kao klasa
        public Ucenik(string v, string prez)
        {           
            this.ime = v; //povezuje v u ovom bloku sa ime tamo gore (public string ime = "";)
            this.prezime = prez;

        }

        public double Prosjek()
        {
            double prosjek = 0;

            prosjek = (double) (ocjenaMatematika + ocjenaEngleski + ocjenaBiologija) / 3;

            return prosjek;
        }

        public override string ToString()
        {
            return "Moje ime je " + this.ime + " a moj prosjek je: " + this.Prosjek().ToString("#.##");
        }
    }
}