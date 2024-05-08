namespace Delegates;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public double TotalSales { get; set; }

    public override string ToString() =>
        $"Id : {Id}, Name : {Name}, Gender : {Gender} ,Total Sales : {TotalSales} $";
     
    public static void Print(string title,List<Employee> employees)
    {
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine($"|{title}");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        
        foreach (Employee employee in employees)
            Console.WriteLine(employee.ToString());
        Console.WriteLine();
    }
}
public enum Gender
{
    Male, Female
} 
