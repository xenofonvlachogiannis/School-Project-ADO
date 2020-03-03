--CREATE DATABASE

CREATE DATABASE XVLACHOGIANNIS_SCHOOL

--AFTER CREATE DATABASE RUN ALL THE BELOW

USE XVLACHOGIANNIS_SCHOOL

--CREATE TABLE FOR STUDENTS

CREATE TABLE [dbo].[Student]
(
 [Student_ID]    int IDENTITY (1, 1) NOT NULL ,
 [First_Name]    varchar(30) NOT NULL ,
 [Last_Name]     varchar(30) NOT NULL ,
 [Date_Of_Birth] date NOT NULL ,
 [Tuition_Fees]  decimal(9,2) NULL ,


 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([Student_ID] ASC)
);


--CREATE TABLE FOR COURSES

CREATE TABLE [dbo].[Course]
(
 [Course_ID]  int IDENTITY (1, 1) NOT NULL ,
 [Title]      nvarchar(30) NOT NULL ,
 [Steam]      nvarchar(30) NOT NULL ,
 [Type]       nvarchar(30) NOT NULL ,
 [Start_Date] date NULL ,
 [End_Date]   date NULL ,


 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([Course_ID] ASC)
);


--CREATE TABLE FOR TRAINERS

CREATE TABLE [dbo].[Trainer]
(
 [Trainer_ID] int IDENTITY (1, 1) NOT NULL ,
 [First_Name] nvarchar(30) NOT NULL ,
 [Last_Name]  nvarchar(30) NOT NULL ,
 [Subject]    nvarchar(30) NOT NULL ,


 CONSTRAINT [PK_Trainer] PRIMARY KEY CLUSTERED ([Trainer_ID] ASC)
);


--CREATE TABLE FOR ASSIGNMENTS

CREATE TABLE [dbo].[Assignment]
(
 [Assignment_ID] int IDENTITY (1, 1) NOT NULL ,
 [Title]         nvarchar(50) NOT NULL ,
 [Description]   nvarchar(50) NOT NULL ,
 [Sub_Date_Time] date NULL ,
 [Oral_Mark]     int NULL ,
 [Total_Mark]    int NULL ,


 CONSTRAINT [PK_Assignment] PRIMARY KEY CLUSTERED ([Assignment_ID] ASC)
);


--CREATE TABLE FOR TRAINERS PER COURSE

CREATE TABLE [dbo].[Trainer_Per_Course]
(
 [Trainer_ID] int NOT NULL ,
 [Course_ID]  int NOT NULL ,


 CONSTRAINT [PK_Trainer_Per_Course] PRIMARY KEY CLUSTERED ([Trainer_ID] ASC, [Course_ID] ASC),
 CONSTRAINT [FK_100] FOREIGN KEY ([Course_ID])  REFERENCES [dbo].[Course]([Course_ID]),
 CONSTRAINT [FK_97] FOREIGN KEY ([Trainer_ID])  REFERENCES [dbo].[Trainer]([Trainer_ID])
);


--CREATE TABLE FOR STUDENTS PER COURSE

CREATE TABLE [dbo].[Student_Per_Course]
(
 [Student_ID] int NOT NULL ,
 [Course_ID]  int NOT NULL ,


 CONSTRAINT [PK_Student_Per_Course] PRIMARY KEY CLUSTERED ([Student_ID] ASC, [Course_ID] ASC),
 CONSTRAINT [FK_73] FOREIGN KEY ([Course_ID])  REFERENCES [dbo].[Course]([Course_ID]),
 CONSTRAINT [FK_76] FOREIGN KEY ([Student_ID])  REFERENCES [dbo].[Student]([Student_ID]),
);


--CREATE TABLE FOR ASSIGNMENTS PER COURSE

CREATE TABLE [dbo].[Assignment_Per_Course]
(
 [Course_ID]     int NOT NULL ,
 [Assignment_ID] int NOT NULL ,


 CONSTRAINT [PK_Assignment_Per_Course] PRIMARY KEY CLUSTERED ([Course_ID] ASC, [Assignment_ID] ASC),
 CONSTRAINT [FK_105] FOREIGN KEY ([Assignment_ID])  REFERENCES [dbo].[Assignment]([Assignment_ID]),
 CONSTRAINT [FK_108] FOREIGN KEY ([Course_ID])  REFERENCES [dbo].[Course]([Course_ID])
);
