using HCweek2a.Model;

namespace HCweek2a
{
    public class BoodschapVM
    {

        public string Naam { get; set; }

        public double Gewicht { get; set; }

        public int Aantal { get; set; }

        public BoodschapVM()
        {

        }

        public BoodschapVM(Boodschap boodschap )
        {
            this.Naam = boodschap.Naam;
            this.Aantal = boodschap.Aantal;
        }
    }
}