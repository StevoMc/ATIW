-------------------------------------------

-- @Author: 		  S.McGough

-- @Descriptiion:	Abfrage von Kunden

-- @FILE:         auf_select2.sql

--------------------------------------------

SELECT
  *
FROM
  KUNDEN;

-- Wieviele Mercedesfahrer gibt es?
SELECT
  COUNT(*) AS MERCEDESFAHRTIGER
FROM
  KUNDEN
WHERE
  FAHRZEUG LIKE '%Mercedes%';

-- Wieviele Mercedesfahrer gibt es aufgeschl�sselt nach M�nnern und Frauen
SELECT
  COUNT(*)   AS MERCEDESFAHRTIGER
, GESCHLECHT
FROM
  KUNDEN
WHERE
  FAHRZEUG LIKE '%Mercedes%'
GROUP BY
  GESCHLECHT;

-- zus�tzlich soll noch nach Visa- bzw. Mastercard-Benutzern Fahrern unterschieden werden  (Frauen zuerst)
SELECT
  COUNT(*)    AS MERCEDESFAHRTIGER
, GESCHLECHT
, KREDITKARTE
FROM
  KUNDEN
WHERE
  FAHRZEUG LIKE '%Mercedes%'
GROUP BY
  GESCHLECHT, KREDITKARTE
ORDER BY
  GESCHLECHT DESC;

-- Erstellen Sie eine Tabelle der Blutgruppenh�ufigkeit absteigend sortiert
SELECT
  BLUTGRUPPE
, COUNT(*)   AS HAEUFIGKEIT
FROM
  KUNDEN
GROUP BY
  BLUTGRUPPE
ORDER BY
  BLUTGRUPPE DESC;

-- Ich brauche eine Liste von der Groeesse der kleinsten Frauen gruppiert nach Geburtsjahr
SELECT
  GROESSECM
, EXTRACT(YEAR FROM GEBURTSTAG)
FROM
  KUNDEN
WHERE
  GESCHLECHT = 'w'
GROUP BY
  EXTRACT(YEAR FROM GEBURTSTAG), GROESSECM;

-- Ich brauche eine Liste von der Groeesse der kleinsten Frauen gruppiert nach Geburtsjahr
SELECT
  MIN(GROESSECM)                AS GROESSE
, EXTRACT(YEAR FROM GEBURTSTAG)
FROM
  KUNDEN K
WHERE
  GESCHLECHT= 'w'
GROUP BY
  EXTRACT(YEAR FROM GEBURTSTAG);

-- Wieviele unterschiedliche Berufe sind in der Datenbank gespeichert?
SELECT
  COUNT(DISTINCT BERUF)
FROM
  KUNDEN K;

SELECT
  COUNT(BERUF)
FROM
  KUNDEN K;

-- Wieviel Gewicht (in t) bringenn die Personen auf die Wage, getrennt nach Frauen und M nnern?
SELECT
  (COUNT(GEWICHTKG) / 1000) AS GEWICHTT
, GESCHLECHT
FROM
  KUNDEN K
GROUP BY
  GESCHLECHT;

-- Taucht eine Kreditkartennummer mehrfach auf?
SELECT
  KREDITNR
, COUNT(*)
FROM
  KUNDEN K
HAVING
  COUNT(*) > 1
GROUP BY
  KREDITNR;

-- Wieviele Leute haben heute Geburtstag?
SELECT
  COUNT(GEBURTSTAG) ASANZAHL
FROM
  KUNDEN K
WHERE
  EXTRACT(DAY FROM GEBURTSTAG) = EXTRACT(DAY FROM CURRENT_DATE)
  AND EXTRACT(MONTH FROM GEBURTSTAG) = EXTRACT(MONTH FROM CURRENT_DATE);

-- Wie alt (in Jahren) ist die  lteste/j nste Person, die heute Geburtstag hat?
SELECT
  COUNT(GEBURTSTAG)                                                      AS ANZAHL
, (EXTRACT(YEAR FROM CURRENT_DATE) - EXTRACT(YEAR FROM MIN(GEBURTSTAG))) AS AELTESTER
, (EXTRACT(YEAR FROM CURRENT_DATE) - EXTRACT(YEAR FROM MAX(GEBURTSTAG))) AS JUENGSTER
FROM
  KUNDEN K
WHERE
  EXTRACT(DAY FROM GEBURTSTAG) = EXTRACT(DAY FROM CURRENT_DATE)
  AND EXTRACT(MONTH FROM GEBURTSTAG) = EXTRACT(MONTH FROM CURRENT_DATE);

-- Gibt es Personen mit gleichen Vor und Nachnamen?
SELECT
  NACHNAME
, VORNAME
, COUNT(*) AS ANZAHL
FROM
  KUNDEN K
GROUP BY
  NACHNAME
, VORNAME
HAVING
  COUNT(*) > 1
ORDER BY
  ANZAHL DESC, NACHNAME, VORNAME;

-- 2 Eigene Abfragen
--Welche Fahrzeugmarke wird am meisten genutzt von Männern, die in einer Auto Firma arbeiten?
SELECT
  NACHNAME
, VORNAME
, GESCHLECHT
, FIRMA
, FAHRZEUG
, COUNT(FAHRZEUG) AS ANZAHL
FROM
  KUNDEN K
WHERE
  FIRMA LIKE '%Auto%'
  AND GESCHLECHT= 'm'
GROUP BY
  FAHRZEUG, FIRMA, GESCHLECHT, VORNAME, NACHNAME
ORDER BY
  ANZAHL DESC;

/*
This query selects all columns from the KUNDEN table where the day of the month of the GEBURTSTAG (birthday) column is equal to the day of the month of the current date (SYSDATE).
*/
SELECT
  *
FROM
  KUNDEN
WHERE
  EXTRACT(DAY FROM GEBURTSTAG) = EXTRACT(DAY FROM SYSDATE);