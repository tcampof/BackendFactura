USE [master]
GO
/****** Object:  Database [DB_Facturacion]    Script Date: 13/02/2021 12:42:45 a. m. ******/
CREATE DATABASE [DB_Facturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Facturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Facturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Facturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_Facturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_Facturacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Facturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Facturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Facturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Facturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Facturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Facturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Facturacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Facturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Facturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Facturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Facturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Facturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Facturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Facturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Facturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Facturacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Facturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Facturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Facturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Facturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Facturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Facturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Facturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Facturacion] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Facturacion] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Facturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Facturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Facturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Facturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Facturacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_Facturacion] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Facturacion', N'ON'
GO
ALTER DATABASE [DB_Facturacion] SET QUERY_STORE = OFF
GO
USE [DB_Facturacion]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[CliId] [int] IDENTITY(1,1) NOT NULL,
	[CliNombre] [nvarchar](100) NULL,
	[CliIdent] [nvarchar](50) NULL,
	[CliTelefono] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[CliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Factura]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Factura](
	[DetId] [int] IDENTITY(1,1) NOT NULL,
	[FactId] [int] NULL,
	[ProdId] [int] NULL,
	[Cantidad] [int] NULL,
	[ValorUnit] [float] NULL,
 CONSTRAINT [PK_Detalle_Factura] PRIMARY KEY CLUSTERED 
(
	[DetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpCedula] [nvarchar](50) NOT NULL,
	[EmpNombre] [nvarchar](200) NULL,
	[EmpCargo] [nvarchar](50) NULL,
	[EmpActivo] [bit] NULL,
	[RolId] [int] NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[FactId] [int] IDENTITY(1,1) NOT NULL,
	[FactNum] [int] NULL,
	[FactFecha] [datetime] NULL,
	[CliId] [int] NULL,
	[EmpId] [int] NULL,
	[Total] [float] NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[FactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ProdId] [int] IDENTITY(1,1) NOT NULL,
	[ProdCod] [int] NULL,
	[ProdNom] [nvarchar](50) NULL,
	[ProdDesc] [nvarchar](200) NULL,
	[ProdPrecio] [float] NULL,
	[ProdStock] [int] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ProdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolId] [int] NOT NULL,
	[RolNombre] [nvarchar](100) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Empleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
CREATE NONCLUSTERED INDEX [IX_Empleado] ON [dbo].[Empleado]
(
	[EmpCedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Factura] FOREIGN KEY([FactId])
REFERENCES [dbo].[Factura] ([FactId])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [FK_Detalle_Factura_Factura]
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Producto] FOREIGN KEY([ProdId])
REFERENCES [dbo].[Producto] ([ProdId])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [FK_Detalle_Factura_Producto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Rol] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolId])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Rol]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Cliente] FOREIGN KEY([CliId])
REFERENCES [dbo].[Cliente] ([CliId])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Cliente]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Empleado] FOREIGN KEY([EmpId])
REFERENCES [dbo].[Empleado] ([EmpId])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Empleado]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCliente]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarCliente]
@CliNombre NVARCHAR(100),
@CliIdent NVARCHAR(50),
@CliTelefono NVARCHAR(50)

AS
BEGIN
	
	
	UPDATE Cliente SET CliNombre = @CliNombre, CliTelefono = @CliTelefono WHERE CliIdent = @CliIdent

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarEmpleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarEmpleado]
@EmpNombre NVARCHAR(200),
@EmpCedula NVARCHAR(50),
@EmpCargo NVARCHAR(50),
@EmpActivo BIT,
@RolId INT

AS
BEGIN
	
		UPDATE Empleado SET 
		EmpNombre = @EmpNombre, 
		EmpActivo = @EmpActivo, 
		EmpCargo = @EmpCargo,
		RolId = @RolId
		WHERE EmpCedula = @EmpCedula

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProducto]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ActualizarProducto]
@ProdCod INT,
@ProdNom NVARCHAR(50),
@ProdDesc NVARCHAR(200),
@ProdPrecio FLOAT,
@ProdStock INT

AS
BEGIN
	
		UPDATE Producto SET 
		ProdDesc = @ProdDesc, 
		ProdNom = @ProdNom, 
		ProdPrecio = @ProdPrecio,
		ProdStock = @ProdStock
		WHERE ProdCod = @ProdCod

	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[ConsultarStock]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ConsultarStock]
@ProdId INT

AS
BEGIN

	SELECT ProdStock from Producto where ProdId = @ProdId


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarCliente]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarCliente]
@CliId INT

AS
BEGIN
	DELETE Cliente WHERE CliId = @CliId
	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarEmpleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarEmpleado]
@EmpId INT

AS
BEGIN
	DELETE Empleado WHERE EmpId = @EmpId
	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarProducto]
@ProdId INT

