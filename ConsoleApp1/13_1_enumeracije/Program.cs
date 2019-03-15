using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_enumeracije
{

    public enum RadniDani
    {
        Ponedjeljak=1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak            
    }

    public enum Ocjene
    {
        Nedovoljan=1,
        Dovoljan,
        Dobar,
        Vrlodobar,
        Odlican
    }

    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Treci,
        Cetvrti
    }


    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o.");
            algebra.Kat = Katovi.Treci;
        
        }
    }

    class Firma
    {
        private Katovi kat;
        private string naziv;
        

        public Firma(string v)
        {
            this.Naziv = v;
        }

        public Katovi Kat { get => kat; set => kat = value; }
        public string Naziv { get => naziv; set => naziv = value; }
    }
}
