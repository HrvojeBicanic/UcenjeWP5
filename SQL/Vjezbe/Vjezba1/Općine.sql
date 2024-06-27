use master;
go 
drop database if exists Općine;
go
create database Općine collate Croatian_CI_AS;
go
use Općine;

create table Načelnici (
šifra int primary key identity (1,1),
ime varchar(55) not null,
prezime varchar(55) not null,
datum_rođenja datetime not null
);

select * from Načelnici;
insert into Načelnici (ime, prezime, datum_rođenja) values
	('Đuka','Galovć','04-24-2000'),
	('Pero','Čuljak','02-02-2002'),
	('Zdenko','Denko','03-02-1991')

update Načelnici set datum_rođenja='04-24-2000 12:00' where šifra=1;
update Načelnici set datum_rođenja='02-02-2002 11:20' where šifra=2;
update Načelnici set datum_rođenja='03-22-1991 09:40' where šifra=3;