use master;
go
drop database if exists tereni;
go
create database tereni;
go
use tereni

create table korisnici (
id int not null primary key identity(1,1),
ime varchar(45) not null,
prezime varchar(45) not null,
broj_mob varchar(45) not null,
email varchar(45),
lozinka varchar(45) not null
);

create table termini (
id int not null primary key identity(1,1),
korisnik_id int not null,
pocetak varchar(45),
kraj varchar(45),
teren_id int not null,
cijena decimal(10,2)
);

create table tereni (
id int not null primary key identity(1,1),
naziv_terena varchar(45),
tip_terena varchar(45)
);

alter table termini add foreign key (korisnik_id) references korisnici(id);
alter table termini add foreign key (teren_id) references tereni(id);