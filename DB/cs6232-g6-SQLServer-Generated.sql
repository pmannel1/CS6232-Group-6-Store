USE [master]
GO
/****** Object:  Database [cs6232-6]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[categories]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[employees]    Script Date: 4/19/2024 5:37:38 PM ******/
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
	[isAdmin] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[members]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[rental_items]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[rental_transactions]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[return_items]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[return_transactions]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[states]    Script Date: 4/19/2024 5:37:38 PM ******/
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
/****** Object:  Table [dbo].[styles]    Script Date: 4/19/2024 5:37:38 PM ******/
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
ALTER TABLE [dbo].[employees] ADD  DEFAULT ((0)) FOR [isAdmin]
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
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/19/2024 5:37:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getMostPopularFurnitureDuringDates]
    @startDate DATE,
    @endDate DATE
AS
BEGIN
    -- Validate input parameters
    IF @startDate IS NULL OR @endDate IS NULL OR @startDate >= @endDate
    BEGIN
        RAISERROR ('Invalid input parameters: Start date should be before end date.', 16, 1);
        RETURN;
    END

    -- Get the most popular furniture during the specified period of time
    SELECT 
        f.id,
        f.categoryName,
        f.description,
        COUNT(rt.id) AS totalRentalTransactions,
        (SELECT COUNT(*) FROM rental_transactions WHERE rentalDate BETWEEN @startDate AND @endDate) AS totalAllRentalTransactions,
        (COUNT(rt.id) * 100.0 / (SELECT COUNT(*) FROM rental_transactions WHERE rentalDate BETWEEN @startDate AND @endDate)) AS percentageOfTotal,
        (SUM(CASE WHEN m.dob BETWEEN DATEADD(YEAR, -29, rt.rentalDate) AND DATEADD(YEAR, -18, rt.rentalDate) THEN 1 ELSE 0 END) * 100.0 / COUNT(rt.id)) AS percentage18To29,
        ((COUNT(rt.id) - SUM(CASE WHEN m.dob BETWEEN DATEADD(YEAR, -29, rt.rentalDate) AND DATEADD(YEAR, -18, rt.rentalDate) THEN 1 ELSE 0 END)) * 100.0 / COUNT(rt.id)) AS percentageOutside18To29
    FROM
        rental_items ri
    INNER JOIN
        rental_transactions rt ON ri.transactionId = rt.id
    INNER JOIN
        furniture f ON ri.furnitureId = f.id
    INNER JOIN
        members m ON rt.memberID = m.id
    WHERE
        rt.rentalDate BETWEEN @startDate AND @endDate
    GROUP BY
        ri.furnitureID, f.id, f.categoryName, f.description
    HAVING
        COUNT(rt.id) >= 2
    ORDER BY
        totalRentalTransactions DESC, ri.furnitureID DESC;
END
GO
USE [master]
GO
ALTER DATABASE [cs6232-6] SET  READ_WRITE 
GO
