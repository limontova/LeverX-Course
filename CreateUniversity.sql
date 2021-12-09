CREATE DATABASE [UniversityDb]
GO
USE [UniversityDb]
GO

/***** Object:  Table [dbo].[CITY]  *****/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Subject](
  [SubjectID] int NOT NULL PRIMARY KEY,
  [Name] varchar(50) NOT NULL,
  [Duration] varchar(50) NOT NULL
)
CREATE TABLE [dbo].[City](
	[CityID] int NOT NULL PRIMARY KEY,
	[Name] varchar(50) NOT NULL,
	[Population] int NOT NULL
)
CREATE TABLE [dbo].[University](
  [UniversityID] int NOT NULL PRIMARY KEY,
  [Name] varchar(70) NOT NULL,
  [Address] varchar(50) NULL,
  [CityID] int NOT NULL FOREIGN KEY REFERENCES City(CityID) ON DELETE CASCADE
)
CREATE TABLE [dbo].[Group](
  [GroupID] int NOT NULL PRIMARY KEY,
  [Name] varchar(50) NOT NULL,
  [UniversityID] int NOT NULL FOREIGN KEY REFERENCES University(UniversityID) ON DELETE CASCADE
)
CREATE TABLE [dbo].[Student](
  [StudentID] int NOT NULL PRIMARY KEY,
  [Name] varchar(50) NOT NULL,
  [Birthday] date NOT NULL,
  [Bursary] numeric NULL,
  [Bonus] numeric NULL,
  [CityID] int, 
  [GroupID] int, 
  FOREIGN KEY(CityID) REFERENCES City(CityID),
  FOREIGN KEY (GroupID) REFERENCES [dbo].[Group] (GroupID)
)

--ALTER TABLE [dbo].[Student] 
--ALTER COLUMN Bonus numeric NULL;

--ALTER TABLE [dbo].[Student] 
--ALTER COLUMN CityID numeric NULL;

CREATE TABLE [dbo].[StudentSubject](
  [Mark] int NOT NULL,
  CONSTRAINT PK_StudentSubject PRIMARY KEY (SubjectID, StudentID),
  [StudentID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[Student](StudentID) ON DELETE CASCADE,
  [SubjectID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[Subject](SubjectID) ON DELETE CASCADE
)
CREATE TABLE [dbo].[Teacher](
  [TeacherID] int NOT NULL PRIMARY KEY,
  [Name] varchar(50) NOT NULL,
  [Phone] int NOT NULL,
  [SubjectID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[Subject](SubjectID) ON DELETE CASCADE
)
CREATE TABLE [dbo].[UniversityTeacher](
  [Wage] int NOT NULL,
  [UniversityID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[University](UniversityID) ON DELETE CASCADE,
  [TeacherID] int NOT NULL FOREIGN KEY REFERENCES [dbo].[Teacher](TeacherID) ON DELETE CASCADE
)
