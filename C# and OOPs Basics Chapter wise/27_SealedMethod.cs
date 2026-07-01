/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _27_SealedMethod
    {
        public class Person
        {
            public virtual void DisplayRole()
            {
                Console.WriteLine("Generic Person Role");
            }
        }

        public class Employee : Person
        {
            // ✅ Overriding and sealing the method here
            // No class inheriting from Employee can redefine this method anymore!
            public sealed override void DisplayRole()
            {
                Console.WriteLine("Role: Employee");
            }
        }

        public class Manager : Employee
        {
            // ❌ COMPILATION ERROR if uncommented:
            // 'Manager.DisplayRole()': cannot override inherited member 'Employee.DisplayRole()' because it is sealed

            // public override void DisplayRole()
            // {
            //     Console.WriteLine("Role: Manager");
            // }
        }

        class Program
        {
            static void Main()
            {
                Employee emp = new Employee();
                emp.DisplayRole();
                Console.ReadLine();
            }
        }
    }
}
 */