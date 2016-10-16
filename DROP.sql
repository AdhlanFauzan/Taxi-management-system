IF OBJECT_ID('dbo.Call','U') IS NOT NULL
	DROP TABLE dbo.[Call];

IF OBJECT_ID('dbo.Employee','U') IS NOT NULL
	DROP TABLE dbo.Employee;

IF OBJECT_ID('dbo.Car','U') IS NOT NULL
	DROP TABLE dbo.Car;

IF OBJECT_ID('dbo.User','U') IS NOT NULL
	DROP TABLE dbo.[User];

IF OBJECT_ID('dbo.CalculatePrice') IS NOT NULL
	DROP FUNCTION dbo.CalculatePrice;

IF OBJECT_ID('dbo.MD5') IS NOT NULL
	DROP FUNCTION dbo.MD5;

IF OBJECT_ID('dbo.spDayInfo') IS NOT NULL
	DROP PROCEDURE dbo.spDayInfo;

IF OBJECT_ID('dbo.spGetAllCalls') IS NOT NULL
	DROP PROCEDURE dbo.spGetAllCalls;

IF OBJECT_ID('dbo.spGetAllCars') IS NOT NULL
	DROP PROCEDURE dbo.spGetAllCars;

IF OBJECT_ID('dbo.spGetAllEmployee') IS NOT NULL
	DROP PROCEDURE dbo.spGetAllEmployee;

IF OBJECT_ID('dbo.spGetCallsByCarId') IS NOT NULL
	DROP PROCEDURE dbo.spGetCallsByCarId;

IF OBJECT_ID('dbo.spGetEmployeesByCarId') IS NOT NULL
	DROP PROCEDURE dbo.spGetEmployeesByCarId;

IF OBJECT_ID('dbo.spInsertEmployee') IS NOT NULL
	DROP PROCEDURE dbo.spInsertEmployee;

IF OBJECT_ID('dbo.spInsertCar') IS NOT NULL
	DROP PROCEDURE dbo.spInsertCar;

IF OBJECT_ID('dbo.spInsertCall') IS NOT NULL
	DROP PROCEDURE dbo.spInsertCall;

IF OBJECT_ID('dbo.spDeleteCall') IS NOT NULL
	DROP PROCEDURE dbo.spDeleteCall;

IF OBJECT_ID('dbo.spDeleteCar') IS NOT NULL
	DROP PROCEDURE dbo.spDeleteCar;

IF OBJECT_ID('dbo.spDeleteEmployee') IS NOT NULL
	DROP PROCEDURE dbo.spDeleteEmployee;

IF OBJECT_ID('dbo.spUpdateEmployeeCar') IS NOT NULL
	DROP PROCEDURE dbo.spUpdateEmployeeCar;

IF OBJECT_ID('dbo.spUpdateCarState') IS NOT NULL
	DROP PROCEDURE dbo.spUpdateCarState;

IF OBJECT_ID('dbo.spGetUserByLogin') IS NOT NULL
	DROP PROCEDURE dbo.spGetUserByLogin;

IF OBJECT_ID('dbo.spGetCarIncomeOfDay') IS NOT NULL
	DROP PROCEDURE dbo.spGetCarIncomeOfDay;
