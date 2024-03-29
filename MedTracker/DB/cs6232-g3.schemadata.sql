USE [master]
GO
/****** Object:  Database [CS6232-g3]    Script Date: 4/23/2017 12:49:32 PM ******/
CREATE DATABASE [CS6232-g3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CS6232-g3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CS6232-g3.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CS6232-g3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CS6232-g3_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CS6232-g3] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CS6232-g3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CS6232-g3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CS6232-g3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CS6232-g3] SET ARITHABORT OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CS6232-g3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CS6232-g3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CS6232-g3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CS6232-g3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CS6232-g3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CS6232-g3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CS6232-g3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CS6232-g3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CS6232-g3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CS6232-g3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CS6232-g3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CS6232-g3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CS6232-g3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CS6232-g3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CS6232-g3] SET RECOVERY FULL 
GO
ALTER DATABASE [CS6232-g3] SET  MULTI_USER 
GO
ALTER DATABASE [CS6232-g3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CS6232-g3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CS6232-g3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CS6232-g3] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CS6232-g3] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CS6232-g3]
GO
/****** Object:  Table [dbo].[administrators]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[administrators](
	[adminID] [int] IDENTITY(1,1) NOT NULL,
	[peopleID] [int] NOT NULL,
	[userName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_administrators_adminID] PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[appointment](
	[date] [datetime] NOT NULL,
	[doctorID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[reasonForVisit] [varchar](150) NOT NULL,
 CONSTRAINT [PK_appointment_date] PRIMARY KEY CLUSTERED 
(
	[date] ASC,
	[doctorID] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[appointment_has_tests]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[appointment_has_tests](
	[appointment_date] [datetime] NOT NULL,
	[appointment_doctorID] [int] NOT NULL,
	[appointment_patientID] [int] NOT NULL,
	[tests_testCode] [varchar](10) NOT NULL,
	[testDate] [date] NULL,
	[results] [varchar](45) NULL,
 CONSTRAINT [PK_appointment_has_tests_appointment_date] PRIMARY KEY CLUSTERED 
(
	[appointment_date] ASC,
	[appointment_doctorID] ASC,
	[appointment_patientID] ASC,
	[tests_testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[clinicemployees]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clinicemployees](
	[userName] [varchar](20) NOT NULL,
	[passwords] [varchar](45) NOT NULL,
 CONSTRAINT [PK_clinicemployees_userName] PRIMARY KEY CLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[doctors]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctors](
	[doctorID] [int] IDENTITY(1,1) NOT NULL,
	[peopleID] [int] NOT NULL,
	[userName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_doctors_doctorID] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[doctors_has_speciality]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[doctors_has_speciality](
	[doctorID] [int] NOT NULL,
	[specialityID] [varchar](10) NOT NULL,
 CONSTRAINT [PK_doctors_has_speciality_doctorID] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC,
	[specialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[nurses]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[nurses](
	[nurseID] [int] IDENTITY(1,1) NOT NULL,
	[peopleID] [int] NOT NULL,
	[userName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_nurses_nurseID] PRIMARY KEY CLUSTERED 
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[patients]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[patientID] [int] IDENTITY(1,1) NOT NULL,
	[peopleID] [int] NOT NULL,
 CONSTRAINT [PK_patients_patientID] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[people]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[people](
	[peopleID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[firstName] [varchar](45) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[streetAddress] [varchar](75) NOT NULL,
	[city] [varchar](65) NOT NULL,
	[state] [varchar](2) NOT NULL,
	[zip] [varchar](5) NOT NULL,
	[phoneNumber] [varchar](12) NOT NULL,
	[ssn] [varchar](9) NOT NULL,
	[gender] [varchar](20) NOT NULL,
 CONSTRAINT [PK_people_peopleID] PRIMARY KEY CLUSTERED 
(
	[peopleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[speciality]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[speciality](
	[specialityID] [varchar](10) NOT NULL,
	[specialityName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_speciality_specialityID] PRIMARY KEY CLUSTERED 
(
	[specialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tests]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tests](
	[testCode] [varchar](10) NOT NULL,
	[testName] [varchar](45) NOT NULL,
 CONSTRAINT [PK_tests_testCode] PRIMARY KEY CLUSTERED 
(
	[testCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[vitals]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[vitals](
	[appointment_date] [datetime] NOT NULL,
	[appointment_doctorID] [int] NOT NULL,
	[appointment_patientID] [int] NOT NULL,
	[nurses_nurseID] [int] NOT NULL,
	[systolic] [varchar](45) NOT NULL,
	[diastolic] [varchar](45) NOT NULL,
	[temperature] [varchar](45) NOT NULL,
	[pulse] [varchar](45) NOT NULL,
	[symptoms] [varchar](45) NOT NULL,
	[diagnosis] [varchar](45) NOT NULL,
 CONSTRAINT [PK_vitals_date_doctor_patient] PRIMARY KEY CLUSTERED 
(
	[appointment_date] ASC,
	[appointment_doctorID] ASC,
	[appointment_patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[administrators] ON 

INSERT [dbo].[administrators] ([adminID], [peopleID], [userName]) VALUES (1, 47, N'mwilaven9')
INSERT [dbo].[administrators] ([adminID], [peopleID], [userName]) VALUES (2, 14, N'revans9')
INSERT [dbo].[administrators] ([adminID], [peopleID], [userName]) VALUES (4, 22, N'dharris9')
INSERT [dbo].[administrators] ([adminID], [peopleID], [userName]) VALUES (5, 44, N'nstaskelunas9')
INSERT [dbo].[administrators] ([adminID], [peopleID], [userName]) VALUES (6, 32, N'tmarks9')
SET IDENTITY_INSERT [dbo].[administrators] OFF
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2010-12-10 13:00:00.000' AS DateTime), 5, 32, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2011-09-10 13:00:00.000' AS DateTime), 4, 11, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2013-06-10 13:00:00.000' AS DateTime), 5, 21, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2013-12-10 13:00:00.000' AS DateTime), 6, 34, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2014-02-10 13:00:00.000' AS DateTime), 1, 20, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2014-10-10 14:00:00.000' AS DateTime), 6, 5, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, N'Appendix')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, N'baby')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, N'Colon')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-06-18 10:30:00.000' AS DateTime), 2, 29, N'eye hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-08-06 11:35:00.000' AS DateTime), 3, 27, N'head hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-09-20 14:15:00.000' AS DateTime), 4, 39, N'foot')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-10-10 11:00:00.000' AS DateTime), 1, 6, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, N'lips hurt')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, N'ear ')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-01-23 08:00:00.000' AS DateTime), 1, 32, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-02-01 12:00:00.000' AS DateTime), 4, 36, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-02-10 13:00:00.000' AS DateTime), 3, 30, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, N'stroke')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-02-26 10:00:00.000' AS DateTime), 2, 33, N'toe hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-03-03 14:30:00.000' AS DateTime), 1, 37, N'pancrease')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-03-29 11:00:00.000' AS DateTime), 3, 34, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-04-05 12:00:00.000' AS DateTime), 5, 38, N'fingerietise')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-05-02 10:00:00.000' AS DateTime), 2, 35, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-05-20 13:00:00.000' AS DateTime), 4, 31, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-06-05 13:00:00.000' AS DateTime), 4, 36, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-06-09 09:15:00.000' AS DateTime), 3, 40, N'busted head')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-06-20 09:00:00.000' AS DateTime), 6, 30, N'stomach')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-06-20 15:20:00.000' AS DateTime), 6, 22, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-07-12 12:00:00.000' AS DateTime), 2, 41, N'lungs')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, N'Appendix')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-07-20 09:00:00.000' AS DateTime), 4, 23, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, N'leopracy')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-11 14:00:00.000' AS DateTime), 5, 38, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-20 13:00:00.000' AS DateTime), 6, 28, N'head hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-20 16:00:00.000' AS DateTime), 6, 24, N'low sugar')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, N'flu like symptoms')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, N'stomach')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-09-20 15:20:00.000' AS DateTime), 6, 25, N'Colon')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-10-07 15:00:00.000' AS DateTime), 1, 42, N'cough')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-10-10 13:00:00.000' AS DateTime), 2, 9, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2016-10-20 16:00:00.000' AS DateTime), 6, 26, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-01-23 08:00:00.000' AS DateTime), 1, 32, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-02-01 12:00:00.000' AS DateTime), 4, 36, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-02-20 10:10:10.000' AS DateTime), 5, 18, N'stroke')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-02-26 10:00:00.000' AS DateTime), 2, 33, N'toe hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-03-29 11:00:00.000' AS DateTime), 3, 34, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-04-05 12:00:00.000' AS DateTime), 5, 38, N'fingerietise')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-06-05 13:00:00.000' AS DateTime), 4, 36, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-06-20 09:00:00.000' AS DateTime), 6, 30, N'stomach')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-06-29 15:30:00.000' AS DateTime), 3, 20, N'Heart attack')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-08-11 14:00:00.000' AS DateTime), 5, 38, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-08-20 13:00:00.000' AS DateTime), 6, 28, N'head hurts')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-08-20 16:00:00.000' AS DateTime), 6, 24, N'low sugar')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-09-20 15:20:00.000' AS DateTime), 6, 25, N'Colon')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2017-10-20 16:00:00.000' AS DateTime), 6, 26, N'Anxiety')
INSERT [dbo].[appointment] ([date], [doctorID], [patientID], [reasonForVisit]) VALUES (CAST(N'2018-02-20 10:10:10.000' AS DateTime), 5, 18, N'stroke')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, N'DHEA', CAST(N'2016-10-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, N'FLU', CAST(N'2016-10-10' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, N'HEPA-B', CAST(N'2016-09-15' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, N'LDL', CAST(N'2015-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, N'HDL', CAST(N'2016-10-17' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, N'HEPA-A', CAST(N'2015-04-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, N'TSH', CAST(N'2016-09-27' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, N'WBC', CAST(N'2015-11-12' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, N'DHEA', CAST(N'2016-09-14' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, N'FLU', CAST(N'2016-09-22' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, N'HEPA-B', CAST(N'2015-03-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, N'LDL', CAST(N'2014-11-12' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-06-10 13:00:00.000' AS DateTime), 5, 21, N'DHEA', CAST(N'2014-10-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-06-10 13:00:00.000' AS DateTime), 5, 21, N'FLU', CAST(N'2014-10-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-06-10 13:00:00.000' AS DateTime), 5, 21, N'HEPA-B', CAST(N'2014-10-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, N'HDL', CAST(N'2015-02-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, N'HEPA-A', CAST(N'2014-12-13' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, N'TSH', CAST(N'2016-08-11' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, N'WBC', CAST(N'2016-09-17' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, N'DHEA', CAST(N'2014-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, N'FLU', CAST(N'2014-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, N'HEPA-B', CAST(N'2014-05-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, N'LDL', CAST(N'2014-05-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, N'DHEA', CAST(N'2015-01-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, N'FLU', CAST(N'2016-07-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, N'HEPA-B', CAST(N'2015-01-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, N'LDL', CAST(N'2016-09-12' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, N'HDL', CAST(N'2015-02-10' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, N'HEPA-A', CAST(N'2016-09-07' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, N'TSH', CAST(N'2014-12-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, N'WBC', CAST(N'2016-06-05' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, N'DHEA', CAST(N'2015-03-27' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, N'FLU', CAST(N'2015-03-27' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, N'HEPA-B', CAST(N'2015-03-27' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, N'LDL', CAST(N'2015-03-27' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, N'DHEA', CAST(N'2015-03-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, N'FLU', CAST(N'2015-03-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, N'HEPA-B', CAST(N'2015-03-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, N'LDL', CAST(N'2015-03-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-06-18 10:30:00.000' AS DateTime), 2, 29, N'DHEA', CAST(N'2015-06-18' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-06-18 10:30:00.000' AS DateTime), 2, 29, N'FLU', CAST(N'2015-06-18' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-06-18 10:30:00.000' AS DateTime), 2, 29, N'HEPA-B', CAST(N'2015-06-18' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-08-06 11:35:00.000' AS DateTime), 3, 27, N'DHEA', CAST(N'2015-08-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-08-06 11:35:00.000' AS DateTime), 3, 27, N'HEPA-B', CAST(N'2015-08-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-08-06 11:35:00.000' AS DateTime), 3, 27, N'LDL', CAST(N'2015-08-08' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-09-20 14:15:00.000' AS DateTime), 4, 39, N'DHEA', CAST(N'2015-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-09-20 14:15:00.000' AS DateTime), 4, 39, N'FLU', CAST(N'2015-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-09-20 14:15:00.000' AS DateTime), 4, 39, N'LDL', CAST(N'2015-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, N'DHEA', CAST(N'2015-11-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, N'FLU', CAST(N'2015-11-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, N'HEPA-B', CAST(N'2015-11-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, N'LDL', CAST(N'2015-11-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, N'DHEA', CAST(N'2015-12-21' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, N'FLU', CAST(N'2015-12-21' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, N'HEPA-B', CAST(N'2015-12-21' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, N'LDL', CAST(N'2015-12-21' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, N'HDL', CAST(N'2016-01-24' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, N'HEPA-A', CAST(N'2016-01-24' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, N'TSH', CAST(N'2016-01-24' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, N'WBC', CAST(N'2016-01-24' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-23 08:00:00.000' AS DateTime), 1, 32, N'HEPA-A', CAST(N'2016-01-23' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-23 08:00:00.000' AS DateTime), 1, 32, N'TSH', CAST(N'2016-04-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-01-23 08:00:00.000' AS DateTime), 1, 32, N'WBC', CAST(N'2016-04-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-01 12:00:00.000' AS DateTime), 4, 36, N'HDL', CAST(N'2016-02-01' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-01 12:00:00.000' AS DateTime), 4, 36, N'HEPA-A', CAST(N'2016-02-01' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, N'HDL', CAST(N'2016-02-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, N'HEPA-A', CAST(N'2016-02-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, N'TSH', CAST(N'2016-02-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, N'WBC', CAST(N'2016-02-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-26 10:00:00.000' AS DateTime), 2, 33, N'FLU', CAST(N'2016-02-26' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-26 10:00:00.000' AS DateTime), 2, 33, N'HEPA-B', CAST(N'2016-02-26' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-02-26 10:00:00.000' AS DateTime), 2, 33, N'LDL', CAST(N'2016-02-26' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-03 14:30:00.000' AS DateTime), 1, 37, N'DHEA', CAST(N'2016-03-03' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-03 14:30:00.000' AS DateTime), 1, 37, N'FLU', CAST(N'2016-03-03' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-03 14:30:00.000' AS DateTime), 1, 37, N'HEPA-B', CAST(N'2016-03-03' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-29 11:00:00.000' AS DateTime), 3, 34, N'HDL', CAST(N'2016-03-29' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-29 11:00:00.000' AS DateTime), 3, 34, N'HEPA-A', CAST(N'2016-03-29' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-03-29 11:00:00.000' AS DateTime), 3, 34, N'WBC', CAST(N'2016-03-29' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-04-05 12:00:00.000' AS DateTime), 5, 38, N'HDL', CAST(N'2016-04-05' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-04-05 12:00:00.000' AS DateTime), 5, 38, N'TSH', CAST(N'2016-04-05' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-02 10:00:00.000' AS DateTime), 2, 35, N'DHEA', CAST(N'2016-05-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-02 10:00:00.000' AS DateTime), 2, 35, N'HEPA-B', CAST(N'2016-05-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-02 10:00:00.000' AS DateTime), 2, 35, N'LDL', CAST(N'2016-05-02' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-20 13:00:00.000' AS DateTime), 4, 31, N'DHEA', CAST(N'2016-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-20 13:00:00.000' AS DateTime), 4, 31, N'FLU', CAST(N'2016-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-05-20 13:00:00.000' AS DateTime), 4, 31, N'LDL', CAST(N'2016-05-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-05 13:00:00.000' AS DateTime), 4, 36, N'TSH', CAST(N'2016-06-05' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-09 09:15:00.000' AS DateTime), 3, 40, N'HEPA-A', CAST(N'2016-06-09' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-09 09:15:00.000' AS DateTime), 3, 40, N'TSH', CAST(N'2016-06-09' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-09 09:15:00.000' AS DateTime), 3, 40, N'WBC', CAST(N'2016-06-09' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 09:00:00.000' AS DateTime), 6, 30, N'HDL', CAST(N'2016-06-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 09:00:00.000' AS DateTime), 6, 30, N'TSH', CAST(N'2016-06-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 09:00:00.000' AS DateTime), 6, 30, N'WBC', CAST(N'2016-06-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 15:20:00.000' AS DateTime), 6, 22, N'HDL', CAST(N'2016-06-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 15:20:00.000' AS DateTime), 6, 22, N'TSH', CAST(N'2016-06-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-20 15:20:00.000' AS DateTime), 6, 22, N'WBC', CAST(N'2016-06-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, N'HDL', CAST(N'2016-06-29' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, N'HEPA-A', CAST(N'2016-06-29' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, N'TSH', CAST(N'2016-06-29' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, N'WBC', CAST(N'2016-06-29' AS Date), N'abnormal')
GO
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-12 12:00:00.000' AS DateTime), 2, 41, N'FLU', CAST(N'2016-07-12' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-12 12:00:00.000' AS DateTime), 2, 41, N'HEPA-B', CAST(N'2016-07-12' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-12 12:00:00.000' AS DateTime), 2, 41, N'LDL', CAST(N'2016-07-12' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, N'DHEA', CAST(N'2016-07-14' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, N'FLU', CAST(N'2016-07-14' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, N'HEPA-B', CAST(N'2016-07-14' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, N'LDL', CAST(N'2016-07-14' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, N'HDL', CAST(N'2016-07-19' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, N'HEPA-A', CAST(N'2016-07-19' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, N'TSH', CAST(N'2016-07-19' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, N'WBC', CAST(N'2016-07-19' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-20 09:00:00.000' AS DateTime), 4, 23, N'DHEA', CAST(N'2016-07-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-20 09:00:00.000' AS DateTime), 4, 23, N'FLU', CAST(N'2016-07-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-20 09:00:00.000' AS DateTime), 4, 23, N'LDL', CAST(N'2016-07-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, N'HDL', CAST(N'2015-10-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, N'HEPA-A', CAST(N'2016-07-29' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, N'TSH', CAST(N'2014-04-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, N'WBC', CAST(N'2015-09-12' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, N'HDL', CAST(N'2016-08-08' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, N'HEPA-A', CAST(N'2016-08-08' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, N'TSH', CAST(N'2016-08-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, N'WBC', CAST(N'2016-08-08' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-11 14:00:00.000' AS DateTime), 5, 38, N'WBC', CAST(N'2016-08-11' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 13:00:00.000' AS DateTime), 6, 28, N'HDL', CAST(N'2016-08-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 13:00:00.000' AS DateTime), 6, 28, N'HEPA-A', CAST(N'2016-08-20' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 13:00:00.000' AS DateTime), 6, 28, N'TSH', CAST(N'2016-08-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 16:00:00.000' AS DateTime), 6, 24, N'HEPA-A', CAST(N'2016-08-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 16:00:00.000' AS DateTime), 6, 24, N'TSH', CAST(N'2016-08-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-20 16:00:00.000' AS DateTime), 6, 24, N'WBC', CAST(N'2016-08-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, N'DHEA', CAST(N'2016-08-23' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, N'FLU', CAST(N'2016-08-23' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, N'HEPA-B', CAST(N'2016-08-23' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, N'LDL', CAST(N'2016-08-23' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, N'HDL', CAST(N'2016-08-28' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, N'HEPA-A', CAST(N'2016-03-30' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, N'TSH', CAST(N'2015-04-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, N'WBC', CAST(N'2014-10-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-09-20 15:20:00.000' AS DateTime), 6, 25, N'FLU', CAST(N'2016-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-09-20 15:20:00.000' AS DateTime), 6, 25, N'HEPA-B', CAST(N'2016-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-09-20 15:20:00.000' AS DateTime), 6, 25, N'LDL', CAST(N'2016-09-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-07 15:00:00.000' AS DateTime), 1, 42, N'HDL', CAST(N'2016-10-07' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-07 15:00:00.000' AS DateTime), 1, 42, N'HEPA-A', CAST(N'2016-10-07' AS Date), N'abnormal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-07 15:00:00.000' AS DateTime), 1, 42, N'WBC', CAST(N'2016-10-07' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-20 16:00:00.000' AS DateTime), 6, 26, N'HDL', CAST(N'2016-10-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-20 16:00:00.000' AS DateTime), 6, 26, N'HEPA-A', CAST(N'2016-10-20' AS Date), N'normal')
INSERT [dbo].[appointment_has_tests] ([appointment_date], [appointment_doctorID], [appointment_patientID], [tests_testCode], [testDate], [results]) VALUES (CAST(N'2016-10-20 16:00:00.000' AS DateTime), 6, 26, N'WBC', CAST(N'2016-10-20' AS Date), N'normal')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'aaverett9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'ajennings', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'dgore9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'dhand9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'dharris9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'ejackaven9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'hjones9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'jjacobs9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'jmayden9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'mfitzpatrick9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'mhumphery9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'mwilaven9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'nstaskelunas9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'rclark9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'revans9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'scarter9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'tdiggs9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'thall9', N'512521991012471557618716612921044901777284')
INSERT [dbo].[clinicemployees] ([userName], [passwords]) VALUES (N'tmarks9', N'512521991012471557618716612921044901777284')
SET IDENTITY_INSERT [dbo].[doctors] ON 

INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (1, 19, N'thall9')
INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (2, 26, N'jjacobs9')
INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (3, 23, N'mhumphery9')
INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (4, 18, N'dgore9')
INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (5, 3, N'aaverett9')
INSERT [dbo].[doctors] ([doctorID], [peopleID], [userName]) VALUES (6, 15, N'mfitzpatrick9')
SET IDENTITY_INSERT [dbo].[doctors] OFF
SET IDENTITY_INSERT [dbo].[nurses] ON 

INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (1, 25, N'ejackaven9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (2, 6, N'scarter9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (3, 7, N'rclark9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (4, 29, N'hjones9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (5, 11, N'tdiggs9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (6, 34, N'jmayden9')
INSERT [dbo].[nurses] ([nurseID], [peopleID], [userName]) VALUES (7, 20, N'dhand9')
SET IDENTITY_INSERT [dbo].[nurses] OFF
SET IDENTITY_INSERT [dbo].[patients] ON 

INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (1, 25)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (2, 6)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (3, 7)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (4, 29)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (5, 11)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (6, 34)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (7, 20)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (8, 40)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (9, 16)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (10, 10)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (11, 35)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (12, 8)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (13, 30)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (14, 45)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (15, 46)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (16, 21)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (17, 41)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (18, 36)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (19, 42)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (20, 43)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (21, 4)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (22, 28)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (23, 33)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (24, 37)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (25, 12)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (26, 13)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (27, 31)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (28, 2)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (29, 39)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (30, 19)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (31, 26)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (32, 23)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (33, 18)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (34, 3)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (35, 15)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (36, 47)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (37, 1)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (38, 14)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (39, 27)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (40, 22)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (41, 44)
INSERT [dbo].[patients] ([patientID], [peopleID]) VALUES (42, 32)
SET IDENTITY_INSERT [dbo].[patients] OFF
SET IDENTITY_INSERT [dbo].[people] ON 

INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (1, N'AnderAven', N'Keaton', CAST(N'1953-06-12' AS Date), N'215 Court', N'Auburn', N'Al', N'30332', N'999-999-9990', N'383576253', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (2, N'AnderAven', N'Ryan', CAST(N'1962-08-02' AS Date), N'253 Road', N'Daphne', N'AL', N'30332', N'999-999-9990', N'068788330', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (3, N'Averett', N'Anthony', CAST(N'1976-10-28' AS Date), N'183 Court', N'Woodbury', N'NU', N'30332', N'999-999-9990', N'993439579', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (4, N'Bateman', N'Cooper', CAST(N'1969-03-12' AS Date), N'220 Court', N'Murray', N'UT', N'30332', N'999-999-9990', N'376622734', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (5, N'Brown', N'Tony', CAST(N'1992-03-14' AS Date), N'900 Birdy Road', N'Atlanta', N'GA', N'30332', N'212-212-1221', N'714570140', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (6, N'Carter', N'Shyheim', CAST(N'1988-04-12' AS Date), N'190 Court', N'Kentwood', N'LA', N'30332', N'999-999-9990', N'663994804', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (7, N'Clark', N'Ronnie', CAST(N'1987-01-21' AS Date), N'215 Ave', N'Calera', N'AL', N'30332', N'999-999-9990', N'459854626', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (8, N'Cornwell', N'David', CAST(N'1978-12-29' AS Date), N'228 Ave', N'Norman', N'OK', N'30332', N'999-999-9990', N'086546132', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (9, N'Davis', N'Ben', CAST(N'1994-11-14' AS Date), N'701 Maple Drive', N'Griffin', N'GA', N'30332', N'770-888-9999', N'648156552', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (10, N'Dieter', N'Gehrig', CAST(N'1980-02-18' AS Date), N'207 Road', N'Aveuth Bend', N'IN', N'30332', N'999-999-9990', N'649419983', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (11, N'Diggs', N'Trevon', CAST(N'1985-07-21' AS Date), N'195	Court', N'Gaithersburg', N'MD', N'30332', N'999-999-9990', N'855280228', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (12, N'Dion Hamilton', N'Shaun', CAST(N'1965-11-22' AS Date), N'232 Court', N'Montgomery', N'AL', N'30332', N'999-999-9990', N'664639739', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (13, N'Emmons', N'B.J.', CAST(N'1984-10-13' AS Date), N'206	Court', N'Morganton', N'NC', N'30332', N'999-999-9990', N'593396377', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (14, N'Evans', N'Rashaan', CAST(N'1982-07-21' AS Date), N'231 Court', N'Auburn', N'AL', N'30332', N'999-999-9990', N'881630107', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (15, N'Fitzpatrick', N'Minkah', CAST(N'1985-01-09' AS Date), N'203 Ave', N'Old Bridge', N'NU', N'30332', N'999-999-9990', N'627129513', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (16, N'Fost', N'Rober', CAST(N'1993-09-11' AS Date), N'800 Cowboy Lane', N'Little Rock', N'GA', N'30332', N'888-777-6666', N'875727745', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (17, N'Foster', N'Reuben', CAST(N'1981-03-13' AS Date), N'236 Road', N'Auburn', N'AL', N'30332', N'999-999-9990', N'302868468', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (18, N'Gore', N'Derrick', CAST(N'1977-03-29' AS Date), N'210	Court', N'Syracuse', N'NY', N'30332', N'999-999-9990', N'642666606', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (19, N'Hall', N'Terrell', CAST(N'1980-06-28' AS Date), N'247	Court', N'Washington', N'DC', N'30332', N'999-999-9990', N'492975552', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (20, N'Hand', N'DaShawn', CAST(N'1983-05-24' AS Date), N'280	Court', N'Woodridge', N'VA', N'30332', N'999-999-9990', N'106383052', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (21, N'HarriAven', N'Ronnie', CAST(N'1974-08-21' AS Date), N'216	Ave', N'Tallahassee', N'FL', N'30332', N'999-999-9990', N'659116636', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (22, N'Harris', N'Damien', CAST(N'1971-10-05' AS Date), N'214	Ave', N'Berea', N'KY', N'30332', N'999-999-9990', N'895103422', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (23, N'Humphrey', N'Marlon', CAST(N'1968-04-21' AS Date), N'196	Ave', N'Hoover', N'AL', N'30332', N'999-999-9990', N'693875015', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (24, N'Hurts', N'Jalen', CAST(N'1991-05-05' AS Date), N'209	FR', N'Channelview', N'TX', N'30332', N'111-111-1111', N'863647418', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (25, N'JackAven', N'Eddie', CAST(N'1989-10-21' AS Date), N'194 Road ', N'Lauderdale Lakes', N'FL', N'30332', N'999-999-9990', N'393194022', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (26, N'Jacobs', N'Joshua', CAST(N'1989-05-27' AS Date), N'204 Court', N'Tulsa', N'OK', N'30332', N'999-999-9990', N'179153341', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (27, N'Jennings', N'Anfernee', CAST(N'1972-07-08' AS Date), N'264 Court', N'Dadeville', N'AL', N'30332', N'999-999-9990', N'093593796', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (28, N'Jennings', N'Shawn', CAST(N'1968-02-21' AS Date), N'200 Court', N'Dadeville', N'AL', N'30332', N'999-999-9990', N'506579093', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (29, N'Jones', N'Hootie', CAST(N'1986-08-03' AS Date), N'215	Court', N'Monroe', N'LA', N'30332', N'999-999-9990', N'246673081', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (30, N'Knott', N'Nigel', CAST(N'1977-11-09' AS Date), N'175	Court', N'MaidAven', N'MS', N'30332', N'999-999-9990', N'613653690', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (31, N'Lewis', N'Rogria', CAST(N'1963-09-14' AS Date), N'196	Court', N'Birmingham', N'AL', N'30332', N'999-999-9990', N'501541304', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (32, N'Marks', N'Torin', CAST(N'1979-10-07' AS Date), N'175	Court', N'Rosenberg', N'TX', N'30332', N'999-999-9990', N'874614274', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (33, N'Marks', N'Xavian', CAST(N'1967-01-08' AS Date), N'166	Ave', N'Rosenberg', N'TX', N'30332', N'999-999-9990', N'971035993', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (34, N'Mayden', N'Jared', CAST(N'1984-06-09' AS Date), N'200	Court', N'Sachse', N'TX', N'30332', N'999-999-9990', N'816735435', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (35, N'Morris', N'Alec', CAST(N'1979-01-25' AS Date), N'233	Road', N'Allen', N'TX', N'30332', N'999-999-9990', N'900238700', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (36, N'Mosley', N'Jamey', CAST(N'1972-06-09' AS Date), N'228	Ave', N'Mobil', N'AL', N'30332', N'999-999-9990', N'371683087', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (37, N'Murphy', N'Montana', CAST(N'1966-12-09' AS Date), N'201	Court', N'Trophy Club', N'rt', N'30332', N'999-999-9990', N'784439002', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (38, N'Ridley', N'Calvin', CAST(N'1990-07-03' AS Date), N'188 SO', N'Coconut Creek', N'FL', N'30332', N'898-900-9999', N'005085253', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (39, N'RobinAven', N'Aaron', CAST(N'1961-07-09' AS Date), N'181 Court', N'Deerfield Beach', N'FL', N'30332', N'999-999-9990', N'979891447', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (40, N'Scarbrough', N'Bo', CAST(N'1982-04-04' AS Date), N'228 Ave', N'Northport', N'AL', N'30332', N'999-999-9990', N'882096308', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (41, N'Scott', N'JK', CAST(N'1973-07-22' AS Date), N'202	Court', N'Denver', N'CO', N'30332', N'999-999-9990', N'133415836', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (42, N'Simmons', N'T.J.', CAST(N'1971-05-11' AS Date), N'201	Court', N'PinAven', N'AL', N'30332', N'999-999-9990', N'155751928', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (43, N'Sims', N'Cam', CAST(N'1970-04-17' AS Date), N'203	Court', N'Monroe', N'LA', N'30332', N'999-999-9990', N'462064882', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (44, N'Staskelunas', N'Nate', CAST(N'1970-09-08' AS Date), N'207	Road', N'Greenville', N'NC', N'30332', N'999-999-9990', N'480015734', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (45, N'Stewart', N'ArDarius', CAST(N'1976-10-28' AS Date), N'204	Court', N'Fultondale', N'AL', N'30332', N'999-999-9990', N'520155730', N'Male')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (46, N'ThompAven', N'Deionte', CAST(N'1975-09-07' AS Date), N'190 Court', N'Orange', N'TX', N'30332', N'999-999-9990', N'174348219', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (47, N'WilAven', N'Mack', CAST(N'1974-05-11' AS Date), N'244	Court', N'Montgomery', N'AL', N'30332', N'999-999-9990', N'583566609', N'Female')
INSERT [dbo].[people] ([peopleID], [lastName], [firstName], [dateOfBirth], [streetAddress], [city], [state], [zip], [phoneNumber], [ssn], [gender]) VALUES (48, N'Woods', N'Thomas', CAST(N'1989-05-21' AS Date), N'165	Court', N'Birmingham', N'AL', N'30332', N'999-999-9990', N'688179969', N'Female')
SET IDENTITY_INSERT [dbo].[people] OFF
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'DHEA', N'Dehydroepiandrosterone')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'FLU', N'Flu Test')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'HDL', N'High Density Lipoproteins')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'HEPA-A', N'Hepatitis A Test')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'HEPA-B', N'Hepatitis B Test')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'LDL', N'Low Density Lipoproteins')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'TSH', N'Thyroid Stimulating Hormone')
INSERT [dbo].[tests] ([testCode], [testName]) VALUES (N'WBC', N'White Blood Cell')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2010-10-10 13:00:00.000' AS DateTime), 2, 1, 2, N'120', N'80', N'99', N'88', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2010-12-10 13:00:00.000' AS DateTime), 5, 32, 3, N'130', N'90', N'97', N'80', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2011-09-10 13:00:00.000' AS DateTime), 4, 11, 4, N'140', N'110', N'98', N'100', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2011-10-10 13:00:00.000' AS DateTime), 3, 2, 5, N'90', N'70', N'98', N'76', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2012-10-10 10:00:00.000' AS DateTime), 4, 3, 7, N'130', N'80', N'98', N'110', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2013-06-10 13:00:00.000' AS DateTime), 5, 21, 2, N'90', N'80', N'97', N'75', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2013-10-10 15:00:00.000' AS DateTime), 5, 4, 3, N'120', N'90', N'98', N'75', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2013-12-10 13:00:00.000' AS DateTime), 6, 34, 4, N'130', N'110', N'98', N'88', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2014-02-10 13:00:00.000' AS DateTime), 1, 20, 5, N'140', N'70', N'99', N'80', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2014-05-13 13:02:00.000' AS DateTime), 5, 13, 4, N'120', N'110', N'99', N'75', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2014-10-10 14:00:00.000' AS DateTime), 6, 5, 6, N'90', N'70', N'98', N'100', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-01-15 09:00:00.000' AS DateTime), 6, 5, 5, N'130', N'70', N'98', N'75', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-02-10 09:00:00.000' AS DateTime), 4, 6, 3, N'130', N'90', N'98', N'100', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-03-10 13:00:00.000' AS DateTime), 2, 19, 7, N'120', N'80', N'99', N'76', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-03-18 09:30:00.000' AS DateTime), 1, 7, 6, N'140', N'70', N'99', N'88', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-06-18 10:30:00.000' AS DateTime), 2, 29, 7, N'90', N'80', N'97', N'80', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-08-06 11:35:00.000' AS DateTime), 3, 27, 1, N'120', N'70', N'98', N'100', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-09-20 14:15:00.000' AS DateTime), 4, 39, 2, N'130', N'80', N'98', N'76', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-10-10 11:00:00.000' AS DateTime), 1, 6, 1, N'130', N'70', N'97', N'56', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-11-10 11:00:00.000' AS DateTime), 5, 15, 3, N'140', N'90', N'99', N'56', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2015-12-19 13:00:00.000' AS DateTime), 6, 11, 4, N'90', N'110', N'98', N'110', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-01-10 13:00:00.000' AS DateTime), 3, 10, 1, N'90', N'70', N'98', N'75', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-01-23 08:00:00.000' AS DateTime), 1, 32, 4, N'120', N'110', N'98', N'75', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-02-01 12:00:00.000' AS DateTime), 4, 36, 7, N'90', N'80', N'98', N'100', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-02-10 13:00:00.000' AS DateTime), 3, 30, 2, N'140', N'80', N'98', N'110', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-02-20 10:10:10.000' AS DateTime), 5, 18, 4, N'130', N'110', N'97', N'80', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-02-26 10:00:00.000' AS DateTime), 2, 33, 5, N'130', N'70', N'98', N'88', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-03-03 14:30:00.000' AS DateTime), 1, 37, 5, N'120', N'70', N'99', N'150', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-03-29 11:00:00.000' AS DateTime), 3, 34, 6, N'140', N'70', N'99', N'80', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-04-05 12:00:00.000' AS DateTime), 5, 38, 2, N'130', N'80', N'97', N'56', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-05-02 10:00:00.000' AS DateTime), 2, 35, 6, N'130', N'70', N'97', N'75', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-05-20 13:00:00.000' AS DateTime), 4, 31, 1, N'140', N'70', N'99', N'150', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-06-05 13:00:00.000' AS DateTime), 4, 36, 1, N'120', N'70', N'99', N'76', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-06-09 09:15:00.000' AS DateTime), 3, 40, 2, N'90', N'80', N'98', N'75', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-06-20 09:00:00.000' AS DateTime), 6, 30, 3, N'90', N'90', N'97', N'75', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-06-20 15:20:00.000' AS DateTime), 6, 22, 6, N'120', N'70', N'99', N'56', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-06-29 15:30:00.000' AS DateTime), 3, 20, 5, N'140', N'70', N'98', N'100', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-07-12 12:00:00.000' AS DateTime), 2, 41, 1, N'140', N'70', N'99', N'75', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-07-14 11:05:00.000' AS DateTime), 3, 17, 7, N'140', N'80', N'98', N'75', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-07-19 11:15:00.000' AS DateTime), 4, 16, 3, N'120', N'90', N'99', N'88', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-07-20 09:00:00.000' AS DateTime), 4, 23, 1, N'90', N'70', N'98', N'88', N'nausea', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-07-29 10:00:00.000' AS DateTime), 1, 14, 6, N'120', N'70', N'98', N'110', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-08 11:00:00.000' AS DateTime), 2, 12, 5, N'90', N'70', N'97', N'56', N'headache', N'headache')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-11 14:00:00.000' AS DateTime), 5, 38, 3, N'140', N'90', N'98', N'110', N'abdominal pain', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-20 13:00:00.000' AS DateTime), 6, 28, 2, N'140', N'80', N'99', N'150', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-20 16:00:00.000' AS DateTime), 6, 24, 6, N'90', N'70', N'98', N'76', N'abdominal pain', N'stomach bug')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-23 10:00:00.000' AS DateTime), 5, 9, 2, N'120', N'80', N'99', N'80', N'beating chest', N'heart attack')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-08-28 10:00:00.000' AS DateTime), 3, 8, 4, N'140', N'110', N'99', N'76', N'fever and chills', N'flu')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-09-20 15:20:00.000' AS DateTime), 6, 25, 7, N'120', N'80', N'99', N'56', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-10-07 15:00:00.000' AS DateTime), 1, 42, 7, N'130', N'80', N'98', N'150', N'Fatigue', N'needs sleep')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-10-10 13:00:00.000' AS DateTime), 2, 9, 3, N'90', N'90', N'98', N'150', N'painful rash', N'funk')
INSERT [dbo].[vitals] ([appointment_date], [appointment_doctorID], [appointment_patientID], [nurses_nurseID], [systolic], [diastolic], [temperature], [pulse], [symptoms], [diagnosis]) VALUES (CAST(N'2016-10-20 16:00:00.000' AS DateTime), 6, 26, 1, N'130', N'70', N'98', N'110', N'nausea', N'stomach bug')
ALTER TABLE [dbo].[administrators]  WITH CHECK ADD  CONSTRAINT [fk_administrators_clinicEmployees] FOREIGN KEY([userName])
REFERENCES [dbo].[clinicemployees] ([userName])
GO
ALTER TABLE [dbo].[administrators] CHECK CONSTRAINT [fk_administrators_clinicEmployees]
GO
ALTER TABLE [dbo].[administrators]  WITH CHECK ADD  CONSTRAINT [fk_administrators_people] FOREIGN KEY([peopleID])
REFERENCES [dbo].[people] ([peopleID])
GO
ALTER TABLE [dbo].[administrators] CHECK CONSTRAINT [fk_administrators_people]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [fk_appointment_doctors] FOREIGN KEY([doctorID])
REFERENCES [dbo].[doctors] ([doctorID])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [fk_appointment_doctors]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [fk_appointment_patients] FOREIGN KEY([patientID])
REFERENCES [dbo].[patients] ([patientID])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [fk_appointment_patients]
GO
ALTER TABLE [dbo].[appointment_has_tests]  WITH CHECK ADD  CONSTRAINT [fk_appointment_has_tests_appointment] FOREIGN KEY([appointment_date], [appointment_doctorID], [appointment_patientID])
REFERENCES [dbo].[appointment] ([date], [doctorID], [patientID])
GO
ALTER TABLE [dbo].[appointment_has_tests] CHECK CONSTRAINT [fk_appointment_has_tests_appointment]
GO
ALTER TABLE [dbo].[appointment_has_tests]  WITH CHECK ADD  CONSTRAINT [fk_appointment_has_tests_tests] FOREIGN KEY([tests_testCode])
REFERENCES [dbo].[tests] ([testCode])
GO
ALTER TABLE [dbo].[appointment_has_tests] CHECK CONSTRAINT [fk_appointment_has_tests_tests]
GO
ALTER TABLE [dbo].[doctors]  WITH CHECK ADD  CONSTRAINT [fk_doctors_clinicEmployees] FOREIGN KEY([userName])
REFERENCES [dbo].[clinicemployees] ([userName])
GO
ALTER TABLE [dbo].[doctors] CHECK CONSTRAINT [fk_doctors_clinicEmployees]
GO
ALTER TABLE [dbo].[doctors]  WITH CHECK ADD  CONSTRAINT [fk_doctors_people] FOREIGN KEY([peopleID])
REFERENCES [dbo].[people] ([peopleID])
GO
ALTER TABLE [dbo].[doctors] CHECK CONSTRAINT [fk_doctors_people]
GO
ALTER TABLE [dbo].[doctors_has_speciality]  WITH CHECK ADD  CONSTRAINT [fk_doctors_has_speciality_doctors] FOREIGN KEY([doctorID])
REFERENCES [dbo].[doctors] ([doctorID])
GO
ALTER TABLE [dbo].[doctors_has_speciality] CHECK CONSTRAINT [fk_doctors_has_speciality_doctors]
GO
ALTER TABLE [dbo].[doctors_has_speciality]  WITH CHECK ADD  CONSTRAINT [fk_doctors_has_speciality_speciality] FOREIGN KEY([specialityID])
REFERENCES [dbo].[speciality] ([specialityID])
GO
ALTER TABLE [dbo].[doctors_has_speciality] CHECK CONSTRAINT [fk_doctors_has_speciality_speciality]
GO
ALTER TABLE [dbo].[nurses]  WITH CHECK ADD  CONSTRAINT [fk_nurses_clinicEmployees] FOREIGN KEY([userName])
REFERENCES [dbo].[clinicemployees] ([userName])
GO
ALTER TABLE [dbo].[nurses] CHECK CONSTRAINT [fk_nurses_clinicEmployees]
GO
ALTER TABLE [dbo].[nurses]  WITH CHECK ADD  CONSTRAINT [fk_nurses_people] FOREIGN KEY([peopleID])
REFERENCES [dbo].[people] ([peopleID])
GO
ALTER TABLE [dbo].[nurses] CHECK CONSTRAINT [fk_nurses_people]
GO
ALTER TABLE [dbo].[patients]  WITH CHECK ADD  CONSTRAINT [fk_patients_people] FOREIGN KEY([peopleID])
REFERENCES [dbo].[people] ([peopleID])
GO
ALTER TABLE [dbo].[patients] CHECK CONSTRAINT [fk_patients_people]
GO
ALTER TABLE [dbo].[vitals]  WITH CHECK ADD  CONSTRAINT [fk_vitals_appointment] FOREIGN KEY([appointment_date], [appointment_doctorID], [appointment_patientID])
REFERENCES [dbo].[appointment] ([date], [doctorID], [patientID])
GO
ALTER TABLE [dbo].[vitals] CHECK CONSTRAINT [fk_vitals_appointment]
GO
ALTER TABLE [dbo].[vitals]  WITH CHECK ADD  CONSTRAINT [fk_vitals_nurses] FOREIGN KEY([nurses_nurseID])
REFERENCES [dbo].[nurses] ([nurseID])
GO
ALTER TABLE [dbo].[vitals] CHECK CONSTRAINT [fk_vitals_nurses]
GO
/****** Object:  StoredProcedure [dbo].[usp_mostPerformedTestsDuringDates]    Script Date: 4/23/2017 12:49:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_mostPerformedTestsDuringDates] 
	@startDate date,
	@endDate date
AS
	/* Used so a row count is not returned */
	SET NOCOUNT ON;

	IF @startDate > @endDate
		THROW 50001, 'Start date is cannot be greater than end date', 1;
	IF @startDate > GETDATE() OR @endDate > GETDATE()
		THROW 50001, 'Date entered is greater than current date', 1;
	IF @endDate IS NULL
		THROW 50001, 'The end date cannot be null', 1;
	IF @startDate IS NULL
		THROW 50001, 'The start date cannot be null', 1;
	IF @startDate = ''
		THROW 50001, 'The start date is empty', 1;
	IF @endDate = ''
		THROW 50001, 'The end date is empty', 1;
	 
    SELECT main1.tests_testCode, main1.testName,  
           main1.timesTestPerformed, 
		   main2.total_performed,
		   ROUND(100 * main1.timesTestPerformed / main2.total_performed, 2),
		   main1.result,
		   main1.abnormal,
		   ROUND(100 * main1.agegroup18 / main1.timesTestPerformed, 2),
		   ROUND(100 * main1.otherAgeGroup / main1.timesTestPerformed, 2)
	FROM 
		(SELECT tests_testCode, 
				t2.testName, 
				COUNT(*) AS timesTestPerformed,
				sum(case when t1.results = 'Normal' then 1 else 0 end) AS result,
				sum(case when t1.results = 'Abnormal' then 1 else 0 end) AS abnormal,
				SUM(case when (DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) >= 18 AND DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) <= 29) then 1 else 0 end) AS agegroup18,
				SUM(case when (DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) < 18 OR DATEDIFF(YEAR, t4.dateOfBirth, t1.testDate) > 29) then 1 else 0 end) AS otherAgeGroup
		FROM
			appointment_has_tests t1
			JOIN tests t2 ON t2.testCode = t1.tests_testCode 
			JOIN patients t3 ON t3.patientID = t1.appointment_patientID
			JOIN people t4 ON t4.peopleID = t3.peopleID
		WHERE t1.testDate >= @startDate AND t1.testDate <= @endDate 
		GROUP BY t1.tests_testCode, t2.testName
		HAVING COUNT(*) > 1) main1,
		(SELECT COUNT(*) AS total_performed FROM appointment_has_tests WHERE 
		testDate >= @startDate AND testDate <= @endDate) main2
	ORDER BY main1.timesTestPerformed DESC, main1.tests_testCode DESC;

GO
USE [master]
GO
ALTER DATABASE [CS6232-g3] SET  READ_WRITE 
GO
