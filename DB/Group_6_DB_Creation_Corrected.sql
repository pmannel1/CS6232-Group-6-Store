USE [master]
GO
/****** Object:  Database [cs6232-6]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[categories]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[employees]    Script Date: 4/22/2024 9:54:54 AM ******/
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
	[isAdmin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[furniture]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[members]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[rental_items]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[rental_transactions]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[return_items]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[return_transactions]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[states]    Script Date: 4/22/2024 9:54:54 AM ******/
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
/****** Object:  Table [dbo].[styles]    Script Date: 4/22/2024 9:54:54 AM ******/
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

INSERT [dbo].[employees] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password], [isAdmin]) VALUES (1, N'Smith', N'John', N'M', CAST(N'1980-06-15T00:00:00.0000000' AS DateTime2), N'123 Maple St', N'Anytown', N'CA', N'90001', N'USA', N'1235551234', N'pass123', 1)
INSERT [dbo].[employees] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password], [isAdmin]) VALUES (2, N'Doe', N'Jane', N'F', CAST(N'1985-07-20T00:00:00.0000000' AS DateTime2), N'456 Oak Ave', N'Othertown', N'NY', N'10001', N'USA', N'1235555678', N'pass456', 0)
SET IDENTITY_INSERT [dbo].[employees] OFF
GO
SET IDENTITY_INSERT [dbo].[furniture] ON 

INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (1, N'Sofa 1', N'Comfortable three-seater sofa', N'Modern', N'Sofa', CAST(19.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (2, N'Chair 1', N'Ergonomic office chair', N'Classic', N'Chair', CAST(9.99 AS Decimal(10, 2)), 15)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (3, N'Table 1', N'Sturdy wooden dining table', N'Vintage', N'Table', CAST(29.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (4, N'Bed Frame', N'Queen-sized bed frame with headboard', N'Contemporary', N'Bed', CAST(39.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (5, N'Bookshelf', N'Tall bookshelf with adjustable shelves', N'Modern', N'Bookshelf', CAST(14.99 AS Decimal(10, 2)), 12)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (6, N'Desk', N'Minimalist writing desk with drawer', N'Scandinavian', N'Desk', CAST(24.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (7, N'Armchair', N'Plush armchair with rolled arms', N'Classic', N'Chair', CAST(12.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (8, N'Coffee Table', N'Glass-top coffee table with metal legs', N'Contemporary', N'Table', CAST(17.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (9, N'Dresser', N'Six-drawer dresser with silver handles', N'Modern', N'Storage', CAST(29.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (10, N'Couch', N'L-shaped sectional couch with chaise', N'Transitional', N'Sofa', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (11, N'Nightstand', N'Bedside nightstand with two drawers', N'Traditional', N'Table', CAST(9.99 AS Decimal(10, 2)), 9)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (12, N'Ottoman', N'Square fabric ottoman with storage', N'Mid-century Modern', N'Chair', CAST(7.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (13, N'Wardrobe', N'Tall wardrobe closet with mirrored doors', N'Classic', N'Storage', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (14, N'Side Table', N'Round wooden side table with tripod base', N'Rustic', N'Table', CAST(11.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (15, N'Rocking Chair', N'Wooden rocking chair with upholstered seat', N'Vintage', N'Chair', CAST(15.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (16, N'Bunk Bed', N'Twin-over-twin bunk bed with built-in ladder', N'Modern', N'Bed', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (17, N'Futon', N'Convertible futon sofa bed with tufted upholstery', N'Contemporary', N'Sofa', CAST(29.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (18, N'Chaise Lounge', N'Velvet chaise lounge with tufted back', N'Glam', N'Chair', CAST(21.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (19, N'Console Table', N'Narrow console table with two drawers', N'Industrial', N'Table', CAST(16.99 AS Decimal(10, 2)), 9)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (20, N'Sectional Sofa', N'Modular sectional sofa with reversible chaise', N'Modern', N'Sofa', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (21, N'Bar Stool', N'Adjustable bar stool with faux leather seat', N'Mid-century Modern', N'Chair', CAST(13.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (22, N'Vanity', N'White vanity table with mirror and stool', N'Traditional', N'Table', CAST(28.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (23, N'Accent Chair', N'Patterned accent chair with tapered legs', N'Eclectic', N'Chair', CAST(18.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (24, N'Dining Set', N'Extendable dining table with four chairs', N'Farmhouse', N'Set', CAST(49.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (25, N'Storage Bench', N'Upholstered storage bench with button tufting', N'Transitional', N'Storage', CAST(19.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (26, N'End Table', N'Square end table with open shelf', N'Modern', N'Table', CAST(12.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (27, N'Recliner', N'Leather recliner chair with overstuffed arms', N'Classic', N'Chair', CAST(23.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (28, N'Computer Desk', N'L-shaped computer desk with hutch', N'Contemporary', N'Desk', CAST(34.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (29, N'Sleigh Bed', N'Cherry wood sleigh bed frame', N'Traditional', N'Bed', CAST(42.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (30, N'Bar Table', N'Round bar table with chrome base', N'Modern', N'Table', CAST(21.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (31, N'Bean Bag Chair', N'Giant bean bag chair in faux fur', N'Bohemian', N'Chair', CAST(9.99 AS Decimal(10, 2)), 12)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (32, N'Cabinet', N'Tall storage cabinet with glass doors', N'Industrial', N'Storage', CAST(32.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (33, N'Gaming Chair', N'Racing-style gaming chair with lumbar support', N'Modern', N'Chair', CAST(24.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (34, N'Kitchen Island', N'Butcher block kitchen island with storage', N'Farmhouse', N'Table', CAST(37.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (35, N'Chesterfield Sofa', N'Tufted velvet Chesterfield sofa', N'Glam', N'Sofa', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (36, N'Pouf', N'Knit pouf ottoman in geometric pattern', N'Scandinavian', N'Chair', CAST(10.99 AS Decimal(10, 2)), 9)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (37, N'Buffet Table', N'Wooden buffet table with wine rack', N'Traditional', N'Table', CAST(26.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (38, N'Daybed', N'Metal-framed daybed with trundle', N'Mid-century Modern', N'Bed', CAST(36.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (39, N'Folding Chair', N'Plastic folding chair for indoor/outdoor use', N'Modern', N'Chair', CAST(6.99 AS Decimal(10, 2)), 15)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (40, N'Trunk', N'Vintage-style trunk with leather straps', N'Rustic', N'Storage', CAST(18.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (41, N'Glider Chair', N'Nursery glider chair with ottoman', N'Classic', N'Chair', CAST(29.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (42, N'Corner Desk', N'L-shaped corner desk with storage shelves', N'Contemporary', N'Desk', CAST(27.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (43, N'Murphy Bed', N'Vertical wall bed with built-in shelves', N'Modern', N'Bed', CAST(49.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (44, N'Outdoor Table', N'Round outdoor dining table with umbrella hole', N'Traditional', N'Table', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (45, N'Sofa Bed', N'Convertible sofa bed with linen upholstery', N'Transitional', N'Sofa', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (46, N'Accent Cabinet', N'Mirrored accent cabinet with quatrefoil design', N'Glam', N'Storage', CAST(31.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (47, N'Garden Bench', N'Wooden garden bench with lattice back', N'Rustic', N'Chair', CAST(22.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (48, N'Drafting Table', N'Adjustable drafting table with tilting surface', N'Industrial', N'Desk', CAST(34.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (49, N'Counter Stool', N'Counter-height stool with metal frame', N'Modern', N'Chair', CAST(16.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (50, N'Gaming Desk', N'Gaming desk with carbon fiber texture surface', N'Contemporary', N'Desk', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (51, N'Platform Bed', N'Platform bed frame with upholstered headboard', N'Mid-century Modern', N'Bed', CAST(45.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (52, N'Outdoor Sofa', N'Outdoor sectional sofa with weather-resistant cushions', N'Modern', N'Sofa', CAST(49.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (53, N'Accent Table', N'Round accent table with metal base', N'Modern', N'Table', CAST(14.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (54, N'Lounge Chair', N'Leather lounge chair with chrome legs', N'Contemporary', N'Chair', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (55, N'Entryway Bench', N'Wooden entryway bench with shoe storage', N'Farmhouse', N'Chair', CAST(19.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (56, N'Console Cabinet', N'Narrow console cabinet with glass doors', N'Traditional', N'Storage', CAST(24.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (57, N'Writing Desk', N'Mid-century modern writing desk with tapered legs', N'Mid-century Modern', N'Desk', CAST(34.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (58, N'Canopy Bed', N'Queen-sized canopy bed frame with metal accents', N'Transitional', N'Bed', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (59, N'Counter Table', N'Square counter-height dining table with storage base', N'Rustic', N'Table', CAST(39.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (60, N'Lamp Table', N'Wooden lamp table with built-in USB ports', N'Modern', N'Table', CAST(16.99 AS Decimal(10, 2)), 9)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (61, N'Patio Chair', N'Stackable patio chair with weather-resistant wicker', N'Outdoor', N'Chair', CAST(12.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (62, N'Corner Cabinet', N'Corner storage cabinet with decorative molding', N'Traditional', N'Storage', CAST(29.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (63, N'Standing Desk', N'Electric standing desk with programmable height settings', N'Modern', N'Desk', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (64, N'Caned Chair', N'Cane-back dining chair with upholstered seat', N'French Country', N'Chair', CAST(24.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (65, N'Gaming Console Table', N'Gaming console table with storage shelves', N'Contemporary', N'Table', CAST(19.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (66, N'Upholstered Bench', N'Upholstered bench with button tufting', N'Glam', N'Chair', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (67, N'Nesting Tables', N'Set of three nesting tables in varying sizes', N'Modern', N'Table', CAST(24.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (68, N'Wine Cabinet', N'Tall wine cabinet with stemware racks', N'Farmhouse', N'Storage', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (69, N'Secretary Desk', N'Secretary desk with drop-down writing surface', N'Traditional', N'Desk', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (70, N'Chippendale Chair', N'Chippendale-style dining chair with carved details', N'Classic', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (71, N'Bar Cabinet', N'Mirrored bar cabinet with wine storage', N'Glam', N'Storage', CAST(49.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (72, N'Round Dining Table', N'Round pedestal dining table with distressed finish', N'Rustic', N'Table', CAST(59.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (73, N'Gaming Ottoman', N'Gaming ottoman with built-in storage compartments', N'Modern', N'Chair', CAST(19.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (74, N'Drop Leaf Table', N'Drop leaf dining table with turned legs', N'Traditional', N'Table', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (75, N'Egg Chair', N'Hanging egg chair with cushion and stand', N'Bohemian', N'Chair', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (76, N'Storage Armoire', N'Tall storage armoire with adjustable shelves', N'Transitional', N'Storage', CAST(54.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (77, N'Drafting Stool', N'Adjustable drafting stool with footrest', N'Industrial', N'Chair', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (78, N'Dining Bench', N'Wooden dining bench with slatted seat', N'Farmhouse', N'Chair', CAST(24.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (79, N'Pallet Coffee Table', N'Coffee table made from repurposed pallet wood', N'Rustic', N'Table', CAST(29.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (80, N'Bar Cart', N'Gold-toned bar cart with glass shelves', N'Glam', N'Storage', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (81, N'Swivel Chair', N'Swivel accent chair with barrel back design', N'Modern', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (82, N'Bistro Table', N'Metal bistro table with mosaic tile top', N'Vintage', N'Table', CAST(24.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (83, N'Chifforobe', N'Combination of a wardrobe and chest of drawers', N'Transitional', N'Storage', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (84, N'Stacking Chair', N'Stackable plastic chair with metal frame', N'Modern', N'Chair', CAST(9.99 AS Decimal(10, 2)), 15)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (85, N'Pedestal Table', N'Round pedestal accent table with distressed finish', N'Farmhouse', N'Table', CAST(19.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (86, N'Glider Bench', N'Outdoor glider bench with weather-resistant cushions', N'Outdoor', N'Chair', CAST(49.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (87, N'Secretary Bookcase', N'Secretary desk with attached bookcase', N'Traditional', N'Desk', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (88, N'Highboy Dresser', N'Tall dresser with multiple drawers and cabinets', N'Classic', N'Storage', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (89, N'Parsons Table', N'Rectangular parsons table with clean lines', N'Modern', N'Table', CAST(29.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (90, N'Cuddle Chair', N'Oversized cuddle chair with swivel base', N'Transitional', N'Chair', CAST(44.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (91, N'Bench Seat', N'Wooden bench seat with storage underneath', N'Rustic', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (92, N'Plant Stand', N'Metal plant stand with three tiers', N'Modern', N'Table', CAST(14.99 AS Decimal(10, 2)), 9)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (93, N'Closet Organizer', N'Closet organizer system with shelves and drawers', N'Contemporary', N'Storage', CAST(49.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (94, N'Vanity Stool', N'Upholstered vanity stool with decorative legs', N'Glam', N'Chair', CAST(19.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (95, N'Drop-leaf Console Table', N'Console table with drop-leaf sides', N'Traditional', N'Table', CAST(34.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (96, N'Cedar Chest', N'Cedar-lined chest for storing blankets and linens', N'Classic', N'Storage', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (97, N'Executive Desk', N'Large executive desk with built-in file drawers', N'Modern', N'Desk', CAST(64.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (98, N'Adirondack Chair', N'Classic Adirondack chair with wide armrests', N'Rustic', N'Chair', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (99, N'Credenza', N'Long, low cabinet for storing dishes or serving food', N'Mid-century Modern', N'Storage', CAST(54.99 AS Decimal(10, 2)), 3)
GO
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (100, N'Game Table', N'Multi-purpose game table with reversible top', N'Traditional', N'Table', CAST(44.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (101, N'Hammock Chair', N'Indoor/outdoor hammock chair with fringe trim', N'Bohemian', N'Chair', CAST(29.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (102, N'Console Desk', N'Console table with built-in desk functionality', N'Modern', N'Desk', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (103, N'Dining Hutch', N'Wooden dining hutch with glass-fronted cabinets', N'Farmhouse', N'Storage', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (104, N'Nailhead Trim Sofa', N'Sofa with nailhead trim and rolled arms', N'Traditional', N'Sofa', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (105, N'Rustic Dining Table', N'Rectangular dining table with distressed finish', N'Rustic', N'Table', CAST(59.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (106, N'Mid-century Armchair', N'Mid-century style armchair with tapered legs', N'Mid-century Modern', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (107, N'Secretary Bookcase', N'Secretary desk with attached bookcase', N'Traditional', N'Desk', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (108, N'Rattan Chair', N'Rattan accent chair with cushion', N'Bohemian', N'Chair', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (109, N'Platform Storage Bed', N'Platform bed frame with under-bed storage drawers', N'Modern', N'Bed', CAST(64.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (110, N'Industrial Coffee Table', N'Industrial-style coffee table with metal accents', N'Industrial', N'Table', CAST(44.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (111, N'Chippendale Sofa', N'Chippendale-style sofa with carved wood frame', N'Classic', N'Sofa', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (112, N'Shoe Bench', N'Wooden shoe bench with storage compartments', N'Farmhouse', N'Chair', CAST(29.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (113, N'Cottage-style End Table', N'Round end table with cottage-style design', N'Cottage', N'Table', CAST(34.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (114, N'Laptop Desk', N'Compact desk designed for laptop use', N'Modern', N'Desk', CAST(24.99 AS Decimal(10, 2)), 7)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (115, N'Ladder Shelf', N'Wooden ladder shelf with five tiers', N'Farmhouse', N'Storage', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (116, N'Wingback Chair', N'Upholstered wingback chair with button tufting', N'Traditional', N'Chair', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (117, N'Pedestal Dining Table', N'Round pedestal dining table with glossy finish', N'Classic', N'Table', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (118, N'Adjustable Standing Desk', N'Standing desk with adjustable height settings', N'Modern', N'Desk', CAST(54.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (119, N'Cane Back Dining Chair', N'Dining chair with cane backrest and upholstered seat', N'French Country', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (120, N'Convertible Sofa', N'Sofa that converts into a bed', N'Modern', N'Sofa', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (121, N'Counter Height Dining Table', N'Square counter height dining table with storage base', N'Modern', N'Table', CAST(59.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (122, N'Retro Armchair', N'Retro-style armchair with colorful upholstery', N'Mid-century Modern', N'Chair', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (123, N'Foldable Desk', N'Desk that can be folded for easy storage', N'Modern', N'Desk', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (124, N'Cottage-style Dresser', N'Wooden dresser with cottage-style design', N'Cottage', N'Storage', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (125, N'Wicker Loveseat', N'Wicker loveseat with cushions for outdoor use', N'Outdoor', N'Sofa', CAST(49.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (126, N'Farmhouse Dining Bench', N'Wooden dining bench with farmhouse-style design', N'Farmhouse', N'Chair', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (127, N'Trestle Dining Table', N'Rectangular trestle dining table with plank-style top', N'Rustic', N'Table', CAST(64.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (128, N'Mid-century Sideboard', N'Mid-century modern sideboard with tapered legs', N'Mid-century Modern', N'Storage', CAST(59.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (129, N'Folding Table', N'Portable folding table for indoor or outdoor use', N'Modern', N'Table', CAST(19.99 AS Decimal(10, 2)), 8)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (130, N'Rustic Bar Stool', N'Wooden bar stool with rustic finish', N'Rustic', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (131, N'Storage Ottoman Bench', N'Upholstered ottoman bench with hidden storage', N'Transitional', N'Chair', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (132, N'Round Pedestal End Table', N'Round end table with pedestal base', N'Traditional', N'Table', CAST(29.99 AS Decimal(10, 2)), 6)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (133, N'Linen Chaise Lounge', N'Linen chaise lounge with rolled arms and button tufting', N'Traditional', N'Chair', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (134, N'Corner Bookcase', N'Corner bookcase with multiple shelves', N'Modern', N'Storage', CAST(39.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (135, N'L-shaped Sectional Sofa', N'L-shaped sectional sofa with chaise', N'Modern', N'Sofa', CAST(69.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (136, N'Industrial Bar Table', N'Industrial-style bar table with metal base', N'Industrial', N'Table', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (137, N'Wall-mounted Desk', N'Desk that can be mounted on the wall', N'Modern', N'Desk', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (138, N'Mid-century Dresser', N'Mid-century modern dresser with tapered legs', N'Mid-century Modern', N'Storage', CAST(64.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (139, N'Outdoor Lounge Chair', N'Outdoor lounge chair with weather-resistant cushions', N'Outdoor', N'Chair', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (140, N'Farmhouse Console Table', N'Wooden console table with farmhouse-style design', N'Farmhouse', N'Table', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (141, N'Tub Chair', N'Upholstered tub chair with curved back and armrests', N'Modern', N'Chair', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (142, N'Floating Desk', N'Wall-mounted floating desk with storage compartments', N'Modern', N'Desk', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (143, N'Farmhouse Side Table', N'Wooden side table with farmhouse-style design', N'Farmhouse', N'Table', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (144, N'Mid-century Nightstand', N'Mid-century modern nightstand with tapered legs', N'Mid-century Modern', N'Table', CAST(39.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (145, N'Storage Daybed', N'Daybed with built-in storage drawers', N'Transitional', N'Bed', CAST(59.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (146, N'Industrial Desk Chair', N'Industrial-style desk chair with metal frame', N'Industrial', N'Chair', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (147, N'Rolling Kitchen Cart', N'Kitchen cart on wheels with storage shelves', N'Modern', N'Table', CAST(49.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (148, N'Farmhouse Bench', N'Wooden bench with farmhouse-style design', N'Farmhouse', N'Chair', CAST(44.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (149, N'Mid-century Bar Cabinet', N'Mid-century modern bar cabinet with tapered legs', N'Mid-century Modern', N'Storage', CAST(69.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (150, N'Folding Lounge Chair', N'Foldable lounge chair for outdoor use', N'Outdoor', N'Chair', CAST(34.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (151, N'Drop-leaf Dining Table', N'Rectangular dining table with drop-leaf sides', N'Traditional', N'Table', CAST(64.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (152, N'Modern File Cabinet', N'Modern file cabinet with locking drawers', N'Modern', N'Storage', CAST(54.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[furniture] ([id], [name], [description], [styleName], [categoryName], [rentalRate], [instockNumber]) VALUES (153, N'Swivel Bar Stool', N'Swivel bar stool with upholstered seat', N'Modern', N'Chair', CAST(39.99 AS Decimal(10, 2)), 3)
SET IDENTITY_INSERT [dbo].[furniture] OFF
GO
SET IDENTITY_INSERT [dbo].[members] ON 

INSERT [dbo].[members] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (1, N'Johnson', N'Bill', N'M', CAST(N'1990-08-30T00:00:00.0000000' AS DateTime2), N'789 Pine Rd', N'Sometown', N'TX', N'75001', N'USA', N'1235559012', N'pw123')
INSERT [dbo].[members] ([id], [lastName], [firstName], [sex], [dob], [street], [city], [state], [zipCode], [country], [contactPhone], [password]) VALUES (2, N'Williams', N'Sara', N'F', CAST(N'1992-09-25T00:00:00.0000000' AS DateTime2), N'321 Birch Blvd', N'Newcity', N'FL', N'32001', N'USA', N'1235553456', N'pw456')
SET IDENTITY_INSERT [dbo].[members] OFF
GO
SET IDENTITY_INSERT [dbo].[rental_items] ON 

INSERT [dbo].[rental_items] ([id], [transactionId], [furnitureId], [quantity], [quantityReturned]) VALUES (1, 1, 1, 2, 2)
INSERT [dbo].[rental_items] ([id], [transactionId], [furnitureId], [quantity], [quantityReturned]) VALUES (2, 2, 2, 1, 0)
INSERT [dbo].[rental_items] ([id], [transactionId], [furnitureId], [quantity], [quantityReturned]) VALUES (3, 3, 1, 4, 0)
SET IDENTITY_INSERT [dbo].[rental_items] OFF
GO
SET IDENTITY_INSERT [dbo].[rental_transactions] ON 

INSERT [dbo].[rental_transactions] ([id], [employeeId], [memberId], [rentalDate], [dueDate]) VALUES (1, 1, 1, CAST(N'2023-01-01T10:00:00.0000000' AS DateTime2), CAST(N'2023-01-15T10:00:00.0000000' AS DateTime2))
INSERT [dbo].[rental_transactions] ([id], [employeeId], [memberId], [rentalDate], [dueDate]) VALUES (2, 2, 2, CAST(N'2023-01-02T11:00:00.0000000' AS DateTime2), CAST(N'2023-01-16T11:00:00.0000000' AS DateTime2))
INSERT [dbo].[rental_transactions] ([id], [employeeId], [memberId], [rentalDate], [dueDate]) VALUES (3, 1, 1, CAST(N'2024-04-21T18:06:35.0319697' AS DateTime2), CAST(N'2024-04-30T18:06:23.4770000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[rental_transactions] OFF
GO
SET IDENTITY_INSERT [dbo].[return_items] ON 

INSERT [dbo].[return_items] ([id], [returnId], [rentalItemId], [quantity]) VALUES (1, 1, 1, 2)
INSERT [dbo].[return_items] ([id], [returnId], [rentalItemId], [quantity]) VALUES (2, 2, 2, 1)
INSERT [dbo].[return_items] ([id], [returnId], [rentalItemId], [quantity]) VALUES (3, 3, 1, 2)
SET IDENTITY_INSERT [dbo].[return_items] OFF
GO
SET IDENTITY_INSERT [dbo].[return_transactions] ON 

INSERT [dbo].[return_transactions] ([id], [employeeId], [memberId], [returnDate], [refund], [fine]) VALUES (1, 1, 1, CAST(N'2023-01-15T11:00:00.0000000' AS DateTime2), CAST(10.00 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[return_transactions] ([id], [employeeId], [memberId], [returnDate], [refund], [fine]) VALUES (2, 2, 2, CAST(N'2023-01-16T12:00:00.0000000' AS DateTime2), CAST(5.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)))
INSERT [dbo].[return_transactions] ([id], [employeeId], [memberId], [returnDate], [refund], [fine]) VALUES (3, 1, 1, CAST(N'2024-04-21T18:07:35.7700000' AS DateTime2), CAST(0.00 AS Decimal(10, 2)), CAST(18510.74 AS Decimal(10, 2)))
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
/****** Object:  StoredProcedure [dbo].[getMostPopularFurnitureDuringDates]    Script Date: 4/22/2024 9:54:54 AM ******/
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
