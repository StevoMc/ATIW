using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace Kursverwaltung
{
  /// <summary>
  /// Klasse: Kurs
  /// <para>
  /// @Author: Steven McGough
  /// </para>
  /// @Date:   25.10.2023
  /// </summary>
  class Kurs
  {
    private string kursNummer = "undefined";
    private string bezeichnung = "undefined";
    private int dauer = 0;
    private double gebuehr = 0;
    private bool ausgebucht = false;
    private Raum? raum;

    public Kurs()
    {
      Console.WriteLine("Kursdaten eintragen:");
      SetInteractiveKursNummer();
      SetInteractiveBezeichnung();
      SetInteractiveDauer();
      SetInteractiveGebuehr();
      SetInteractiveRaum();

      if (Kursnummer == "undefiend" || Bezeichnung == "undefiend" || Dauer == 0 || Gebuehr == 0)
      {
        throw new Exception("[ERROR]: Data unchanged");
      }
    }
    /// <summary>
    /// Initialisiert eine neue Instanz der Klasse <see cref="Kurs"/> mit den angegebenen Parametern.
    /// </summary>
    /// <param name="kursNummer">Die Kursnummer.</param>
    /// <param name="bezeichnung">Die Kursbeschreibung.</param>
    /// <param name="dauer">Die Kursdauer in Stunden.</param>
    /// <param name="gebuehr">Die Kursgebühr.</param>
    public Kurs(string kursNummer, string bezeichnung, int dauer, double gebuehr)
    {
      Kursnummer = kursNummer;
      Bezeichnung = bezeichnung;
      Dauer = dauer;
      Gebuehr = gebuehr;
    }

    private void SetInteractiveBezeichnung()
    {
      Console.Write("Was ist die Kursbezeichnung?\n> ");
      string input = Console.ReadLine() ?? "";
      if (input != "") { Bezeichnung = bezeichnung; }
      else
      {
        SetInteractiveBezeichnung();
      }
    }
    private void SetInteractiveKursNummer()
    {
      Console.Write("Was ist die Kursnummer?\n> ");
      string kursNummer;
      for (int i = 0; i < 3; i++)
      {
        kursNummer = Console.ReadLine() ?? "";
        if (!Regex.IsMatch(kursNummer, @"^\w{1,6}"))
        {
          Kursnummer = kursNummer;
          return;
        }
        else
        {
          Console.WriteLine("Invalid input");
        }
      }
      Kursnummer = "Kurs";
    }
    private void SetInteractiveDauer()
    {
      Console.Write("Wie lange dauert der Kurs in Tagen?\n> ");
      try
      {

        int dauer = Convert.ToInt32(Console.ReadLine());
        if (dauer > 0) { Dauer = dauer; }
        else
        {
          Console.WriteLine("Invalid input");
          SetInteractiveDauer();
        }
      }
      catch
      {
        SetInteractiveDauer();
      }

    }

    private void SetInteractiveGebuehr()
    {
      Console.Write("Was ist die Gebuehr für den Kurs?\n> ");
      try
      {
        double gebuehr = Convert.ToDouble(Console.ReadLine());
        if (gebuehr >= 0) { Gebuehr = gebuehr; }

        else
        {
          Console.WriteLine("Invalid input");
          SetInteractiveGebuehr();
        }
      }
      catch
      {
        SetInteractiveGebuehr();
      }
    }

    private void SetInteractiveRaum()
    {
      try
      {
        Raum r = new();
        Console.WriteLine(r.ToString());
      }
      catch (Exception e)
      {
        Console.WriteLine("Error: {0}", e.Message);
        SetInteractiveRaum();
      }
    }

    /// <summary>
    /// Returns a string representation of the Kurs object.
    /// </summary>
    /// <returns>A string containing the kursNummer, dauer, bezeichnung, gebuehr, and ausgebucht status.</returns>
    public override string ToString()
    {
      string className = GetType().Name.ToUpper();
      return $"[{className}]\t{kursNummer}\n\t{kursNummer} dauert {dauer} Tage\n\tBeschreibung: {bezeichnung}\n\tKostet: {gebuehr} Euro\n\tStatus: {(ausgebucht ? "" : "Nicht")} Ausgebucht\n\t{(Raumeintrag != null ? $"Raum: {Raumeintrag?.ToString()}" : "")}";
    }

    /// <summary>
    /// Validates the given kursNummer string and returns a valid kursNummer.
    /// </summary>
    /// <param name="kursNummer">The kursNummer string to be validated.</param>
    /// <returns>A valid kursNummer string.</returns>
    public string ValidKursNummer(string kursNummer)
    {
      if (Regex.IsMatch(kursNummer, @"^\w{1,6}"))
      {
        return kursNummer;
      }

      if (kursNummer.Length > 6)
      {
        return kursNummer.Substring(0, 6);
      }

      return "Kurs";
    }

    public void SetRaum(Raum? raum)
    {
      Raumeintrag = raum;
    }

    public void GetRaume()
    {
      Console.WriteLine(Raumeintrag?.ToString());
    }

    // getter and setter
    public double Gebuehr
    {
      get => this.gebuehr;
      set => this.gebuehr = value;
    }
    public string Kursnummer
    {
      get => this.kursNummer;
      set => this.kursNummer = ValidKursNummer(value);
    }
    public string Bezeichnung
    {
      get => this.bezeichnung;
      set => this.bezeichnung = value;
    }
    public int Dauer
    {
      get => this.dauer;
      set => this.dauer = value;
    }
    public bool Ausgebucht
    {
      get => this.ausgebucht;
      set => this.ausgebucht = value;
    }
    public Raum? Raumeintrag
    {
      get => this.raum;
      set => this.raum = value;
    }
  }
}