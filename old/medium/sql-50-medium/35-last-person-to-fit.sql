---35.Last Person to Fit in the Bus
---There is a queue of people waiting to board a bus. However, the bus has a weight limit of 1000 kilograms, so there may be some people who cannot board.
---Write a solution to find the person_name of the last person that can fit on the bus without exceeding the weight limit. 
---The test cases are generated such that the first person does not exceed the weight limit.
---I used here solution by user deepankyadav
SELECT a.person_name
FROM Queue a, Queue b 
WHERE a.turn >= b.turn
GROUP BY a.turn
HAVING SUM(b.weight) <= 1000 --filter out groups whose sum of weights exceeds the weight limit of 1000
ORDER BY SUM(b.weight) DESC --order by the sum of weights
LIMIT 1; --limit to 1 result (last person)