using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    public class Person
    {
        // String property to store the person's first name
        public string FirstName { get; set; }

        // String property to store the person's last name
        public string LastName { get; set; }

        // Abstract method SayName() — has no body here.
        // Any class that inherits from Person MUST provide its own implementation.
        public abstract void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
