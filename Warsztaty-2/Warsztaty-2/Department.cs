using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty_2
{
    class Department
    {
        private string name;
        public string Name
        {
            get
            {
                Console.WriteLine($"{name} department name was read by property");
                return name;
            }
            set
            {
                Console.WriteLine($"Changing department name from {name} to {value}");
                name = value;
            }
        }

        public List<Employee> Employees { get; private set; }

        public Department()
        {
            name = "Default";
            Employees = new List<Employee>();
        }

        public void ShowEmployees()
        {
            int n = Employees.Count;
            if (n > 0)
            {
                Console.WriteLine($"Found {n} employees in {name}:");
                for (int i=0; i<n; i++)
                {
                    Console.WriteLine(Employees[i]);
                }
            }
            else
            {
                Console.WriteLine($"No employees in {name}");
            }
        }

    }
}
