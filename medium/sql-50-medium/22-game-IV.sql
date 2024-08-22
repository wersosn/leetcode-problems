---22. Game Play Analysis IV
---Write a solution to report the fraction of players that logged in again on the day after the day they first logged in, rounded to 2 decimal places. 
---In other words, you need to count the number of players that logged in for at least two consecutive days starting from their first login date, 
---then divide that number by the total number of players.
---I used here the implementation from Editorial
SELECT IFNULL(ROUND (COUNT(a.player_id) / (SELECT COUNT(DISTINCT c.player_id) FROM Activity c), 2), 0) as fraction
FROM Activity a 
WHERE (a.player_id, DATE_SUB(a.event_date, INTERVAL 1 DAY)) IN
    (SELECT b.player_id, MIN(b.event_date)
     FROM Activity b
     GROUP BY b.player_id);


---Explanation for myself:
/*
SELECT IFNULL(ROUND (COUNT(a.player_id) / (SELECT COUNT(DISTINCT c.player_id) FROM Activity c), 2), 0) as fraction
-- COUNT(a.player_id) - counts players that meet the condition in the WHERE
-- (SELECT COUNT(DISTINCT c.player_id) FROM Activity c) - counts all unique players in the table
-- ROUND(...) - divides the number of active players by the total number of players, rounding the result to two decimal places
-- IFNULL(...) - returns 0 if the result of the expression is NULL

WHERE (a.player_id, DATE_SUB(a.event_date, INTERVAL 1 DAY)) IN
-- WHERE checks if there is an entry for the given player in the Activity table with a date one day earlier
-- DATE_SUB(a.event_date, INTERVAL 1 DAY) decreases the date by one day.
-- Filters results to only leave those where the player was active the day after they were active the day before

SELECT b.player_id, MIN(b.event_date)
-- The subquery selects the minimum active date for each player (the player's first active date)
*/
