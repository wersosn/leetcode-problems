---25. Product Sales Analysis III
---Write a solution to select the product id, year, quantity, and price for the first year of every product sold.
SELECT DISTINCT product_id, year AS first_year, quantity, price
FROM Sales 
WHERE (product_id, year) IN 
    (SELECT product_id, MIN(year) ---pick the first year
     FROM Sales
     GROUP BY product_id);