using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class _09_SingleLevelInheritance
    {
        class ParentClass
        {
            public void ParentExample()
            {
                Console.WriteLine("This is a parent class!");
            }
        }

        // ChildClass inherits from ParentClass
        class ChildClass : ParentClass
        {
            public void ChildExample()
            {
                Console.WriteLine("This is a child class!");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create an object of the derived (child) class
                ChildClass obj = new ChildClass();

                // Call the method from the parent class (inherited)
                obj.ParentExample();

                // Call the method from the child class
                obj.ChildExample();

                // Keeps the console window open to view outputs
                Console.ReadLine();
            }
        }
    }
}

