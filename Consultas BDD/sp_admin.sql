                    -- ! PROCEDIMIENTOS ALMACENADOS PARA EL PERFIL ADMINISTRADOR --

                                            -- TODO: CLIENTES

--PROCEDIMIENTO ALMACENADO PARA MOSTRAR DATOS 
-- todo: este  procedimienmto almacenado es solo usado por
-- todo: el administrador ya que puede ver a todos los usuarios activops e inactivos

-- ? los procedimientos almacenados para actualizar y guardar se comparten con un perfil vendedor
-- ? es decir se encuentran en el archivo sp_vendedor_clientes.sql


-- * procedimiento almacenado para guardar un nuevo cliente

CREATE PROC sp_guardar_cliente_admin
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT
AS
	INSERT INTO Cliente(nombre, apellido, dni, email, telefono, direccion, fecha_nac, estado)
	VALUES (@nombre, @apellido, @dni, @email, @tel, @direccion, @fecha_nac, @estado)
GO

-- * Procedimiento almacenado para actualizar un cliente desde administrador

-- * Procedimiento almacenado para actualizar un cliente
CREATE PROC sp_actualizar_cliente_admin
	@nombre VARCHAR(100),
	@apellido VARCHAR(100),
	@dni VARCHAR(8),
	@email VARCHAR(100),
	@tel VARCHAR(15),
	@direccion VARCHAR(100),
	@fecha_nac DATE,
	@estado BIT,
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
	fecha_nac = @fecha_nac,
	estado = @estado
WHERE id_cliente = @id_cliente
GO

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
	@id_usuario INT --para saber a que usuario se quiere actualizar
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


-- * Procedimiento almacenado para msotrar als categorias
CREATE PROC sp_mostrar_categorias
AS
SELECT * FROM
Categoria
GO

-- * Procedimeinto almacenado para guardar un prodcuto
CREATE PROC sp_guardar_producto
	@fk_id_categoria INT,
	@cod_producto VARCHAR(100),
	@nombre VARCHAR(100),
    @stock INT,
    @precio_costo MONEY,
	@precio_venta MONEY,
    @marca VARCHAR(100),
	@genero VARCHAR(100),
	@material VARCHAR(100),
	@gema VARCHAR(100),
	@estado bit
AS
	INSERT INTO Producto(fk_id_categoria, cod_producto, nombre,stock, 
	precio_costo,precio_venta, marca, genero, material, gema, estado)
	
	VALUES (@fk_id_categoria, @cod_producto, @nombre,@stock, @precio_costo,
	  		@precio_venta, @marca, @genero, @material, @gema, @estado)
GO

-- * Procfedimiento almacenado para actualizar un producto desde administrador
CREATE PROC sp_actualizar_producto
    @fk_id_categoria INT,
	@cod_producto VARCHAR(100),
	@nombre VARCHAR(100),
    @stock INT,
    @precio_costo MONEY,
	@precio_venta MONEY,
    @marca VARCHAR(100),
	@genero VARCHAR(100),
	@material VARCHAR(100),
	@gema VARCHAR(100),
	@estado BIT,
	@id_producto INT
AS
UPDATE Producto 
SET
	fk_id_categoria = @fk_id_categoria,
	cod_producto = @cod_producto,
	nombre = @nombre,
    stock = @stock,
    precio_costo = @precio_costo,
	precio_venta =@precio_venta,
    marca = @marca,
	genero =@genero,
	material = @material,
	gema = @gema,
	estado = @estado
WHERE id_producto = @id_producto 
GO

-- * Procedimiento almacenado para eliminar un producto

CREATE PROC sp_eliminar_producto
	@id_producto INT
AS
	DELETE FROM Producto WHERE id_producto = @id_producto 
GO

select * from Producto


/*
select * from Venta;
exec sp_help Venta;
nro_venta
id_v_detalle
id_t_pago
id_cliente
id_usuario
fecha_venta
total_venta
*/




/*
select * from VentaDetalle;
exec sp_help Venta;
nro_venta
id_v_detalle
id_t_pago
id_cliente
id_usuario
fecha_venta
total_venta

ventadetalle pasa a ser ventas
venta pasa a ser VentaDetalle
*/

exec sp_rename 'VentaDetalle', 'Ventas';

exec sp_rename 'Venta', 'VntaDetalle';
exec sp_rename 'VntaDetalle', 'VentaDetalle';


--traspasar sus columnas
--primero eliminar todos sus datos


select * FROM Ventas;

EXEC SP_RENAME 'Ventas.id_v_detalle', 'id_venta', 'COLUMN'

EXEC SP_RENAME 'VentaDetalle.nro_venta', 'id_detalle', 'COLUMN'

EXEC SP_RENAME 'VentaDetalle.id_v_detalle', 'id_venta', 'COLUMN'


alter table VentaDetalle 
	add id_producto int not null,
	constraint fk_producto foreign key (id_producto) references Producto(id_producto)


select * from VentaDetalle;

alter table VentaDetalle

	add sub_total money 


select * from Ventas;

alter table Ventas
drop CK__VentaDeta__canti__4F7CD00D

alter table Ventas
drop column  cantidad

alter table ventas
drop CK__VentaDeta__preci__5070F446

alter table Ventas
drop column  precio


alter table VEntas
drop CK__VentaDeta__sub_t__52593CB8

alter table Ventas
drop column  sub_total
	
alter table Ventas
	add id_vendedor int not null

alter table Ventas
	add constraint  fk_vendedor foreign key(id_vendedor) references Usuario(id_usuario)


alter table Ventas
	add id_cliente int not null


alter table Ventas
	add constraint  fk_cliente foreign key(id_cliente) references Cliente(id_cliente)


alter table Ventas
	add id_tpago int not null

alter table Ventas
	add constraint  fk_tpago foreign key(id_tpago) references TipoPago(id_t_pago)


alter table Ventas
	add total money not null


alter table Ventas
	add fecha date not null




select * from Ventas
select * from VentaDetalle

select * from Producto