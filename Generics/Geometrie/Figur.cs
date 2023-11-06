namespace Geometrie
{
    internal class Figur
    {
        (double _xMitte, double _yMitte) _mitte;
        string? _farbe;


        public Figur((double xMitte, double yMitte) mitte, string? farbe)
        {
            Mitte = mitte;
            Farbe = farbe;
        }

        public void SetMittelPunkt(double xMitte, double yMitte)
        {
            Mitte = (xMitte, yMitte);
        }

        public (double _xMitte, double _yMitte) Mitte { get => _mitte; private set => _mitte = value; }
        public string? Farbe { get => _farbe; private set => _farbe = value; }

        public override string ToString()
        {
            return $"Figur: Mitte:{Mitte} Farbe:{Farbe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Figur figur &&
                   Mitte.Equals(figur.Mitte) &&
                   Farbe == figur.Farbe;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Mitte, Farbe);
        }
    }
}
