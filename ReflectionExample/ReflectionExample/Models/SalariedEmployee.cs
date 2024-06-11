using System.Reflection;

namespace ReflectionExample.Models;

public class SalariedEmployee : IEmployee
{
    private static int _id = 1;
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double MonthlySalary { get; set; }

    public SalariedEmployee()
    {
        Id = _id;
        _id++;
    }

    public double CalculateSalary()
    {
        return MonthlySalary;
    }

    public void DisplayDetails()
    {
        PropertyInfo[] properties = this
            .GetType()
            .GetProperties();

        int propertyLength = properties
            .Select(p => p.Name)
            .OrderByDescending(name => name.Length)
            .FirstOrDefault().Length;

        foreach (PropertyInfo property in properties)
        {
            Console.WriteLine($"{property.Name.PadRight(propertyLength)} : {property.GetValue(this)}");
        }

        Console.WriteLine(new String('-', 50));
    }

}


