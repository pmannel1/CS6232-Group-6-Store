USE [master]
GO
/****** Object:  Database [cs6232-6]    Script Date: 3/18/2024 5:16:11 PM ******/
CREATE DATABASE [cs6232-6]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-6', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-6.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-6_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-6_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-6] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-6].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-6] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-6] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-6] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-6] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-6] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-6] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-6] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-6] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-6] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-6] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-6] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-6] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-6] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-6] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-6] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cs6232-6] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-6] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-6] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-6] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-6] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-6] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-6] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-6] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-6] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-6] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-6] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-6] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-6] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-6] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-6] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-6', N'ON'
GO
ALTER DATABASE [cs6232-6] SET QUERY_STORE = OFF
GO
USE [cs6232-6]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [nvarchar](255) NOT NULL,
	[firstName] [nvarchar](255) NOT NULL,
	[sex] [nvarchar](50) NOT NULL,
	[dob] [datetime2](7) NOT NULL,
	[street] [nvarchar](255) NOT NULL,
	[city] [nvarchar](255) NOT NULL,
	[state] [nvarchar](255) NOT NULL,
	[zipCode] [nvarchar](255) NOT NULL,
	[country] [nvarchar](255) NOT NULL,
	[contactPhone] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[furniture](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[description] [nvarchar](255) NOT NULL,
	[styleName] [nvarchar](255) NOT NULL,
	[categoryName] [nvarchar](255) NOT NULL,
	[rentalRate] [decimal](10, 2) NOT NULL,
	[instockNumber] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[members]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[members](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [nvarchar](255) NOT NULL,
	[firstName] [nvarchar](255) NOT NULL,
	[sex] [nvarchar](50) NOT NULL,
	[dob] [datetime2](7) NOT NULL,
	[street] [nvarchar](255) NOT NULL,
	[city] [nvarchar](255) NOT NULL,
	[state] [nvarchar](255) NOT NULL,
	[zipCode] [nvarchar](255) NOT NULL,
	[country] [nvarchar](255) NOT NULL,
	[contactPhone] [nvarchar](255) NOT NULL,
	[password] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_items]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[transactionId] [int] NOT NULL,
	[furnitureId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[quantityReturned] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rental_transactions]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rental_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[memberId] [int] NOT NULL,
	[rentalDate] [datetime2](7) NOT NULL,
	[dueDate] [datetime2](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_items]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_items](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[returnId] [int] NOT NULL,
	[rentalItemId] [int] NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[return_transactions]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[return_transactions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NOT NULL,
	[memberId] [int] NOT NULL,
	[returnDate] [datetime2](7) NOT NULL,
	[refund] [decimal](10, 2) NULL,
	[fine] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[states]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[states](
	[stateAbbreviation] [char](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[stateAbbreviation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[styles]    Script Date: 3/18/2024 5:16:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[styles](
	[name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[categories] ([name]) VALUES (N'Bed')
INSERT [dbo].[categories] ([name]) VALUES (N'Chair')
INSERT [dbo].[categories] ([name]) VALUES (N'Sofa')
INSERT [dbo].[categories] ([name]) VALUES (N'Table')
GO
SET IDENTITY_INSERT [dbo].[employees] ON 

INSERT [dbo].[employees] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (1, N'Smith', N'John', N'M', CAST(N'1980-06-15T00:00:00.0000000' AS DateTime2), N'123 Maple St', N'Anytown', N'CA', N'90001', N'USA', N'1235551234', N'pass123')
INSERT [dbo].[employees] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (2, N'Doe', N'Jane', N'F', CAST(N'1985-07-20T00:00:00.0000000' AS DateTime2), N'456 Oak Ave', N'Othertown', N'NY', N'10001', N'USA', N'1235555678', N'pass456')
SET IDENTITY_INSERT [dbo].[employees] OFF
GO
SET IDENTITY_INSERT [dbo].[furniture] ON 

INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (1, N'Sofa 1', N'Comfortable three-seater sofa', N'Modern', N'Sofa', CAST(19.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (2, N'Chair 1', N'Ergonomic office chair', N'Classic', N'Chair', CAST(9.99 AS Decimal(10, 2)), 15)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (3, N'Table 1', N'Sturdy wooden dining table', N'Vintage', N'Table', CAST(29.99 AS Decimal(10, 2)), 5)
SET IDENTITY_INSERT [dbo].[furniture] OFF
GO
SET IDENTITY_INSERT [dbo].[members] ON 

INSERT [dbo].[members] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (1, N'Johnson', N'Bill', N'M', CAST(N'1990-08-30T00:00:00.0000000' AS DateTime2), N'789 Pine Rd', N'Sometown', N'TX', N'75001', N'USA', N'1235559012', N'pw123')
INSERT [dbo].[members] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (2, N'Williams', N'Sara', N'F', CAST(N'1992-09-25T00:00:00.0000000' AS DateTime2), N'321 Birch Blvd', N'Newcity', N'FL', N'32001', N'USA', N'1235553456', N'pw456')
SET IDENTITY_INSERT [dbo].[members] OFF
GO
SET IDENTITY_INSERT [dbo].[rental_items] ON 

INSERT [dbo].[rental_items] ([id], [transactionId], [furnitureId], [quantity], [quantityReturned]) VALUES (1, 1, 1, 2, 0)
INSERT [dbo].[rental_items] ([id], [transactionId], [furnitureId], [quantity], [quantityReturned]) VALUES (2, 2, 2, 1, 0)
SET IDENTITY_INSERT [dbo].[rental_items] OFF
GO
SET IDENTITY_INSERT [dbo].[rental_transactions] ON 

INSERT [dbo].[rental_transactions] ([id], [employeeId], [memberId], [rentalDate], [dueDate]) VALUES (1, 1, 1, CAST(N'2023-01-01T10:00:00.0000000' AS DateTime2), CAST(N'2023-01-15T10:00:00.0000000' AS DateTime2))
INSERT [dbo].[rental_transactions] ([id], [employeeId], [memberId], [rentalDate], [dueDate]) VALUES (2, 2, 2, CAST(N'2023-01-02T11:00:00.0000000' AS DateTime2), CAST(N'2023-01-16T11:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[rental_transactions] OFF
GO
SET IDENTITY_INSERT [dbo].[return_items] ON 

INSERT [dbo].[return_items] ([id], [returnId], [rentalItemId], [quantity]) VALUES (1, 1, 1, 2)
INSERT [dbo].[return_items] ([id], [returnId], [rentalItemId], [quantity]) VALUES (2, 2, 2, 1)
SET IDENTITY_INSERT [dbo].[return_items] OFF
GO
SET IDENTITY_INSERT [dbo].[return_transactions] ON 

INSERT [dbo].[return_transactions] ([id], [employeeId], [memberId], [returnDate], [refund], [fine]) VALUES (1, 1, 1, CAST(N'2023-01-15T11:00:00.0000000' AS DateTime2), CAST(10.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[return_transactions] ([id], [employeeId], [memberId], [returnDate], [refund], [fine]) VALUES (2, 2, 2, CAST(N'2023-01-16T12:00:00.0000000' AS DateTime2), CAST(5.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[return_transactions] OFF
GO
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'AK')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'AL')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'AR')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'AZ')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'CA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'CO')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'CT')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'DE')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'FL')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'GA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'HI')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'IA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'ID')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'IL')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'IN')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'KS')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'KY')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'LA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MD')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'ME')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MI')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MN')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MO')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MS')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'MT')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NC')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'ND')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NE')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NH')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NJ')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NM')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NV')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'NY')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'OH')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'OK')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'OR')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'PA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'RI')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'SC')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'SD')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'TN')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'TX')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'UT')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'VA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'VT')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'WA')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'WI')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'WV')
INSERT [dbo].[states] ([stateAbbreviation]) VALUES (N'WY')
GO
INSERT [dbo].[styles] ([name]) VALUES (N'Classic')
INSERT [dbo].[styles] ([name]) VALUES (N'Modern')
INSERT [dbo].[styles] ([name]) VALUES (N'Vintage')
GO
ALTER TABLE [dbo].[rental_items] ADD  DEFAULT ((0)) FOR [quantityReturned]
GO
ALTER TABLE [dbo].[rental_items]  WITH CHECK ADD FOREIGN KEY([furnitureId])
REFERENCES [dbo].[furniture] ([id])
GO
ALTER TABLE [dbo].[rental_items]  WITH CHECK ADD FOREIGN KEY([transactionId])
REFERENCES [dbo].[rental_transactions] ([id])
GO
ALTER TABLE [dbo].[rental_transactions]  WITH CHECK ADD FOREIGN KEY([employeeId])
REFERENCES [dbo].[employees] ([id])
GO
ALTER TABLE [dbo].[rental_transactions]  WITH CHECK ADD FOREIGN KEY([memberId])
REFERENCES [dbo].[members] ([id])
GO
ALTER TABLE [dbo].[return_items]  WITH CHECK ADD FOREIGN KEY([rentalItemId])
REFERENCES [dbo].[rental_items] ([id])
GO
ALTER TABLE [dbo].[return_items]  WITH CHECK ADD FOREIGN KEY([returnId])
REFERENCES [dbo].[return_transactions] ([id])
GO
ALTER TABLE [dbo].[return_transactions]  WITH CHECK ADD FOREIGN KEY([employeeId])
REFERENCES [dbo].[employees] ([id])
GO
ALTER TABLE [dbo].[return_transactions]  WITH CHECK ADD FOREIGN KEY([memberId])
REFERENCES [dbo].[members] ([id])
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD CHECK  (([sex]='Other' OR [sex]='F' OR [sex]='M'))
GO
ALTER TABLE [dbo].[members]  WITH CHECK ADD CHECK  (([sex]='Other' OR [sex]='F' OR [sex]='M'))
GO
USE [master]
GO
ALTER DATABASE [cs6232-6] SET  READ_WRITE 
GO
