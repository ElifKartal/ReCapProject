CREATE TABLE Cars(
	CarId int primary key identity(1,1),
	CarName int,
	BrandId int,
	ColorId int,
	ModelYear int,
	DailyPrice decimal,
	Descriptions varchar(50)
)

CREATE TABLE Colors(
	ColorId int primary key identity(1,1),
	ColorName nvarchar(50)
)

CREATE TABLE Brands(
	BrandId int primary key identity(1,1),
	BrandName nvarchar(50)
)

INSERT INTO Cars(CarName, ColorId, ModelYear, DailyPrice, Descriptions)
VALUES
	(BMW,123, 124554, 2019, 650, 'BMW M2 COMPETITION'),
	(AUDİ,234, 172355, 2016, 500,'AUDI A3 SEDAN'),
	(SKODA,345, 542367, 2017, 1000, 'SKODA OCTAVİA'),
	(FORD,123, 127535, 2016, 750, 'FORD FİESTA'),
	(HONDA,234, 254962, 2020, 900, 'HONDA CIVIC');

INSERT INTO Brands(BrandName)
VALUES
	('BMW'),
	('AUDI'),
	('SKODA'),
	('FORD'),
	('HONDA');

INSERT INTO Colors(ColorName)
VALUES
	('Black'),
	('Red'),
	('Gray'),
	('Gold'),
	('Silver');

SELECT * FROM Cars;
SELECT * FROM Brands;
SELECT * FROM Colors;