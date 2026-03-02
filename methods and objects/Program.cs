using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a new Employee object and initialize FirstName and LastName
            // Note: We cannot do 'new Person()' because Person is abstract
            Employee emp = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the overridden SayName() method defined inside the Employee class
            // Output: Name: Sample Student
            emp.SayName();
        }
    }

}
