namespace Kursverwaltung
{
  class Raumliste
  {
    private List<Raum> raeume;

    public Raumliste()
    {
      raeume = new List<Raum>();
    }

    public bool AddRaum(Raum raum)
    {
      Console.WriteLine($"[Raumliste] Raum {raum.RaumNummer} wird hinzugefügt");
      raeume.Add(raum);
      return true;

    }

    public bool RemoveRaum(string raumNummer)
    {
      Console.WriteLine($"[Raumliste] Raum {raumNummer} wird geloescht");
      foreach (Raum raum in raeume)
      {
        if (raum.RaumNummer.Equals(raumNummer))
        {
          raeume.Remove(raum);
          return true;
        }
      }
      return false;
    }

    public Raum? GetRaum(string raumNummer)
    {
      Console.WriteLine($"[Raumliste] Raum {raumNummer} wird gesucht");
      foreach (Raum raum in raeume)
      {
        if (raum.RaumNummer.Equals(raumNummer))
        {
          return raum;
        }
      }
      return null;
    }

    public override string ToString()
    {
      string output = "[Raumliste]\n";
      foreach (Raum raum in raeume)
      {
        output += raum.ToString() + "\n";
      }
      return output;
    }

    public List<Raum> Raeume
    {
      get => raeume;
      private set => raeume = value;
    }
  }
}