
Create login HotelAdmin
with password = 'sistemas123'
sp_adduser Hoteladmin, Hoteladmin

sp_addrolemember db_owner, Hoteladmin

Execute Insertar_Usuario
'Uni', 'sistemas', 'Administrador', 2

CREATE procedure Mostrar_Empleado
as
SELECT TOP (50) [id_empleado]
      ,[p_nom] as [Primer Nombre]
      ,[s_nom] as [Segundo Nombre]
      ,[p_apell] as [Primer Apellido]
      ,[s_apell] as [Segundo Apellido]
      ,[direccion] as Dirección
      ,[tel] as Teléfono
      ,[correo] as Correo,
	  Estado as Estado
  FROM [NuevoHotel].[dbo].[empleado]

alter procedure Buscar_Empleado
@Dato varchar(60)
as
SELECT TOP (50) [id_empleado]
      ,[p_nom] as [Primer Nombre]
      ,[s_nom] as [Segundo Nombre]
      ,[p_apell] as [Primer Apellido]
      ,[s_apell] as [Segundo Apellido]
      ,[direccion] as Dirección
      ,[tel] as Teléfono
      ,[correo] as Correo,
	  Estado as Estado
  FROM [NuevoHotel].[dbo].[empleado]
  where
  [p_nom] like @Dato + '%' or
  s_nom like @Dato + '%' or
  p_apell like @Dato + '%' or
  s_apell like @Dato + '%' or
  correo like @Dato + '%' or
  tel like @Dato + '%' 

select * from Usuario_Sistema
  Create procedure EstadoEmpleado
  @idEmpleado int
  as
  if((Select estado from Empleado where Id_Empleado = @idEmpleado) = 'Habilitado')
    update Empleado set Estado = 'Deshabilitado' where Id_Empleado = @idEmpleado
	else
	 update Empleado set Estado = 'Habilitado' where Id_Empleado = @idEmpleado

  Select * from Empleado
  Alter table Empleado
  add Estado varchar(60)
  go
  update Empleado set Estado = 'Habilitado'

  Create procedure Insertar_Empleado
  @primernombre varchar(60),
  @segundonombre  varchar(60),
  @primerapellido varchar(60),
  @segundoapellido varchar(60),
  @direccion varchar(100),
 @telefono varchar(60),
  @correo varchar(60)
  as
  Insert into Empleado values
  (@primernombre, @segundonombre, @primerapellido, @segundoapellido, @direccion,
  @telefono, @correo, 'Habilitado')

    Create procedure Editar_Empleado
 @idempleado int,
  @primernombre varchar(60),
  @segundonombre  varchar(60),
  @primerapellido varchar(60),
  @segundoapellido varchar(60),
  @direccion varchar(100),
 @telefono varchar(60),
  @correo varchar(60)
  as
    update Empleado set p_nom = @primernombre,
	                    s_nom = @segundonombre, 
						p_apell = @primerapellido,
						s_apell =  @segundoapellido,
						direccion = @direccion,
						tel =   @telefono, 
						correo =@correo

						where Id_Empleado = @idempleado

  Select * from Empleado
  