--PROCEDIMIENTO ALMACENADO PARA MOSTRAR DATOS 
-- todo: este  procedimienmto almacenado es solo usado por
-- todo: el administrador ya que puede cver toedo

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

-- * PROCEDIMIENTO ALMACENADO PARA ELIMINAR UN DATO
-- ! ESTE PROCEDIMIENTO ALMACENADO SOLO PUEDE SER USADO POR UN ADMIN
CREATE PROC sp_eliminar_cliente
@id_cliente INT
AS
delete from Cliente WHERE id_cliente = @id_cliente
GO