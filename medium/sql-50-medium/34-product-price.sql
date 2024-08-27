---34. Product Price at a Given Date
---Write a solution to find the prices of all products on 2019-08-16. Assume the price of all products before any change is 10.
SELECT product_id, 10 AS price
FROM Products
GROUP BY product_id
HAVING MIN(change_date) > '2019-08-16'
UNION ALL
SELECT product_id, new_price AS price
FROM Products
WHERE (product_id, change_date) IN ( -- find the product_id field and the last changed date until 2019-08-16
    SELECT product_id, MAX(change_date)
    FROM Products
    WHERE change_date <= '2019-08-16'
    GROUP BY product_id
);