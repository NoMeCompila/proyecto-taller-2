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
CREATE TYPE EVentaEdalle AS TABLE(
	id_producto INT NULL,
	cantidad INT NULL,
	precio DECIMAL NULL,
	sub_total DECIMAL NULL
)
GO

	
-- TODO:transaccion para registrar una venta

CREATE PROC sp_registrar_venta(
	@id_vendedor int,
	@id_cliente int,
	@id_tpago int,
	@total decimal,
	@fecha date,
	@vendedor_dni int,
	@cliente_dni int,
	@cliente_tel int,
	@cliente_email varchar(100),
	@cliente_fullname varchar(100),
	@importe decimal,
	@vuelto decimal,
	@VentaDetalle [EVentaEdalle] READONLY,
	@resultado bit output,
	@mensaje varchar(500) output)
AS
	BEGIN
		BEGIN TRY
			DECLARE @id_venta INT = 0
			SET @resultado = 1
			SET @mensaje = ''
			BEGIN TRANSACTION registro
			
				INSERT INTO Ventas(
					id_vendedor,
					id_cliente,
					id_tpago,
					total,
					fecha,
					vendedor_dni,
					cliente_dni,
					cliente_tel,
					cliente_email,
					cliente_fullname,
					importe,
					vuelto)
				VALUES(
					@id_vendedor,
					@id_cliente,
					@id_tpago,
					@total,
					@fecha,
					@vendedor_dni,
					@cliente_dni,
					@cliente_tel,
					@cliente_email,
					@cliente_fullname,
					@importe,
					@vuelto)

				SET @id_venta = SCOPE_IDENTITY()
				EXEC sp_help VentaDetalle
				INSERT INTO VentaDetalle(
					id_venta,
					id_producto,
					cantidad,
					precio,
					sub_total)
				SELECT 
					@id_venta, 
					id_producto,
					cantidad,
					precio,
					sub_total FROM @VentaDetalle					 
			COMMIT TRANSACTION registro
		END TRY
		BEGIN CATCH
			set @resultado = 0
			set @mensaje = ERROR_MESSAGE()
			ROLLBACK TRANSACTION registro
		END CATCH	
	END	 
GO

exec sp_help Producto


id_venta
id_vendedor
id_cliente
id_tpago
total
fecha
vendedor_dni
cliente_dni
cliente_tel
cliente_email
cliente_fullname
importe
vuelto