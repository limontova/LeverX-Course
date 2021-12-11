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
SELECT  Name, convert(varchar, Birthday, 105) FROM Student
WHERE (right(Name, 1) = 'O')

--5
SELECT * FROM Student
WHERE (Bonus != NULL AND Birthday >= '1998-01-01')

--6
SELECT DISTINCT Bursary FROM Student, City
WHERE (City.Name = 'Gomel')

--7
SELECT * FROM Student, City
WHERE (City.Name = 'Vitebsk') ORDER BY Student.Bursary

--8
SELECT City.Name, Student.Birthday FROM Student, City
WHERE (Birthday >= '1990-01-01' AND Birthday <= '1991-01-01') ORDER BY Bursary DESC

--9
SELECT Student.Name, Student.GroupID, Student.Bursary/max(Student.Bursary) OVER () as [BursaryPercentage] from Student
WHERE (GroupID = 102)
group by Student.Name, Student.GroupID, Bursary

--10
select * from student, City
where ((City.Name != 'Minsk' and City.Name != 'Gomel' and City.Name != 'Grodno') or City.Name = null)

--11
select * from Student
where (Name like '%[^a-zA-Z0-9]%')

--12
select Name, Bursary from Student
where Birthday <= '1984-04-23'
order by GroupID, Name

--13
select Teacher.Name as Teacher, Subject.Name as Subject, Subject.Duration from Subject, Teacher
where Teacher.SubjectID = Subject.SubjectID

--14
select "GROUP".Name as groupName, University.Name as university, City.Name as city from [dbo].[Group], University, City
where (City.CityID = University.CityID and "Group".UniversityID = University.UniversityID)

--15
select Student.Name as StudentName, StudentSubject.Mark as Mark, Student.GroupID as "Group", City.CityID as City from StudentSubject, Student, "Group", City
where (Mark <= 6.2 and Student.CityID = City.CityID and Student.GroupID = "Group".GroupID and Student.StudentID = StudentSubject.StudentID)

--16
select Student.Name, University.Name, City.Name, City.Population as CityPopulation from Student, University, City, "Group"
where (City.Population > 340000 and "Group".Name like '%Uni%' and Student.CityID = City.CityID and Student.GroupID = "Group".GroupID and University.UniversityID = "Group".UniversityID)

--17
select Teacher.Name as TeacherName, UniversityTeacher.Wage, University.Name as UniName from Teacher, UniversityTeacher, University
where (Wage >= 750 and Teacher.TeacherID = UniversityTeacher.TeacherID and University.UniversityID = UniversityTeacher.UniversityID)

--18
select Teacher.Name as TeacherName, City.Name as CityName, Subject.Name as SubjectName, UniversityTeacher.Wage, Subject.Name as SubjectName, Student.GroupID from Teacher, UniversityTeacher, Subject, Student, "Group", City
where ((City.Name = 'Minsk' or City.Name = 'Grodno') and Subject.Name != 'English' and Teacher.SubjectID = Subject.SubjectID and Teacher.TeacherID = UniversityTeacher.TeacherID and "Group".UniversityID = UniversityTeacher.UniversityID and City.CityID = Student.CityID)