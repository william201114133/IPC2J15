create database QuetzalExpress

use QuetzalExpress

Create table Impuesto(
idImpuesto int identity (1,1),
categoria nvarchar(40),
impuesto int,
estado nvarchar(30),
constraint pk_impue primary key (idImpuesto)
)

Create Table Empleado(
idEmpleado int identity (1,1),
apellidos nvarchar(50),
nombres nvarchar (50),
sueldo int,
idsucursal int,
iddepartamento int,
puesto nvarchar(50),
contrase�a nvarchar(30),
constraint pk_empleado primary key (idEmpleado)
)

Create Table Cliente(
idCliente int identity (1,1),
apellidos nvarchar(50),
nombres nvarchar(50),
dpi int,
nit int,
telefono int,
direccion nvarchar(50),
tajerta int,
casilla int,
idSucursal int,
estado nvarchar(30),
contrase�a nvarchar(30),
constraint pk_cliente primary key (idCliente)
)

Create Table Paquete(
idPaquete int identity(1,1),
categoria nvarchar(50),
casilla int,
precio int,
peso int,
estado nvarchar(30),
estadotrayecto nvarchar (30),
idCliente int,
costo int,
idLote int,
constraint pk_paquete primary key (idPaquete)
)

Create Table Historial(
idHistorial int identity (1,1),
fecha date,
estado nvarchar(50),
idPaquete int,
constraint pk_historial primary key (idHistorial)
)

Create Table CostoEnvio(
idCE int identity(1,1),
detalle nvarchar (50),
porcentaje int,
estado nvarchar(50),
constraint pk_CostoEnvio primary key (idCE)
)

Create Table Comision(
idComision int identity (1,1),
detalle nvarchar(50),
porcentaje int,
estado nvarchar(30),
constraint pk_comision primary key (idComision)
)
 
Create Table Sede(
idSede int identity(1,1),
pais nvarchar(30),
constraint pk_sede primary key (idSede)
)

Create Table Sucursal(
idSucursal int identity (1,1),
pais nvarchar(30),
direccion nvarchar(30),
telefono int,
capacidad int,
constraint pk_Sucursal primary key (idSucursal)
)

Create Table Departamento(
idDepartamento int identity(1,1),
nombre nvarchar(30),
constraint pk_depto primary key (idDepartamento)
)

Create Table Envio(
idEnvio int identity(1,1),
fecha nvarchar(30),
idLote int,
idSucursal int,
constraint pk_envio primary key (idEnvio)
)

Create Table Lote(
idLote int identity(1,1),
estado nvarchar(30),
constraint pk_Lote primary key (idLote)
)

Create table Factura(
idFactura int identity(1,1),
fecha nvarchar(30),
idCliente int,
idPaquete int,
total int,
constraint pk_idFactura primary key (idFactura)
)

Create table Devoulucion(
idDevolucion int identity(1,1),
fecha nvarchar(30),
idCliente int,
idPaquete int,
motivo int,
constraint pk_devolucion primary key (idDevolucion)
)

alter table Empleado add constraint fk_Empleado_idsucursal foreign key (idsucursal) references Sucursal(idSucursal);
alter table Empleado add constraint fk_Empleado_iddepartamento foreign key (iddepartamento) references Departamento(idDepartamento);
alter table Cliente add constraint fk_Cliente_idSucursal foreign key (idSucursal) references Sucursal(idSucursal);
alter table Envio add constraint fk_Envio_idSucursal foreign key (idSucursal) references Sucursal(idSucursal);
alter table Envio add constraint fk_Envio_idLote foreign key (idLote) references Lote(idLote);
alter table Paquete add constraint fk_Paquete_idLote foreign key (idLote) references Lote(idLote);
alter table Devoulucion add constraint fk_Devolucion_idCliente foreign key (idCliente) references Cliente(idCliente);
alter table Devoulucion add constraint fk_Devolucion_idPaquete foreign key (idPaquete) references Paquete(idPaquete);
alter table Factura add constraint fk_Factura_idCliente foreign key (idCliente) references Cliente(idCliente);
alter table Factura add constraint fk_Factura_idPaquete foreign key (idPaquete) references Paquete(idPaquete);
Alter table Paquete add constraint fk_Paquete_idCliente foreign key (idCliente) references Cliente(idCliente);
Alter Table Historial add constraint fk_Historial_idPaquete foreign key (idPaquete) references Paquete(idPaquete);