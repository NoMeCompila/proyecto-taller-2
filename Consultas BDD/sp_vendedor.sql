								--! PROCEDIMIENTOS ALMACENADOS PARA EL VENDEDOR --

-- * Procedimiento almacenado para guardar un nuevo cliente
CREATE PROC sp_guardar_cliente
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE
AS
	INSERT INTO Cliente(nombre, apellido, dni, email, telefono, direccion, fecha_nac)
	VALUES (@nombre, @apellido, @dni, @email, @tel, @direccion, @fecha_nac)
GO

-- * Procedimiento almacenado para actualizar un cliente
CREATE PROC sp_actualizar_cliente
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@id_cliente INT
AS
UPDATE Cliente 
SET
	nombre = @nombre,
	apellido = @apellido,
	dni = @dni,
	email = @email,
	telefono = @tel,
	direccion = @direccion,
	fecha_nac = @fecha_nac
WHERE id_cliente = @id_cliente
GO

-- TODO: este procedimiento es para mostrar los datos en vendedor, es decir solo están los activos
-- todo:  ademas se muestra las columnas con alias para mejor visibilidad
CREATE PROC sp_mostrar_clientes_activos
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
	WHERE Cliente.estado = 1
GO

-- * Procedimiento almacenado para eliminar lógicamente a un cliente desde el perfil vendedor
CREATE PROC sp_cliente_inactivo
@id_cliente INT
AS
	UPDATE Cliente SET estado = 0 
	WHERE id_cliente = @id_cliente
GO