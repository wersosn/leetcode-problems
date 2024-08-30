---48. Group Sold Products By The Date
---Write a solution to find for each date the number of different products sold and their names.
---The sold products names for each date should be sorted lexicographically.
---Return the result table ordered by sell_date.
SELECT sell_date, COUNT(DISTINCT product) AS num_sold, GROUP_CONCAT(DISTINCT product) AS 'products'
FROM Activities
GROUP BY sell_date
ORDER BY sell_date;

--Notes for myself:
--GROUP_CONCAT is used to combine values ​​from multiple rows into one text value, separated by a selected separator, syntax:
--GROUP_CONCAT([DISTINCT] column_name [ORDER BY column_name ASC/DESC] SEPARATOR 'separator')