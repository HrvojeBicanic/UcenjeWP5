--create database ERAispit;

--use ERAispit;

--create table IspitniRok (
--sifra int,
--predmet varchar(50),
--vrstaIspita varchar(50),
--datum varchar(50),
--pristupio bit
--);

--create table pristupnici (
--ispitniRok varchar(50),
--student varchar(50),
--brojBodova int,
--ocjena int
--);

--create database ERAprojekti;
--use ERAprojekti;

--create table zaposlenik (
--sifra int,
--nadredeni int,
--ime varchar(45),
--prezime varchar(45),
--datumrodenja datetime,
--placa decimal,
--odjel int
--);

--create table sudjeluje(
--zaposlenik int,
--projekt int,
--datumpristupanja datetime
--);

--create table projekti (
--sifra int,
--naziv varchar(45),
--datumpocetka datetime,
--datumkraja datetime
--);

--create table odjel(
--sifra int,
--naziv varchar(45)
--);

--create database ERAracun;
--use ERAracun;

--create table racun(
--sifra int,
--rdniBroj int,
--datum datetime,
--kupac varchar(50),
--placeno bit
--);

--create table stavkeracuna (
--racun varchar(50),
--artikl varchar(50),
--cijena decimal(15,3),
--kolicina int,
--popust int
--);

--create database radnik;
--use radnik;

--create table radnik(
--sifra int,
--ime varchar(50),
--prezime varchar(50),
--nadredeni int
--);

