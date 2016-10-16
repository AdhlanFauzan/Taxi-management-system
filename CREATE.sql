CREATE FUNCTION CalculatePrice(@distance INT)
RETURNS MONEY
AS
BEGIN
	DECLARE @priceForKilometr MONEY = 5.00;
	DECLARE @returnValue MONEY;

	--minimal price for callilng taxi
	IF(@distance<10)
		SET @returnValue = (10 * @priceForKilometr);
	ELSE
		SET @returnValue = (@distance * @priceForKilometr);

	RETURN @returnValue;
END;
GO

--hashing varchar value by MD5 algorithm 
CREATE FUNCTION MD5(@value VARCHAR(255))
RETURNS VARCHAR(32)
AS
BEGIN
	RETURN SUBSTRING(sys.fn_sqlvarbasetostr(HASHBYTES('MD5', @value)),3,32);
END;
GO

USE [TaxiManagementSystem]

CREATE TABLE
	Car
		(
			Id INT NOT NULL IDENTITY(1111,1),
			LicensePlate VARCHAR(30) NOT NULL,
			Model VARCHAR(30) NOT NULL,
			Mileage INT NOT NULL,
			[State] VARCHAR(50) NULL,
			[Enabled] BIT NOT NULL 
		);

ALTER TABLE Car
	ADD CONSTRAINT PK_Car
		PRIMARY KEY(Id);

ALTER TABLE Car
	ADD CONSTRAINT CHK_Id_InputFormat_Car
		CHECK (Id LIKE ('____'));

ALTER TABLE Car
	ADD CONSTRAINT CHK_Mileage_Car
		CHECK (Mileage>0);

ALTER TABLE Car
	ADD CONSTRAINT CHK_LicensePlate_Car
		CHECK (LicensePlate LIKE('[A-C][A-Z] [0-9][0-9][0-9][0-9] [A-Z][A-Z]'));

ALTER TABLE Car
	ADD CONSTRAINT DFLT_Enabled_Call
		DEFAULT(1)
			FOR [Enabled];
GO

USE [TaxiManagementSystem]

CREATE TABLE 
	[Call]
		(
		    Id INT NOT NULL IDENTITY(1,1),
			CarId INT NOT NULL,
			DeparturePlace VARCHAR(30) NOT NULL,
			ArrivalPlace VARCHAR(30) NOT NULL,
			Distance INT NOT NULL,
			Price AS dbo.CalculatePrice(Distance),
			[Date] DATE NOT NULL		 
		);

ALTER TABLE [Call]
	ADD CONSTRAINT PK_Call
		PRIMARY KEY(Id);

ALTER TABLE [Call]
	ADD CONSTRAINT FK_Call_Employee
		FOREIGN KEY (CarId)
			REFERENCES dbo.Car(Id);

ALTER TABLE	[Call]
	ADD CONSTRAINT CHK_PositiveDistance_Call
		CHECK (Distance>0);

ALTER TABLE [Call]
	ADD CONSTRAINT CHK_CarId_InputFormat_Call
		CHECK (CarID LIKE ('____'));

ALTER TABLE [Call]
	ADD CONSTRAINT DFLT_Date_Call
		DEFAULT(CONVERT(date,SYSDATETIME()))
			FOR [Date];
GO

USE [TaxiManagementSystem]

CREATE TABLE 
	Employee
		(
			Id INT NOT NULL IDENTITY(1,1), 
			CarId INT NOT NULL,
			FirstName VARCHAR(30) NOT NULL,
			LastName VARCHAR(30) NOT NULL,
			Age INT NOT NULL,
			Gender CHAR(1) NOT NULL 
		);

ALTER TABLE Employee
	ADD CONSTRAINT PK_Employee
		PRIMARY KEY(Id);

ALTER TABLE Employee
	ADD CONSTRAINT FK_CarId_Employee_Car
		FOREIGN KEY(CarId)
			REFERENCES dbo.Car(Id);

ALTER TABLE Employee
	ADD CONSTRAINT CHK_Age_Employee
		CHECK (Age>=18);
		
ALTER TABLE Employee
	ADD CONSTRAINT CHK_GenderInputFormat_Employee
		CHECK (Gender LIKE ('M') OR Gender Like ('F'));

ALTER TABLE Employee
	ADD CONSTRAINT CHK_CarId_InputFormat_Employee
		CHECK (CarID LIKE ('____'));
GO

--when had registered new call, add the distance of this call to mileage car  
CREATE TRIGGER dbo.CarMileageUpdate
	ON [dbo].[Call] AFTER INSERT AS 
		IF @@ROWCOUNT = 1
			BEGIN
				UPDATE dbo.Car	
				SET Car.Mileage = Car.Mileage + inserted.Distance
					FROM inserted
						WHERE Car.Id = inserted.CarId;
			END
GO

CREATE TABLE 
	[User]
		(
			Id INT NOT NULL IDENTITY(1,1), 
			FirstName VARCHAR(30) NOT NULL,
			LastName VARCHAR(30) NOT NULL,
			[Login] VARCHAR(30) NOT NULL,
			[Password] VARCHAR(255) NOT NULL
		);

ALTER TABLE [User]
	ADD CONSTRAINT PK_User
		PRIMARY KEY(Id);

ALTER TABLE [User]
	ADD CONSTRAINT CHK_TooEasyPassword_User
		CHECK(LEN([User].[Password])>3);

ALTER TABLE [User]
	ADD CONSTRAINT UNQ_Login_User
		UNIQUE([Login]);
GO
