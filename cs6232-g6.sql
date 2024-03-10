create database [cs6232-g6]
go
use [cs6232-g6]
go

create table employees
(
id int primary key,
firstName VARCHAR(255),
lastName VARCHAR(255),
sex  VARCHAR(15),
dob datetime,
address VARCHAR(255),
contactPhone VARCHAR(255),
userName VARCHAR(255),
hashedPassword VARCHAR(255)
);
create table members
(
id int primary key,
firstName VARCHAR(255),
lastName VARCHAR(255),
sex VARCHAR(15),
DOB datetime,
Street VARCHAR(255),
City VARCHAR(255),
State VARCHAR(255),
zipCode VARCHAR(255) NOT NULL,
 country VARCHAR(255) NOT NULL,
contactPhone VARCHAR(255)
);



insert into employees select 1, 'Jone','Albert','Male','10-23-1990','DC','0911040690', 'jane','123456'
--.
--.
--.
--.


insert into members select 8, 'Jakson','Regen','Male','01-06-1990','streetAddress','DC','DC','1345','USA','240123456';
insert into members select 7, 'Mikele','Winger','Male','01-06-1987','streetAddress','DC','DC','1456','USA','202345678';

--.
--.
--.
--.
