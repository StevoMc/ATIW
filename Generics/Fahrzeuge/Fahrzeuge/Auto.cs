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

        public Auto(string kennzeichen, string besitzer): base(besitzer) => Kennzeichen = kennzeichen;

        public override string ToString()
        {
            string className = this.GetType().Name.ToUpper();
            return $"[{className}] {Kennzeichen} : {Besitzer}";
        }

        public string Kennzeichen { get => kennzeichen ?? ""; set => kennzeichen = value; }
    }
}
