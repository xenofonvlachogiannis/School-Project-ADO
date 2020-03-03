USE XVLACHOGIANNIS_SCHOOL

--INSERT STUDENTS

INSERT INTO Student
VALUES 
('Xenofon', 'Vlachogiannis', '1989-08-01', 2500),
('Nikolaos', 'Sentis','1990-11-10', 2500),
('Panagiotis', 'Rizos', '1993-05-13', 2500),
('Karolos', 'Koniewicz','1993-03-22', 2500),
('Zacharias', 'Drimiskianakis', '1992-12-03', 2500),
('Alexandros', 'Perikleous', '1992-01-10', 2500),
('Eleni', 'Parisi','1989-11-20', 2500),
('Eystathios', 'Kanellis','1986-09-19', 2500),
('Giorgos', 'Poulakos','1988-04-04', 2500),
('Thanos', 'Katsakis','1991-07-29', 2500);

--INSERT COURSES

INSERT INTO Course
VALUES
('CB7', 'Full time', 'C#', '2019-12-11','2020-04-02'),
('CB8', 'Full time', 'Java', '2019-12-10','2020-04-03'),
('CB9', 'Part time', 'Sql', '2019-12-07', '2020-07-05'),
('CB10', 'Part time', 'Html', '2019-12-09','2020-07-06');

--INSERT ASSIGNMENTS

INSERT INTO Assignment
VALUES
('Design a Private School', 'Individal Project','2020-01-20', 15, 18),
('Design a Company', 'Individal Project','2020-03-19', 12, 15),
('Create an e-shop', 'Group Project','2020-05-05', 18, 19),
('Create Program for Zara', 'Group Project','2020-02-04', 13, 18),
('Design a Travel App', 'Individal Project','2020-01-16', 15, 18),
('Design an App for Android', 'Individal Project','2020-03-19', 12, 15),
('Create Program for Plaisio', 'Group Project','2020-03-02', 17, 19),
('Create Final Project', 'Group Project','2020-02-04', 13, 18);

--INSERT TRAINERS

INSERT INTO Trainer
VALUES
('Hector', 'Gkatsos', 'C#'),
('Nikolaos', 'Manakis', 'SQL'),
('Panos', 'Bozas', 'HTML'),
('Manolis', 'Kapsis', 'HTML'),
('Konstantinos', 'Zitis', 'Java'),
('Giorgos', 'Pasparakis', 'C#'),
('Aliki', 'Tzirozidi', 'Java'),
('Alexia', 'Vasilakopoulou', 'HTML'),
('Dimitrios', 'Tsonis', 'HTML'),
('Konstantinos', 'Striggilos', 'SQL');

--INSERT STUDENTS PER COURSE

INSERT INTO Student_Per_Course
VALUES
(1,1),
(2,1),
(3,1),
(4,1),
(5,1),
(6,2),
(7,2),
(1,2),
(3,2),
(5,3),
(8,3),
(2,3),
(4,3),
(9,4),
(10,4),
(7,4);

--INSERT TRAINERS PER COURSE

INSERT INTO Trainer_Per_Course
VALUES
(1,1),
(2,1),
(3,1),
(4,1),
(5,2),
(9,2),
(10,2),
(6,3),
(7,3),
(8,3),
(1,4),
(6,4),
(10,4)

--INSERT ASSIGNMENT PER COURSE

INSERT INTO Assignment_Per_Course
VALUES
(1,1),
(1,2),
(1,3),
(2,4),
(2,5),
(2,6),
(3,7),
(3,8),
(3,1),
(4,2),
(4,3),
(4,4),
(4,5)