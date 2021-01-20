drop database if exists SistemaBancario;
create database SistemaBancario;
use SistemaBancario;

create table Usuarios(
id varchar(10) primary key not null,
tipoUsuario tinyint not null,
cc varchar(10) not null,
monto int not null,
nombre varchar (60) not null,
correo varchar (30) not null,
clave varchar(20) not null
);

create table Retiros(
cod int primary key not null auto_increment,
id varchar(10) not null, foreign key (id) references Usuarios(id),
valor varchar(20) not null,
establecimiento varchar(70) not null,
fecha datetime not null
);

create table Depositos(
cod int primary key not null auto_increment,
id varchar(10) not null, foreign key (id) references Usuarios(id),
valor varchar(20) not null,
establecimiento varchar(70) not null,
fecha datetime not null
);

create table Transferencias(
cod int primary key not null auto_increment,
id varchar(10) not null, foreign key (id) references Usuarios(id),
valor varchar(20) not null,
cuenta varchar(10) not null,
fecha datetime not null
);

insert into transferencias values (default, '1005151268', 1000000, '3203626961', now());

select * from usuarios;
select * from transferencias;
update usuarios set monto = monto+500000 where id='1005151268';
update usuarios set monto = monto+500000 where id='1005151268';
