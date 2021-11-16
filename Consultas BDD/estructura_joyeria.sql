								--! ESTRUCTURA DE LA BASE DE DATOS --

--todo: CREACION DE LA BASE DE DATOS
create database Joyeria;

-- todo: SE ESEPCIFÍCA QUE LA TABLA A USAR ES LA DE JOYERIA
use Joyeria;

-- * TABLA PERFIL: aqui se indica que una descripcion de cada perfil
create table Perfil(
	id_perfil int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_desc check (descripcion in ('Vendedor', 'Administrador', 'Supervisor'))
);

-- * TABLA USUARIO: tabla con todos los datos personales de los usuarios
create table Usuario(
	id_usuario int primary key identity,
	id_perfil int not null,
	nombre varchar(100) not null,
	apellido varchar(100) not null,
	dni varchar(8) not null unique,
	usuario varchar(100) not null unique,
	contra varchar(100) not null unique,
	email varchar(100) not null unique,
	telefono varchar(15) not null unique,
	direccion varchar(100) not null,
	fecha_nac date not null,
	constraint fk_perfil foreign key (id_perfil) references Perfil(id_perfil)
);

-- * TABLA CLIENTE:  en esta tabla estan todos los datos personales de los usuarios
create table Cliente(
	id_cliente int primary key identity,
	nombre varchar(100) not null,
	apellido varchar(100) not null,
	dni varchar(8) not null unique,
	email varchar(100) not null unique,
	telefono varchar(15) not null unique,
	direccion varchar(100) not null,
	fecha_nac date not null
);

-- * TABLA CATEGORIA: esta tabla indica a quecategoria pertenecen las joyas
create table Categoria(
	id_categoria int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_descCate check (descripcion in ('Alianzas', 'Aros', 'Colgantes', 'Pendientes', 'Anillos', 'Pulseras', 'Cadenas'))
);

-- * TABLA PRODUCTO: la tabla producto contiene todos los datos necesarios para gestionar las joyas 
create table Producto(
	id_producto int primary key identity,
	fk_id_categoria int not null,
	cod_producto varchar(100) not null unique,
	nombre varchar(100),
	stock int not null check (stock >= 0),
	precio_costo money not null check (precio_costo >= 0),
	precio_venta money not null check (precio_venta >= 0),
	imagen varchar(100) unique,
	marca varchar(100) not null,
	coleccion varchar(100),
	genero varchar(10) check (genero in ('Caballero', 'Dama', 'Unisex')),
	material varchar(100) not null,
	gema varchar(100) not null,
	constraint fk_categoria foreign key (fk_id_categoria) references Categoria(id_categoria)
);

-- * TABLA TIPO DE PAGO: sirve para verificar con que tipo de pago se efectu� la compra del producto
create table TipoPago(
	id_t_pago int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_descTPago check (descripcion in ('Credito', 'Debito', 'Efectivo', 'Mercado Pago'))
);

-- * DETALLE DE LAS VENTAS:  en esta tabla se especifican cada producto que se realiz� en una venta en especifico
create table VentaDetalle(
	id_v_detalle int primary key identity,
	id_producto int not null,
	cantidad int not null check(cantidad >= 0),
	precio money not null check (precio >= 0),
	total money not null check (total >= 0),
	sub_total money not null check (sub_total >= 0),
	constraint fk_id_producto foreign key (id_producto) references Producto(id_producto)
);

-- * TABLA VENTA: resumen de todos los datos referentes a una venta
create table Venta(
	id_venta int primary key identity,
	id_vendedor int not null foreign key references Usuario(id_usuario),
	id_cliente int not null foreign key references  Cliente(id_cliente),
	id_tpago int not null foreign key references TipoPago(id_t_pago),
	total decimal(10,2) not null,
	fecha_venta date not null
	
);

ALTER TABLE Ventas
	ADD vendedor_dni int

ALTER TABLE Ventas
	ADD cliente_dni int

ALTER TABLE Ventas
	ADD cliente_tel varchar(100)

ALTER TABLE Ventas
	ADD cliente_email varchar(100)

ALTER TABLE Ventas
	ADD cliente_fullname varchar(100)

ALTER TABLE Ventas
	ADD importe decimal(10,2)

ALTER TABLE Ventas
	ADD vuelto  decimal(10,2)

select * from Ventas


create table Venta(
	id_venta int primary key identity,
	id_vendedor int not null foreign key references Usuario(id_usuario),
	id_cliente int not null foreign key references  Cliente(id_cliente),
	id_tpago int not null foreign key references TipoPago(id_t_pago),
	total decimal(10,2) not null,
	fecha_venta date not null
	
);




