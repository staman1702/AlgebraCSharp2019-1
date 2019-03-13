namespace Businees_layer
{
    public class Ispit
    {
        private string naziv="Matematika";
        private string v;

        public Ispit(string v)
        {
            this.naziv = v;
        }

        public string Naziv { get => naziv; set => naziv = value; }
    }
}