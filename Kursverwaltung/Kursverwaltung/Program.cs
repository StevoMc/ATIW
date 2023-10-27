using System.Text.RegularExpressions;

namespace Kursverwaltung
{
    /// <summary>
    /// Program: Kursverwaltung
    /// <para>
    /// @Author: Steven McGough
    /// </para>
    /// @Date:   25.10.2023
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kurs k = new();
            // Console.WriteLine(k.ToString());
            // Kurs a = new Kurs("Test", "Alphabet", 10, 100);
            // Console.WriteLine(a.ToString());

            Kursliste kursliste = new();
            Raumliste raumliste = new();

            kursliste.AddKurs(new Kurs("Kurs1", "Test", 10, 100));
            kursliste.AddKurs(new Kurs("Kurs2", "Test", 10, 100));
            kursliste.AddKurs(new Kurs("Kurs3", "Test", 10, 100));

            Console.WriteLine(kursliste.ToString());
            Console.WriteLine(kursliste.GetKurs("Kurs1"));
            Console.WriteLine("\n");
            Console.WriteLine(kursliste.ToString());
            kursliste.RemoveKurs("Kurs1");
            Console.WriteLine("\n");
            Console.WriteLine(kursliste.ToString());
            Console.WriteLine("\n");

            raumliste.AddRaum(new Raum("OG230", 45.8, 25));
            raumliste.AddRaum(new Raum("EG180", 250, 250));
            raumliste.AddRaum(new Raum("UG004", 30.3, 10));
            Console.WriteLine(raumliste.ToString());
            raumliste.RemoveRaum("Kurs Raum");
            Console.WriteLine(raumliste.ToString());
            Console.WriteLine(raumliste.GetRaum("Meeting Raum"));

            Kurs? k = kursliste.GetKurs("Kurs2");
            k?.SetRaum(raumliste.GetRaum("OG230"));
            k?.GetRaume();

            Console.WriteLine(kursliste.ToString());


            var nr = Regex.Match("FS223", @"^(?'mail'\w{1,6})");
            Console.WriteLine(nr.Groups["mail"]);

        }
    }
}