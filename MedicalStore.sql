USE [master]
GO
/****** Object:  Database [MedicalStore]    Script Date: 12/12/2019 2:45:50 PM ******/
CREATE DATABASE [MedicalStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Medical Store', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Medical Store.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Medical Store_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Medical Store_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MedicalStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MedicalStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MedicalStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MedicalStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MedicalStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MedicalStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MedicalStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MedicalStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MedicalStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MedicalStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MedicalStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MedicalStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MedicalStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MedicalStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MedicalStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MedicalStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MedicalStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MedicalStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MedicalStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MedicalStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MedicalStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MedicalStore] SET  MULTI_USER 
GO
ALTER DATABASE [MedicalStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MedicalStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MedicalStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MedicalStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MedicalStore]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Credentials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CustomerHistories]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CustomerHistories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Contact] [int] NOT NULL,
	[SaleId] [int] NOT NULL,
	[MedName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_CustomerHistories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmpId] [int] IDENTITY(6001,1) NOT NULL,
	[EmpName] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Contact] [int] NOT NULL,
	[Salary] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicines]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicines](
	[MedId] [int] IDENTITY(2111,1) NOT NULL,
	[MedName] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[BuyingPrice] [float] NOT NULL,
	[SellingPrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED 
(
	[MedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profits]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SaleId] [int] NOT NULL,
	[MedId] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Income] [float] NOT NULL,
 CONSTRAINT [PK_Profits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Purchases](
	[SaleId] [int] NOT NULL,
	[MedId] [int] NOT NULL,
	[MedName] [varchar](50) NOT NULL,
	[UnitPrice] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Amount] [float] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 12/12/2019 2:45:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[SaleId] [int] NOT NULL,
	[MedName] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Credentials] ON 

INSERT [dbo].[Credentials] ([Id], [UserId], [Password], [Type]) VALUES (1, 6001, N'sam', 1)
INSERT [dbo].[Credentials] ([Id], [UserId], [Password], [Type]) VALUES (2, 6002, N'p4105619', 1)
INSERT [dbo].[Credentials] ([Id], [UserId], [Password], [Type]) VALUES (5, 6005, N'qwe', 0)
INSERT [dbo].[Credentials] ([Id], [UserId], [Password], [Type]) VALUES (7, 6007, N'p4740719', 1)
SET IDENTITY_INSERT [dbo].[Credentials] OFF
SET IDENTITY_INSERT [dbo].[CustomerHistories] ON 

INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1021, CAST(0x74400B00 AS Date), 123654789, 54, N'Fexo', 4)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1022, CAST(0x74400B00 AS Date), 123654789, 54, N'Adora', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1023, CAST(0x74400B00 AS Date), 123654789, 54, N'Ansulin', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1024, CAST(0x75400B00 AS Date), 789654123, 55, N'Conasyd', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1025, CAST(0x75400B00 AS Date), 789654123, 55, N'Prevas', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1026, CAST(0x75400B00 AS Date), 789654123, 55, N'Adora', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1027, CAST(0x76400B00 AS Date), 852147963, 56, N'Prevas', 8)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1028, CAST(0x76400B00 AS Date), 852147963, 56, N'Adora', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1029, CAST(0x76400B00 AS Date), 852147963, 56, N'Fexo', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1030, CAST(0x76400B00 AS Date), 852147963, 56, N'Ciprocin', 5)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1031, CAST(0x76400B00 AS Date), 698745213, 57, N'Conasyd', 2)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1032, CAST(0x77400B00 AS Date), 741258963, 58, N'Adora', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1033, CAST(0x77400B00 AS Date), 741258963, 58, N'Prevas', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1034, CAST(0x77400B00 AS Date), 741258963, 58, N'Finix', 9)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1035, CAST(0x78400B00 AS Date), 987456301, 59, N'Ansulin', 3)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1036, CAST(0x78400B00 AS Date), 987400563, 60, N'Compiron', 5)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1037, CAST(0x79400B00 AS Date), 120014789, 61, N'Finix', 5)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1038, CAST(0x79400B00 AS Date), 120014789, 61, N'Prevas', 6)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1039, CAST(0x7A400B00 AS Date), 789654123, 62, N'Eumovate', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1040, CAST(0x7A400B00 AS Date), 789654123, 62, N'Conasyd', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1041, CAST(0x7A400B00 AS Date), 852369740, 63, N'test', 2)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1042, CAST(0x7A400B00 AS Date), 852369740, 63, N'Eumovate', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1043, CAST(0x7A400B00 AS Date), 852369740, 63, N'Ansulin', 1)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1044, CAST(0x7B400B00 AS Date), 120365478, 64, N'Finix', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1045, CAST(0x7B400B00 AS Date), 456301287, 65, N'Adora', 2)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1046, CAST(0x7B400B00 AS Date), 456301287, 65, N'Ciprocin', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1047, CAST(0x7C400B00 AS Date), 741258963, 67, N'Lanso', 10)
INSERT [dbo].[CustomerHistories] ([Id], [Date], [Contact], [SaleId], [MedName], [Quantity]) VALUES (1048, CAST(0x7C400B00 AS Date), 741258963, 67, N'Alacor DS', 1)
SET IDENTITY_INSERT [dbo].[CustomerHistories] OFF
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmpId], [EmpName], [Designation], [Contact], [Salary]) VALUES (6001, N'Joe', N'Manager', 789654, 500)
INSERT [dbo].[Employees] ([EmpId], [EmpName], [Designation], [Contact], [Salary]) VALUES (6002, N'Leo', N'Salesman', 987456, 320)
INSERT [dbo].[Employees] ([EmpId], [EmpName], [Designation], [Contact], [Salary]) VALUES (6005, N'Henry', N'Salesman', 456455, 300)
INSERT [dbo].[Employees] ([EmpId], [EmpName], [Designation], [Contact], [Salary]) VALUES (6007, N'Keviin', N'Manager', 741258, 450)
SET IDENTITY_INSERT [dbo].[Employees] OFF
SET IDENTITY_INSERT [dbo].[Medicines] ON 

INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2124, N'test', N'Drop', 5, 6, 14)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2125, N'testd', N'Capsule', 4, 9, 36)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2127, N'Adora', N'Drops', 50, 53, 15)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2128, N'Compiron', N'Drops', 30, 34, 85)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2129, N'Rifamex', N'Tablet', 65, 68, 97)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2130, N'Alacor DS', N'Eye Drop', 150.45, 155, 98)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2131, N'Ansulin', N'SC Injection', 4150, 4200, 65)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2132, N'Cefotil', N'Suspention', 199.35, 202, 19)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2133, N'Phylopen Forte ', N'Oral Suspension', 110.41, 112, 495)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2134, N'Lanso', N'Capsule', 3.51, 4.5, 477)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2135, N'Eumovate', N'Cream', 45, 48, 148)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2136, N'Napa Extra', N'Tablet', 4.2, 5.5, 790)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2137, N'Finix', N'Tablet', 5, 6, 435)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2138, N'Ciprocin', N'Capsule', 15.5, 17, 525)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2139, N'Fexo', N'Tablet', 7, 9, 681)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2140, N'Conasyd', N'Cream', 163.5, 166, 143)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2141, N'Prevas', N'Capsule', 4, 6, 364)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2142, N'Yamadin', N'Tablet', 4, 5.5, 675)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2143, N'Napa', N'Tablet', 2, 2.5, 700)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2146, N'Adora', N'Drops', 55, 58, 94)
INSERT [dbo].[Medicines] ([MedId], [MedName], [Type], [BuyingPrice], [SellingPrice], [Quantity]) VALUES (2147, N'Fexo', N'Tablet', 9, 10, 470)
SET IDENTITY_INSERT [dbo].[Medicines] OFF
SET IDENTITY_INSERT [dbo].[Profits] ON 

INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1038, 54, 2139, CAST(0x74400B00 AS Date), 8)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1039, 54, 2146, CAST(0x74400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1040, 54, 2131, CAST(0x74400B00 AS Date), 50)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1041, 55, 2140, CAST(0x75400B00 AS Date), 2.5)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1042, 55, 2141, CAST(0x75400B00 AS Date), 20)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1043, 55, 2146, CAST(0x75400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1044, 56, 2141, CAST(0x76400B00 AS Date), 16)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1045, 56, 2146, CAST(0x76400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1046, 56, 2147, CAST(0x76400B00 AS Date), 10)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1047, 56, 2138, CAST(0x76400B00 AS Date), 7.5)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1048, 57, 2140, CAST(0x76400B00 AS Date), 5)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1049, 58, 2146, CAST(0x77400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1050, 58, 2141, CAST(0x77400B00 AS Date), 20)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1051, 58, 2137, CAST(0x77400B00 AS Date), 9)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1052, 59, 2131, CAST(0x78400B00 AS Date), 150)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1053, 60, 2128, CAST(0x78400B00 AS Date), 20)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1054, 61, 2137, CAST(0x79400B00 AS Date), 5)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1055, 61, 2141, CAST(0x79400B00 AS Date), 12)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1056, 62, 2135, CAST(0x7A400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1057, 62, 2140, CAST(0x7A400B00 AS Date), 2.5)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1058, 63, 2124, CAST(0x7A400B00 AS Date), 2)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1059, 63, 2135, CAST(0x7A400B00 AS Date), 3)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1060, 63, 2131, CAST(0x7A400B00 AS Date), 50)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1061, 64, 2137, CAST(0x7B400B00 AS Date), 10)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1062, 65, 2146, CAST(0x7B400B00 AS Date), 6)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1063, 65, 2138, CAST(0x7B400B00 AS Date), 15)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1064, 67, 2134, CAST(0x7C400B00 AS Date), 9.90000000000001)
INSERT [dbo].[Profits] ([Id], [SaleId], [MedId], [Date], [Income]) VALUES (1065, 67, 2130, CAST(0x7C400B00 AS Date), 4.55000000000001)
SET IDENTITY_INSERT [dbo].[Profits] OFF
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (1, 12, N'po', 4, 5, 20)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (13, 2127, N'Adora', 53, 2, 106)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (32, 2127, N'Adora', 53, 1, 53)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (14, 2136, N'Napa Extra', 5.5, 10, 55)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (26, 2115, N'test2', 47, 1, 47)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (15, 2127, N'Adora', 53, 2, 106)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (15, 2128, N'Compiron', 34, 1, 34)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (27, 2116, N'test3', 10, 1, 10)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (37, 2141, N'Prevas', 6, 5, 30)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (20, 2117, N'test4', 33, 1, 33)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (21, 2115, N'test2', 47, 5, 235)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (23, 2115, N'test2', 47, 2, 94)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (24, 2115, N'test2', 47, 2, 94)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (25, 2115, N'test2', 47, 4, 188)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (38, 2142, N'Yamadin', 5.5, 15, 82.5)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (38, 2141, N'Prevas', 6, 20, 120)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (38, 2140, N'Conasyd', 166, 1, 166)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (39, 2124, N'test', 6, 1, 6)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (42, 2130, N'Alacor DS', 155, 1, 155)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (42, 2126, N'Xpain', 3, 9, 27)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (44, 2122, N'test20', 10, 7, 70)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (46, 2125, N'testd', 9, 4, 36)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (47, 2124, N'test', 6, 1, 6)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (48, 2130, N'Alacor DS', 155, 1, 155)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (49, 2128, N'Compiron', 34, 6, 204)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (50, 2140, N'Conasyd', 166, 2, 332)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (54, 2139, N'Fexo', 9, 4, 36)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (54, 2146, N'Adora', 58, 1, 58)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (54, 2131, N'Ansulin', 4200, 1, 4200)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (55, 2140, N'Conasyd', 166, 1, 166)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (55, 2141, N'Prevas', 6, 10, 60)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (56, 2141, N'Prevas', 6, 8, 48)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (56, 2146, N'Adora', 58, 1, 58)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (56, 2147, N'Fexo', 10, 10, 100)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (56, 2138, N'Ciprocin', 17, 5, 85)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (57, 2140, N'Conasyd', 166, 2, 332)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (58, 2146, N'Adora', 58, 1, 58)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (61, 2137, N'Finix', 6, 5, 30)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (63, 2124, N'test', 6, 2, 12)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (63, 2135, N'Eumovate', 48, 1, 48)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (63, 2131, N'Ansulin', 4200, 1, 4200)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (65, 2146, N'Adora', 58, 2, 116)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (66, 2125, N'testd', 9, 10, 90)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (26, 2115, N'test2', 47, 1, 47)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (31, 2129, N'Rifamex', 68, 10, 680)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (32, 2120, N'test6', 105, 2, 210)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (33, 2141, N'Prevas', 6, 10, 60)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (41, 2126, N'Xpain', 3, 10, 30)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (45, 2122, N'test20', 10, 3, 30)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (58, 2141, N'Prevas', 6, 10, 60)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (42, 2129, N'Rifamex', 68, 2, 136)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (60, 2128, N'Compiron', 34, 5, 170)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (65, 2138, N'Ciprocin', 17, 10, 170)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (26, 2116, N'test3', 10, 1, 10)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (27, 2115, N'test2', 47, 1, 47)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (28, 2115, N'test2', 47, 1, 47)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (29, 2115, N'test2', 47, 1, 47)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (29, 2116, N'test3', 10, 1, 10)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (30, 2142, N'Yamadin', 5.5, 10, 55)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (30, 2141, N'Prevas', 6, 10, 60)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (31, 2130, N'Alacor DS', 155, 1, 155)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (32, 2130, N'Alacor DS', 155, 1, 155)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (33, 2142, N'Yamadin', 5.5, 15, 82.5)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (34, 2139, N'Fexo', 9, 10, 90)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (35, 2141, N'Prevas', 6, 7, 42)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (35, 2142, N'Yamadin', 5.5, 5, 27.5)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (36, 2129, N'Rifamex', 68, 1, 68)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (36, 2128, N'Compiron', 34, 2, 68)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (37, 2140, N'Conasyd', 166, 1, 166)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (39, 2126, N'Xpain', 3, 1, 3)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (41, 2120, N'test6', 105, 5, 525)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (44, 2123, N'test5', 50, 2, 100)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (53, 2134, N'Lanso', 4.5, 10, 45)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (55, 2146, N'Adora', 58, 1, 58)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (58, 2137, N'Finix', 6, 9, 54)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (62, 2135, N'Eumovate', 48, 1, 48)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (67, 2134, N'Lanso', 4.5, 10, 45)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (34, 2136, N'Napa Extra', 5.5, 20, 110)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (39, 2125, N'testd', 9, 1, 9)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (40, 2120, N'test6', 105, 2, 210)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (41, 2117, N'test4', 33, 2, 66)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (43, 2117, N'test4', 33, 2, 66)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (34, 2142, N'Yamadin', 5.5, 10, 55)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (51, 2125, N'testd', 9, 2, 18)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (59, 2131, N'Ansulin', 4200, 3, 12600)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (67, 2130, N'Alacor DS', 155, 1, 155)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (52, 2129, N'Rifamex', 68, 1, 68)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (62, 2140, N'Conasyd', 166, 1, 166)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (64, 2137, N'Finix', 6, 10, 60)
INSERT [dbo].[Purchases] ([SaleId], [MedId], [MedName], [UnitPrice], [Quantity], [Amount]) VALUES (61, 2141, N'Prevas', 6, 6, 36)
SET IDENTITY_INSERT [dbo].[Sales] ON 

INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1011, CAST(0x74400B00 AS Date), 54, N'Fexo', 4)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1012, CAST(0x74400B00 AS Date), 54, N'Adora', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1013, CAST(0x74400B00 AS Date), 54, N'Ansulin', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1014, CAST(0x75400B00 AS Date), 55, N'Conasyd', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1015, CAST(0x75400B00 AS Date), 55, N'Prevas', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1016, CAST(0x75400B00 AS Date), 55, N'Adora', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1017, CAST(0x76400B00 AS Date), 56, N'Prevas', 8)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1018, CAST(0x76400B00 AS Date), 56, N'Adora', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1019, CAST(0x76400B00 AS Date), 56, N'Fexo', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1020, CAST(0x76400B00 AS Date), 56, N'Ciprocin', 5)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1021, CAST(0x76400B00 AS Date), 57, N'Conasyd', 2)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1022, CAST(0x77400B00 AS Date), 58, N'Adora', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1023, CAST(0x77400B00 AS Date), 58, N'Prevas', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1024, CAST(0x77400B00 AS Date), 58, N'Finix', 9)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1025, CAST(0x78400B00 AS Date), 59, N'Ansulin', 3)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1026, CAST(0x78400B00 AS Date), 60, N'Compiron', 5)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1027, CAST(0x79400B00 AS Date), 61, N'Finix', 5)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1028, CAST(0x79400B00 AS Date), 61, N'Prevas', 6)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1029, CAST(0x7A400B00 AS Date), 62, N'Eumovate', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1030, CAST(0x7A400B00 AS Date), 62, N'Conasyd', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1031, CAST(0x7A400B00 AS Date), 63, N'test', 2)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1032, CAST(0x7A400B00 AS Date), 63, N'Eumovate', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1033, CAST(0x7A400B00 AS Date), 63, N'Ansulin', 1)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1034, CAST(0x7B400B00 AS Date), 64, N'Finix', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1035, CAST(0x7B400B00 AS Date), 65, N'Adora', 2)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1036, CAST(0x7B400B00 AS Date), 65, N'Ciprocin', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1037, CAST(0x7C400B00 AS Date), 67, N'Lanso', 10)
INSERT [dbo].[Sales] ([Id], [Date], [SaleId], [MedName], [Quantity]) VALUES (1038, CAST(0x7C400B00 AS Date), 67, N'Alacor DS', 1)
SET IDENTITY_INSERT [dbo].[Sales] OFF
ALTER TABLE [dbo].[Credentials]  WITH CHECK ADD  CONSTRAINT [FK_Credentials_Employees] FOREIGN KEY([UserId])
REFERENCES [dbo].[Employees] ([EmpId])
GO
ALTER TABLE [dbo].[Credentials] CHECK CONSTRAINT [FK_Credentials_Employees]
GO
USE [master]
GO
ALTER DATABASE [MedicalStore] SET  READ_WRITE 
GO
