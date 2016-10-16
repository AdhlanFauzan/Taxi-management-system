
namespace DAL.Names
{
    internal class StoredProcedureNames
    {
        public const string spGetAllEmployee = "[dbo].[spGetAllEmployee]";
        public const string spGetAllCalls = "[dbo].[spGetAllCalls]";
        public const string spGetAllCars = "[dbo].[spGetAllCars]";

        public const string spGetEmployeesByCarId = "[dbo].[spGetEmployeesByCarId]";
        public const string spGetCallsByCarId = "[dbo].[spGetCallsByCarId]";

        public const string spGetCarIncomeOfDay = "[dbo].[spGetCarIncomeOfDay]";
        public const string spDayInfo = "[dbo].[spDayInfo]";

        public const string spInsertEmployee = "[dbo].[spInsertEmployee]";
        public const string spInsertCar = "[dbo].[spInsertCar]";
        public const string spInsertCall = "[dbo].[spInsertCall]";

        public const string spDeleteCall = "[dbo].[spDeleteCall]";
        public const string spDeleteEmployee = "[dbo].[spDeleteEmployee]";
        public const string spDeleteCar = "[dbo].[spDeleteCar]";

        public const string spUpdateEmployeeCar = "[dbo].[spUpdateEmployeeCar]";
        public const string spUpdateCarState = "[dbo].[spUpdateCarState]";

        public const string spGetUserByLogin = "[dbo].[spGetUserByLogin]";
    }
}
