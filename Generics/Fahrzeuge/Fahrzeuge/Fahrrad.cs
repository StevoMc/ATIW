﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeuge
{
    internal class Fahrrad : Fahrzeuge
    {
        private string? rahmennr;
        public Fahrrad(string rahmennr, string besitzer): base(besitzer) => Rahmennr = rahmennr;

        public override string ToString()
        {
            string className = this.GetType().Name.ToUpper();
            return $"[{className}] {Rahmennr} : {Besitzer}";
        }

        public string Rahmennr { get => rahmennr ?? ""; set => rahmennr = value; }
    }
}
