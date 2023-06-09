USE [Knitwears]
GO
/****** Object:  Table [dbo].[Knitwears_Main]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Main](
	[Knitwears_Main_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Stock_id] [int] NULL,
	[Knitwears_Plan_id] [int] NULL,
	[Knitwears_Order_id] [int] NULL,
	[Knitwears_Product_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Main_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Order]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Order](
	[Knitwears_Order_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Order_Name] [nvarchar](50) NULL,
	[Knitwears_Order_Vendor_Code] [nvarchar](50) NULL,
	[Knitwears_Order_Weight] [nvarchar](50) NULL,
	[Knitwears_Order_Number_Boxes] [nvarchar](50) NULL,
	[Knitwears_Order_Date] [nvarchar](50) NULL,
	[Knitwears_Order_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Plan_Day]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Plan_Day](
	[Knitwears_Plan_Day_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Plan_Day_Nomenclature] [nvarchar](50) NULL,
	[Knitwears_Plan_Day_Date] [nvarchar](50) NULL,
	[Knitwears_Plan_Day_Volume] [nvarchar](50) NULL,
	[Knitwears_Plan_Day_Note] [nvarchar](50) NULL,
	[Knitwears_Plan_Day_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Plan_Day_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Plan_General]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Plan_General](
	[Knitwears_Plan_General_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Plan_General_Nomenclature] [nvarchar](50) NULL,
	[Knitwears_Plan_General_Date] [nvarchar](50) NULL,
	[Knitwears_Plan_General_Volume] [nvarchar](50) NULL,
	[Knitwears_Plan_General_Note] [nvarchar](50) NULL,
	[Knitwears_Plan_General_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Plan_General_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Plan_Main]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Plan_Main](
	[Knitwears_Plan_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Plan_Day_id] [int] NULL,
	[Knitwears_Plan_Week_id] [int] NULL,
	[Knitwears_Plan_Month_id] [int] NULL,
	[Knitwears_Plan_General_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Plan_Month]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Plan_Month](
	[Knitwears_Plan_Month_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Plan_Month_Nomenclature] [nvarchar](50) NULL,
	[Knitwears_Plan_Month_Date] [nvarchar](50) NULL,
	[Knitwears_Plan_Month_Volume] [nvarchar](50) NULL,
	[Knitwears_Plan_Month_Note] [nvarchar](50) NULL,
	[Knitwears_Plan_Month_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Plan_Month_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Plan_Week]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Plan_Week](
	[Knitwears_Plan_Week_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Plan_Week_Nomenclature] [nvarchar](50) NULL,
	[Knitwears_Plan_Week_Date] [nvarchar](50) NULL,
	[Knitwears_Plan_Week_Volume] [nvarchar](50) NULL,
	[Knitwears_Plan_Week_Note] [nvarchar](50) NULL,
	[Knitwears_Plan_Week_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Plan_Week_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Product]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Product](
	[Knitwears_Product_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Product_Name] [nvarchar](50) NULL,
	[Knitwears_Product_Weight] [nvarchar](50) NULL,
	[Knitwears_Product_Sample] [nvarchar](50) NULL,
	[Knitwears_Product_Description] [nvarchar](50) NULL,
	[Knitwears_Product_Date] [nvarchar](50) NULL,
	[Knitwears_Product_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_Stock]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_Stock](
	[Knitwears_Stock_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_Stock_Name] [nvarchar](50) NULL,
	[Knitwears_Stock_Feature] [nvarchar](50) NULL,
	[Knitwears_Stock_Weight] [nvarchar](50) NULL,
	[Knitwears_Stock_Image] [varbinary](max) NULL,
	[Knitwears_Stock_Date] [nvarchar](50) NULL,
	[Knitwears_Stock_Status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_Stock_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knitwears_User]    Script Date: Пн 29.05.23 15:46:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knitwears_User](
	[Knitwears_User_id] [int] IDENTITY(1,1) NOT NULL,
	[Knitwears_User_Login] [nvarchar](50) NULL,
	[Knitwears_User_Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Knitwears_User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Knitwears_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Main_Knitwears_Order] FOREIGN KEY([Knitwears_Order_id])
REFERENCES [dbo].[Knitwears_Order] ([Knitwears_Order_id])
GO
ALTER TABLE [dbo].[Knitwears_Main] CHECK CONSTRAINT [FK_Knitwears_Main_Knitwears_Order]
GO
ALTER TABLE [dbo].[Knitwears_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Main_Knitwears_Plan_Main] FOREIGN KEY([Knitwears_Plan_id])
REFERENCES [dbo].[Knitwears_Plan_Main] ([Knitwears_Plan_id])
GO
ALTER TABLE [dbo].[Knitwears_Main] CHECK CONSTRAINT [FK_Knitwears_Main_Knitwears_Plan_Main]
GO
ALTER TABLE [dbo].[Knitwears_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Main_Knitwears_Product] FOREIGN KEY([Knitwears_Product_id])
REFERENCES [dbo].[Knitwears_Product] ([Knitwears_Product_id])
GO
ALTER TABLE [dbo].[Knitwears_Main] CHECK CONSTRAINT [FK_Knitwears_Main_Knitwears_Product]
GO
ALTER TABLE [dbo].[Knitwears_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Main_Knitwears_Stock] FOREIGN KEY([Knitwears_Stock_id])
REFERENCES [dbo].[Knitwears_Stock] ([Knitwears_Stock_id])
GO
ALTER TABLE [dbo].[Knitwears_Main] CHECK CONSTRAINT [FK_Knitwears_Main_Knitwears_Stock]
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Day] FOREIGN KEY([Knitwears_Plan_Day_id])
REFERENCES [dbo].[Knitwears_Plan_Day] ([Knitwears_Plan_Day_id])
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main] CHECK CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Day]
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_General] FOREIGN KEY([Knitwears_Plan_General_id])
REFERENCES [dbo].[Knitwears_Plan_General] ([Knitwears_Plan_General_id])
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main] CHECK CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_General]
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Month] FOREIGN KEY([Knitwears_Plan_Month_id])
REFERENCES [dbo].[Knitwears_Plan_Month] ([Knitwears_Plan_Month_id])
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main] CHECK CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Month]
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main]  WITH CHECK ADD  CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Week] FOREIGN KEY([Knitwears_Plan_Week_id])
REFERENCES [dbo].[Knitwears_Plan_Week] ([Knitwears_Plan_Week_id])
GO
ALTER TABLE [dbo].[Knitwears_Plan_Main] CHECK CONSTRAINT [FK_Knitwears_Plan_Main_Knitwears_Plan_Week]
GO