AS
BEGIN
	DELETE Producto WHERE ProdId = @ProdId
	SELECT 1
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarDetalleFactura]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GuardarDetalleFactura]
@FactId INT,
@ProdId INT,
@Cantidad INT,
@Valor float

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @Stock INT = 0;
	SET @Stock = (SELECT ProdStock from Producto where ProdId = @ProdId)

	IF @Stock > 0
	BEGIN

	INSERT INTO dbo.Detalle_Factura(FactId,
							 Cantidad,
							 ProdId,
							 ValorUnit) 
							 VALUES (@FactId,
							 @Cantidad,
							 @ProdId,
							 @Valor)

	UPDATE Producto SET ProdStock = ProdStock - @Cantidad Where ProdId = @ProdId
	END

	SELECT @Stock
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarFactura]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GuardarFactura]
@FactNum INT,
@FactFecha NVARCHAR(50),
@CliId INT,
@EmpId INT,
@Total float

AS
BEGIN
	DECLARE @FactId INT = 0;

	SET NOCOUNT ON;
	IF NOT EXISTS(SELECT FactNum from Factura where FactNum = @FactNum)
	BEGIN
	INSERT INTO dbo.Factura(FactNum,
							 FactFecha,
							 CliId,
							 EmpId,
							 Total) 
							 VALUES (@FactNum,
							 @FactFecha,
							 @CliId,
							 @EmpId,
							 @Total)

	SET @FactId = SCOPE_IDENTITY()
	
	END

	SELECT @FactId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarCliente]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarCliente]
@CliNombre NVARCHAR(100),
@CliIdent NVARCHAR(50),
@CliTelefono NVARCHAR(50)

AS
BEGIN
	DECLARE @CliID INT = 0;

	SET NOCOUNT ON;
	IF NOT EXISTS(SELECT CliId from CLIENTE where CliIdent = @CliIdent)
	BEGIN
	INSERT INTO dbo.Cliente (CliNombre,
							 CliIdent,
							 CliTelefono) 
							 VALUES (@CliNombre,
							 @CliIdent,
							 @CliTelefono)

	SET @CliID = SCOPE_IDENTITY()
	
	END

	SELECT @CliID
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarEmpleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarEmpleado]
@EmpNombre NVARCHAR(200),
@EmpCedula NVARCHAR(50),
@EmpCargo NVARCHAR(50),
@EmpActivo BIT,
@RolId INT

AS
BEGIN
	DECLARE @EmpId INT = 0;

	SET NOCOUNT ON;
	IF NOT EXISTS(SELECT EmpId from Empleado where EmpCedula = @EmpCedula)
	BEGIN
	INSERT INTO dbo.Empleado(EmpNombre,
							 EmpCedula,
							 EmpCargo,
							 EmpActivo,
							 RolId) 
							 VALUES (@EmpNombre,
							 @EmpCedula,
							 @EmpCargo,
							 @EmpActivo,
							 @RolId)

	SET @EmpId = SCOPE_IDENTITY()
	
	END

	SELECT @EmpId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarProducto]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertarProducto]
@ProdCod INT,
@ProdNom NVARCHAR(50),
@ProdDesc NVARCHAR(200),
@ProdPrecio FLOAT,
@ProdStock INT

AS
BEGIN
	DECLARE @ProdId INT = 0;

	SET NOCOUNT ON;
	IF NOT EXISTS(SELECT ProdId from Producto where ProdCod = @ProdCod)
	BEGIN
	INSERT INTO dbo.Producto(ProdCod,
							 ProdNom,
							 ProdDesc,
							 ProdPrecio,
							 ProdStock) 
							 VALUES (@ProdCod,
							 @ProdNom,
							 @ProdDesc,
							 @ProdPrecio,
							 @ProdStock)

	SET @ProdId = SCOPE_IDENTITY()
	
	END

	SELECT @ProdId
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerClientes]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerClientes]
@CliId int = NULL
AS
BEGIN

	SET NOCOUNT ON;

	IF @CliId IS NULL 
	BEGIN
		SELECT * FROM Cliente
	END
	ELSE
	BEGIN
		SELECT * FROM Cliente WHERE CliId = @CliId
	END

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerEmpleado]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerEmpleado]
@EmpCedula int = NULL
AS
BEGIN

	SET NOCOUNT ON;

	IF @EmpCedula IS NULL 
	BEGIN
		SELECT * FROM Empleado
	END
	ELSE
	BEGIN
		SELECT * FROM Empleado WHERE EmpCedula = @EmpCedula
	END

END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerProducto]    Script Date: 13/02/2021 12:42:45 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtenerProducto]
@ProdCod int = NULL
AS
BEGIN

	SET NOCOUNT ON;

	IF @ProdCod IS NULL 
	BEGIN
		SELECT * FROM Producto
	END
	ELSE
	BEGIN
		SELECT * FROM Producto WHERE ProdCod = @ProdCod
	END

END
GO
USE [master]
GO
ALTER DATABASE [DB_Facturacion] SET  READ_WRITE 
GO
