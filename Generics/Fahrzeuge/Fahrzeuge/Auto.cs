using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge
{
    internal class Auto : Fahrzeuge
    {
        private string? kennzeichen;


        public Auto()
        {
            Kennzeichen = "WM SM 2001";
        }

        public Auto(string kennzeichen) => Kennzeichen = kennzeichen;

        public override string ToString()
        {
            string className = this.GetType().Name.ToUpper();
            return $"[{className}] {Kennzeichen}";
        }

        public string Kennzeichen { get => kennzeichen ?? ""; set => kennzeichen = value; }
    }
}
