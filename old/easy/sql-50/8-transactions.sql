---8. Customer Who Visited but Did Not Make Any Transactions
---Write a solution to find the IDs of the users who visited without making any transactions and the number of times they made these types of visits.
SELECT customer_id, COUNT(*) AS count_no_trans
FROM Visits AS v
LEFT JOIN Transactions AS t ON v.visit_id = t.visit_id
WHERE transaction_id IS NULL
GROUP BY customer_id;