-------------------------------------------

-- @Author: 		  S.McGough

-- @Descriptiion:	Abfrage von Kunden

-- @FILE:         auf_personen1.sql

--------------------------------------------

SELECT * FROM KUNDEN;

-- Eine Liste mit Name, Vorname, Postleitzahl, Ort , Strasse mit Hausnummer aller Personen aus Soest (PLZ 59494)

SELECT nachname, vorname, plz, stadt , strassenr FROM Kunden;

-- In welcher Stadt wohnt Lukas Meier?

SELECT stadt
FROM kunden
WHERE
    vorname = 'Lukas'
    and nachname = 'Meier';

-- Ich brauche: alle Zahnärzte (Dentist) der Datenbank

SELECT * FROM Kunden where beruf = 'Dentist';

-- aus dem PLZ-Gebiet 2....

SELECT * FROM Kunden where plz LIKE '2%';

-- alle Lehrer und Lehrerinnen mit der Berufsbezeichnung aus der Datenbank sortiert nach beruf

SELECT * FROM Kunden where beruf LIKE '%teacher%';

-- nur die Lehrerinnen, die an einer Schule unterrichten

SELECT *
FROM Kunden
where
    beruf LIKE '%teacher%'
    and (
        beruf LIKE '%school%'
        or beruf LIKE '%School%'
    )
    and geschlecht = 'w';

-- eine Liste der Namen und Geburtsdaten aller unter 30 Jährigen aus München?

SELECT
    vorname,
    nachname,
    geburtstag
FROM Kunden
WHERE
    Stadt = 'München'
    and 2023 - Extract (
        YEAR
        FROM GEBURTSTAG
    ) < 30;

-- Welche personen haben heute Geburtstag?

SELECT
    vorname,
    nachname,
    geburtstag
FROM Kunden
WHERE (
        17 - Extract (
            DAY
            FROM
                GEBURTSTAG
        ) = 0
    )
    and (
        10 - Extract (
            MONTH
            FROM
                GEBURTSTAG
        ) = 0
    );

-- Liste aller Personen über 50, die einen Toyota Celica fahren nach Alter absteigend sortiert

SELECT *
FROM Kunden
WHERE
    fahrzeug Like '%Toyota Celica%'
    and 2023 - Extract (
        YEAR
        FROM GEBURTSTAG
    ) > 50;

-- Liste aller Frauen aus NRW mit Blutgruppe A+ und aller Männer aus NRW mit Blutgruppe A-, zuerst die Frauen, dann die Männer

SELECT *
FROM Kunden
where
    bundesland = 'Nordrhein-Westfalen'
    and ( (
            geschlecht = 'w'
            and BLUTGRUPPE = 'A+'
        )
        or (
            geschlecht = 'm'
            and BLUTGRUPPE = 'A-'
        )
    )

-- Eigene Datenabfrage (1)

SELECT *
FROM Kunden
WHERE (beruf LIKE '%tech%')
    AND (
        geschlecht = 'm'
        OR geschlecht = 'w'
    );

-- Eigene Datenabfrage (2)

SELECT * FROM Kunden WHERE id LIKE '%1' ORDER BY geburtstag ASC