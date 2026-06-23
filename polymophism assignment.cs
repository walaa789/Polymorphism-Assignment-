using System;

namespace EmployeeInterfaceApp
{
    // 1. Define the IQuittable interface
    // Interfaces are a contract: any class that implements this MUST have a Quit method.
    interface IQuittable
    {
        void Quit();
    }

    // 2. The Employee class inherits from the IQuittable interface
    // It also provides the specific implementation for the Quit method.
    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implementing the Quit method from the interface
        public void Quit()
        {
            // For this drill, we will just print a message to the console
            Console.WriteLine($"{FirstName} {LastName} has officially resigned from the position.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3. Use Polymorphism to create an object of type IQuittable
            // Even though the object is an 'Employee', we can store it in an 'IQuittable' variable
            // because the Employee class implements that interface.
            IQuittable quittableEmployee = new Employee() 
            { 
                FirstName = "Shorouq", 
                LastName = "Student" 
            };

            // Call the Quit() method on the interface object
            // The program knows to execute the version of Quit() defined inside the Employee class.
            quittableEmployee.Quit();

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

