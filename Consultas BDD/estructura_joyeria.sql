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
	nro_venta int primary key identity,
	id_v_detalle int not null foreign key references VentaDetalle(id_v_detalle),
	id_t_pago int not null foreign key references TipoPago(id_t_pago),
	id_cliente int not null foreign key references  Cliente(id_cliente),
	id_usuario int not null foreign key references  Usuario(id_usuario),
	telefono_cliente varchar(15) not null,
	fecha_venta date not null,
	total_venta money not null
);

								-- ! MODIFICACIONES A LAS TABLAS -- 

-- * insercion de datos de prueba en la tabla clientes para probar el CRUD  en el tipo de usuario vendedor
INSERT INTO Cliente(nombre, apellido, dni, email, telefono, direccion, fecha_nac) 
VALUES('Fernando', 'Caballero', '40982473', 'cabafer1@gmail.com', '3794002323', 'Pje Florida 228', '1998-01-24');

-- * se verifica si se agregaron correctamente los datos
--select * from Cliente;

-- todo: MODIFICACIONES A LA TABLA CLIENTE
ALTER TABLE Cliente
	ADD estado bit  default 1;
UPDATE Cliente set estado = 1;

-- todo: modificaciones a la tabla Usuario
ALTER TABLE Usuario
	ADD estado BIT default 1;
UPDATE Usuario SET estado = 1;

-- todo: modificaciones a la tabla Producto
ALTER TABLE Producto
	DROP COLUMN coleccion;

ALTER TABLE Producto
	DROP COLUMN imagen;


ALTER TABLE Producto
	ADD estado BIT default 1;

-- INSERTANDO DATOS EN LA TABLA CATEGORIA

INSERT INTO Categoria
	(descripcion)
VALUES
	('Anillos'),
	('Alianzas'),
	('Aros'),
	('Colgantes'),
	('Pendientes'),
	('Pulseras');


SELECT 
	pro.id_producto As  ID,           
    cat.descripcion AS TIPO, 
    pro.cod_producto AS CODIGO, 
    pro.nombre AS NOMBRE, 
    pro.stock AS STOCK, 
    pro.precio_costo AS 'PRECIO COSTO', 
    pro.precio_venta AS 'PRECIO VENTA', 
    pro.marca AS MARCA,
    pro.genero AS GENERO,
    pro.material AS MATERIAL,
    pro.gema AS GEMA,
	pro.estado AS ESTADO 
FROM Producto pro INNER JOIN Categoria cat 
ON pro.fk_id_categoria = cat.id_categoria
WHERE pro.estado = 1;



ALTER TABLE VentaDetalle
	DROP COLUMN total;

ALTER TABLE Venta
	DROP COLUMN telefono_cliente;



INSERT INTO TipoPago(descripcion)
VALUES('Credito'),
('Debito'),
('Efectivo'),
('Mercado Pago');

select * from Usuario