---17. Project Employees I
---Write an SQL query that reports the average experience years of all the employees for each project, rounded to 2 digits.
SELECT project_id, ROUND(SUM(experience_years) / COUNT(p.employee_id), 2) as average_years
FROM Project p
LEFT JOIN Employee e ON p.employee_id = e.employee_id
GROUP BY project_id;