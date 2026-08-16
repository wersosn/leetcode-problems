---38. Exchange Seats
---Write a solution to swap the seat id of every two consecutive students. If the number of students is odd, the id of the last student is not swapped.
---Return the result table ordered by id in ascending order.
SELECT 
    CASE
        WHEN id%2 = 0 THEN id-1 --if number is even - swap it with the previous id (id-1)
        WHEN id%2 > 0 AND id = (SELECT MAX(id) FROM Seat) THEN id --if number is odd and it's the last ID in the list - don't swap id
        WHEN id%2 > 0 THEN id+1 --if number is odd - swap it with the next id (id+1)
    END AS id, student
FROM Seat
ORDER BY id ASC;