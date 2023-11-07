using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    internal class Kreis: Figur
    {
        double _radius;

        public Kreis((double xMitte, double yMitte) mitte,  double radius, string farbe) : base(mitte, farbe)
        {
            Radius = radius;
        }

        public double Radius { get => _radius; set => _radius = value; }

        public override string ToString()
        {
            return $"[KREIS]:\t Radius:{Radius} Mitte:{Mitte} Farbe:{Farbe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Kreis kreis &&
                   Radius == kreis.Radius && Farbe == kreis.Farbe;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Radius);
        }
    }
}
