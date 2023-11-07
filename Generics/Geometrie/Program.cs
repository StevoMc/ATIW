namespace Geometrie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figur> figuren = new()
            {
                // Figur( mitte, seiten|radius, farbe)
                new Kreis((2.5, 2.5), 5, "rot"),
                new Kreis((2, 2), 4, "gelb"),
                new Rechteck((1.5, 2), (3, 4), "blau"),
                new Rechteck((2, 1.5), (4, 3), "schwarz"),
                new Rechteck((1, 3), (2, 6), "gruen"),
                new Rechteck((1, 3), (2, 6), "gruen")
            };

            figuren.ForEach(f => Console.WriteLine(f));
            FindDuplicates(figuren);
            figuren.ForEach(f => Console.WriteLine(f));

        }

        static void FindDuplicates(List<Figur> figuren)
        {
            figuren.ForEach(a => figuren.ForEach(b =>
            {
                if (a == b) return;
                if (a.Equals(b))
                {
                    Console.WriteLine("[WARN] Duplicate Object found!");
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine("");
                }
            }));

        }
    }
}