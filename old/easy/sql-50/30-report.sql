---30.The Number of Employees Which Report to Each Employee
---For this problem, we will consider a manager an employee who has at least 1 other employee reporting to them.
---Write a solution to report the ids and the names of all managers, the number of employees who report directly to them, 
---and the average age of the reports rounded to the nearest integer.
---Return the result table ordered by employee_id.
SELECT e.employee_id, e.name, COUNT(m.employee_id) AS reports_count, ROUND(AVG(m.age)) AS average_age
FROM Employees e, Employees m
WHERE e.employee_id = m.reports_to
GROUP BY e.employee_id ---allows to calculate the reports_count
ORDER BY e.employee_id;