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






									-- TODO: CLIENTES 2.0

-- * Procedimiento almacenado para Registrar un nuevo cliente
CREATE proc sp_registrar_cliente
	--variables para almacenar
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT,

	--mensajes y salida
	@resultado int OUTPUT,
	@mensaje varchar(500) OUTPUT
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''

	IF exists (select * from Cliente where dni = @dni)
		SET @mensaje = 'El DNI ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Cliente where email = @email)
		SET @mensaje = 'El correo ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Cliente where telefono = @tel)
		SET @mensaje = 'El teléfono ya se encuentra registrado en el sistema, intente de nuevo'
	ELSE
	BEGIN
		INSERT INTO Cliente(nombre, apellido, dni, email, telefono, direccion, fecha_nac, estado)
		VALUES (@nombre, @apellido, @dni, @email, @tel, @direccion, @fecha_nac,@estado)
		SET @resultado = SCOPE_IDENTITY()
	END
END
GO

--todo Funciona
-- !Probando procedimiento almacenado para gaurdar cliente

/*
DECLARE @resultado int
DECLARE @mensaje varchar(500)

EXEC sp_registrar_cliente 
	'otroTest','Testing2',
	
	'39393939', 
	't2@gmail.com',
	'88988889',
	
	'Calle 123','1998-02-01',1,@resultado output, @mensaje output


SELECT @resultado
SELECT @mensaje

select * from Cliente
*/

-- * Procedimiento almacenado para actualizar un cliente
CREATE proc sp_update_cliente(
	--variables para almacenar
	@id_cliente int,
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT,

	--mensajes y salida
	@resultado bit OUTPUT,
	@mensaje varchar(500) OUTPUT)
AS
	BEGIN
	SET @resultado = 0
	SET @mensaje = ''

	IF exists (select * from Cliente where dni = @dni and id_cliente != @id_cliente)
		SET @mensaje = 'El DNI ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Cliente where email = @email and id_cliente != @id_cliente)
		SET @mensaje = 'El correo ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Cliente where telefono = @tel and id_cliente != @id_cliente)
		SET @mensaje = 'El teléfono ya se encuentra registrado en el sistema, intente de nuevo'
	ELSE
	BEGIN
		update Cliente SET
		nombre =  @nombre, 
		apellido = @apellido, 
		dni = @dni, 
		email = @email, 
		telefono = @tel, 
		direccion = @direccion, 
		fecha_nac = @fecha_nac, 
		estado = @estado
		WHERE id_cliente = @id_cliente
		SET @resultado = 1
	END
END
GO



--todo Funciona
-- !Probando procedimiento almacenado para gaurdar cliente
/*
DECLARE @resultado BIT
DECLARE @mensaje varchar(500)
EXEC sp_update_cliente 
	5012,
	'otroTest','Testing2',
	
	'1111111', 
	't3@gmail.com',
	'3794923799',
	
	'Calle 123','1998-02-01',1,@resultado output, @mensaje output

SELECT @resultado
SELECT @mensaje
*/

-- * PROCEDIMIENTO ALMACENADO PARA ELIMINAR UN CLIENTE LÓGICAMENTE

CREATE proc sp_delete_cliente(
	--variables para almacenar
	@id_cliente int,

	--mensajes y salida
	@resultado bit OUTPUT,
	@mensaje varchar(500) OUTPUT)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	DECLARE @pasoreglas bit = 1

	IF exists (select C.dni from Ventas V  inner join Cliente C on V.id_cliente = C.id_cliente WHERE C.id_cliente = @id_cliente)
		begin
			SET @pasoreglas = 0
			SET @resultado = 0
			SET @mensaje = 'No se puede eliminar porque el cliente se encuentra relacionado a una venta, intente de nuevo'
		END
	
	IF (@pasoreglas = 1)
		begin 
			DELETE FROM Cliente WHERE id_cliente = @id_cliente
			SET @resultado = 1
		END
END
GO


/*
PROBANDO Y FUNCIONA
select * FROM ventas
select * FROM Cliente

DECLARE @resultado BIT
DECLARE @mensaje varchar(500)

EXEC sp_delete_cliente 1, @resultado output, @mensaje output

select @resultado as bitResutado
select @mensaje as mensaje
*/

										--todo: Empleados/Usuarios

