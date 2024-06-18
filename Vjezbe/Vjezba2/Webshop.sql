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
	cijena decimal(10,2),
	aktivan bit not null
);

create table kupci (
	šifra int not null primary key identity(1,1),
	ime varchar(55) not null,
	prezime varchar(55) not null,
	ulica varchar(55),
	mjesto varchar(55)
);

create table računi(
	šifra int not null primary key identity (1,1),
	datum datetime,
	kupac int not null foreign key references kupci(šifra),
	"status" bit
);


create table stavke (
	račun int not null foreign key references računi(šifra),
	proizvod int not null foreign key references proizvodi(šifra),
	količina int,
	cijena decimal (10,2)
);

select * from proizvodi;
insert into proizvodi (naziv, datum_nabave, cijena, aktivan) values
	('Voda', '05-06-2023 11:24', 1.23, 1 ),
	('Jogurt','03-04-2023 12:11', 2.10, 0),
	('Batak','02-04-2023 09:23', 50.25, 1)
update proizvodi set naziv='Kisela', aktivan=0 where naziv='Voda';

select * from kupci;
insert into kupci (ime, prezime, mjesto) values
	('Damir','Mirda','Švajcarnica'),
	('Vojko','Vucina','Svinjarevci'),
	('Bizzo','Bodega','Privlaka')
update kupci set prezime='Vrućina' where prezime='Vucina';
delete from kupci where ime='Damir';

