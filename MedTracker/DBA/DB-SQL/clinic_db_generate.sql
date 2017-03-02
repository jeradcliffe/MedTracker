
/* Check if database already exists and delete it if it does exist*/
IF EXISTS(SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'Clinic') 
BEGIN
DROP DATABASE Clinic
END
GO

CREATE DATABASE [Clinic]
GO

USE [Clinic]
GO

/**** Object: Create Table [dbo].[clinicEmployees] ****/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[clinicemployees]
(
   [userName] varchar(20)  NOT NULL,
   [passwords] varchar(45)  NOT NULL,
CONSTRAINT [PK_clinicemployees_userName] PRIMARY KEY CLUSTERED ([userName])
)

GO

/**** Object: Create Table [dbo].[people] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[people]
(
   [peopleID] int IDENTITY(1, 1)  NOT NULL,
   [lastName] varchar(45)  NOT NULL,
   [firstName] varchar(45)  NOT NULL,
   [dateOfBirth] varchar(45)  NOT NULL,
   [streetAddress] varchar(75)  NOT NULL,
   [city] varchar(65)  NOT NULL,
   [state] varchar(2)  NOT NULL,
   [zip] varchar(5)  NOT NULL,
   [phoneNumber] varchar(12)  NOT NULL,
CONSTRAINT [PK_people_peopleID] PRIMARY KEY CLUSTERED ([peopleID])
)

GO

/**** Object: Create Table [dbo].[speciality] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[speciality]
(
   [specialityID] varchar(10)  NOT NULL,
   [specialityName] varchar(45)  NOT NULL,
CONSTRAINT [PK_speciality_specialityID] PRIMARY KEY CLUSTERED ([specialityID])
)

GO

/**** Object: Create Table [dbo].[tests] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tests]
(
   [testCode] varchar(10)  NOT NULL,
   [testName] varchar(45)  NOT NULL,
CONSTRAINT [PK_tests_testCode] PRIMARY KEY CLUSTERED ([testCode])
)

GO

/**** Object: Create Table [dbo].[administrators] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[administrators]
(
   [adminID] int IDENTITY(1, 1)  NOT NULL,
   [peopleID] int  NOT NULL,
   [userName] varchar(20)  NOT NULL,
CONSTRAINT [PK_administrators_adminID] PRIMARY KEY CLUSTERED ([adminID]),
CONSTRAINT [fk_administrators_clinicEmployees] FOREIGN KEY ([userName]) REFERENCES clinicemployees ([userName]),
CONSTRAINT [fk_administrators_people] FOREIGN KEY ([peopleID]) REFERENCES people ([peopleID])  
)

GO

/**** Object: Create Table [dbo].[patients] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[patients]
(
   [patientID] int IDENTITY(1, 1)  NOT NULL,
   [peopleID] int  NOT NULL,
CONSTRAINT [PK_patients_patientID] PRIMARY KEY CLUSTERED ([patientID]),
CONSTRAINT [fk_patients_people] FOREIGN KEY ([peopleID]) REFERENCES people ([peopleID])
)

GO

/**** Object: Create Table [dbo].[nurses] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[nurses]
(
   [nurseID] int IDENTITY(1, 1)  NOT NULL,
   [peopleID] int  NOT NULL,
   [userName] varchar(20)  NOT NULL,
CONSTRAINT [PK_nurses_nurseID] PRIMARY KEY CLUSTERED ([nurseID]),
CONSTRAINT [fk_nurses_clinicEmployees] FOREIGN KEY ([userName]) REFERENCES clinicemployees ([userName]),
CONSTRAINT [fk_nurses_people] FOREIGN KEY ([peopleID]) REFERENCES people ([peopleID])
)

GO

/**** Object: Create Table [dbo].[doctors] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[doctors]
(
   [doctorID] int IDENTITY(1, 1)  NOT NULL,
   [peopleID] int  NOT NULL,
   [userName] varchar(20)  NOT NULL,
CONSTRAINT [PK_doctors_doctorID] PRIMARY KEY CLUSTERED ([doctorID]),
CONSTRAINT [fk_doctors_clinicEmployees] FOREIGN KEY ([userName]) REFERENCES clinicemployees ([userName]),
CONSTRAINT [fk_doctors_people] FOREIGN KEY ([peopleID]) REFERENCES people ([peopleID])
)

GO

/**** Object: Create Table [dbo].[doctors_has_speciality] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[doctors_has_speciality]
(
   [doctorID] int  NOT NULL,
   [specialityID] varchar(10)  NOT NULL,
CONSTRAINT [PK_doctors_has_speciality_doctorID] PRIMARY KEY CLUSTERED ([doctorID], [specialityID]),
CONSTRAINT [fk_doctors_has_speciality_doctors] FOREIGN KEY ([doctorID]) REFERENCES doctors ([doctorID]),
CONSTRAINT [fk_doctors_has_speciality_speciality] FOREIGN KEY ([specialityID]) REFERENCES speciality ([specialityID])
)

GO

/**** Object: Create Table [dbo].[appointment] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[appointment]
(
   [date] datetime  NOT NULL,
   [doctorID] int  NOT NULL,
   [patientID] int  NOT NULL,
   [reasonForVisit] varchar(150)  NOT NULL,
CONSTRAINT [PK_appointment_date] PRIMARY KEY CLUSTERED ([date], [doctorID], [patientID]),
CONSTRAINT [fk_appointment_doctors] FOREIGN KEY ([doctorID]) REFERENCES doctors ([doctorID]),
CONSTRAINT [fk_appointment_patients] FOREIGN KEY ([patientID]) REFERENCES patients ([patientID])
)

GO

/**** Object: Create Table [dbo].[vitals] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[vitals]
(
   [appointment_date] datetime  NOT NULL,
   [appointment_doctorID] int  NOT NULL,
   [appointment_patientID] int  NOT NULL,
   [nurses_nurseID] int  NOT NULL,
   [systolic] varchar(45)  NOT NULL,
   [diastolic] varchar(45)  NOT NULL,
   [temperature] varchar(45)  NOT NULL,
   [pulse] varchar(45)  NOT NULL,
   [symptoms] varchar(45)  NOT NULL,
   [diagnosis] varchar(45)  NOT NULL,
CONSTRAINT [PK_vitals_date_doctor_patient] PRIMARY KEY CLUSTERED ([appointment_date], [appointment_doctorID], [appointment_patientID]),
CONSTRAINT [fk_vitals_appointment] FOREIGN KEY ([appointment_date], [appointment_doctorID], [appointment_patientID])
 REFERENCES appointment ([date], [doctorID], [patientID]),
CONSTRAINT [fk_vitals_nurses] FOREIGN KEY ([nurses_nurseID]) REFERENCES nurses ([nurseID])
)

GO

/**** Object: Create Table [dbo].[appointment_has_tests] ****/

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[appointment_has_tests]
(
   [appointment_date] datetime  NOT NULL,
   [appointment_doctorID] int  NOT NULL,
   [appointment_patientID] int  NOT NULL,
   [tests_testCode] varchar(10)  NOT NULL,
   [testDate] date  NULL,
   [results] varchar(45)  NULL,
CONSTRAINT [PK_appointment_has_tests_appointment_date] PRIMARY KEY CLUSTERED ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode]),
CONSTRAINT [fk_appointment_has_tests_appointment] FOREIGN KEY ([appointment_date], [appointment_doctorID], [appointment_patientID]) REFERENCES 
   appointment ([date], [doctorID], [patientID]),
CONSTRAINT [fk_appointment_has_tests_tests] FOREIGN KEY ([tests_testCode]) REFERENCES tests ([testCode])   
)