--select * from Usuario
-- * Procedimiento almacenado para Registrar un nuevo usuario
ALTER proc sp_registrar_usuario
	--variables para almacenar
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@usuario VARCHAR(100),
	@contra VARCHAR(100),
	@email VARCHAR(100),
	@perfil	INT,
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT,

	--mensajes y salida
	@resultado int OUTPUT,
	@mensaje varchar(500) OUTPUT
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''

	IF exists (select * from Usuario where dni = @dni)
		SET @mensaje = 'El DNI ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where email = @email)
		SET @mensaje = 'El correo ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where telefono = @tel)
		SET @mensaje = 'El teléfono ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where usuario = @usuario)
		SET @mensaje = 'El usuario ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where [Password] = @contra)
		SET @mensaje = 'La contraseña ya se encuentra registrada en el sistema, intente de nuevo'
	
	ELSE
	BEGIN
		INSERT INTO Usuario(nombre, apellido, dni,usuario,[Password], email,id_perfil, telefono, direccion, fecha_nac, estado)
		VALUES (@nombre, @apellido, @dni,@usuario,@contra, @email,@perfil, @tel, @direccion, @fecha_nac,@estado)
		SET @resultado = SCOPE_IDENTITY()
	END
END
GO

-- ! Probando y funciona
/*
SELECT * FROM usuario
DECLARE @resultado int
DECLARE @mensaje varchar(100)
EXECUTE sp_registrar_usuario 'Deto','bicampeon','35885588','DetoMC','Detx123!','deto@mc.com',1,'3784778888','brocoli  123','1990-09-05',2,@resultado output, @mensaje output
SELECT @resultado
SELECT @mensaje
*/

-- * Procedimiento almacenado para actualizar un usuario
CREATE proc sp_update_usuario(
	--variables para almacenar
	@id_usuario INT,
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@usuario VARCHAR(100),
	@contra VARCHAR(100),
	@email VARCHAR(100),
	@perfil	INT,
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT,

	--mensajes y salida
	@resultado bit OUTPUT,
	@mensaje varchar(500) OUTPUT)
AS
	BEGIN
	SET @resultado = 0
	SET @mensaje = ''

	IF exists (select * from Usuario where dni = @dni and id_usuario != @id_usuario)
		SET @mensaje = 'El DNI ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where email = @email and id_usuario != @id_usuario)
		SET @mensaje = 'El correo ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where telefono = @tel and id_usuario != @id_usuario)
		SET @mensaje = 'El teléfono ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where usuario = @usuario and id_usuario != @id_usuario)
		SET @mensaje = 'El usuario ya se encuentra registrado en el sistema, intente de nuevo'
	IF exists (select * from Usuario where [Password] = @contra and id_usuario != @id_usuario)
		SET @mensaje = 'La contraseña ya se encuentra registrada en el sistema, intente de nuevo'
	ELSE
	BEGIN
		update Usuario SET
		nombre =  @nombre, 
		apellido = @apellido, 
		dni = @dni,
		usuario = @usuario,
		[Password] = @contra,
		email = @email,
		id_perfil = @perfil, 
		telefono = @tel, 
		direccion = @direccion, 
		fecha_nac = @fecha_nac, 
		estado = @estado
		WHERE id_usuario = @id_usuario
		SET @resultado = 1
	END
END
GO

--! Probando y funciona
/*
select * from Usuario
DECLARE @resultado BIT
DECLARE @mensaje VARCHAR(100)
EXECUTE sp_update_usuario 14, 'Deto','bicampeon','35885588','Lenteja','Detx123!','deto@mc.com',1,'3784778888','brocoli  123','1990-09-05',2,@resultado output, @mensaje output
SELECT @resultado
SELECT @mensaje
*/

create proc sp_delete_usuario(
	--variables para almacenar
	@id_usuario int,

	--mensajes y salida
	@resultado bit OUTPUT,
	@mensaje varchar(500) OUTPUT)
AS
BEGIN
	SET @resultado = 0
	SET @mensaje = ''
	DECLARE @pasoreglas bit = 1

	IF exists (select U.dni from Ventas V  inner join Usuario U on V.id_cliente = U.id_usuario WHERE U.id_usuario = @id_usuario)
		begin
			SET @pasoreglas = 0
			SET @resultado = 0
			SET @mensaje = 'No se puede eliminar porque el usuario se encuentra relacionado a una venta, intente de nuevo'
		END
	
	IF (@pasoreglas = 1)
		begin 
			DELETE FROM Usuario WHERE id_usuario = @id_usuario
			SET @resultado = 1
		END
END
GO

--! Probando Y FUNCIONANDO 

/*
select * from Usuario

DECLARE @resultado BIT
DECLARE @mensaje VARCHAR(100)
EXEC sp_delete_usuario 1,@resultado output, @mensaje output
SELECT @resultado
SELECT @mensaje
*/