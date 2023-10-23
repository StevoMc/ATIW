namespace Kursverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kurs k = new Kurs();
            Console.WriteLine(k.ToString());

            Kurs a = new Kurs("A", "Alphabet", 10, 100);
            Console.WriteLine(a.ToString());

        }
    }
}