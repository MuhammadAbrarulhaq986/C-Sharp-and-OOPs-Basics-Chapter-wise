using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _28_SealedProperty
    {
        public class Person
        {
            // Virtual property in base class
            public virtual string Name { get; set; } = "Unknown";
        }

        public class Employee : Person
        {
            // ✅ Sealing the property override
            public sealed override string Name
            {
                get { return "Employee"; }
                set { /* Locked */ }
            }
        }

        public class Manager : Employee
        {
            // ❌ COMPILATION ERROR if uncommented: Name is marked as sealed in Employee

            // public override string Name
            // {
            //     get { return "Manager"; }
            // }
        }

        class Program
        {
            static void Main()
            {
                Employee emp = new Employee();
                Console.WriteLine(emp.Name);
                Console.ReadLine();
            }
        }
    }
}