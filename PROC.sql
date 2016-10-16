USE TaxiManagementSystem;
GO

CREATE PROCEDURE spGetAllEmployee
	AS SELECT *
		FROM dbo.Employee;
GO

CREATE PROCEDURE spGetAllCalls
	AS SELECT *
		FROM dbo.[Call];
GO

CREATE PROCEDURE spGetAllCars
	AS SELECT *
		FROM dbo.Car;
GO

CREATE PROCEDURE spGetEmployeesByCarId(@carId INT)
	AS SELECT *
		FROM dbo.Employee
		WHERE @carId=CarId;
GO

CREATE PROCEDURE spGetCallsByCarId(@carId INT)
	AS SELECT *
		FROM dbo.[Call]
		WHERE @carId=[Call].CarId;
GO

-- Return all money that given machine has earned during specified day
CREATE PROCEDURE [dbo].[spGetCarIncomeOfDay](@carId INT,@date VARCHAR(15))
	AS SELECT CONVERT(VARCHAR(30),CONVERT(MONEY,SUM(Price))) AS 'Salary'
		FROM dbo.Car
			INNER JOIN dbo.[Call] 
				ON Car.Id = [Call].CarId
			WHERE Car.Id = @carId AND CONVERT(VARCHAR(15),[Call].[Date]) = @date;
GO

--Return string with values for specified day: Total money , Oil costs, Employees salary, Company profit  
CREATE PROCEDURE [dbo].[spDayInfo](@date VARCHAR(15))
	AS SELECT CONVERT(VARCHAR(15),SUM(Price))+' '+
	 CONVERT(VARCHAR(15),(CAST(SUM(Price)*0.25 AS MONEY)))+' '+
	 CONVERT(VARCHAR(15),(CAST(SUM(Price)*0.40 AS MONEY)))+' '+
	 CONVERT(VARCHAR(15),(CAST(SUM(Price)*0.35 AS MONEY)))
		FROM dbo.[Call]
			WHERE [Date]=CONVERT(date,@date);
GO

CREATE PROCEDURE spInsertEmployee(@carId INT, @firstName VARCHAR(30), @lastName VARCHAR(30), @age INT, @gender CHAR(1))
	AS INSERT INTO dbo.Employee(CarId, FirstName,LastName, Age, Gender)
		VALUES(@carId, @firstName,@lastName, @age, @gender);
GO

CREATE PROCEDURE spInsertCar(@licensePlate VARCHAR(30),@model VARCHAR(30),@mileage INT, @state VARCHAR(50))
	AS INSERT INTO dbo.Car(LicensePlate,Model, Mileage, [State])
		VALUES(@licensePlate, @model, @mileage, @state);
GO

CREATE PROCEDURE spInsertCall(@carId INT,@departurePlace VARCHAR(30),@arrivalPlace VARCHAR(30),@distance INT)
	AS INSERT INTO dbo.[Call](CarId, DeparturePlace, ArrivalPlace, Distance)
		VALUES(@carId, @departurePlace, @arrivalPlace, @distance);
GO

CREATE PROCEDURE spDeleteCall(@callId INT)
	AS DELETE FROM dbo.[Call]
		WHERE [Call].Id=@callId;
GO

CREATE PROCEDURE spDeleteEmployee(@id INT)
	AS DELETE FROM dbo.Employee
		WHERE Employee.Id=@Id;
GO

CREATE PROCEDURE spDeleteCar(@carId INT)
	AS DELETE FROM dbo.Car
		WHERE Car.Id = @carId;
GO

CREATE PROCEDURE spUpdateEmployeeCar(@employeeId INT, @newCarId INT)
	AS UPDATE dbo.Employee
		SET CarId=@newCarId
			WHERE Id=@employeeId;
GO

CREATE PROCEDURE spUpdateCarState(@carId INT,@newState VARCHAR(50))
	AS UPDATE dbo.Car
		SET [State]= @newState
			WHERE Id=@carId;
GO

CREATE PROCEDURE [dbo].[spGetUserByLogin](@login VARCHAR(30), @password VARCHAR(32))
	AS SELECT Id, FirstName, LastName, [Login] 
		FROM dbo.[User]
			WHERE [Login]=@login AND [Password]=@password; 
GO