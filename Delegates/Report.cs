namespace Delegates;

public class Report
{
    public delegate bool TargetedSales(Employee employee);
    public static List<Employee> GetEmployees(List<Employee> employees, TargetedSales targetedSales)
    {
        List<Employee> employeesResult = new();
        foreach (Employee employee in employees)
            if (targetedSales(employee))
                employeesResult.Add(employee);

        return employeesResult;
    }

    // this will need to add new function to return new report 

    //public static List<Employee> GetEmployeesWithSales60000AndMore(List<Employee> employees)
    //{
    //    List<Employee> employeesResult = new();
    //    foreach (Employee employee in employees)
    //        if (employee.TotalSales >= 60000)
    //            employeesResult.Add(employee);

    //    return employeesResult;
    //}

    //public static List<Employee> GetEmployeesWithSalesBetween30000andLessThan60000(List<Employee> employees)
    //{
    //    List<Employee> employeesResult = new();
    //    foreach (Employee employee in employees)
    //        if (30000 <= employee.TotalSales && employee.TotalSales < 60000)
    //            employeesResult.Add(employee);

    //    return employeesResult;
    //}
    //public static List<Employee> GetEmployeesWithSalesLessThan30000(List<Employee> employees)
    //{
    //    List<Employee> employeesResult = new();
    //    foreach (Employee employee in employees)
    //        if (employee.TotalSales < 30000)
    //            employeesResult.Add(employee);

    //    return employeesResult;
    //}
}
