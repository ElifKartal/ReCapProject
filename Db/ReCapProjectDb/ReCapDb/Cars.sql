CREATE TABLE Cars(
	[CarId] int PRIMARY KEY IDENTITY(1,1),
	[BrandName] nvarchar(50),
	BrandId int,
	ColorId int,
	DailyPrice decimal,
	ModelYear int,
	Description nvarchar(50),

)