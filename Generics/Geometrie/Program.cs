namespace Geometrie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figur> figuren = new();

            Figur kreis5 = new Kreis((2.5, 2.5), 5, "rot");
            Figur kreis4 = new Kreis((2, 2), 4, "gelb");

            Figur rechteck3 = new Rechteck((1.5, 2), (3, 4), "blau");
            Figur rechteck4 = new Rechteck((2, 1.5), (4, 3), "schwarz");
            Figur rechteck2 = new Rechteck((1, 3), (2, 6), "gruen");

            figuren.Add(kreis5);
            figuren.Add(kreis4);
            figuren.Add(rechteck3);
            figuren.Add(rechteck4);
            figuren.Add(rechteck2);

            figuren.ForEach(f =>
            {
                Console.WriteLine(f);
            });


            Console.WriteLine(rechteck3.Equals(rechteck4));
        }
    }
}