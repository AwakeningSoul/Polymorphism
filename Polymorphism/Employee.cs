using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // Define the Employee class that implements the IQuittable interface
    // This class inherits the Quit method from the IQuittable interface
    class Employee : IQuittable
    {
        // Implementation of the Quit method
        // Here, we'll simply print a message to the console
        public void Quit()
        {
            Console.WriteLine("The employee has quit the job.");
        }
    }
}
