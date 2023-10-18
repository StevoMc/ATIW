-------------------------------------------

-- @Author: 		  S.McGough

-- @Descriptiion:	Abfrage von Kunden

-- @FILE:         auf_personen1.sql

--------------------------------------------

SELECT
    *
FROM
    KUNDEN;

-- Eine Liste mit Name, Vorname, Postleitzahl, Ort , Strasse mit Hausnummer aller Personen aus Soest (PLZ 59494)

SELECT
    NACHNAME,
    VORNAME,
    PLZ,
    STADT,
    STRASSENR
FROM
    KUNDEN;

-- In welcher Stadt wohnt Lukas Meier?

SELECT
    STADT
FROM
    KUNDEN
WHERE
    VORNAME = 'Lukas'
    AND NACHNAME = 'Meier';

-- Ich brauche: alle Zahnärzte (Dentist) der Datenbank

SELECT
    *
FROM
    KUNDEN
WHERE
    BERUF = 'Dentist';

-- aus dem PLZ-Gebiet 2....

SELECT
    *
FROM
    KUNDEN
WHERE
    PLZ LIKE '2%';

-- alle Lehrer und Lehrerinnen mit der Berufsbezeichnung aus der Datenbank sortiert nach beruf

SELECT
    *
FROM
    KUNDEN
WHERE
    BERUF LIKE '%teacher%';

-- nur die Lehrerinnen, die an einer Schule unterrichten

SELECT
    *
FROM
    KUNDEN
WHERE
    BERUF LIKE '%teacher%'
    AND ( BERUF LIKE '%school%'
    OR BERUF LIKE '%School%' )
    AND GESCHLECHT = 'w';

-- eine Liste der Namen und Geburtsdaten aller unter 30 Jährigen aus München?

SELECT
    VORNAME,
    NACHNAME,
    GEBURTSTAG
FROM
    KUNDEN
WHERE
    STADT = 'München'
    AND 2023 - EXTRACT ( YEAR FROM GEBURTSTAG ) < 30;

-- Welche personen haben heute Geburtstag?

SELECT
    VORNAME,
    NACHNAME,
    GEBURTSTAG
FROM
    KUNDEN
WHERE
    ( 17 - EXTRACT ( DAY FROM GEBURTSTAG ) = 0 )
    AND ( 10 - EXTRACT ( MONTH FROM GEBURTSTAG ) = 0 );

-- Liste aller Personen über 50, die einen Toyota Celica fahren nach Alter absteigend sortiert

SELECT
    *
FROM
    KUNDEN
WHERE
    FAHRZEUG LIKE '%Toyota Celica%'
    AND 2023 - EXTRACT ( YEAR FROM GEBURTSTAG ) > 50;

-- Liste aller Frauen aus NRW mit Blutgruppe A+ und aller Männer aus NRW mit Blutgruppe A-, zuerst die Frauen, dann die Männer

SELECT
    *
FROM
    KUNDEN
WHERE
    BUNDESLAND = 'Nordrhein-Westfalen'
    AND ( ( GESCHLECHT = 'w'
    AND BLUTGRUPPE = 'A+' )
    OR ( GESCHLECHT = 'm'
    AND BLUTGRUPPE = 'A-' ) )
 -- Eigene Datenabfrage (1)
    SELECT
        *
    FROM
        KUNDEN
    WHERE
        (BERUF LIKE '%tech%')
        AND ( GESCHLECHT = 'm'
        OR GESCHLECHT = 'w' );

-- Eigene Datenabfrage (2)

SELECT
    *
FROM
    KUNDEN
WHERE
    ID LIKE '%1'
ORDER BY
    GEBURTSTAG ASC