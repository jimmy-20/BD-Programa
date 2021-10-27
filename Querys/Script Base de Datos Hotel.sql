USE [master]
GO
/****** Object:  Database [NuevoHotel]    Script Date: 16/10/2021 12:07:23 ******/
CREATE DATABASE [NuevoHotel]
 
GO
USE [NuevoHotel]
GO
/****** Object:  User [hoteladmin]    Script Date: 16/10/2021 12:07:23 ******/

/****** Object:  Table [dbo].[cargos_servicios]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cargos_servicios](
	[id_servicio] [int] NOT NULL,
	[id_hab_reserva] [int] NOT NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC,
	[id_hab_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[p_nom] [varchar](15) NULL,
	[s_nom] [varchar](15) NULL,
	[p_apell] [varchar](15) NULL,
	[s_apell] [varchar](15) NULL,
	[direccion] [varchar](70) NULL,
	[tel] [varchar](10) NULL,
	[correo] [varchar](25) NULL,
	[Estado] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[IdFactura] [int] NULL,
	[IdServicio] [int] NULL,
	[Cantidad] [float] NULL,
	[Precio] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[p_nom] [varchar](15) NULL,
	[s_nom] [varchar](15) NULL,
	[p_apell] [varchar](15) NULL,
	[s_apell] [varchar](15) NULL,
	[direccion] [varchar](70) NULL,
	[tel] [varchar](10) NULL,
	[correo] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[IDFactura] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NULL,
	[IdUsuario] [int] NULL,
	[IdCliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitacion]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitacion](
	[no_habitacion] [int] NOT NULL,
	[cod_tipo] [int] NULL,
	[descr] [varchar](60) NULL,
	[cap] [int] NOT NULL,
	[stat] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[no_habitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[habitacion_reserva]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[habitacion_reserva](
	[id_hab_reserva] [int] IDENTITY(1,1) NOT NULL,
	[no_habitacion] [int] NULL,
	[id_reserva] [int] NULL,
	[fecha_entrada] [date] NOT NULL,
	[fecha_salida] [date] NOT NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hab_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[huesped]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[huesped](
	[id_huesped] [int] IDENTITY(1,1) NOT NULL,
	[p_nom] [varchar](15) NULL,
	[s_nom] [varchar](15) NULL,
	[p_apell] [varchar](15) NULL,
	[s_apell] [varchar](15) NULL,
	[direccion] [varchar](70) NULL,
	[tel] [varchar](10) NULL,
	[nacionalidad] [varchar](25) NULL,
	[correo] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_huesped] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[huesped_hab_reserva]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[huesped_hab_reserva](
	[id_huesped] [int] NOT NULL,
	[id_hab_reserva] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_huesped] ASC,
	[id_hab_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reserva]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[id_empleado] [int] NULL,
	[fecha_reserva] [date] NOT NULL,
	[forma_pago] [varchar](15) NULL,
	[divisa] [varchar](3) NULL,
	[stat] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[servicio]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicio](
	[id_servicio] [int] IDENTITY(1,1) NOT NULL,
	[descr] [varchar](60) NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_habitacion]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_habitacion](
	[cod_tipo] [int] NOT NULL,
	[nom_tipo] [varchar](25) NOT NULL,
	[precio] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cod_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Sistema]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Sistema](
	[idUsuario] [int] IDENTITY(0,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[contraseña] [varchar](150) NULL,
	[rol] [varchar](50) NULL,
	[Estado] [varchar](25) NULL,
	[id_Empleado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[cargos_servicios] ([id_servicio], [id_hab_reserva], [precio]) VALUES (1, 1, 60.0000)
INSERT [dbo].[cargos_servicios] ([id_servicio], [id_hab_reserva], [precio]) VALUES (3, 1, 40.0000)
INSERT [dbo].[cargos_servicios] ([id_servicio], [id_hab_reserva], [precio]) VALUES (5, 2, 30.0000)
SET IDENTITY_INSERT [dbo].[cliente] ON 

INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (1, N'Juan', N'Mairena', N'Lopez', N'Mendoza', N'12565 Reghan St.', N'0051414899', N'juanlopez@aol.com', N'Deshabilitado')
INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (2, N'Maria', N'Alejandra', N'Jerez', N'Mendez', N'564 Union Av.', N'8888888', N'marjerez@hotmail.com', N'Habilitado')
INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (3, N'Pepito', N'Jaime', N'Perez', N'Garcia', N'7848 Longhorn & Vista Rd.', N'877744555', N'peperez@aol.com', N'Deshabilitado')
INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (4, N'Vanessa', N'Lucia', N'Mejia', N'Avendaño', N'5567 Calle 8.', N'1526047893', N'lucia_mejia15@yahoo.com', N'Deshabilitado')
INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (5, N'Ana', N'Conda', N'Juarez', N'Soza', N'141 Union Rd.', N'7894514799', N'anaconda@yahoo.com', N'Deshabilitado')
INSERT [dbo].[cliente] ([id_cliente], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo], [Estado]) VALUES (6, N'Walger', N'José', N'Herrera', N'Treminio', N'Managua', N'555555555', N'walger@gmail.com', N'Deshabilitado')
SET IDENTITY_INSERT [dbo].[cliente] OFF
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (9, 4, 50, 5)
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (9, 2, 70, 8)
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (10, 3, 40, 5)
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (10, 5, 30, 3)
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (12, 5, 30, 3)
INSERT [dbo].[DetalleFactura] ([IdFactura], [IdServicio], [Cantidad], [Precio]) VALUES (12, 1, 60, 4)
SET IDENTITY_INSERT [dbo].[empleado] ON 

INSERT [dbo].[empleado] ([id_empleado], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo]) VALUES (1, N'Mario', N'Alberto', N'Roa', N'Carrion', N'12569 Reghan St.', N'0051488772', N'maalroca@gmail.com')
INSERT [dbo].[empleado] ([id_empleado], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo]) VALUES (2, N'Maria', N'Alejandra', N'Garcia', N'Jiron', N'12560 Vinerod St.', N'0052218772', N'maalegaji@gmail.com')
INSERT [dbo].[empleado] ([id_empleado], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [correo]) VALUES (3, N'Carlos', N'Jesus', N'Joya', N'Lola', N'4474 Fines Av.', N'0051278457', N'quejoyonpapa@gmail.com')
SET IDENTITY_INSERT [dbo].[empleado] OFF
SET IDENTITY_INSERT [dbo].[Factura] ON 

INSERT [dbo].[Factura] ([IDFactura], [Fecha], [IdUsuario], [IdCliente]) VALUES (9, CAST(N'2021-03-25' AS Date), 1, 2)
INSERT [dbo].[Factura] ([IDFactura], [Fecha], [IdUsuario], [IdCliente]) VALUES (10, CAST(N'2021-03-25' AS Date), 1, 2)
INSERT [dbo].[Factura] ([IDFactura], [Fecha], [IdUsuario], [IdCliente]) VALUES (11, CAST(N'2021-03-25' AS Date), 1, 2)
INSERT [dbo].[Factura] ([IDFactura], [Fecha], [IdUsuario], [IdCliente]) VALUES (12, CAST(N'2021-10-16' AS Date), 1, 2)
SET IDENTITY_INSERT [dbo].[Factura] OFF
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (1, 10, N'Ninguna descripcion', 2, N'DISPONIBLE')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (2, 11, N'Ninguna descripcion', 4, N'OCUPADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (3, 10, N'Ninguna descripcion', 2, N'RESERVADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (4, 12, N'Ninguna descripcion', 4, N'OCUPADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (5, 10, N'Ninguna descripcion', 2, N'OCUPADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (6, 11, N'Ninguna descripcion', 4, N'RESERVADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (7, 11, N'Ninguna descripcion', 4, N'DISPONIBLE')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (8, 12, N'Ninguna descripcion', 4, N'RESERVADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (9, 10, N'Ninguna descripcion', 2, N'RESERVADA')
INSERT [dbo].[habitacion] ([no_habitacion], [cod_tipo], [descr], [cap], [stat]) VALUES (10, 12, N'Ninguna descripcion', 4, N'RESERVADA')
SET IDENTITY_INSERT [dbo].[habitacion_reserva] ON 

INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (1, 4, 1, CAST(N'2019-03-12' AS Date), CAST(N'2019-03-18' AS Date), 500.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (2, 2, 1, CAST(N'2019-03-12' AS Date), CAST(N'2019-03-18' AS Date), 200.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (3, 3, 2, CAST(N'2019-03-18' AS Date), CAST(N'2019-03-20' AS Date), 100.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (4, 5, 3, CAST(N'2019-03-10' AS Date), CAST(N'2019-03-18' AS Date), 100.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (5, 6, 4, CAST(N'2019-03-20' AS Date), CAST(N'2019-03-25' AS Date), 200.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (6, 8, 4, CAST(N'2019-03-20' AS Date), CAST(N'2019-03-25' AS Date), 500.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (7, 9, 5, CAST(N'2019-03-19' AS Date), CAST(N'2019-03-23' AS Date), 100.0000)
INSERT [dbo].[habitacion_reserva] ([id_hab_reserva], [no_habitacion], [id_reserva], [fecha_entrada], [fecha_salida], [precio]) VALUES (8, 10, 6, CAST(N'2019-03-18' AS Date), CAST(N'2019-03-21' AS Date), 500.0000)
SET IDENTITY_INSERT [dbo].[habitacion_reserva] OFF
SET IDENTITY_INSERT [dbo].[huesped] ON 

INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (1, N'Juan', N'Jose', N'Lopez', N'Mendoza', N'12565 Reghan St.', N'0051414899', N'Nicaraguense', N'juanlopez@aol.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (2, N'Maria', N'Alejandra', N'Jerez', N'Mendez', N'564 Union Av.', N'0088947476', N'Mexicano', N'marjerez@hotmail.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (3, N'Pepito', N'Jaime', N'Perez', N'Garcia', N'7848 Longhorn & Vista Rd.', N'7894514899', N'Hondureño', N'peperez@aol.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (4, N'Vanessa', N'Lucia', N'Mejia', N'Avendaño', N'5567 Calle 8.', N'1526047893', N'Español', N'lucia_mejia15@yahoo.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (5, N'Ana', N'Conda', N'Juarez', N'Soza', N'141 Union Rd.', N'7894514799', N'Costarricense', N'anaconda@yahoo.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (6, N'Juan', N'Alberto', N'Lopez', N'Gasca', N'12565 Reghan St.', N'0051414899', N'Nicaraguense', N'juancho@aol.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (7, N'Guadalupe', N'Sofia', N'Gutierrez', N'Mendez', N'564 Union Av.', N'0088947476', N'Nicaraguense', N'exempl@gmail.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (8, N'Jose', N'Roberto', N'Norori', N'Guillen', N'7848 Longhorn & Vista Rd.', N'7894514899', N'Nicaraguense', N'joseguillen@hotmail.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (9, N'Hellen', N'del Carmen', N'Mejia', N'Avendaño', N'5567 Calle 8.', N'1526047893', N'Español', N'carmelaxd@live.com')
INSERT [dbo].[huesped] ([id_huesped], [p_nom], [s_nom], [p_apell], [s_apell], [direccion], [tel], [nacionalidad], [correo]) VALUES (10, N'Julia', N'del Socorro', N'Juarez', N'Soza', N'141 Union Rd.', N'7894514799', N'Americano', N'julitasalvame@outlook.com')
SET IDENTITY_INSERT [dbo].[huesped] OFF
SET IDENTITY_INSERT [dbo].[reserva] ON 

INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (1, 1, 1, CAST(N'2019-02-15' AS Date), N'CONTADO', N'NIO', N'PAGADO')
INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (2, 2, 1, CAST(N'2019-02-28' AS Date), N'CREDITO', N'USD', N'RESERVADO')
INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (3, 3, 2, CAST(N'2019-02-01' AS Date), N'CHEQUE', N'USD', N'PENALIZADO')
INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (4, 4, 3, CAST(N'2019-03-02' AS Date), N'CONTADO', N'EUR', N'CANCELADO')
INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (5, 5, 2, CAST(N'2019-03-11' AS Date), N'CREDITO', N'USD', N'RESERVADO')
INSERT [dbo].[reserva] ([id_reserva], [id_cliente], [id_empleado], [fecha_reserva], [forma_pago], [divisa], [stat]) VALUES (6, 1, 3, CAST(N'2019-03-17' AS Date), N'CONTADO', N'NIO', N'RESERVADO')
SET IDENTITY_INSERT [dbo].[reserva] OFF
SET IDENTITY_INSERT [dbo].[servicio] ON 
SET IDENTITY_INSERT [dbo].[Usuario_Sistema]off

INSERT [dbo].[servicio] ([id_servicio], [descr], [precio]) VALUES (1, N'Desayuno al cuarto', 60.0000)
INSERT [dbo].[servicio] ([id_servicio], [descr], [precio]) VALUES (2, N'Almuerzo al cuarto', 70.0000)
INSERT [dbo].[servicio] ([id_servicio], [descr], [precio]) VALUES (3, N'Lavado de ropa', 40.0000)
INSERT [dbo].[servicio] ([id_servicio], [descr], [precio]) VALUES (4, N'Bebidas alcoholicas', 50.0000)
INSERT [dbo].[servicio] ([id_servicio], [descr], [precio]) VALUES (5, N'Internet dedicado', 30.0000)
SET IDENTITY_INSERT [dbo].[servicio] OFF
INSERT [dbo].[tipo_habitacion] ([cod_tipo], [nom_tipo], [precio]) VALUES (10, N'Basica', 150.0000)
INSERT [dbo].[tipo_habitacion] ([cod_tipo], [nom_tipo], [precio]) VALUES (11, N'Ejecutiva', 200.0000)
INSERT [dbo].[tipo_habitacion] ([cod_tipo], [nom_tipo], [precio]) VALUES (12, N'Presidencial', 500.0000)
SET IDENTITY_INSERT [dbo].[Usuario_Sistema] ON 


ALTER TABLE [dbo].[cargos_servicios]  WITH CHECK ADD FOREIGN KEY([id_hab_reserva])
REFERENCES [dbo].[habitacion_reserva] ([id_hab_reserva])
GO
ALTER TABLE [dbo].[cargos_servicios]  WITH CHECK ADD FOREIGN KEY([id_servicio])
REFERENCES [dbo].[servicio] ([id_servicio])
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Factura] ([IDFactura])
GO
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD FOREIGN KEY([IdServicio])
REFERENCES [dbo].[servicio] ([id_servicio])
GO
ALTER TABLE [dbo].[habitacion]  WITH CHECK ADD FOREIGN KEY([cod_tipo])
REFERENCES [dbo].[tipo_habitacion] ([cod_tipo])
GO
ALTER TABLE [dbo].[habitacion_reserva]  WITH CHECK ADD FOREIGN KEY([id_reserva])
REFERENCES [dbo].[reserva] ([id_reserva])
GO
ALTER TABLE [dbo].[habitacion_reserva]  WITH CHECK ADD FOREIGN KEY([no_habitacion])
REFERENCES [dbo].[habitacion] ([no_habitacion])
GO
ALTER TABLE [dbo].[huesped_hab_reserva]  WITH CHECK ADD FOREIGN KEY([id_hab_reserva])
REFERENCES [dbo].[habitacion_reserva] ([id_hab_reserva])
GO
ALTER TABLE [dbo].[huesped_hab_reserva]  WITH CHECK ADD FOREIGN KEY([id_huesped])
REFERENCES [dbo].[huesped] ([id_huesped])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Usuario_Sistema]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Sistema_empleado] FOREIGN KEY([id_Empleado])
REFERENCES [dbo].[empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Usuario_Sistema] CHECK CONSTRAINT [FK_Usuario_Sistema_empleado]
GO
ALTER TABLE [dbo].[habitacion]  WITH CHECK ADD  CONSTRAINT [CK_VAL_hab_stat] CHECK  (([stat]='DISPONIBLE' OR [stat]='RESERVADA' OR [stat]='OCUPADA'))
GO
ALTER TABLE [dbo].[habitacion] CHECK CONSTRAINT [CK_VAL_hab_stat]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [CK_VAL_res_formapago] CHECK  (([forma_pago]='CHEQUE' OR [forma_pago]='CONTADO' OR [forma_pago]='CREDITO'))
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [CK_VAL_res_formapago]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [CK_VAL_res_stat] CHECK  (([stat]='PENALIZADO' OR [stat]='CANCELADO' OR [stat]='RESERVADO' OR [stat]='PAGADO'))
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [CK_VAL_res_stat]
GO
/****** Object:  StoredProcedure [dbo].[Buscar_Cliente]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Buscar_Cliente]
	 @dato varchar(20)
	 as
	 Select
 id_cliente as Id_Cliente,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 tel as Teléfono,
 estado as Estado
 from Cliente c
 where c.p_nom like @dato + '%' 
 or  c.s_nom like @dato + '%' 
 or  c.p_apell like @dato + '%' 
  or  c.s_apell like @dato + '%' 
GO
/****** Object:  StoredProcedure [dbo].[CambioEstado]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[CambioEstado] @IdCliente int
as
Declare @Estado varchar(25)
set @Estado = (Select Estado from Cliente where
                Id_Cliente = @IdCliente)

				if(@Estado = 'Habilitado')
				Begin
				update Cliente set Estado = 'Deshabilitado'
				where Id_Cliente = @IdCliente
			    End
				Else
				Begin 
				update Cliente set Estado = 'Habilitado'
				where Id_Cliente = @IdCliente
				End
GO
/****** Object:  StoredProcedure [dbo].[Editar_Cliente]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create procedure [dbo].[Editar_Cliente]
	 @idcliente int,
	 @primernombre varchar(15),
     @segundonombre varchar(15),
     @primerapellido varchar(15),
     @segundoapellido varchar(15),
	 @direccion varchar(90),
	 @correo varchar(40),
	 @telefono varchar(20)
	 as
	 update Cliente set 
	 p_nom =  @primernombre,
	 s_nom = @segundonombre,
	 p_apell = @primerapellido,
	 s_apell =  @segundoapellido,
	 direccion = @direccion,
	 correo = @correo,
	 tel = @telefono
	 where id_cliente = @idcliente
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Cliente]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Insertar_Cliente]
 @primernombre varchar(15),
  @segundonombre varchar(15),
   @primerapellido varchar(15),
    @segundoapellido varchar(15),
	 @direccion varchar(90),
	 @correo varchar(40),
	 @telefono varchar(20)
	 as
	 insert into Cliente values (@primernombre,@segundonombre,@primerapellido, @segundoapellido,
	    @direccion, @telefono, @correo, 'Habilitado' )
GO
/****** Object:  StoredProcedure [dbo].[Insertar_DetalleFactura]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create procedure [dbo].[Insertar_DetalleFactura]
  @IdFactura int,
  @IdServicio int,
  @Precio float,
  @Cantidad float
  as
  insert into DetalleFactura values (@IdFactura,
  @IdServicio,@Precio, @Cantidad)

GO
/****** Object:  StoredProcedure [dbo].[Insertar_Factura]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Insertar_Factura]
  @IdUsuario int,
  @IdCliente int
  as
  Declare @IdFactura int
  Insert into Factura 
  values(getdate(), @IdUsuario, @IdCliente)
  set @IdFactura = @@IDENTITY
  Select @IdFactura as IDFACTURA
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Usuario]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


SET IDENTITY_INSERT [dbo].[Usuario_Sistema]off
go

CREATE procedure [dbo].[Insertar_Usuario]
 @usuario varchar(50), @contraseña varchar(50), @rol varchar(50), @id_Empleado int
 as
 insert into Usuario_sistema(usuario, contraseña, rol, estado, ID_empleado) values
 (@usuario, ENCRYPTBYPASSPHRASE( @contraseña,  @contraseña), @rol, 'Habilitado', @id_Empleado)
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Cliente]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Mostrar_Cliente]
as
Select
 id_cliente as Id_Cliente,
 c.p_nom as [Primer Nombre],
 c.s_nom as [Segundo Nombre],
 c.p_apell as [Primer Apellido],
 c.s_apell as [Segundo Apellido],
 direccion as Dirección,
 correo as Correo,
 
 tel as Teléfono,
 Estado as Estado
 from Cliente c
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Factura]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create procedure [dbo].[Mostrar_Factura] @IdFactura int
  as
  Declare @NombreUsuario varchar(80), @NombreCliente varchar(80), @Fecha date
  Declare @SubTotal float, @Total float

  set @NombreUsuario = (  Select e.p_nom + ' '+e.p_apell from 
  Usuario_Sistema us inner join empleado e
  on e.id_empleado = us.id_empleado
  inner join Factura f
  on f.IdUsuario = us.idUsuario
  where f.IDFactura = @IdFactura)
  set @NombreCliente = (Select c.p_nom + ' ' + c.p_apell from Factura f
  inner join cliente c
  on c.id_cliente = f.IdCliente
  where f.IDFactura = @IdFactura)
  set @Fecha = (Select Factura.Fecha from Factura where Factura.IDFactura = @IdFactura)
  
   set @SubTotal = (Select sum(df.Precio * df.Cantidad) as SubTotal  from DetalleFactura df
  inner join servicio s
  on s.id_servicio = df.IdServicio
  where df.IdFactura = @IdFactura)
  set @Total = @SubTotal *1.15
 Select @Fecha, @NombreUsuario, @NombreCliente, s.id_servicio, s.descr, df.Precio, df.Cantidad, (df.Precio * df.Cantidad) as SubTotal, @SubTotal, @Total  
 from DetalleFactura df
  inner join servicio s
  on s.id_servicio = df.IdServicio
  where df.IdFactura =@IdFactura
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Servicio]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Mostrar_Servicio]
as
Select 
Id_Servicio as IDServicio,
Descr   as Descripcion,
precio as Precio
from Servicio
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Usuario]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Mostrar_Usuario]
as
Select
idUsuario as IdUsuario,
usuario as Usuario,
contraseña as Contraseña,
Rol as Rol,
Estado as Estado
 from usuario_Sistema
GO
/****** Object:  StoredProcedure [dbo].[Validar_Acceso]    Script Date: 16/10/2021 12:07:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Validar_Acceso]
@usuario varchar(50),
@contraseña varchar(50)
as
if exists (Select usuario from Usuario_sistema
            where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado' )
			 select 'Acceso Exitoso' as Resultado,
			 (Select Rol from Usuario_sistema
              where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado') as Rol,
			  (Select IdUsuario from Usuario_sistema
              where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado') as IdUsuario,
			  (Select usuario from Usuario_sistema
              where  cast (DECRYPTBYPASSPHRASE(@contraseña, contraseña) as Varchar(100)) = @contraseña
			 and usuario = @Usuario and Estado = 'Habilitado') as Usuario
			 else
			 Select 'Acceso Denegado' as Resultado
GO
USE [master]
GO
ALTER DATABASE [NuevoHotel] SET  READ_WRITE 
GO
