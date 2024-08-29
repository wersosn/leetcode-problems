---40. Restaurant Growth
---You are the restaurant owner and you want to analyze a possible expansion (there will be at least one customer every day).
---Compute the moving average of how much the customer paid in a seven days window (i.e., current day + 6 days before). 
---average_amount should be rounded to two decimal places.
---Return the result table ordered by visited_on in ascending order.
---I used here the solution created by user deepankyadav

SELECT a.visited_on, 
    --Sum up the amount for each visited_on date by considering the previous 7 days
    (SELECT SUM(amount)
     FROM Customer
     WHERE visited_on BETWEEN DATE_SUB(a.visited_on, INTERVAL 6 DAY) AND a.visited_on) AS amount, 
    --Divide the sum of the amount by 7, representing the rolling window of 7 days
    IFNULL(ROUND( (SELECT SUM(amount)/7
     FROM Customer
     WHERE visited_on BETWEEN DATE_SUB(a.visited_on, INTERVAL 6 DAY) AND a.visited_on), 2), 0) AS average_amount
FROM Customer a
WHERE a.visited_on >= (SELECT DATE_ADD(MIN(visited_on), INTERVAL 6 DAY) FROM Customer)
GROUP BY a.visited_on
ORDER BY a.visited_on ASC;