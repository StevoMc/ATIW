namespace Kursverwaltung
{
    internal class Raum
    {
        private string raumNummer = "ABCDE";
        private double raumGroesse;
        private int maxPersonen;

        Raum() {
            this.RaumGroesse = 12;
            this.MaxPersonen = 40;
        }

        public Raum(string raumNummer, double raumGroesse, int maxPersonen)
        {
            this.RaumNummer = raumNummer;
            this.RaumGroesse = raumGroesse;
            this.MaxPersonen = maxPersonen;
        }


        public override string ToString() { return $"NR: {raumNummer} [{raumGroesse/maxPersonen}]"; }

        public string RaumNummer { get => raumNummer; set => raumNummer = value; }
        public double RaumGroesse { get => raumGroesse; set => raumGroesse = value; }
        public int MaxPersonen { get => maxPersonen; set => maxPersonen = value; }

    }
}