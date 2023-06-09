USE [master]
GO
/****** Object:  Database [bd_control_inventario]    Script Date: 21/4/2023 8:56:01 p. m. ******/
CREATE DATABASE [bd_control_inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_control_inventario', FILENAME = N'C:\sqlserverdata\MSSQL16.SQLEXPRESS\MSSQL\DATA\bd_control_inventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_control_inventario_log', FILENAME = N'C:\sqlserverdata\MSSQL16.SQLEXPRESS\MSSQL\DATA\bd_control_inventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bd_control_inventario] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_control_inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_control_inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_control_inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_control_inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_control_inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_control_inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_control_inventario] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bd_control_inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_control_inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_control_inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_control_inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_control_inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_control_inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_control_inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_control_inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_control_inventario] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bd_control_inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_control_inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_control_inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_control_inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_control_inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_control_inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_control_inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_control_inventario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bd_control_inventario] SET  MULTI_USER 
GO
ALTER DATABASE [bd_control_inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_control_inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_control_inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_control_inventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_control_inventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_control_inventario] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [bd_control_inventario] SET QUERY_STORE = ON
GO
ALTER DATABASE [bd_control_inventario] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bd_control_inventario]
GO
/****** Object:  Table [dbo].[tb_movimientosproductos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_movimientosproductos](
	[cod_movimiento] [int] IDENTITY(1,1) NOT NULL,
	[cod_producto] [int] NULL,
	[cantidad] [int] NOT NULL,
	[fecha_movimiento] [datetime] NULL,
	[tipo_movimiento] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_movimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_productos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_productos](
	[cod_producto] [int] IDENTITY(1,1) NOT NULL,
	[desc_producto] [varchar](200) NOT NULL,
	[categoria_producto] [varchar](100) NULL,
	[costo_producto] [decimal](18, 2) NULL,
	[precio_producto] [decimal](18, 2) NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
	[medida_producto] [varchar](3) NULL,
	[existencia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuarios]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuarios](
	[cod_usuario] [int] IDENTITY(1,1) NOT NULL,
	[login_usuario] [varchar](20) NOT NULL,
	[password_usuario] [varchar](20) NOT NULL,
	[nombre] [varchar](80) NOT NULL,
	[correo] [varchar](100) NOT NULL,
	[rol_usuario] [varchar](20) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_movimientosproductos] ADD  DEFAULT (getdate()) FOR [fecha_movimiento]
GO
/****** Object:  StoredProcedure [dbo].[ps_verificar_usuario]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ps_verificar_usuario]
    @login_usuario VARCHAR(50),
    @password_usuario VARCHAR(50)
AS
BEGIN
    -- Verificar si el usuario y la contraseña son correctos
    DECLARE @rol_usuario VARCHAR(50)
    SELECT @rol_usuario = rol_usuario
    FROM tb_usuarios
    WHERE login_usuario = @login_usuario AND password_usuario = @password_usuario

    -- Devolver el rol si el usuario y la contraseña son correctos
    IF @rol_usuario IS NOT NULL
        SELECT @rol_usuario AS 'Rol'
    ELSE
        SELECT 'Usuario y/o contraseña incorrectos' AS 'Error'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_10_productos_con_mas_movimientos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_10_productos_con_mas_movimientos]
AS
SELECT TOP 10 m.cod_producto AS CODPROD, p.desc_producto AS DESCRIPCION, COUNT(*) AS VENTAS 
FROM tb_movimientosproductos m
INNER JOIN tb_productos p ON m.cod_producto = p.cod_producto
GROUP BY m.cod_producto, p.desc_producto 
ORDER BY VENTAS DESC;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_producto]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizar_producto]
	@cod_producto INT,
	@desc_producto VARCHAR(200),
	@categoria_producto VARCHAR(100),
	@costo_producto DECIMAL(18,2),
	@precio_producto DECIMAL(18,2),
	@medida_producto VARCHAR(3),
	@existencia INT
AS
UPDATE tb_productos
SET
	desc_producto = @desc_producto,
	categoria_producto = @categoria_producto,
	costo_producto = @costo_producto,
	precio_producto = @precio_producto,
	medida_producto = @medida_producto,
	existencia = @existencia,
	fecha_modificacion = GETDATE()
WHERE cod_producto = @cod_producto;
GO
/****** Object:  StoredProcedure [dbo].[sp_actualizar_usuario]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_actualizar_usuario]
@cod_usuario int,
@login_usuario VARCHAR(20),
@password_usuario VARCHAR(20),
@nombre VARCHAR(80),
@correo VARCHAR(100),
@rol_usuario VARCHAR(20)
AS
UPDATE tb_usuarios
SET 
	login_usuario = @login_usuario,
	password_usuario = @password_usuario,
	nombre = @nombre,
	correo = @correo,
	rol_usuario = @rol_usuario,
	fecha_modificacion = GETDATE()
WHERE cod_usuario = @cod_usuario;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_movimientos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_movimientos]
AS
SELECT cod_movimiento AS CODMOV, cod_producto AS CODPROD, cantidad AS CANTIDAD, fecha_movimiento AS FECHA, tipo_movimiento AS TIPO_MOVIMIENTO FROM tb_movimientosproductos;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_producto_by_id]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_producto_by_id]
@cod_producto INT
AS
SELECT cod_producto AS CODPROD, desc_producto AS DESCRIPCION, categoria_producto AS CATEGORIA, costo_producto AS COSTO, precio_producto AS PRECIO, medida_producto AS MEDIDA, existencia AS EXISTENCIA FROM tb_productos
WHERE cod_producto = @cod_producto;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_productos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_productos]
AS
SELECT cod_producto AS CODPROD, desc_producto AS DESCRIPCION, categoria_producto AS CATEGORIA, costo_producto AS COSTO, precio_producto AS PRECIO, medida_producto AS MEDIDA, existencia AS EXISTENCIA FROM tb_productos;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_usuario_by_id]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_usuario_by_id]
@cod_usuario INT
AS
SELECT cod_usuario CODUSER, login_usuario, correo EMAIL, nombre NOMBRE, rol_usuario ROL_USUARIO FROM tb_usuarios
WHERE cod_usuario = @cod_usuario;
GO
/****** Object:  StoredProcedure [dbo].[sp_consultar_usuarios]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultar_usuarios]
AS
SELECT cod_usuario AS CODUSER, login_usuario AS USUARIO, correo AS EMAIL, nombre AS NOMBRE, rol_usuario AS ROL_USUARIO FROM tb_usuarios;
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_producto]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_crear_producto]
	@desc_producto VARCHAR(200),
	@categoria_producto VARCHAR(100),
	@costo_producto DECIMAL(18,2),
	@precio_producto DECIMAL(18,2),
	@medida_producto VARCHAR(3),
	@existencia INT
AS
INSERT INTO tb_productos (desc_producto, categoria_producto, costo_producto, precio_producto, medida_producto, existencia) 
VALUES (@desc_producto,	@categoria_producto, @costo_producto, @precio_producto, @medida_producto, @existencia);
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_usuario]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_crear_usuario]
@login_usuario VARCHAR(20),
@password_usuario VARCHAR(20),
@nombre VARCHAR(80),
@correo VARCHAR(100),
@rol_usuario VARCHAR(20)
AS
INSERT INTO tb_usuarios (login_usuario, password_usuario, nombre, correo, rol_usuario)
VALUES (@login_usuario, @password_usuario, @nombre, @correo, @rol_usuario)
GO
/****** Object:  StoredProcedure [dbo].[sp_decrementar_producto]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_decrementar_producto]
@cod_producto INT,
@cantidad INT
AS
BEGIN
INSERT INTO tb_movimientosproductos (cod_producto, cantidad, tipo_movimiento)
VALUES (@cod_producto, @cantidad, 'DECREMENTO');

UPDATE tb_productos
SET existencia = existencia - @cantidad, fecha_modificacion = GETDATE()
WHERE cod_producto = @cod_producto;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_producto]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--ELIMINAR PRODUCTO
CREATE PROCEDURE [dbo].[sp_eliminar_producto]
@cod_producto INT
AS
DELETE tb_productos
WHERE cod_producto = @cod_producto;
GO
/****** Object:  StoredProcedure [dbo].[sp_eliminar_usuario]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_eliminar_usuario]
@cod_usuario INT
AS
DELETE tb_usuarios
WHERE cod_usuario = @cod_usuario
GO
/****** Object:  StoredProcedure [dbo].[sp_incrementar_producto]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_incrementar_producto]
@cod_producto INT,
@cantidad INT
AS
BEGIN
INSERT INTO tb_movimientosproductos (cod_producto, cantidad, tipo_movimiento)
VALUES (@cod_producto, @cantidad, 'INCREMENTO');

UPDATE tb_productos
SET existencia = existencia + @cantidad, fecha_modificacion = GETDATE()
WHERE cod_producto = @cod_producto;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_decrementos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_reporte_decrementos]
AS
SELECT TOP 10 m.cod_producto AS CODPROD, p.desc_producto AS DESCRIPCION
FROM tb_movimientosproductos m
INNER JOIN tb_productos p ON m.cod_producto = p.cod_producto
WHERE m.tipo_movimiento LIKE '%DECREMENTO%';
GO
/****** Object:  StoredProcedure [dbo].[sp_reporte_incrementos]    Script Date: 21/4/2023 8:56:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_reporte_incrementos]
AS
SELECT TOP 10 m.cod_producto AS CODPROD, p.desc_producto AS DESCRIPCION
FROM tb_movimientosproductos m
INNER JOIN tb_productos p ON m.cod_producto = p.cod_producto
WHERE m.tipo_movimiento LIKE '%INCREMENTO%';
GO
USE [master]
GO
ALTER DATABASE [bd_control_inventario] SET  READ_WRITE 
GO
