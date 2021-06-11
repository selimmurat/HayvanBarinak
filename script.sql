USE [HayvanBakımEviDb]
GO
/****** Object:  Table [dbo].[AdminBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [varchar](100) NULL,
	[Soyadı] [varchar](100) NULL,
	[Eposta] [varchar](100) NULL,
	[Sifre] [varchar](100) NULL,
 CONSTRAINT [PK_AdminBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BeslemeBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BeslemeBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HayvanId] [tinyint] NULL,
	[MamaTürü] [nvarchar](100) NULL,
	[Miktar] [varchar](20) NULL,
	[VerilisTarihi] [datetime] NULL,
 CONSTRAINT [PK_BeslemeBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HayvanBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HayvanBilgileri](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[HayvanKimlikNumarası] [int] NULL,
	[Turu] [nchar](30) NULL,
	[Cinsi] [nchar](30) NULL,
	[Yas] [char](2) NULL,
	[Renk] [nchar](10) NULL,
	[AsıBilgisi] [nvarchar](100) NULL,
	[BakıcıId] [int] NULL,
	[GelisTarihi] [datetime] NULL,
	[EkBilgi] [nvarchar](100) NULL,
	[Foto] [nvarchar](250) NULL,
 CONSTRAINT [PK_HayvanBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adı] [nvarchar](50) NULL,
	[Soyadı] [nvarchar](50) NULL,
	[TelNo] [nchar](11) NULL,
 CONSTRAINT [PK_PersonelBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SahiplenenBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SahiplenenBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TcKimlik] [char](11) NULL,
	[Adı] [nvarchar](50) NULL,
	[Soyadı] [nvarchar](50) NULL,
	[TelNo] [nchar](11) NULL,
 CONSTRAINT [PK_SahiplenenBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SahiplenmeBilgileri]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SahiplenmeBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HayvanId] [tinyint] NULL,
	[PersonelId] [int] NULL,
	[SahipId] [int] NULL,
	[Tarih] [datetime] NULL,
 CONSTRAINT [PK_SahiplenmeBilgileri] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BeslemeBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_BeslemeBilgileri_HayvanBilgileri] FOREIGN KEY([HayvanId])
REFERENCES [dbo].[HayvanBilgileri] ([Id])
GO
ALTER TABLE [dbo].[BeslemeBilgileri] CHECK CONSTRAINT [FK_BeslemeBilgileri_HayvanBilgileri]
GO
ALTER TABLE [dbo].[HayvanBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_HayvanBilgileri_PersonelBilgileri] FOREIGN KEY([BakıcıId])
REFERENCES [dbo].[PersonelBilgileri] ([Id])
GO
ALTER TABLE [dbo].[HayvanBilgileri] CHECK CONSTRAINT [FK_HayvanBilgileri_PersonelBilgileri]
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_SahiplenmeBilgileri_HayvanBilgileri] FOREIGN KEY([HayvanId])
REFERENCES [dbo].[HayvanBilgileri] ([Id])
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri] CHECK CONSTRAINT [FK_SahiplenmeBilgileri_HayvanBilgileri]
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_SahiplenmeBilgileri_PersonelBilgileri] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[PersonelBilgileri] ([Id])
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri] CHECK CONSTRAINT [FK_SahiplenmeBilgileri_PersonelBilgileri]
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_SahiplenmeBilgileri_SahiplenenBilgileri] FOREIGN KEY([SahipId])
REFERENCES [dbo].[SahiplenenBilgileri] ([Id])
GO
ALTER TABLE [dbo].[SahiplenmeBilgileri] CHECK CONSTRAINT [FK_SahiplenmeBilgileri_SahiplenenBilgileri]
GO
/****** Object:  StoredProcedure [dbo].[HayvanBilgileriListesi]    Script Date: 2.04.2021 14:31:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[HayvanBilgileriListesi]
as
select HayvanBilgileri.Id,HayvanKimlikNumarası,Turu,Cinsi,Yas,Renk,AsıBilgisi,personel.Adı,personel.Soyadı, GelisTarihi,EkBilgi,Foto from  HayvanBilgileri left join PersonelBilgileri personel on personel.Id=HayvanBilgileri.BakıcıId
GO
