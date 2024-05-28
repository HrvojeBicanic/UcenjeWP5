--create database termini;

--use termini;

--create table "user" (
--id int,
--ime varchar(45),
--broj_mob varchar(45),
--email varchar(45),
--prezime varchar(45),
--password varchar(45)
--);

--create table card (
--id int,
--broj_kartice int,
--cvv int,
--istek_kartice varchar(45),
--iznos int
--);

create table termini (
id int,
user_id int,
pocetak varchar(45),
kraj varchar(45),
tereni_id int,
cijena decimal
);