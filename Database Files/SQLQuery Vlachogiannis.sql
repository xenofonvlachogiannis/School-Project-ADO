USE XVLACHOGIANNIS_SCHOOL

--A list of all the students.
SELECT * FROM Student;

--A list of all the trainers.
SELECT * FROM Trainer;

--A list of all the assignments.
SELECT * FROM Assignment;

--A list of all the courses.
SELECT * FROM Course;

--All the students per course.
SELECT c.Title, s.First_Name, s.Last_Name FROM Student s
INNER JOIN Student_Per_Course SPC ON SPC.Student_ID = s.Student_ID
INNER JOIN Course c ON SPC.Course_ID = c.Course_ID
ORDER BY c.Title;

--All the trainers per course.
SELECT c.Title, t.First_Name, t.Last_Name FROM Trainer T
INNER JOIN Trainer_Per_Course TPC ON TPC.Trainer_ID = T.Trainer_ID
INNER JOIN Course c ON c.Course_ID = TPC.Course_ID
ORDER BY c.Title;

--All the assignments per course.
SELECT c.Title, a.Title FROM Assignment A
INNER JOIN Assignment_Per_Course APC ON APC.Assignment_ID = A.Assignment_ID
INNER JOIN Course c ON c.Course_ID = APC.Course_ID
ORDER BY c.Title;

--All the assignments per course per student.
SELECT c.Title, A.Title, s.First_Name, s.Last_Name FROM Student s
INNER JOIN Student_Per_Course SPC ON SPC.Student_ID = s.Student_ID
INNER JOIN Course c ON SPC.Course_ID = c.Course_ID
INNER JOIN Assignment_Per_Course APC ON APC.Course_ID = c.Course_ID
INNER JOIN Assignment A ON A.Assignment_ID = APC.Assignment_ID
ORDER BY c.Title, A.Title, First_Name;

--A list of students that belong to more than one courses.
SELECT s.First_Name, s.Last_Name, COUNT(spc.Student_ID) AS Total_Courses FROM Student s , Student_Per_Course spc
WHERE spc.Student_ID = s.Student_ID
GROUP BY s.First_Name, s.Last_Name
HAVING COUNT(spc.Student_ID)>1;
