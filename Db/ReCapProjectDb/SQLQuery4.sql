INSERT INTO Cars(BrandId, ColorId, ModelYear, DailyPrice, Descriptions)
VALUES
	(123, 124554, 2019, 650, 'BMW M2 COMPETITION'),
	(234, 172355, 2016, 500,'AUDI A3 SEDAN'),
	(345, 542367, 2017, 1000, 'ALFA ROMEO GIULIETTA'),
	(123, 127535, 2016, 750, 'BMW M4 SPECIFICATIONS'),
	(234, 254962, 2020, 900, 'AUDI S4');

INSERT INTO Brands(BrandName)
VALUES
	('BMW'),
	('AUDI'),
	('ALFA ROMEO'),
	('BMW'),
	('AUDI');

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