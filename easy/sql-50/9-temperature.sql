---9. Rising Temperature
---Write a solution to find all dates' Id with higher temperatures compared to its previous dates (yesterday).
SELECT w.id
FROM Weather w
LEFT JOIN Weather a ON DATEDIFF(w.recordDate, a.recordDate) = 1
WHERE w.temperature > a.temperature;

--Note to myself: The DATEDIFF() function returns the number of days between two date values. Syntax: DATEDIFF(date1, date2)