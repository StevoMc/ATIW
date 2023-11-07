SELECT
  *
FROM
  kunden;

-- Aktualisieren Sie die Kunden_Artikel-Tabelle um die Spalte Anzahl
ALTER TABLE kunden_artikel ADD anzahl NUMBER;

-- Geben Sie zu den vorhandenen Datensätzen noch entsprechende Beispielwerte eine
SELECT
  *
FROM
  artikel;

SELECT
  *
FROM
  kunden_artikel;

INSERT INTO kunden_artikel VALUES(
  9876,
  6155,
  2
);

-- Erstellen Sie die passenden Abfragen zur Ausgabe der folgenden Daten
-- Liefere eine Liste der bestellten Artikelbezeichnungen und Artikelanzahl des Kunden mit Namen XYZ.

SELECT
  k.vorname,
  k.nachname,
  a.bezeichnung,
  ka.anzahl
FROM
  kunden         k
  JOIN kunden_artikel ka
  ON k.id = ka.kundenid JOIN artikel a
  ON a.artikelnummer = ka.artikelnummer;

-- Wie viele Artikel mit der Artikelnummer XYZ sind bestellt worden (insgesamt).

SELECT
  SUM(anzahl)
FROM
  kunden_artikel ka
WHERE
  ka.artikelnummer = 9876;

-- Wie viele Artikel mit der Artikelnummer XYZ sind bestellt worden (gruppiert nach den Bestellern).

SELECT
  k.id     AS besteller,
  COUNT(*)AS anzahl_artikel
FROM
  kunden         k
  JOIN kunden_artikel ka
  ON k.id = ka.kundenid JOIN artikel a
  ON a.artikelnummer = ka.artikelnummer
WHERE
  a.artikelnummer = 1234
GROUP BY
  k.id;

-- Liefere eine Liste der bestellten Artikelnummern des Kunden mit der ID XYZ.
SELECT
  a.artikelnummer, K.VORNAME
FROM
  kunden         k
  JOIN kunden_artikel ka
  ON k.id = ka.kundenid JOIN artikel a
  ON a.artikelnummer = ka.artikelnummer
WHERE
  k.id = 6155;

-- Liefere eine Liste der bestellten Artikelbezeichnungen des Kunden mit Namen XYZ.
SELECT
  a.BEZEICHNUNG
FROM
  kunden         k
  JOIN kunden_artikel ka
  ON k.id = ka.kundenid JOIN artikel a
  ON a.artikelnummer = ka.artikelnummer
WHERE
  k.VORNAME = 'Petra';

-- Liefere eine Liste unserer Artikel mit der Anzahl der Bestellungen nach Anzahl sortiert.
SELECT a.ARTIKELNUMMER, a.BEZEICHNUNG, COUNT(*) AS Bestellungen
FROM ARTIKEL a
JOIN KUNDEN_ARTIKEL ka ON a.ARTIKELNUMMER = ka.ARTIKELNUMMER
GROUP BY a.ARTIKELNUMMER, a.BEZEICHNUNG 
ORDER BY Bestellungen DESC;


-- Welche Artikel haben die Kunden, di Mitarbeiter XYZ betreut, bestellt?
SELECT a.BEZEICHNUNG, a.ARTIKELNUMMER
FROM KUNDEN_ARTIKEL ka 
JOIN ARTIKEL a ON ka.ARTIKELNUMMER = a.ARTIKELNUMMER
JOIN KUNDEN k ON ka.KUNDENID = k.ID
JOIN MITARBEITER m ON k.ID = m.PERSONALNUMMER;