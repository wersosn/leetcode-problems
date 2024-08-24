---28. Biggest Single Number
---A single number is a number that appeared only once in the MyNumbers table.
---Find the largest single number. If there is no single number, report null.
SELECT IFNULL(MAX(num), null) AS num
FROM (SELECT num
      FROM MyNumbers
      GROUP BY num
      HAVING COUNT(*) = 1
) AS result;