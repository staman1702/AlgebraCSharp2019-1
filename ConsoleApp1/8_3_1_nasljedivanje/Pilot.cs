namespace _8_3_1_nasljedivanje

{
    internal class Pilot : Vozac
    {
        public bool Kategorija_x;

        public Pilot(string v1, string v2) : base(v1, v2)
        { }

        public override string ToString()
        {

            if (this.Kategorija_x)
            {
                return base.ToString() + " X";
            }
            else
            {
                return base.ToString();
            }
        }
    }
}