namespace GrandFinaleA.ViewModel
{
    public class DoelVM
    {
        private Doel doel;

        public DoelVM(Doel doel)
        {
            this.doel = doel;
        }

        public string Omschrijving
        {
            get { return doel.Omschrijving;  }
            set { doel.Omschrijving = value;  }
        }

        public int AantalIdeeen
        {
            get { return doel.Idees.Count; }
        }

    }
}