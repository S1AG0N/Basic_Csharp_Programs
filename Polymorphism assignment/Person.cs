using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_assignment
{
    public  class Person
    {
        // Public property to store the first name
        public string FirstName { get; set; }

        // Public property to store the last name
        public string LastName { get; set; }

        // Virtual method allows derived classes to override this behavior
        public virtual void SayName()
        {
            // Outputs the full name to the console
            System.Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
