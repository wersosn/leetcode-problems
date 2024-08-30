---47. Second Highest Salary
---Write a solution to find the second highest distinct salary from the Employee table. If there is no second highest salary, return null.
SELECT IFNULL(MAX(DISTINCT salary), null) AS SecondHighestSalary
FROM Employee
WHERE salary != (
    SELECT MAX(DISTINCT salary)
    FROM Employee
);