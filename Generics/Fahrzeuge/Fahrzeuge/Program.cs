namespace Fahrzeuge
{

    internal class Program
    {

        public static void Main(string[] args)
        {
            Auto auto = new("PB A 123");
            Fahrrad fahrrad = new("ABCD");

            Fahrzeugflotte<Fahrzeuge>? fahrzeuge = new();
            fahrzeuge?.Fahrzeuge?.Add(auto);

            fahrzeuge?.Erwerben(fahrrad);

            Console.WriteLine(fahrzeuge?.ToString());

        }
    }
}