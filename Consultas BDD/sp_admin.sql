                    -- ! PROCEDIMIENTOS ALMACENADOS PARA EL PERFIL ADMINISTRADOR --

                                            -- TODO: CLIENTES

--PROCEDIMIENTO ALMACENADO PARA MOSTRAR DATOS 
-- todo: este  procedimienmto almacenado es solo usado por
-- todo: el administrador ya que puede ver a todos los usuarios activops e inactivos

-- ? los procedimientos almacenados para actualizar y guardar se comparten con un perfil vendedor
-- ? es decir se encuentran en el archivo sp_vendedor_clientes.sql

-- * Procedimiento almacenado para mostrar a todos los clientes y poner un alias a sus columnas
-- ! ESTE PROCEDIMIENTO ALMACENADO SOLO PUEDE SER USADO POR UN ADMIN
CREATE PROC sp_mostrar_clientes
AS
	SELECT 
		Cliente.id_cliente as ID,
		Cliente.nombre AS NOMBRE,
		Cliente.apellido AS APELLIDO,
		Cliente.dni AS DNI,
		Cliente.email AS EMAIL,
		Cliente.telefono AS TELÉFONO,
		Cliente.direccion AS DIRECCIÓN,
		Cliente.fecha_nac AS "FECHA NACIMIENTO"
	FROM Cliente
GO

-- * Procedimiento almacenado para eliminar físicamente a un cliente
-- ! ESTE PROCEDIMIENTO ALMACENADO SOLO PUEDE SER USADO POR UN ADMIN
CREATE PROC sp_eliminar_cliente
@id_cliente INT
AS
DELETE FROM Cliente WHERE id_cliente = @id_cliente
GO

                                         -- TODO: USUASRIOS

-- * Procedimiento almacenado para listar los perfiles de usuario
CREATE PROC sp_listar_perfiles
AS
    SELECT * FROM Perfil
GO

-- * Procedimiento almacenado para listar a los usuarios y su perfil mediante un inner join
CREATE PROC sp_listar_usuarios
AS
    SELECT 
        us.id_usuario AS ID,
        us.nombre AS NOMBRE,
        us.apellido AS APELLIDO,
        us.dni AS DNI,
        us.usuario AS USUARIO,
        us.[Password] AS CONTRASEÑA,
        per.descripcion AS PERFIL,
        us.email AS EMAIL,
        us.telefono AS TELÉFONO,
        us.direccion AS DIRECCIÓN,
        us.fecha_nac AS "FECHA NACIMIENTO"
    FROM Usuario us INNER JOIN Perfil per
    ON us.id_perfil = per.id_perfil
GO

-- * Procedimiento almacenado para guardar a un nuevo usuario/empleado en el sistema como administrador
CREATE PROC sp_guardar_usuario
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
    @usuario VARCHAR(100),
    @contra VARCHAR(100),
	@email VARCHAR(100),
    @id_perfil int,
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE
AS
	INSERT INTO Usuario(nombre, apellido, dni, usuario, [Password], email,  id_perfil, telefono, direccion, fecha_nac)
	VALUES (@nombre, @apellido, @dni, @usuario, @contra, @email, @id_perfil, @tel, @direccion, @fecha_nac)
GO

-- * Procedimiento almacenado para actualizar un usuario desde el perfil Administrador
CREATE PROC sp_actualizar_usuario
    @nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
    @usuario VARCHAR(100),
    @contra VARCHAR(100),
	@email VARCHAR(100),
    @id_perfil INT,
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@id_usuario INT
AS
UPDATE Usuario 
SET
	nombre = @nombre,
	apellido = @apellido,
	dni = @dni,
    usuario = @usuario,
    Password = @contra,
	email = @email,
    id_perfil = @id_perfil,
	telefono = @tel,
	direccion = @direccion,
	fecha_nac = @fecha_nac
WHERE id_usuario= @id_usuario
GO

-- * Procedimiento almacenado para eliminar físicamente a un usuario desde el perfil de administrador
CREATE PROC sp_eliminar_usuario
    @id_usuario INT
AS
    DELETE FROM Usuario WHERE id_usuario = @id_usuario
GO

								-- TODO: PRODUCTOS

-- * Procedimiento almacenado para ver los productos