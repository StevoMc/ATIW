using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    internal class Rechteck: Figur
    {
        private (double a, double b) _seiten;

        public Rechteck((double xMitte, double yMitte) mitte, (double a, double b) seiten, string? farbe) : base(mitte, farbe) {
            Seiten = seiten;
        }

        public (double a, double b) Seiten { get => _seiten; set => _seiten = value; }

        public override string ToString()
        {
            return $"[Rechteck]:\t Seiten:{Seiten} Mitte:{Mitte} Farbe:{Farbe}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Rechteck rechteck && (Seiten == rechteck.Seiten || Seiten.a == rechteck.Seiten.b && Seiten.b == rechteck.Seiten.a) && Farbe == rechteck.Farbe;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Seiten);
        }
    }
}
