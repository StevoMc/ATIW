using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge
{
    internal class Fahrzeugflotte<T>
    {
        private List<T>? fahrzeuge;
        public Fahrzeugflotte() => Fahrzeuge = new();

        public override string ToString()
        {
            string fahrzeugListe = "";
            int index = 1;
            fahrzeuge?.ForEach(fahrzeug => fahrzeugListe += $"[{index++}]: {fahrzeug?.ToString()}\n");
            return fahrzeugListe;
        }

        public void Erwerben(T fahrzeug)
        {
            Fahrzeuge?.Add(fahrzeug);
        }

        public List<T>? Fahrzeuge { get => fahrzeuge; set => fahrzeuge = value; }
    }
}
