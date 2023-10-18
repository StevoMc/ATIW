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

-- Wieviele unterschiedliche Berufe sind in der Datenbank gespeichert?


-- Wieviel Gewicht (in t) bringenn die Personen auf die Wage, getrennt nach Frauen und M�nnern?

-- Taucht eine Kreditkartennummer mehrfach auf?

-- Wieviele Leute haben heute Geburtstag?

-- Wie alt (in Jahren) ist die �lteste/j�nste Person, die heute Geburtstag hat?

-- Gibt es Personen mit gleichen Vor und Nachnamen?

-- 2 Eigene Abfragen