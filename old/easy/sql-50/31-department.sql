---31. Primary Department for Each Employee
---Employees can belong to multiple departments. When the employee joins other departments, they need to decide which department is their primary department. 
---Note that when an employee belongs to only one department, their primary column is 'N'.
---Write a solution to report all the employees with their primary department. For employees who belong to one department, report their only department.

--Retrieving employees that belong to exactly one department
SELECT employee_id, department_id
FROM Employee
GROUP BY employee_id
HAVING COUNT(department_id) = 1
UNION ALL
--Retrieving employees with primary_flag set to 'Y'
SELECT employee_id, department_id
FROM Employee
WHERE primary_flag = 'Y';