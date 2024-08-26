---29. Customers Who Bought All Products
---Write a solution to report the customer ids from the Customer table that bought all the products in the Product table.
SELECT customer_id
FROM Customer
GROUP BY customer_id
HAVING COUNT(DISTINCT product_key) IN (SELECT IFNULL(COUNT(product_key), 0) FROM Product);