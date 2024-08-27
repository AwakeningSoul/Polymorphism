using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type IQuittable using the Employee class
            // This demonstrates polymorphism - an Employee is also an IQuittable
            IQuittable employee = new Employee();

            // Call the Quit method on the IQuittable object
            employee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
