create database Joyeria;

use Joyeria;

create table Perfil(
	id_perfil int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_desc check (descripcion in ('Vendedor', 'Administrador', 'Supervisor'))
);

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


create table Categoria(
	id_categoria int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_descCate check (descripcion in ('Alianzas', 'Aros', 'Colgantes', 'Pendientes', 'Anillos', 'Pulseras', 'Cadenas'))
);

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






create table TipoPago(
	id_t_pago int primary key identity,
	descripcion varchar(100) not null,
	constraint chk_descTPago check (descripcion in ('Credito', 'Debito', 'Efectivo', 'Mercado Pago'))
);

create table VentaDetalle(
	id_v_detalle int primary key identity,
	id_producto int not null,
	cantidad int not null check(cantidad >= 0),
	precio money not null check (precio >= 0),
	total money not null check (total >= 0),
	sub_total money not null check (sub_total >= 0),
	constraint fk_id_producto foreign key (id_producto) references Producto(id_producto)
);

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


select * from Cliente;

INSERT INTO Cliente(nombre, apellido, dni, email, telefono, direccion, fecha_nac) 
VALUES('Fernando', 'Caballero', '40982473', 'cabafer1@gmail.com', '3794002323', 'Pje Florida 228', '1998-01-24');

