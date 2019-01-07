using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty_2
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }

        public Employee(string firstName, string lastName, Position position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, working as {Position.Name}";
        }

    }
}
