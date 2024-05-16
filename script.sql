USE [MusicShop]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[ID_Employee] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[Post] [nvarchar](max) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID_Employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[ID_Item] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [nvarchar](max) NOT NULL,
	[ItemType] [nvarchar](max) NOT NULL,
	[Photo] [nvarchar](max) NULL,
	[Cost] [nvarchar](max) NOT NULL,
	[Count] [int] NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[ID_Item] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID_Order] [int] IDENTITY(1,1) NOT NULL,
	[Item] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Client] [int] NOT NULL,
	[Employee] [int] NULL,
	[Status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID_Order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[ID_Provider] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[ID_Provider] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipment]    Script Date: 16.05.2024 18:19:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment](
	[ID_Shipment] [int] IDENTITY(1,1) NOT NULL,
	[Provider] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[Count] [int] NOT NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_Shipment] PRIMARY KEY CLUSTERED 
(
	[ID_Shipment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID_Client], [Surname], [Name], [LastName], [Email], [Password]) VALUES (1, N'1', N'1', N'1', N'1@mail.ru', N'1')
INSERT [dbo].[Client] ([ID_Client], [Surname], [Name], [LastName], [Email], [Password]) VALUES (2, N'2', N'2', N'2', N'2@mail.ru', N'2')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([ID_Employee], [Surname], [Name], [LastName], [Post], [Login], [Password]) VALUES (1, N'2', N'2', N'2', N'Администратор', N'2', N'2')
INSERT [dbo].[Employee] ([ID_Employee], [Surname], [Name], [LastName], [Post], [Login], [Password]) VALUES (4, N'1', N'1', N'1', N'Менеджер', N'1', N'1')
INSERT [dbo].[Employee] ([ID_Employee], [Surname], [Name], [LastName], [Post], [Login], [Password]) VALUES (5, N'1', N'1', N'1', N'Консультант', N'3', N'3')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([ID_Item], [ItemName], [ItemType], [Photo], [Cost], [Count]) VALUES (1, N'test1', N'test1', N'guitar.png', N'1', 0)
INSERT [dbo].[Item] ([ID_Item], [ItemName], [ItemType], [Photo], [Cost], [Count]) VALUES (2, N'test2', N'test2', N'2', N'2', 100)
INSERT [dbo].[Item] ([ID_Item], [ItemName], [ItemType], [Photo], [Cost], [Count]) VALUES (3, N'test3', N'test3', N'3', N'3', 62)
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([ID_Order], [Item], [Count], [Client], [Employee], [Status]) VALUES (1, 1, 25, 1, 1, N'Не оплачен')
INSERT [dbo].[Order] ([ID_Order], [Item], [Count], [Client], [Employee], [Status]) VALUES (2, 1, 14, 1, 1, N'Не оплачен')
INSERT [dbo].[Order] ([ID_Order], [Item], [Count], [Client], [Employee], [Status]) VALUES (3, 3, 2, 1, 1, N'Оплачен')
INSERT [dbo].[Order] ([ID_Order], [Item], [Count], [Client], [Employee], [Status]) VALUES (1002, 3, 8, 1, NULL, N'Оплачен')
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([ID_Provider], [ProviderName]) VALUES (1, N'Provider1')
INSERT [dbo].[Provider] ([ID_Provider], [ProviderName]) VALUES (2, N'Provider2')
INSERT [dbo].[Provider] ([ID_Provider], [ProviderName]) VALUES (3, N'Provider3')
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Shipment] ON 

INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (1, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (2, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (3, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (4, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (5, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (6, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (7, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (8, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (9, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (10, 1, 1, 1, N'Заявка')
INSERT [dbo].[Shipment] ([ID_Shipment], [Provider], [Item], [Count], [Status]) VALUES (11, 1, 1, 1, N'Заявка')
SET IDENTITY_INSERT [dbo].[Shipment] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Client] FOREIGN KEY([Client])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Client]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([Employee])
REFERENCES [dbo].[Employee] ([ID_Employee])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Item] FOREIGN KEY([Item])
REFERENCES [dbo].[Item] ([ID_Item])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Item]
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Item] FOREIGN KEY([Item])
REFERENCES [dbo].[Item] ([ID_Item])
GO
ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Item]
GO
ALTER TABLE [dbo].[Shipment]  WITH CHECK ADD  CONSTRAINT [FK_Shipment_Provider] FOREIGN KEY([Provider])
REFERENCES [dbo].[Provider] ([ID_Provider])
GO
ALTER TABLE [dbo].[Shipment] CHECK CONSTRAINT [FK_Shipment_Provider]
GO
