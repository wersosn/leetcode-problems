---39. Movie Rating
---Write a solution to:
--1. Find the name of the user who has rated the greatest number of movies. In case of a tie, return the lexicographically smaller user name.
--2. Find the movie name with the highest average rating in February 2020. In case of a tie, return the lexicographically smaller movie name.
(SELECT u.name AS results --1.
FROM Users u
JOIN MovieRating r ON u.user_id = r.user_id
GROUP BY u.user_id
ORDER BY COUNT(*) DESC, u.name
LIMIT 1)

UNION ALL

(SELECT m.title AS results --2.
FROM Movies m
JOIN MovieRating r ON m.movie_id = r.movie_id
WHERE r.created_at < '2020-03-01' AND r.created_at >= '2020-02-01'
GROUP BY m.movie_id
ORDER BY AVG(r.rating) DESC, m.title
LIMIT 1);