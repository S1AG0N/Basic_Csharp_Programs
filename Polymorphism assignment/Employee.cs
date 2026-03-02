using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_assignment
{
    public class Employee: Person, IQuittable
    {
        public void Quit()
        {
            System.Console.WriteLine(FirstName + " " + LastName + " has quit the company.");

        }
    }
}
