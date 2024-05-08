namespace Delegates;
internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new()
        {
            new Employee() { Id = 1, Name ="Mohamed",Gender = Gender.Male , TotalSales = 60000},
            new Employee() { Id = 2, Name ="Soha",Gender = Gender.Female, TotalSales = 35000},
            new Employee() { Id = 3, Name ="Adel",Gender = Gender.Male , TotalSales = 40000},
            new Employee() { Id = 4, Name ="Saeed",Gender = Gender.Male , TotalSales = 35000},
            new Employee() { Id = 5, Name ="Mona",Gender = Gender.Female, TotalSales = 22000},
            new Employee() { Id = 6, Name ="Eman",Gender = Gender.Female  , TotalSales = 80000},
            new Employee() { Id = 7, Name ="Emad",Gender = Gender.Male , TotalSales = 40000},
            new Employee() { Id = 8, Name ="Waleed",Gender = Gender.Male , TotalSales = 33000},
            new Employee() { Id = 9, Name ="Noha",Gender = Gender.Female  , TotalSales = 45000}
        };

        #region using custom functions
        //List<Employee> employeeHaveSalesOver60000 = Report.GetEmployeesWithSales60000AndMore(employees);
        //Employee.Print("employees Have Sales Over 60000 ", employeeHaveSalesOver60000);

        //List<Employee> employeeHaveSalesBetween30000andLessThan60000 = Report.GetEmployeesWithSalesBetween30000andLessThan60000(employees);
        //Employee.Print("employees Have Sales Between 30000 and Less Than 60000 ", employeeHaveSalesBetween30000andLessThan60000);

        //List<Employee> employeeHaveSalesLessThan30000 = Report.GetEmployeesWithSalesLessThan30000(employees);
        //Employee.Print("employees Have Sales Less Than 30000 ", employeeHaveSalesLessThan30000);
        #endregion

        #region using delegate 
        //List<Employee> employeeHaveSalesOver60000 = Report.GetEmployees(employees, IsTotalSalesGreaterThan60000);
        //Employee.Print("employees Have Sales Over 60000 ", employeeHaveSalesOver60000);

        //List<Employee> employeeHaveSalesBetween30000andLessThan60000 = Report.GetEmployees(employees, IsTotalSalesBetween30000And60000);
        //Employee.Print("employees Have Sales Between 30000 and Less Than 60000 ", employeeHaveSalesBetween30000andLessThan60000);

        //List<Employee> employeeHaveSalesLessThan30000 = Report.GetEmployees(employees, IsTotalSalesLessThan20000);
        //Employee.Print("employees Have Sales Less Than 30000 ", employeeHaveSalesLessThan30000);
        #endregion

        #region using annonymous delegate 
        //List<Employee> employeeHaveSalesOver60000 = Report.GetEmployees(employees, delegate (Employee employee) { return employee.TotalSales >= 60000; });

        //Employee.Print("employees Have Sales Over 60000 ", employeeHaveSalesOver60000);

        //List<Employee> employeeHaveSalesBetween30000andLessThan60000 =
        //    Report.GetEmployees(employees, delegate (Employee employee) { return employee.TotalSales >= 30000 && employee.TotalSales < 60000; });

        //Employee.Print("employees Have Sales Between 30000 and Less Than 60000 ", employeeHaveSalesBetween30000andLessThan60000);

        //List<Employee> employeeHaveSalesLessThan30000 = Report.GetEmployees(employees, delegate (Employee employee) { return employee.TotalSales < 30000; });
        //Employee.Print("employees Have Sales Less Than 30000 ", employeeHaveSalesLessThan30000);
        #endregion

        #region using lambda expression 
        List<Employee> employeeHaveSalesOver60000 = Report.GetEmployees(employees, employee => employee.TotalSales >= 60000);

        Employee.Print("employees Have Sales Over 60000 ", employeeHaveSalesOver60000);

        List<Employee> employeeHaveSalesBetween30000andLessThan60000 =
            Report.GetEmployees(employees, employee => employee.TotalSales >= 30000 && employee.TotalSales < 60000);

        Employee.Print("employees Have Sales Between 30000 and Less Than 60000 ", employeeHaveSalesBetween30000andLessThan60000);

        List<Employee> employeeHaveSalesLessThan30000 = Report.GetEmployees(employees, employee => employee.TotalSales < 30000);
        Employee.Print("employees Have Sales Less Than 30000 ", employeeHaveSalesLessThan30000);
        #endregion

    }

    //static bool IsTotalSalesGreaterThan60000(Employee employee) => employee.TotalSales >= 60000;
    //static bool IsTotalSalesBetween30000And60000(Employee employee) => employee.TotalSales >= 30000 && employee.TotalSales < 60000;
    //static bool IsTotalSalesLessThan20000(Employee employee) => employee.TotalSales < 30000;
}