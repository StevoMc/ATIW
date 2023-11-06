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

            fahrzeuge?.Erwerben(new Auto("PB A 13", "NotMe"));
            fahrzeuge?.Erwerben(new Auto("MA AN 123", "Nady"));
            fahrzeuge?.Erwerben(new Fahrrad("ASDFDSDF", "Me"));

            Console.WriteLine(fahrzeuge);
        }
    }
}