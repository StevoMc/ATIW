-------------------------------------------
-- @Author: 		  S.McGough
-- @Descriptiion:	Abfrage von Kunden 
-- @FILE:         FirstScript.sql
--------------------------------------------

SELECT * FROM KUNDEN k;

-- Eingrenzung
SELECT Nachname, VORNAME, GEBURTSTAG  FROM KUNDEN k;

-- Sortier
SELECT Nachname, VORNAME, GEBURTSTAG  FROM KUNDEN k;


-- Verwenden von Antwort-Aliasen
SELECT Nachname, Vorname, EXTRACT (YEAR FROM GEBURTSTAG) FROM KUNDEN k
ORDER BY NACHNAME DESC, VORNAME ASC;

-- Bedingung fuer die selectiven Datensaetze
SELECT Nachname, Vorname, EXTRACT (YEAR FROM GEBURTSTAG) FROM KUNDEN k
WHERE vorname = 'Juliane'
ORDER BY NACHNAME DESC, VORNAME ASC;

-- Bedingung fuer die selectiven Datensaetze
SELECT Nachname, Vorname, EXTRACT (YEAR FROM GEBURTSTAG) FROM KUNDEN k
WHERE vorname = 'Juliane' and nachname = 'Muller'
ORDER BY NACHNAME DESC, VORNAME ASC;