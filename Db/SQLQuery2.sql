CREATE TABLE Colors(
	ColorId int PRIMARY KEY IDENTITY(1,1),
	ColorName nvarchar(50),
)

CREATE TABLE Brands(
	BrandId int PRIMARY KEY IDENTITY(1,1),
	BrandName nvarchar(50),
)

CREATE TABLE Cars(
	CarId int PRIMARY KEY IDENTITY(1,1),
	CarName nvarchar(50),
	BrandId int,
	ColorId int,
	DailyPrice decimal,
	ModelYear int,
	Description nvarchar(50),
	FOREIGN KEY (ColorId) REFERENCES Colors(Id),
	FOREIGN KEY (BrandId) REFERENCES Brands(Id)
)