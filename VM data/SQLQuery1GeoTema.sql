use master;

if db_id ('GeoTema') is not null
begin 
drop database GeoTema
end
go
create database GeoTema;
go
use GeoTema

-- table 1
create table Country(
ID int identity(1,1) not null primary key,
Country_Name nvarchar (15),
Continent nvarchar (25),
);

-- table 2

create table Ranks(
ID int identity(1,1) not null foreign key references Country(ID),
Ranks int,
Birthrate float 
);

insert into Country(Country_Name,Continent)
values('Denmark','Europe'),
('Canada','Northamerica'),
('Nigeria','Africa'),
('India','Asia'),
('Brazil','Southamerica'),
('New Zealand','Oceania'),
('USA','Northamerica'),
('Norway','Europe'),
('Turky','Europe and Asia'),
('Ukrain','Europe and Asien')

insert into Ranks
values(169,10.27),
(168,10.28),
(1,45.45),
(85,19.50),
(129,14.46),
(139,13.33),
(145,12.38),
(149,12.14),
(114,16.33),
(162,10.72)




select * from Ranks

select * from Country

select * from Country,Ranks

-- selecting the ID and the county and country data 

select Country.ID, Country.Country_Name, Country.Continent, Ranks.Ranks, Ranks.Birthrate  from Country
 inner join Ranks on Country.ID = Ranks.ID

 -- user tables

 create table AdminUser(
 UserId nvarchar (10),
 Pass nvarchar (10)
 );

 create table SuperUser(
 UserId nvarchar (10),
 Pass nvarchar (10)
 );

 create table StandedUser(
 UserId nvarchar (10),
 Pass nvarchar (10)
 );

 select * from AdminUser
 select * from SuperUser
 select * from StandedUser


 insert into AdminUser
 values('Admin','Passw0rd'),
 ('Brian','Audi')

 insert into SuperUser
 values('Brian','Audi'),
 ('Dimal','Audi')

  insert into StandedUser
 values('Brian','dimal'),
 ('Dimal','brian')

