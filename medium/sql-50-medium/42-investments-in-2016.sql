---42. Investments in 2016
---Write a solution to report the sum of all total investment values in 2016 tiv_2016, for all policyholders who:
--have the same tiv_2015 value as one or more other policyholders, and
--are not located in the same city as any other policyholder (i.e., the (lat, lon) attribute pairs must be unique).
---Round tiv_2016 to two decimal places.
SELECT ROUND(SUM(i.tiv_2016), 2) AS tiv_2016
FROM Insurance i
--they are not located in the same city as any other policyholder
WHERE (i.lat, i.lon) NOT IN (
    SELECT lat, lon
    FROM Insurance 
    GROUP BY lat, lon
    HAVING COUNT(lat) > 1 AND COUNT(lon) > 1
) 
--the same tiv_2015 value as one or more other policyholders
  AND i.tiv_2015 IN ( 
    SELECT tiv_2015
    FROM Insurance
    GROUP BY tiv_2015
    HAVING COUNT(tiv_2015) > 1
);