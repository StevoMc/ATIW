using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Kursverwaltung
{
    class Kurs
    {
        private string kursNummer;
        private string bezeichnung;
        private int dauer;
        private double gebuehr;
        private bool ausgebucht = false;
        private List<Raum> raeume;


        public Kurs()
        {
            Console.WriteLine("Kursdaten eintragen:");
            setInteractiveRaum();
            setInteractiveKursNummer();
            setInteractiveBezeichnung();
            setInteractiveDauer();
            setInteractiveGebuehr();
        }


        public Kurs(string kursNummer, string bezeichnung, int dauer, double gebuehr)
        {
            setKursNummer(kursNummer);
            this.bezeichnung = bezeichnung;
            this.dauer = dauer;
            this.gebuehr = gebuehr;
        }

        private void setInteractiveBezeichnung()
        {
            Console.Write("Bezeichnung\t> ");
            string bezeichnung = Console.ReadLine();
            if (bezeichnung != null) { setBezeichnung(bezeichnung); }

            else
            {
                setInteractiveBezeichnung();
            }
        }

        private void setInteractiveKursNummer()
        {
            Console.Write("KursNummer\t> ");
            string kursNummer = Console.ReadLine();
            if (kursNummer != null) { setKursNummer(kursNummer); }
            else
            {
                Console.Write("Invalid input");
                setInteractiveKursNummer();
            }
        }

        private void setInteractiveDauer()
        {
            Console.Write("Dauer\t> ");
            try
            {

                int dauer = Convert.ToInt32(Console.ReadLine());
                if (dauer > 0) { setDauer(dauer); }
                else
                {
                    Console.Write("Invalid input");
                    setInteractiveDauer();
                }
            }
            catch
            {
                setInteractiveDauer();
            }

        }

        private void setInteractiveGebuehr()
        {
            Console.Write("Gebuehr\t> ");
            try
            {
                double gebuehr = Convert.ToDouble(Console.ReadLine());
                if (gebuehr >= 0) { setGebuehr(gebuehr); }

                else
                {
                    Console.Write("Invalid input");
                    setInteractiveGebuehr();
                }
            }
            catch
            {
                setInteractiveGebuehr();
            }
        }

        private void setInteractiveRaum()
        {
            Console.Write("Raum\t> [nr, gr, p]");
            try
            {
                string[] raum = Console.ReadLine().Split(",");
                Raeume(raum[0])

                if (raum >= 0) { setGebuehr(gebuehr); }

                else
                {
                    Console.Write("Invalid input");
                    setInteractiveRaum();
                }
            }
            catch
            {
                setInteractiveRaum();
            }
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


        internal List<Raum> Raeume { get => raeume; set => raeume = value; }

        public bool getAusgebucht()
        {
            return this.ausgebucht;
        }
    }

}