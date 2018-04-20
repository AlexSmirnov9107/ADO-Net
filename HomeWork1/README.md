# Спроектировать в mdf файле (локальном файле БД) таблицы со связями Person, Car, Order. Скинуть в текстовом файле команды на создание таблиц со связями.

1.  CREATE TABLE [dbo].[person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fio] [varchar](200) NULL,
	[phone] [varchar](50) NULL,
 CONSTRAINT [PK_person] PRIMARY KEY 
)
2.  CREATE TABLE [dbo].[cars] (
  [id] int IDENTITY(1,1) NOT NULL,
  [carname] int NULL,
  [model] varchar(255) NULL,
  [price] int NULL,
  PRIMARY KEY CLUSTERED ([id]),
)

3.  CREATE TABLE [dbo].[orders] (
  [id] int IDENTITY(1,1) NOT NULL,
  [userid] int NULL,
  [carid] int NULL,
  [date] datetime2 NULL,
  PRIMARY KEY CLUSTERED ([id]),
  CONSTRAINT [car] FOREIGN KEY ([carid]) REFERENCES [dbo].[cars] ([id]),
  CONSTRAINT [userid] FOREIGN KEY ([userid]) REFERENCES [dbo].[users] ([id])
)