# csharpmySQL

#Run script in my sql:


create database sample db;

create table Users(
UserId int primary key,
Username varchar(50),
password varchar(100)
);

insert into users
select 1,'mond123','1234';
