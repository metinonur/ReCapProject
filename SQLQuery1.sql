CREATE TABLE Cars
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NOT NULL, 

    [ColorId] INT NOT NULL, 
    [ModelYear] INT NOT NULL, 
    [DailyPrice] DECIMAL NOT NULL, 
    [Description] VARCHAR(50) NULL


)

CREATE TABLE Brands
(
	[BrandId] INT NOT NULL PRIMARY KEY, 
    [Name] varchar NOT NULL, 

)

CREATE TABLE Colors
(
	[ColorId] INT NOT NULL PRIMARY KEY, 
    [Name] varchar NOT NULL, 

)