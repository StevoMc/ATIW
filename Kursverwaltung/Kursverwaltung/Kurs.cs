using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace Kursverwaltung
{
    class Kurs
    {
        private string kursNummer;
        private string bezeichnung;
        private int dauer;
        private double gebuehr;
        private bool ausgebucht = false;

        public Kurs()
        {
            Console.WriteLine("Kursdaten eintragen:");
            bool fertig = false;
            while (!fertig)
            {
                try
                {
                    Console.Write("KursNummer\t> ");
                    string kursNummer = Console.ReadLine();
                    if (kursNummer == null) { continue; }
                    setKursNummer(kursNummer);
                }
                catch
                {
                    throw new Exception("[KURS]: kursnummer error");
                }

                try
                {
                    Console.Write("Bezeichnung\t> ");
                    string bezeichnung = Console.ReadLine();
                    if (bezeichnung == null) { continue; }
                    setBezeichnung(bezeichnung);
                }
                catch
                {
                    throw new Exception("[KURS]: bezeichnung error");
                }

                try
                {
                    Console.Write("Dauer\t> ");
                    int dauer = Convert.ToInt32(Console.ReadLine());
                    if (dauer < 0) { continue; }
                    setDauer(dauer);
                }
                catch
                {
                    throw new Exception("[KURS]: dauer error");
                }

                try
                {
                    Console.Write("Gebuehr\t> ");
                    double gebuehr = Convert.ToDouble(Console.ReadLine());
                    if (gebuehr < 0) { continue; };
                    setGebuehr(gebuehr);
                }
                catch
                {
                    throw new Exception("[KURS]: gebuehr error");
                }

                fertig = true;

            }
        }


        public Kurs(string kursNummer, string bezeichnung, int dauer, double gebuehr)
        {
            setKursNummer(kursNummer);
            this.bezeichnung = bezeichnung;
            this.dauer = dauer;
            this.gebuehr = gebuehr;
        }

        public override string ToString()
        {
            return String.Format("Kurs {0}:\t{1} dauert {2} Tage. Kostet: {3} Euro und Status von Ausgebucht ist: {4}", this.kursNummer, this.bezeichnung, this.dauer, this.gebuehr, this.ausgebucht);
        }

        public void setKursNummer(string kursNummer)
        {
            if (kursNummer.Length < 1)
            {
                this.kursNummer = "Kurs";
            }
            else if (kursNummer.Length > 6)
            {
                this.kursNummer = kursNummer.Substring(0, 6);
                // throw new ArgumentException("Kursnummber ist nicht gueltig");
            }
            else
            {
                this.kursNummer = kursNummer;
            }
        }

        public string getKursNummer()
        {
            return this.kursNummer;
        }

        public void setBezeichnung(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;
        }

        public string getBezeichnung()
        {
            return this.bezeichnung;
        }

        public void setDauer(int dauer)
        {
            this.dauer = dauer;
        }

        public int getDauer()
        {
            return this.dauer;
        }

        public void setGebuehr(double gebuehr)
        {
            this.gebuehr = gebuehr;
        }

        public double getGebuehr()
        {
            return this.gebuehr;
        }

        public void setAusgebucht(bool ausgebucht)
        {
            this.ausgebucht = ausgebucht;
        }

        public bool getAusgebucht()
        {
            return this.ausgebucht;
        }
    }

}