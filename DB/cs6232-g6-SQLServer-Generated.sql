USE [cs6232-6]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[employees]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[furniture]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[members]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[rental_items]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[rental_transactions]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[return_items]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[return_transactions]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[states]    Script Date: 4/20/2024 5:46:48 PM ******/
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
/****** Object:  Table [dbo].[styles]    Script Date: 4/20/2024 5:46:48 PM ******/
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