-- ! SE CREA UN TIPO DE DATO DE ESTRUCTURA VENTADETALLE








CREATE TYPE [dbo].[detalle_tabla] AS TABLE(
	[id_producto] INT NULL,
	[cantidad] INT NULL,
	[precio] DECIMAL NULL,
	[sub_total] DECIMAL NULL,
	[cod_prod] VARCHAR(100),
	[nombre_prod] VARCHAR(100),
	[marca] VARCHAR(100),
	[material] VARCHAR(100),
	[Kilates] VARCHAR(100)
)
GO

drop type	detalle_tabla
drop PROC	sp_registro


select * from Ventas

EXEC sp_help VentaDetalle

alter table Ventas
	add vendedor_nombre varchar(100)


alter table Ventas
	add vendedor_tel varchar(100)

alter table Ventas
	add nro_correlativo varchar(100)

go
-- TODO:transaccion para registrar una venta
-- Intentando pasar un parámetro con valores de 

CREATE PROC sp_registro(
@id_vendedor int,
@id_cliente int,
@total decimal,
@fecha date,
@vendedor_dni varchar(100),
@cliente_dni varchar(100),
@cliente_tel varchar(100),
@cliente_email varchar(100),
@cliente_fullname varchar(100),
@importe decimal,
@vuelto decimal,
@vendedor_nombre varchar(100),
@vendedor_tel varchar(100),
@nro_correlativo varchar(100),
@detalle_tabla [detalle_tabla] READONLY,
@resultado bit output,
@mensaje varchar(500) output)
AS
	BEGIN
		BEGIN TRY
			DECLARE @id_venta INT = 0
			SET @resultado = 1
			SET @mensaje = ''
			BEGIN TRANSACTION registro
			
				INSERT INTO Ventas(id_vendedor,id_cliente,total,fecha,
				vendedor_dni,cliente_dni,cliente_tel,cliente_email,cliente_fullname,
				importe,vuelto,vendedor_nombre,vendedor_tel,nro_correlativo)
								
				VALUES(@id_vendedor,@id_cliente,@total,@fecha,
				@vendedor_dni,@cliente_dni, @cliente_tel,@cliente_email,@cliente_fullname,
				@importe,@vuelto,@vendedor_nombre,@vendedor_tel,@nro_correlativo)

				SET @id_venta = SCOPE_IDENTITY()

				INSERT INTO VentaDetalle(id_venta, id_producto,cantidad,precio,sub_total,
					cod_prod, nombre_prod, marca, material, Kilates)
				SELECT 
					@id_venta, id_producto, cantidad, precio, sub_total, 
					cod_prod, nombre_prod, marca, material, Kilates 
					FROM  @detalle_tabla 				 
			COMMIT TRANSACTION registro
		END TRY
		BEGIN CATCH
			set @resultado = 0
			set @mensaje = ERROR_MESSAGE()
			ROLLBACK TRANSACTION registro
		END CATCH	
	END	 
GO

DROP PROC sp_registrar_venta

SELECT * from Ventas;

EXEC sp_help VentaDetalle


EXEC sp_help Ventas

ALTER TABLE Ventas ALTER COLUMN vendedor_dni varchar(100);  
GO  

ALTER TABLE Ventas ALTER COLUMN cliente_dni varchar(100);  
GO  

select * from VentaDetalle

-- TODO: CONSULTA PARA VER CABECERA DE FACTURA
select
	v.nro_correlativo as 'nro factura',
	v.id_venta,
	v.fecha  as fecha,
	u.dni as 'vendedor dni',
	CONCAT(u.nombre, ' ', u.apellido)  as 'vendedor nombre',
	u.dni as 'vendedor dni',	
	c.id_cliente as 'id cliente', 
	c.dni as 'cliente dni',
	c.telefono as 'cliente tel.',
	CONCAT(c.nombre, ' ', c.apellido)  as 'cliente nombre',
	c.email as 'cliente correo',
	v.total as total,
	v.importe as importe,
	v.vuelto as vuelto
from 
	Ventas  v inner join 
	Usuario u on v.id_vendedor = u.id_usuario inner join 
	Cliente c on c.id_cliente = v.id_cliente


-- TODO: CONSULTA PARA VER DETALLE DE FACTURA

select 
	p.id_producto as 'ID producto',
	p.cod_producto as 'Cod producto',
	p.nombre as nombre,
	p.marca as marca,
	p.material as material,
	p.gema as kilates,
	p.precio_venta as precio,
	vd.cantidad as cantidad,
	vd.sub_total as subtotal
from VentaDetalle vd inner join Producto p 
on vd.id_producto = p.id_producto

SELECT * from Ventas