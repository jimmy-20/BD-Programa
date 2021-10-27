CREATE LOGIN AdminSistemas	with password = 'Sistemas123'

CREATE ROLE Administracion

sp_adduser AdminSistemas, AdminSistemas

sp_addrolemember Administracion, AdminSistemas
sp_addrolemember Vendedor, AdminSistemas
sp_addrolemember Facturador, AdminSistemas


GRANT EXECUTE ON Validar_Acceso to AdminSistemas

--Seguridad de nivel de SQL SERVER

--Sirve para darle acceso al usuario el procedimiento almacenado dado
GRANT EXECUTE ON Mostrar_Cliente to AdminSistemas


GRANT EXECUTE ON Schema: DBO to Administracion

SELECT @@SERVERNAME

SELECT * FROM Usuario_Sistema


Execute Insertar_Usuario 'Vee','Ve','Administrador',4
Execute Insertar_Usuario '2M1','sistemas123','Facturador',1

 /*
 Ve = Vendedor
 Ad = Admin
 Fa = Facturacion
 */

SELECT * FROM Usuario_Sistema
SELECT * FROM empleado

INSERT INTO empleado VALUES
('Pedro','Alexander','Aburto','Ortiz','Guayacanes','78029722','Pedrou@gmail.com')
INSERT INTO  empleado VALUES 
('Alice','Paola','Rosales','Sandino','Calle 43','78229088','alyssaneva@hotmail.com')

--Codigos
sp_droprolemember 