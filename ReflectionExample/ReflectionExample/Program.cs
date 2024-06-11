using ReflectionExample.Models;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee h = new HourlyEmployee()
            {
                Name = "saatlik calisan",
                Surname = "testdjc",
                Age = 20,
                HourlyRate = 10,
                HoursWorked = 120
            };

            SalariedEmployee s = new SalariedEmployee()
            {
                Name = "saatlik calisan",
                Surname = "testdjc",
                Age = 20,
                MonthlySalary = 300
            };

            Console.WriteLine("saatliq calisanin maasi: " + h.CalculateSalary());
            h.DisplayDetails();

            Console.WriteLine("ayliq calisanin maasi: " + s.CalculateSalary());
            s.DisplayDetails();

        }
    }
}
