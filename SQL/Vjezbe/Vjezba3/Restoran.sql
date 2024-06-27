use master
go
drop database if exists Restoran
go
create database Restoran
go
use Restoran

create table Persons (
	id int not null primary key identity (1,1),
	last_name varchar(55) not null,
	first_name varchar(55) not null,
	age int
);

create table Orders (
	oreder_id int not null primary key identity (1,1),
	order_number int not null,
	person_id int not null foreign key references Persons(id)
);

insert into Persons(last_name, first_name, age) values
	('Damirović', 'Danko', 34),
	('Katić', 'Pera', 56),
	('Goranović', 'Luka', 34)
select * from  Persons;

insert into Orders (order_number, person_id) values
	('23232423', 1),
	('12344533', 2),
	('31454636', 3)
select * from  Orders;

update Persons set last_name='Bujadinović' where last_name='Katić';
update Persons set first_name='Sinan'where first_name='Danko';
update Orders set order_number='43545' where order_number='23232423';
delete from Orders where order_number='31454636';
