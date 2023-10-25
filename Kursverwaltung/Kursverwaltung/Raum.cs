using System.Text.RegularExpressions;

namespace Kursverwaltung
{
    /// <summary>
    /// Klasse: Raum
    /// <para>
    /// @Author: Steven McGough
    /// </para>
    /// @Date:   25.10.2023
    /// </summary>
    internal class Raum
    {
        private string raumNummer = "";
        private double raumGroesse = 0;
        private int maxPersonen = 0;

        public Raum()
        {
            try
            {
                Console.Write("Raumdaten eingeben in dem Format:\n[ZimmerNr] [Groesse] [MaxPersonen]\n> ");
                string raumInput = Console.ReadLine() ?? "";
                if (!Regex.IsMatch(raumInput, @"^\w{1,12}\s\d+(\,\d+)?\s\d+"))
                {
                    string error = $"Invalid input: [{raumInput}]";
                    throw new Exception(error);
                }
                else
                {
                    string[] raum = raumInput.Split(' ');
                    this.RaumNummer = raum[0];
                    this.RaumGroesse = Convert.ToDouble(raum[1]);
                    this.MaxPersonen = Convert.ToInt32(raum[2]);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Raum(string raumNummer, double raumGroesse, int maxPersonen)
        {
            this.RaumNummer = raumNummer;
            this.RaumGroesse = raumGroesse;
            this.MaxPersonen = maxPersonen;
        }


        public override string ToString() { return $"[{raumNummer}]: ({raumGroesse}m², maximale Personenanzahl: {maxPersonen})"; }

        public string RaumNummer { get => raumNummer; set => raumNummer = value; }
        public double RaumGroesse { get => raumGroesse; set => raumGroesse = value; }
        public int MaxPersonen { get => maxPersonen; set => maxPersonen = value; }

    }
}