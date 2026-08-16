---18. Percentage of Users Attended a Contest
---Write a solution to find the percentage of the users registered in each contest rounded to two decimals.
---Return the result table ordered by percentage in descending order. In case of a tie, order it by contest_id in ascending order.
SELECT contest_id, IFNULL(ROUND(COUNT(DISTINCT r.user_id) * 100 / (SELECT COUNT(user_id) FROM Users), 2), 0) AS percentage
FROM Register r
GROUP BY contest_id
ORDER BY percentage DESC, contest_id ASC; 