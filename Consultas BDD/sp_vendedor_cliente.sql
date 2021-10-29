--PROCEDIMIENTOS ALMACENADOS

--PROCEDIMIENTO ALMACENADO PARA MOSTRAR DATOS 
CREATE PROC sp_mostrar_clientes
AS
SELECT * FROM Cliente;
GO
-- prueba EXEC sp_mostrar_clientes;

--PROCEDIMIENTO ALMACENADO PARA INSERTAR UN DATO
CREATE PROC sp_guardar_cliente
@nombre VARCHAR(100),
@apellido VARCHAR(100),
@dni VARCHAR(8),
@email VARCHAR(100),
@tel VARCHAR(15),
@direccion VARCHAR(100),
@fecha_nac DATE
AS
INSERT INTO Cliente
VALUES (@nombre, @apellido, @dni, @email, @tel, @direccion, @fecha_nac)
GO

/*probando procedimiento almacenado para insertar
EXEC sp_guardar_cliente 'Elena', 'Cherey', '27889989', 'elen@gmail.com', '3794923784', 'Salta 1400', '1972-01-12'
EXEC sp_mostrar_clientes
*/

--PROCEDIMIENTO ALMACENADO PARA ACTUALIZAR UN DATO
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

/*probando procedimiento almacenado para actualizar un cliente
EXEC sp_actualizar_cliente 'Fernando', 'Caballero', '40982473', 'cabaf1@gmail.com', '3794006302', 'Pje Florida 228', '1998-01-24', 1
EXEC sp_mostrar_clientes
*/


--PROCEDIMIENTO ALMACENADO PARA ELIMINAR UN DATO
CREATE PROC sp_eliminar_cliente
@id_cliente INT
AS
delete from Cliente WHERE id_cliente = @id_cliente
GO
/*probando procedimiento almacenado para ELIMINAR un cliente
exec sp_eliminar_cliente 6
EXEC sp_mostrar_clientes
*/
select * from Cliente;


