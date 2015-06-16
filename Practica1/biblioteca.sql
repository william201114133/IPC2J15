Create DataBase biblioteca


use biblioteca
Create table libro(
idLibro int identity(1,1),
nombre varchar(30),
numpaginas int,
tema varchar(30),
autor varchar(30),
existencia int,
constraint pk_libro primary key (idLibro));

Create table cliente(
idCliente int identity(1,1),
nombre varchar(30),
dpi int,
direccion varchar(30),
telefono int,
constraint pk_cliente primary key(idCliente));

Create table autor(
idAutor int identity(1,1),
nombre varchar(30),
constraint pk_autor primary key(idAutor));

Create table prestamo(
idPrestamo int identity(1,1),
fecha date,
idCliente int,
idLibro int,
constraint pk_prestamo primary key(idPrestamo));

Create table devolucion(
idDevolucion int identity(1,1),
fecha date,
idCliente int,
idLibro int,
constraint pk_devolucion primary key(idDevolucion));

Create table reservacion(
idreservacion int identity(1,1),
idCliente int,
idLibro int,
constraint pk_reservacion primary key(idreservacion)
);

alter table prestamo add constraint fk_prestamo_idCliente foreign key(idCliente) references cliente(idCliente);
alter table prestamo add constraint fk_prestamo_idLibro foreign key(idLibro) references Libro(idLibro);
alter table devolucion add constraint fk_devolucion_idCliente foreign key(idCliente) references cliente(idCliente);
alter table devolucion add constraint fk_devolucion_idLibro foreign key(idLibro) references Libro(idLibro);
alter table reservacion add constraint fk_reservacion_idCliente foreign key(idCliente) references cliente(idCliente);
alter table reservacion add constraint fk_reservacion_idLibro foreign key(idLibro) references Libro(idLibro);

