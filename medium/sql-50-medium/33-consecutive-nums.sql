---33. Consecutive Numbers
---Find all numbers that appear at least three times consecutively.
SELECT DISTINCT l.num AS ConsecutiveNums
FROM Logs l
WHERE EXISTS (
    --Check if there is a record in Logs table with original id+1 (or current id-1) and the same num value
    SELECT 1
    FROM Logs l2
    WHERE l2.id = l.id + 1 AND l.num = l2.num
    AND EXISTS (
        --Check if there is a record in Logs table with original id+2 (or current id-2) and the same num value
        SELECT 1
        FROM Logs l3
        WHERE l3.id = l.id + 2 AND l.num = l3.num
    )
);