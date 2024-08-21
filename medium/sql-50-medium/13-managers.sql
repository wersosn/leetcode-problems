---13. Managers with at Least 5 Direct Reports
---Write a solution to find managers with at least five direct reports.
SELECT b.name
FROM Employee a
JOIN Employee b ON a.managerId = b.id
GROUP BY a.managerId
HAVING COUNT(*) >= 5;