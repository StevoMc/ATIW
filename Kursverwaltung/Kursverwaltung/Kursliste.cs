namespace Kursverwaltung
{
  /// <summary>
  /// Klasse: Kursliste
  /// <para>
  /// @Autor: Steven McGough
  /// </para>
  /// @Datum: 25.10.2023
  /// </summary>
  class Kursliste
  {
    private List<Kurs> kursListe;

    public Kursliste()
    {
      kursListe = new List<Kurs>();
    }

    /// <summary>
    /// Fügt einen neuen Kurs zur Liste von Kursen hinzu.
    /// </summary>
    /// <param name="kurs">Der hinzuzufügende Kurs.</param>
    /// <returns>True</returns>
    public bool AddKurs(Kurs kurs)
    {
      Console.WriteLine($"[Kursliste] Kurs {kurs.Kursnummer} wird hinzugefügt");
      kursListe.Add(kurs);
      return true;
    }

    /// <summary>
    /// Entfernt einen Kurs aus der Liste von Kursen.
    /// </summary>
    /// <param name="kursNummer">Die Kursnummer des zu entfernenden Kurses.</param>
    /// <returns>True, wenn der Kurs erfolgreich entfernt wurde, andernfalls false.</returns>
    public bool RemoveKurs(string kursNummer)
    {
      Console.WriteLine($"[Kursliste] Kurs {kursNummer} wird geloescht");
      foreach (Kurs kurs in kursListe)
      {
        if (kurs.Kursnummer.Equals(kursNummer))
        {
          kursListe.Remove(kurs);
          return true;
        }
      }
      return false;
    }

    /// <summary>
    /// Sucht nach einem Kurs mit der angegebenen Kursnummer in der Liste von Kursen.
    /// </summary>
    /// <param name="kursNummer">Die zu suchende Kursnummer.</param>
    /// <returns>Der Kurs mit der angegebenen Kursnummer oder null, wenn ein solcher Kurs nicht gefunden wurde.</returns>
    public Kurs? GetKurs(string kursNummer)
    {
      Console.WriteLine($"[Kursliste] Kurs {kursNummer} wird gesucht");
      foreach (Kurs kurs in kursListe)
      {
        if (kurs.Kursnummer.Equals(kursNummer))
        {
          return kurs;
        }
      }
      return null;
    }

    /// <summary>
    /// Überschreibt die ToString-Methode, die Kursliste zurückzugeben.
    /// </summary>
    /// <returns>Eine Zeichenfolgendarstellung des Kursliste-Objekts.</returns>
    public override string ToString()
    {
      string output = "";
      foreach (Kurs kurs in kursListe)
      {
        output += kurs.ToString() + "\n";
      }
      return output;
    }

    // Getter & Setter
    public List<Kurs> KursListe
    {
      get => kursListe;
      private set => kursListe = value;
    }
  }
}
