USE UniversityDb;
GO

--1
SELECT * FROM Student
WHERE (GroupID = 101 OR GroupID = 105 OR GroupID = 106)

--2
SELECT * FROM Student
WHERE ((GroupID = 101 OR GroupID = 105 OR GroupID = 106) AND (Bursary > 300))

--3
SELECT * FROM StudentSubject, Student
WHERE ((Mark > 7.4 AND Mark < 9.5) AND (SUBSTRING(Name, 1, 1) = 'D'))

--4
--SELECT * FROM Student
--WHERE (SUBSTRING(Name, 1, LEN(Name) - 1) = 'O')

--5
SELECT * FROM Student
WHERE (Bonus != NULL AND Birthday >= '1998-01-01')

--6
SELECT DISTINCT Bursary FROM Student, City
WHERE (City.Name = 'Gomel')

--7
SELECT * FROM Student, City
WHERE (City.Name = 'Vitebsk') ORDER BY Student.Bursary

--8 CITY?
SELECT City.Name, Student.Birthday FROM Student, City
WHERE (Birthday >= '1990-01-01' AND Birthday <= '1991-01-01') ORDER BY Bursary DESC