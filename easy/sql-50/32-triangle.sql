---32. Triangle Judgement
---Report for every three line segments whether they can form a triangle.
SELECT x, y, z, IF(x + y > z AND y + z > x AND x + z > y, "Yes", "No") AS triangle
FROM Triangle;