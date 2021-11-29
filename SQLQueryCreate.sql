USE [UniversityDb]

GO

DROP DATABASE IF EXISTS UniversityDb;

DROP TABLE [dbo].[City]
GO

/****** Object:  Table [dbo].[City]    Script Date: 11/24/2021 1:23:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[City](
	[CityID] [numeric](18, 0) NOT NULL,
	[Name] [text] NULL,
	[Population] [numeric](18, 0) NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Group_] DROP CONSTRAINT [FK_Group_University]
GO

/****** Object:  Table [dbo].[Group_]    Script Date: 11/24/2021 1:26:09 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Group_]') AND type in (N'U'))
DROP TABLE [dbo].[Group_]
GO

/****** Object:  Table [dbo].[Group_]    Script Date: 11/24/2021 1:26:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Group_](
	[GroupID] [numeric](18, 0) NOT NULL,
	[Name] [text] NULL,
	[UniversityID] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Group_]  WITH CHECK ADD  CONSTRAINT [FK_Group_University] FOREIGN KEY([UniversityID])
REFERENCES [dbo].[University] ([UniversityID])
GO

ALTER TABLE [dbo].[Group_] CHECK CONSTRAINT [FK_Group_University]
GO

ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Group]
GO

ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_City]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 11/24/2021 1:27:04 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
DROP TABLE [dbo].[Student]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 11/24/2021 1:27:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[StudentID] [numeric](18, 0) NOT NULL,
	[Name] [text] NULL,
	[Birthday] [date] NULL,
	[Bursary] [numeric](18, 0) NULL,
	[Bonus] [numeric](18, 0) NULL,
	[CityID] [numeric](18, 0) NULL,
	[GroupID] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO

ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_City]
GO

ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Group] FOREIGN KEY([GroupID])
REFERENCES [dbo].[Group_] ([GroupID])
GO

ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Group]
GO

ALTER TABLE [dbo].[StudentSubject] DROP CONSTRAINT [FK_StudentSubject_Subject]
GO

ALTER TABLE [dbo].[StudentSubject] DROP CONSTRAINT [FK_StudentSubject_Student]
GO

/****** Object:  Table [dbo].[StudentSubject]    Script Date: 11/24/2021 1:27:51 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentSubject]') AND type in (N'U'))
DROP TABLE [dbo].[StudentSubject]
GO

/****** Object:  Table [dbo].[StudentSubject]    Script Date: 11/24/2021 1:27:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentSubject](
	[StudentID] [numeric](18, 0) NOT NULL,
	[SubjectID] [numeric](18, 0) NOT NULL,
	[Mark] [tinyint] NULL,
 CONSTRAINT [PK_StudentSubject] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[StudentSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubject_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO

ALTER TABLE [dbo].[StudentSubject] CHECK CONSTRAINT [FK_StudentSubject_Student]
GO

ALTER TABLE [dbo].[StudentSubject]  WITH CHECK ADD  CONSTRAINT [FK_StudentSubject_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO

ALTER TABLE [dbo].[StudentSubject] CHECK CONSTRAINT [FK_StudentSubject_Subject]
GO

/****** Object:  Table [dbo].[Subject]    Script Date: 11/24/2021 1:28:18 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type in (N'U'))
DROP TABLE [dbo].[Subject]
GO

/****** Object:  Table [dbo].[Subject]    Script Date: 11/24/2021 1:28:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Subject](
	[SubjectID] [numeric](18, 0) NOT NULL,
	[Name] [numeric](18, 0) NULL,
	[Duration] [text] NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[SubjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Teacher] DROP CONSTRAINT [FK_Teacher_Subject]
GO

/****** Object:  Table [dbo].[Teacher]    Script Date: 11/24/2021 1:28:43 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type in (N'U'))
DROP TABLE [dbo].[Teacher]
GO

/****** Object:  Table [dbo].[Teacher]    Script Date: 11/24/2021 1:28:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teacher](
	[TeacherID] [numeric](18, 0) NOT NULL,
	[Name] [text] NULL,
	[Phone] [numeric](18, 0) NULL,
	[SubjectID] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Subject] FOREIGN KEY([SubjectID])
REFERENCES [dbo].[Subject] ([SubjectID])
GO

ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Subject]
GO

ALTER TABLE [dbo].[University] DROP CONSTRAINT [FK_University_City]
GO

/****** Object:  Table [dbo].[University]    Script Date: 11/24/2021 1:29:02 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[University]') AND type in (N'U'))
DROP TABLE [dbo].[University]
GO

/****** Object:  Table [dbo].[University]    Script Date: 11/24/2021 1:29:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[University](
	[UniversityID] [numeric](18, 0) NOT NULL,
	[Name] [text] NULL,
	[Address] [nvarchar](50) NULL,
	[CityID] [numeric](18, 0) NULL,
 CONSTRAINT [PK_University] PRIMARY KEY CLUSTERED 
(
	[UniversityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[University]  WITH CHECK ADD  CONSTRAINT [FK_University_City] FOREIGN KEY([CityID])
REFERENCES [dbo].[City] ([CityID])
GO

ALTER TABLE [dbo].[University] CHECK CONSTRAINT [FK_University_City]
GO

ALTER TABLE [dbo].[UniversityTeacher] DROP CONSTRAINT [FK_UniversityTeacher_University]
GO

ALTER TABLE [dbo].[UniversityTeacher] DROP CONSTRAINT [FK_UniversityTeacher_Teacher]
GO

/****** Object:  Table [dbo].[UniversityTeacher]    Script Date: 11/24/2021 1:29:25 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UniversityTeacher]') AND type in (N'U'))
DROP TABLE [dbo].[UniversityTeacher]
GO

/****** Object:  Table [dbo].[UniversityTeacher]    Script Date: 11/24/2021 1:29:25 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UniversityTeacher](
	[UniversityID] [numeric](18, 0) NOT NULL,
	[TeacherID] [numeric](18, 0) NOT NULL,
	[Wage] [numeric](18, 0) NULL,
 CONSTRAINT [PK_UniversityTeacher] PRIMARY KEY CLUSTERED 
(
	[UniversityID] ASC,
	[TeacherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[UniversityTeacher]  WITH CHECK ADD  CONSTRAINT [FK_UniversityTeacher_Teacher] FOREIGN KEY([TeacherID])
REFERENCES [dbo].[Teacher] ([TeacherID])
GO

ALTER TABLE [dbo].[UniversityTeacher] CHECK CONSTRAINT [FK_UniversityTeacher_Teacher]
GO

ALTER TABLE [dbo].[UniversityTeacher]  WITH CHECK ADD  CONSTRAINT [FK_UniversityTeacher_University] FOREIGN KEY([UniversityID])
REFERENCES [dbo].[University] ([UniversityID])
GO

ALTER TABLE [dbo].[UniversityTeacher] CHECK CONSTRAINT [FK_UniversityTeacher_University]
GO


INSERT [dbo].[City] ([CityID], [Name], [Population]) VALUES (CAST(1 AS Numeric(18, 0)), N'Minsk', CAST(1829100 AS Numeric(18, 0)))
INSERT [dbo].[City] ([CityID], [Name], [Population]) VALUES (CAST(2 AS Numeric(18, 0)), N'Gomel', CAST(484000 AS Numeric(18, 0)))
INSERT [dbo].[City] ([CityID], [Name], [Population]) VALUES (CAST(3 AS Numeric(18, 0)), N'Grodno', CAST(338000 AS Numeric(18, 0)))
INSERT [dbo].[City] ([CityID], [Name], [Population]) VALUES (CAST(4 AS Numeric(18, 0)), N'Slutsk', CAST(61000 AS Numeric(18, 0)))
INSERT [dbo].[City] ([CityID], [Name], [Population]) VALUES (CAST(5 AS Numeric(18, 0)), N'Vitebsk', CAST(347000 AS Numeric(18, 0)))

INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(10 AS Numeric(18, 0)), N'Belarusian State University', N'K. Marksa, 31', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(20 AS Numeric(18, 0)), N'Belarusian State University of Transport', N'Kirova, 34', CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(30 AS Numeric(18, 0)), N'Belarusian State University of Informatics and Radioelectronics', N'P. Brovki, 6', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(40 AS Numeric(18, 0)), N'Belarusian National Technological University', N'Nezavisimosti, 65', CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(50 AS Numeric(18, 0)), N'Vitebsk State Technological University', N'Moskovskiy Avenue, 72', CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[University] ([UniversityID], [Name], [Address], [CityID]) VALUES (CAST(60 AS Numeric(18, 0)), N'Gomel State University after F Skorina', N'Kirova, 119', CAST(2 AS Numeric(18, 0)))

INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(101 AS Numeric(18, 0)), N'BSU Group', 10)
INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(102 AS Numeric(18, 0)), N'BSUT GomelUni Grup', 20)
INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(103 AS Numeric(18, 0)), N'BSUIR Group', 30)
INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(104 AS Numeric(18, 0)), N'BNTU Group', 40)
INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(105 AS Numeric(18, 0)), N'VSTU VitUni1 Group', 50)
INSERT [dbo].[Group_] ([GroupID], [Name], [UniversityID]) VALUES (CAST(106 AS Numeric(18, 0)), N'SU GomelUni1 Group', 60)

INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(101 AS Numeric(18, 0)), N'BLAZEJ', CAST(N'1990-09-10' AS Date), CAST(4000 AS Numeric(18, 0)), CAST(102 AS Numeric(18, 0)), NULL, CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(102 AS Numeric(18, 0)), N'JUS%TIN', CAST(N'1988-04-21' AS Date), CAST(4000 AS Numeric(18, 0)), CAST(102 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), NULL)
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(103 AS Numeric(18, 0)), N'DOMINIC', CAST(N'1987-10-11' AS Date), CAST(3500 AS Numeric(18, 0)), CAST(104 AS Numeric(18, 0)), NULL, NULL)
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(104 AS Numeric(18, 0)), N'OTTO', CAST(N'1990-07-12' AS Date), CAST(2000 AS Numeric(18, 0)), CAST(103 AS Numeric(18, 0)), NULL, CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(105 AS Numeric(18, 0)), N'JAMES', CAST(N'1983-04-19' AS Date), CAST(2000 AS Numeric(18, 0)), CAST(101 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(106 AS Numeric(18, 0)), N'NORMAN', CAST(N'1983-11-22' AS Date), CAST(2000 AS Numeric(18, 0)), CAST(101 AS Numeric(18, 0)), NULL, NULL)
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(107 AS Numeric(18, 0)), N'ALEX', CAST(N'1984-04-19' AS Date), CAST(2500 AS Numeric(18, 0)), CAST(101 AS Numeric(18, 0)), NULL, CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(108 AS Numeric(18, 0)), N'BILL', CAST(N'1985-01-24' AS Date), CAST(2000 AS Numeric(18, 0)), CAST(103 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(109 AS Numeric(18, 0)), N'MARTIN', CAST(N'1985-06-11' AS Date), CAST(2500 AS Numeric(18, 0)), CAST(102 AS Numeric(18, 0)), NULL, NULL)
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(110 AS Numeric(18, 0)), N'DAVID', CAST(N'1985-02-25' AS Date), CAST(3500 AS Numeric(18, 0)), CAST(105 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(111 AS Numeric(18, 0)), N'ULMA', CAST(N'1985-12-19' AS Date), CAST(5000 AS Numeric(18, 0)), CAST(101 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(112 AS Numeric(18, 0)), N'DEON', CAST(N'1986-04-12' AS Date), CAST(3500 AS Numeric(18, 0)), CAST(101 AS Numeric(18, 0)), NULL, CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(113 AS Numeric(18, 0)), N'LEON', CAST(N'1983-05-01' AS Date), CAST(4500 AS Numeric(18, 0)), CAST(104 AS Numeric(18, 0)), NULL, CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(114 AS Numeric(18, 0)), N'JAN', CAST(N'1990-01-20' AS Date), CAST(3500 AS Numeric(18, 0)), CAST(106 AS Numeric(18, 0)), NULL, CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[Student] ([StudentID], [Name], [Birthday], [Bursary], [GroupID], [Bonus], [CityID]) VALUES (CAST(115 AS Numeric(18, 0)), N'EMI%L', CAST(N'1990-03-19' AS Date), CAST(2000 AS Numeric(18, 0)), CAST(106 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)), NULL)

INSERT [dbo].[Subject] ([SubjectID], [Name], [Duration]) VALUES (CAST(1 AS Numeric(18, 0)), N'Math', N'40')
INSERT [dbo].[Subject] ([SubjectID], [Name], [Duration]) VALUES (CAST(2 AS Numeric(18, 0)), N'Physics', N'55')
INSERT [dbo].[Subject] ([SubjectID], [Name], [Duration]) VALUES (CAST(3 AS Numeric(18, 0)), N'Chemistry', N'30')
INSERT [dbo].[Subject] ([SubjectID], [Name], [Duration]) VALUES (CAST(4 AS Numeric(18, 0)), N'English', N'60')
INSERT [dbo].[Subject] ([SubjectID], [Name], [Duration]) VALUES (CAST(5 AS Numeric(18, 0)), N'Belarusian', N'30')

INSERT [dbo].[Teacher] ([TeacherID], [Name], [Phone], [SubjectID]) VALUES (CAST(10 AS Numeric(18, 0)), N'Mathematician', CAST(5553154 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)))
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Phone], [SubjectID]) VALUES (CAST(20 AS Numeric(18, 0)), N'Physicist', CAST(5553748 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)))
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Phone], [SubjectID]) VALUES (CAST(30 AS Numeric(18, 0)), N'Chemist', CAST(5559377 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)))
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Phone], [SubjectID]) VALUES (CAST(40 AS Numeric(18, 0)), N'English Teacher', CAST(5559011 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)))
INSERT [dbo].[Teacher] ([TeacherID], [Name], [Phone], [SubjectID]) VALUES (CAST(50 AS Numeric(18, 0)), N'Belarusian Teacher', CAST(5555912 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)))

INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(800 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(750 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(620 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(40 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(10 AS Numeric(18, 0)), CAST(50 AS Numeric(18, 0)), CAST(450 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(800 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(750 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(40 AS Numeric(18, 0)), CAST(620 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(20 AS Numeric(18, 0)), CAST(50 AS Numeric(18, 0)), CAST(740 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(615 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(760 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(40 AS Numeric(18, 0)), CAST(910 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(30 AS Numeric(18, 0)), CAST(50 AS Numeric(18, 0)), CAST(810 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(450 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(670 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(40 AS Numeric(18, 0)), CAST(810 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(40 AS Numeric(18, 0)), CAST(50 AS Numeric(18, 0)), CAST(920 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(10 AS Numeric(18, 0)), CAST(540 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(20 AS Numeric(18, 0)), CAST(650 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(30 AS Numeric(18, 0)), CAST(540 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(40 AS Numeric(18, 0)), CAST(810 AS Numeric(18, 0)))
INSERT [dbo].[UniversityTeacher] ([TeacherID], [UniversityID], [Wage]) VALUES (CAST(50 AS Numeric(18, 0)), CAST(50 AS Numeric(18, 0)), CAST(500 AS Numeric(18, 0)))


INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (101, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (101, 2, 7)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (101, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (101, 4, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (101, 5, 5)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (102, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (102, 2, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (102, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (102, 4, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (102, 5, 6)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (103, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (103, 2, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (103, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (103, 4, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (103, 5, 6)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (104, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (104, 2, 2)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (104, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (104, 4, 2)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (104, 5, 6)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (105, 1, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (105, 2, 4)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (105, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (105, 4, 2)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (105, 5, 6)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (106, 1, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (106, 2, 5)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (106, 3, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (106, 4, 4)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (106, 5, 8)


INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (107, 1, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (107, 2, 5)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (107, 3, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (107, 4, 5)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (107, 5, 8)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (108, 1, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (108, 2, 4)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (108, 3, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (108, 4, 2)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (108, 5, 7)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (109, 1, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (109, 2, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (109, 3, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (109, 4, 5)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (109, 5, 9)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (110, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (110, 2, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (110, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (110, 4, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (110, 5, 6)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (111, 1, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (111, 2, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (111, 3, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (111, 4, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (111, 5, 10)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (112, 1, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (112, 2, 7)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (112, 3, 7)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (112, 4, 5)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (112, 5, 9)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (113, 1, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (113, 2, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (113, 3, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (113, 4, 10)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (113, 5, 9)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (114, 1, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (114, 2, 8)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (114, 3, 7)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (114, 4, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (114, 5, 8)

INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (115, 1, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (115, 2, 2)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (115, 3, 9)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (115, 4, 6)
INSERT [dbo].[StudentSubject] ([StudentID], [SubjectID], [Mark]) VALUES (115, 5, 4)
