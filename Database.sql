CREATE TABLE [dbo].[Category](
	[CategoryID] [uniqueidentifier] NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[CategoryDescription] [nvarchar](max) NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Device]    Script Date: 2022/07/17 16:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Device](
	[DeviceID] [uniqueidentifier] NOT NULL,
	[DeviceName] [nvarchar](max) NULL,
	[CategoryID] [uniqueidentifier] NOT NULL,
	[ZoneID] [uniqueidentifier] NOT NULL,
	[Status] [nvarchar](max) NULL,
	[IsActvie] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_Device] PRIMARY KEY CLUSTERED 
(
	[DeviceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zone]    Script Date: 2022/07/17 16:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zone](
	[ZoneID] [uniqueidentifier] NOT NULL,
	[ZoneName] [nvarchar](max) NOT NULL,
	[ZoneDescription] [nvarchar](max) NULL,
	[DateCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_Zone] PRIMARY KEY CLUSTERED 
(
	[ZoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [DF_Category_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Device] ADD  CONSTRAINT [DF_Device_IsActvie]  DEFAULT ((0)) FOR [IsActvie]
GO
ALTER TABLE [dbo].[Device] ADD  CONSTRAINT [DF_Device_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[Zone] ADD  CONSTRAINT [DF_Zone_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
USE [master]
GO
ALTER DATABASE [ConnectedOffice] SET  READ_WRITE 
GO
