---24. User Activity for the Past 30 Days I
---Write a solution to find the daily active user count for a period of 30 days ending 2019-07-27 inclusively. 
---A user was active on someday if they made at least one activity on that day.
SELECT activity_date AS day, COUNT(DISTINCT user_id) AS active_users
FROM Activity
WHERE DATEDIFF('2019-07-27', activity_date) < 30 AND DATEDIFF('2019-07-27', activity_date) >= 0
GROUP BY activity_date;

---Notes for myself:
---DATEDIFF('2019-07-27', activity_date) < 30 - checks that activity_date is within 30 days of 2019-07-27
---DATEDIFF('2019-07-27', activity_date) >= 0 - checks that activity_date does not occur after 2019-07-27