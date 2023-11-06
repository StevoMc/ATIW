using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge
{
    internal class Fahrzeuge
    {

        protected string besitzer;

        public Fahrzeuge(string besitzer) => this.besitzer = besitzer;


        public string Besitzer { get => this.besitzer; set => besitzer = value; }

        public override string ToString()
        {
            return $"Besitzer: {Besitzer}";
        }

        public string ToString(string besitzer)
        {
            return $"Besitzer: {besitzer}";
        }
    }
}
