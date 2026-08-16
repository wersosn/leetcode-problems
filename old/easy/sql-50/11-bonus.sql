---11. Employee Bonus
---Write a solution to report the name and bonus amount of each employee with a bonus less than 1000.
SELECT name, bonus
FROM Employee e
LEFT JOIN Bonus b ON e.empId = b.empID
WHERE bonus < 1000 OR bonus IS NULL;