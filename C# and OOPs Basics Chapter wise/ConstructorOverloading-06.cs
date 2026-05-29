using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__and_OOPs_Basics_Chapter_wise
{
    internal class ConstructorOverloading_06
    {
        class ClassName
        {
            // Default constructor
            public ClassName()
            {
                Console.WriteLine("Default Constructor Called!");
            }
            // Parameterized constructor
            public ClassName(int x)
            {
                Console.WriteLine($"Parameterized Constructor Called with x = {x}");
            }
            // Another overloaded constructor
            public ClassName(int x, int y)
            {
                Console.WriteLine($"Overloaded Constructor Called with x = {x} and y = {y}");
            }
        }
    class Program
    {
            static void Main(String[] args)
        {
            // Demonstrating the different ways objects can be initialized
            ClassName obj1 = new ClassName();
            ClassName obj2 = new ClassName(10);
            ClassName obj3 = new ClassName(10, 20);
        }
    }
}
}
