USE [master]
GO

/****** Object:  Database [KOpenPos]    Script Date: 6/17/2013 11:04:56 PM ******/
DROP DATABASE [KOpenPos]
GO

/****** Object:  Database [KOpenPos]    Script Date: 6/17/2013 11:04:56 PM ******/
CREATE DATABASE [KOpenPos] ON  PRIMARY 
( NAME = N'OpenPos', FILENAME = N'D:\Database\SQL 2005\OpenPos.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OpenPos_log', FILENAME = N'D:\Database\SQL 2005\OpenPos_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [KOpenPos] SET COMPATIBILITY_LEVEL = 90
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KOpenPos].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO

ALTER DATABASE [KOpenPos] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [KOpenPos] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [KOpenPos] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [KOpenPos] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [KOpenPos] SET ARITHABORT OFF 
GO

ALTER DATABASE [KOpenPos] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [KOpenPos] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [KOpenPos] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [KOpenPos] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [KOpenPos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [KOpenPos] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [KOpenPos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [KOpenPos] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [KOpenPos] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [KOpenPos] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [KOpenPos] SET  DISABLE_BROKER 
GO

ALTER DATABASE [KOpenPos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [KOpenPos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [KOpenPos] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [KOpenPos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [KOpenPos] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [KOpenPos] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [KOpenPos] SET RECOVERY FULL 
GO

ALTER DATABASE [KOpenPos] SET  MULTI_USER 
GO

ALTER DATABASE [KOpenPos] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [KOpenPos] SET DB_CHAINING OFF 
GO

ALTER DATABASE [KOpenPos] SET  READ_WRITE 
GO


USE [KOpenPos]
GO

/****** Object:  Table [dbo].[Branch]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Branch](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[BranchName] [varchar](64) NOT NULL,
	[IsHeadOffice] [bit] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[BranchDetail]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BranchDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[Address] [varchar](64) NULL,
	[ZipCode] [char](5) NULL,
	[City] [varchar](64) NULL,
	[State] [varchar](64) NULL,
	[PhoneLine1] [varchar](16) NULL,
	[PhoneLine2] [varchar](16) NULL,
	[FaxOffice] [varchar](16) NULL,
	[Email] [varchar](128) NULL,
	[Description] [varchar](256) NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ConfigBase]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ConfigBase](
	[Seq] [uniqueidentifier] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[ConfigName] [varchar](24) NOT NULL,
	[ConfigValue] [varchar](64) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[InvoiceCollecting]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvoiceCollecting](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[InvoiceId] [uniqueidentifier] NOT NULL,
	[CollectingCode] [varchar](16) NULL,
	[CollectorName] [varchar](64) NULL,
	[CollectingDate] [datetime] NULL,
	[CollectingReportDate] [datetime] NULL,
	[PaymentType] [tinyint] NOT NULL,
	[PaymentRefNumber] [varchar](24) NULL,
	[PayerName] [varchar](64) NULL,
	[PayerAddress] [varchar](64) NULL,
	[PayerPhoneNumber] [varchar](16) NULL,
	[Amount] [float] NOT NULL,
	[Notes] [varchar](128) NULL,
	[NotesReport] [varchar](128) NULL,
	[IsOneTime] [bit] NOT NULL,
	[FromFrontDesk] [bit] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[InvoiceLogs]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[InvoiceLogs](
	[Sequence] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [uniqueidentifier] NOT NULL,
	[Logs] [text] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Invoices]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Invoices](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[InvoiceDate] [datetime] NOT NULL,
	[InvoiceNumber] [varchar](24) NOT NULL,
	[PrintCounter] [int] NOT NULL,
	[LastPrintDate] [datetime] NOT NULL,
	[DiscountAllowances] [bit] NOT NULL,
	[PaymentDiscount] [decimal](4, 2) NULL,
	[DueDaysDiscount] [tinyint] NULL,
	[PaymentTerm] [tinyint] NULL,
	[TermType] [char](3) NULL,
	[Notes] [varchar](256) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ItemCategory]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ItemCategory](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[CategoryName] [varchar](32) NOT NULL,
	[CategoryDescription] [varchar](64) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[OrderDetail]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OrderDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[OrderLine] [smallint] NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[ProductCode] [varchar](8) NULL,
	[ProductName] [varchar](32) NULL,
	[MarketName] [varchar](32) NULL,
	[GeneralCode] [varchar](16) NULL,
	[UnitPrice] [float] NOT NULL,
	[Quantity] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[QaCode] [char](2) NOT NULL,
	[UomCode] [varchar](4) NOT NULL,
	[Notes] [varchar](128) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[OrderLogs]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[OrderLogs](
	[Sequence] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [uniqueidentifier] NOT NULL,
	[Logs] [text] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Orders]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[OrderNo] [varchar](12) NOT NULL,
	[ExternalDocumentNo] [varchar](16) NOT NULL,
	[OrderType] [tinyint] NOT NULL,
	[OrderStatus] [tinyint] NOT NULL,
	[PaymentType] [tinyint] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DateRequireShipment] [datetime] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[DownPayment] [float] NOT NULL,
	[ShippingCharge] [float] NOT NULL,
	[AddValueTax] [float] NOT NULL,
	[OtherTax] [float] NOT NULL,
	[TotalOrders] [float] NOT NULL,
	[Notes] [varchar](256) NOT NULL,
	[IsOrderFullFill] [bit] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ProductDetail]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProductDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[GrossWeight] [float] NOT NULL,
	[NetWeight] [float] NOT NULL,
	[Length] [float] NOT NULL,
	[Width] [float] NOT NULL,
	[Height] [float] NOT NULL,
	[ReorderPoint] [float] NOT NULL,
	[MaxOrders] [float] NOT NULL,
	[MinOrders] [float] NOT NULL,
	[WarnInstructions] [varchar](512) NOT NULL,
	[PickInstructions] [varchar](512) NOT NULL,
	[DeliveryInstructions] [varchar](512) NOT NULL,
	[SafeInstructions] [varchar](512) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ProductPicture]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProductPicture](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[FileName] [varchar](64) NOT NULL,
	[ProductPicture] [image] NOT NULL,
	[Description] [varchar](64) NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ProductPricing]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProductPricing](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[PriceCode] [char](4) NOT NULL,
	[PriceCodeDisplayed] [varchar](16) NOT NULL,
	[StartSalesPrice] [float] NOT NULL,
	[EndSalesPrice] [float] NOT NULL,
	[StartActiveDate] [datetime] NOT NULL,
	[EndActiveDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[Products]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[ItemCategoryId] [uniqueidentifier] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[ProductCode] [varchar](8) NOT NULL,
	[ProductName] [varchar](32) NOT NULL,
	[MarketName] [varchar](32) NOT NULL,
	[GeneralCode] [varchar](16) NOT NULL,
	[DefaultQaCode] [char](2) NOT NULL,
	[DefaultUomCode] [varchar](4) NOT NULL,
	[MethodValuating] [tinyint] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ProductStock]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProductStock](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[QuantityAvailable] [float] NOT NULL,
	[QuantityAllocated] [float] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ProductStockJournal]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProductStockJournal](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[ProductId] [uniqueidentifier] NOT NULL,
	[TransactionCode] [char](3) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[QuantityAvailable] [float] NOT NULL,
	[QuantityAllocated] [float] NOT NULL,
	[QuantityTurnover] [float] NOT NULL,
	[AllocatedTurnover] [float] NOT NULL,
	[Notes] [varchar](256) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ShippingOrderLog]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ShippingOrderLog](
	[Sequence] [int] IDENTITY(1,1) NOT NULL,
	[ShippingOrderId] [uniqueidentifier] NOT NULL,
	[Logs] [text] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ShippingOrders]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ShippingOrders](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[ShippingServicesId] [uniqueidentifier] NOT NULL,
	[ShipmentNo] [varchar](16) NOT NULL,
	[ShipmentNoExternal] [varchar](16) NULL,
	[ShipmentStatus] [tinyint] NOT NULL,
	[ShipmentType] [tinyint] NOT NULL,
	[ShipmentDate] [datetime] NOT NULL,
	[ReceiverName] [varchar](64) NOT NULL,
	[ReceiverNotes] [varchar](256) NULL,
	[TransporterNotes] [varchar](256) NULL,
	[PrintCounter] [int] NOT NULL,
	[PrintDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ShippingServiceDetail]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ShippingServiceDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[Address] [varchar](128) NULL,
	[City] [varchar](64) NULL,
	[PostalCode] [char](5) NULL,
	[PhoneLine1] [varchar](16) NULL,
	[PhoneLine2] [varchar](16) NULL,
	[Fax] [varchar](16) NULL,
	[Email] [varchar](128) NULL,
	[Notes] [varchar](256) NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[ShippingServices]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ShippingServices](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[Priority] [tinyint] NOT NULL,
	[ShippingCharge] [float] NOT NULL,
	[LegalName] [varchar](64) NOT NULL,
	[MarketName] [varchar](32) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[UserDetails]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserDetails](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[RegisterDate] [datetime] NULL,
	[ActivationDate] [datetime] NULL,
	[ActivationKey] [varchar](64) NULL,
	[SecurityQuestion] [varchar](256) NULL,
	[SecurityAnswer] [varchar](128) NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[UserProfile]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserProfile](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[BranchCode] [char](3) NOT NULL,
	[AppCode] [char](3) NOT NULL,
	[UserName] [varchar](24) NOT NULL,
	[FullName] [varchar](64) NOT NULL,
	[Email] [varchar](128) NOT NULL,
	[CssProfile] [varchar](128) NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

/****** Object:  Table [dbo].[UserSecurity]    Script Date: 6/17/2013 11:05:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserSecurity](
	[Id] [uniqueidentifier] NOT NULL,
	[RowStatus] [tinyint] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[UserPassword] [varchar](24) NULL,
	[MustChangePassword] [bit] NOT NULL,
	[IsWindowIdentity] [bit] NOT NULL,
	[CreatedBy] [varchar](24) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedBy] [varchar](24) NULL,
	[ModifiedDate] [datetime] NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

