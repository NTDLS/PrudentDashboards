SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataView]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataView](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](128) NOT NULL,
	[SQLText] [varchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_DataView_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DataView] ADD  CONSTRAINT [DF_DataView_CreatedDate]  DEFAULT (getutcdate()) FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_DataView_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DataView] ADD  CONSTRAINT [DF_DataView_UpdatedDate]  DEFAULT (getutcdate()) FOR [UpdatedDate]
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FieldType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FieldType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_FieldType_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[FieldType] ADD  CONSTRAINT [DF_FieldType_CreatedDate]  DEFAULT (getutcdate()) FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_FieldType_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[FieldType] ADD  CONSTRAINT [DF_FieldType_UpdatedDate]  DEFAULT (getutcdate()) FOR [UpdatedDate]
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FieldTypeUsage]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FieldTypeUsage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](128) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DataViewField]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DataViewField](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataViewId] [int] NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Alias] [nvarchar](128) NOT NULL,
	[FieldTypeId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_DataViewField_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DataViewField] ADD  CONSTRAINT [DF_DataViewField_CreatedDate]  DEFAULT (getutcdate()) FOR [CreatedDate]
END

GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DF_DataViewField_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DataViewField] ADD  CONSTRAINT [DF_DataViewField_UpdatedDate]  DEFAULT (getutcdate()) FOR [UpdatedDate]
END

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[FieldTypeUsageMapping](
	[FieldTypeId] [int] NOT NULL,
	[FieldTypeUsageId] [int] NOT NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[DataView]') AND name = N'PK_DataView')
ALTER TABLE [dbo].[DataView] ADD  CONSTRAINT [PK_DataView] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FieldType]') AND name = N'PK_FieldType')
ALTER TABLE [dbo].[FieldType] ADD  CONSTRAINT [PK_FieldType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FieldTypeUsage]') AND name = N'PK_FieldTypeUsage')
ALTER TABLE [dbo].[FieldTypeUsage] ADD  CONSTRAINT [PK_FieldTypeUsage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[DataViewField]') AND name = N'PK_DataViewField')
ALTER TABLE [dbo].[DataViewField] ADD  CONSTRAINT [PK_DataViewField] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]') AND name = N'PK_FieldTypeUsageMapping')
ALTER TABLE [dbo].[FieldTypeUsageMapping] ADD  CONSTRAINT [PK_FieldTypeUsageMapping] PRIMARY KEY CLUSTERED 
(
	[FieldTypeId] ASC,
	[FieldTypeUsageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataViewField_DataView]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataViewField]'))
ALTER TABLE [dbo].[DataViewField]  WITH CHECK ADD  CONSTRAINT [FK_DataViewField_DataView] FOREIGN KEY([DataViewId])
REFERENCES [dbo].[DataView] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataViewField_DataView]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataViewField]'))
ALTER TABLE [dbo].[DataViewField] CHECK CONSTRAINT [FK_DataViewField_DataView]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataViewField_FieldType]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataViewField]'))
ALTER TABLE [dbo].[DataViewField]  WITH CHECK ADD  CONSTRAINT [FK_DataViewField_FieldType] FOREIGN KEY([FieldTypeId])
REFERENCES [dbo].[FieldType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DataViewField_FieldType]') AND parent_object_id = OBJECT_ID(N'[dbo].[DataViewField]'))
ALTER TABLE [dbo].[DataViewField] CHECK CONSTRAINT [FK_DataViewField_FieldType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FieldTypeUsageMapping_FieldType]') AND parent_object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]'))
ALTER TABLE [dbo].[FieldTypeUsageMapping]  WITH CHECK ADD  CONSTRAINT [FK_FieldTypeUsageMapping_FieldType] FOREIGN KEY([FieldTypeId])
REFERENCES [dbo].[FieldType] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FieldTypeUsageMapping_FieldType]') AND parent_object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]'))
ALTER TABLE [dbo].[FieldTypeUsageMapping] CHECK CONSTRAINT [FK_FieldTypeUsageMapping_FieldType]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FieldTypeUsageMapping_FieldTypeUsage]') AND parent_object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]'))
ALTER TABLE [dbo].[FieldTypeUsageMapping]  WITH CHECK ADD  CONSTRAINT [FK_FieldTypeUsageMapping_FieldTypeUsage] FOREIGN KEY([FieldTypeUsageId])
REFERENCES [dbo].[FieldTypeUsage] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_FieldTypeUsageMapping_FieldTypeUsage]') AND parent_object_id = OBJECT_ID(N'[dbo].[FieldTypeUsageMapping]'))
ALTER TABLE [dbo].[FieldTypeUsageMapping] CHECK CONSTRAINT [FK_FieldTypeUsageMapping_FieldTypeUsage]
GO
CREATE TABLE #tmp_892c80fbb19a4cc69417042295760d8d ([Id] [int],[Name] [nvarchar](100),[CreatedDate] [datetime],[UpdatedDate] [datetime])
GO

