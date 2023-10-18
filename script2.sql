-------------------------------------------

-- @Author: 		  S.McGough

-- @Descriptiion:	Abfrage von Kunden

--------------------------------------------

SELECT
  *
FROM
  KUNDEN;

-- Wer ist uner schwerster Kunde im PLZ-Bereich 33000 - 33200?
SELECT
  MAX(GEWICHTKG)
FROM
  KUNDEN K
WHERE
  PLZ BETWEEN 33000 AND 33200;

SELECT
  STADT
, MAX(GEWICHTKG)
FROM
  KUNDEN K
WHERE
  PLZ BETWEEN 33000 AND 33200
GROUP BY
  STADT;