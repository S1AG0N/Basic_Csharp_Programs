using System;

namespace Operators_Assignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both references point to the same object
            if (ReferenceEquals(emp1, emp2))
                return true;

            // Check if either one is null (without triggering recursion)
            if (emp1 is null || emp2 is null)
                return false;

            // Compare Id values
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}