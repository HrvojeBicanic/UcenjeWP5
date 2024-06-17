use master;
go
drop database if exists webShop;
go
create database webShop collate Croatian_CI_AS;
go
use webShop;

create table proizvodi (
	šifra int not null primary key identity (1,1),
	naziv varchar(55) not null,
	datum_nabave datetime,
	cijena decimal(10,2) not null,
	aktivan bit
);

create table računi(
	šifra int not null primary key identity (1,1),
	datum datetime,
	kupac varchar(55),
	status bit
);

create table kupci (
	šifra int not null primary key identity(1,1),
	ime varchar(55) not null,
	prezime varchar(55) not null,
	ulica varchar(55),
	mjesto varchar(55)
);

create table stavke (
	račun int,
	proizvod int,
	količina int,
	cijena int
);