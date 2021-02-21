Create table Cars
(
	CarId int primary key identity (1,1),
	CarName nvarchar,
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions nvarchar(50),
	foreign key (BrandId) references Colors(ColorId),
	foreign key (ColorId) references Brands(BrandId),
)

create table Colors
(
	ColorId int primary key identity (1,1),
	ColorName nvarchar(10)
)

create table Brands
(
	BrandId int primary key identity (1,1),
	BrandName nvarchar(10)
)
create table Users
(
	UserId int  primary key identity(1,1),
	Firstname nvarchar(50),
	LastName  NVARCHAR (50) NULL,
    Email     NVARCHAR (50) NULL,
    Password  INT           NULL,
	
)

create table Customers
(
	UserId int primary key identity(1,1),
	CompanyName nvarchar(50)
)
create table Rentals
(
	Id int primary key identity(1,1),
	CustomerId nvarchar(50),
	RentDate  NVARCHAR (50) NULL,
    ReturnDate     NVARCHAR (50) NULL,
    
)



insert into Cars(CarId,CarName,BrandId, ColorId, DailyPrice,ModelYear)
values
	('1','BMW','1','1','100','2020'),
	('2','MERCEDES','2','2','200','2006'),
	('3','AUDİ','3','3','400','2010'),
	('4','SKODA''4','4','300','2015')
	

insert into Brands(BrandName)
values
	('BMW'),
	('Mercedes'),
	('Audi'),
	('Skoda')

insert into Colors(ColorName)
values
	('Red'),
	('Black'),
	('Grey'),
	('white')
	
Select * from Cars
select * from Brands
select * from Colors
select*from Customers
select*from Users
select*from Rentals
