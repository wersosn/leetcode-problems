---12. Students and Examinations
---Write a solution to find the number of times each student attended each exam.
---Return the result table ordered by student_id and subject_name.
SELECT s.student_id, s.student_name, sb.subject_name, COUNT(e.student_id) AS attended_exams
FROM Students s
CROSS JOIN Subjects sb --cross join = full join
LEFT JOIN Examinations e ON s.student_id = e.student_id AND sb.subject_name = e.subject_name
GROUP BY s.student_id, s.student_name, sb.subject_name
ORDER BY s.student_id, sb.subject_name;