INSERT INTO #tmp_892c80fbb19a4cc69417042295760d8d ([Id],[Name],[CreatedDate],[UpdatedDate]) VALUES
(1,'String','11/21/2023 9:54:13 PM','11/21/2023 9:54:13 PM'),
(2,'DateTime','11/21/2023 9:54:26 PM','11/21/2023 9:54:26 PM'),
(3,'Decimal','11/21/2023 9:54:29 PM','11/21/2023 9:54:29 PM'),
(5,'Int32','11/21/2023 9:56:09 PM','11/21/2023 9:56:09 PM'),
(6,'Boolean','11/21/2023 9:56:14 PM','11/21/2023 9:56:14 PM'),
(7,'Int64','11/21/2023 9:56:16 PM','11/21/2023 9:56:16 PM'),
(8,'Guid','11/21/2023 9:56:21 PM','11/21/2023 9:56:21 PM')
GO
ALTER TABLE [dbo].[FieldType] NOCHECK CONSTRAINT ALL
GO
UPDATE T SET 
T.[Name] = S.[Name],
T.[CreatedDate] = S.[CreatedDate],
T.[UpdatedDate] = S.[UpdatedDate]

FROM [dbo].[FieldType] as T
INNER JOIN #tmp_892c80fbb19a4cc69417042295760d8d as S
ON T.[Id] = S.[Id]
GO
SET IDENTITY_INSERT [dbo].[FieldType] ON;
INSERT INTO [dbo].[FieldType] (
	[Id],[Name],[CreatedDate],[UpdatedDate])
SELECT
	[Id],[Name],[CreatedDate],[UpdatedDate]
FROM #tmp_892c80fbb19a4cc69417042295760d8d as S
WHERE NOT EXISTS (
	SELECT TOP 1 1 FROM  [dbo].[FieldType] as T
	WHERE T.[Id] = S.[Id]
)
SET IDENTITY_INSERT [dbo].[FieldType] OFF;
ALTER TABLE [dbo].[FieldType] CHECK CONSTRAINT ALL
GO
DROP TABLE #tmp_892c80fbb19a4cc69417042295760d8d
GO

GO
CREATE TABLE #tmp_63ddf012a1794ba194db604da79a07e9 ([Id] [int],[Name] [varchar](128))
GO

INSERT INTO #tmp_63ddf012a1794ba194db604da79a07e9 ([Id],[Name]) VALUES
(1,'Dimension'),
(2,'Measure')
GO
ALTER TABLE [dbo].[FieldTypeUsage] NOCHECK CONSTRAINT ALL
GO
UPDATE T SET 
T.[Name] = S.[Name]

FROM [dbo].[FieldTypeUsage] as T
INNER JOIN #tmp_63ddf012a1794ba194db604da79a07e9 as S
ON T.[Id] = S.[Id]
GO
SET IDENTITY_INSERT [dbo].[FieldTypeUsage] ON;
INSERT INTO [dbo].[FieldTypeUsage] (
	[Id],[Name])
SELECT
	[Id],[Name]
FROM #tmp_63ddf012a1794ba194db604da79a07e9 as S
WHERE NOT EXISTS (
	SELECT TOP 1 1 FROM  [dbo].[FieldTypeUsage] as T
	WHERE T.[Id] = S.[Id]
)
SET IDENTITY_INSERT [dbo].[FieldTypeUsage] OFF;
ALTER TABLE [dbo].[FieldTypeUsage] CHECK CONSTRAINT ALL
GO
DROP TABLE #tmp_63ddf012a1794ba194db604da79a07e9
GO

GO
CREATE TABLE #tmp_18a996f82cac4117a7d9138bcc99ef52 ([FieldTypeId] [int],[FieldTypeUsageId] [int])
GO

INSERT INTO #tmp_18a996f82cac4117a7d9138bcc99ef52 ([FieldTypeId],[FieldTypeUsageId]) VALUES
(1,1),
(2,1),
(3,1),
(3,2),
(5,1),
(5,2),
(6,1),
(7,1),
(7,2),
(8,1)
GO
ALTER TABLE [dbo].[FieldTypeUsageMapping] NOCHECK CONSTRAINT ALL
GO
INSERT INTO [dbo].[FieldTypeUsageMapping] (
	[FieldTypeId],[FieldTypeUsageId])
SELECT
	[FieldTypeId],[FieldTypeUsageId]
FROM #tmp_18a996f82cac4117a7d9138bcc99ef52 as S
WHERE NOT EXISTS (
	SELECT TOP 1 1 FROM  [dbo].[FieldTypeUsageMapping] as T
	WHERE T.[FieldTypeId] = S.[FieldTypeId] AND T.[FieldTypeUsageId] = S.[FieldTypeUsageId]
)
ALTER TABLE [dbo].[FieldTypeUsageMapping] CHECK CONSTRAINT ALL
GO
DROP TABLE #tmp_18a996f82cac4117a7d9138bcc99ef52
GO
