using System;

namespace Warsztaty_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Department marketing = new Department();
            marketing.Name = "Marketing";
            Console.WriteLine(marketing.Name);

            marketing.ShowEmployees();

            marketing.Employees.Add(new Employee("Jan", "Kowalski", new Position("Manager")));
            marketing.Employees.Add(new Employee("Adam", "Nowak", new Position("Programmer")));

            marketing.ShowEmployees();

            Console.ReadKey();
        }
    }
}
