using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _08_Abstraction
    {
        // Abstract Class
        abstract class Employee
        {
            // Abstract Method (Has no body)
            public abstract int GetSalary();
        }
        // Subclass 1: Developer inheriting from Employee
        class Developer : Employee
        {
            private int salary;
            public Developer(int s)
        {
            salary = s;
        }

        // Overriding the abstract method to provide implementation
        public override int GetSalary()
        {
            return salary;
        }
    }

    // Subclass 2: Driver inheriting from Employee
    class Driver : Employee
    {
        private int salary;

        public Driver(int s)
        {
            salary = s;
        }

        // Overriding the abstract method to provide implementation
        public override int GetSalary()
        {
            return salary;
        }
    }

    // Main testing class
    class Test
    {
        static void Main(string[] args)
        {
            Developer d1 = new Developer(5000);
            Driver d2 = new Driver(3000);

            int a, b;
            a = d1.GetSalary();
            b = d2.GetSalary();

            Console.WriteLine($"Salary of developer : {a}");
            Console.WriteLine($"Salary of driver : {b}");
            // Keeps console window open
            Console.ReadLine();
            }
        }
    }
}
