---43. Department Top Three Salaries
---A company's executives are interested in seeing who earns the most money in each of the company's departments. 
---A high earner in a department is an employee who has a salary in the top three unique salaries for that department.
---Write a solution to find the employees who are high earners in each of the departments.
SELECT d.name AS Department, e.name AS Employee, e.salary AS Salary
FROM Department d, Employee e
WHERE d.id = e.departmentId AND
    (SELECT COUNT(DISTINCT salary)
     FROM Employee
     WHERE salary > e.salary AND e.departmentId = departmentId) < 3;